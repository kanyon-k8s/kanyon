using Community.VisualStudio.Toolkit;
using EnvDTE;
using EnvDTE80;
using Kanyon;
using Kanyon.Core;
using Kanyon.Engine.Loaders;
using Kanyon.Filters;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using OutputWindowPane = Community.VisualStudio.Toolkit.OutputWindowPane;
using Project = Community.VisualStudio.Toolkit.Project;
using Task = System.Threading.Tasks.Task;

namespace KanyonVSIX.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel(DTE2 dte)
        {
            LoadProjectsCommand = new RelayCommand(() => LoadProjects(null));
            this.dte = dte;
        }

        public string ManifestSource { get; set; }

        private ObservableCollection<ConfigurationItemViewModel> configItems;
        public ObservableCollection<ConfigurationItemViewModel> ConfigurationItems
        {
            get => configItems;
            set => SetProperty(ref configItems, value);
        }

        FileSystemWatcher watcher;
        OutputWindowPane outputWindowPane;
        DTE2 dte;

        public async Task Initialize()
        {
            VS.Events.SolutionEvents.OnAfterLoadProject += LoadProjects;
            outputWindowPane = await VS.Windows.CreateOutputWindowPaneAsync("Kanyon");
        }

        public ICommand LoadProjectsCommand { get; private set; }
        public async void LoadProjects(Project obj)
        {
            try
            {
                var projects = await (await VS.Solutions.GetAllProjectsAsync()).ToAsyncEnumerable().WhereAwait(async p => await p.IsKindAsync(ProjectTypes.CSHARP)).ToListAsync();

                AvailableProjects = new ObservableCollection<Project>(projects);

                SelectedProject = await VS.Solutions.GetActiveProjectAsync();
            }
            catch (Exception ex)
            {
                ex.Log();
            }
        }

        private ObservableCollection<Project> projects;
        public ObservableCollection<Project> AvailableProjects
        {
            get => projects;
            set => SetProperty(ref projects, value);
        }

        private Project selectedProject { get; set; }
        public Project SelectedProject
        {
            get { return selectedProject; }
            set
            {
                selectedProject = value;
                LoadWatcher();
            }
        }

        public CompiledManifestLoader Loader { get; private set; }

        public async void LoadWatcher()
        {
            if (watcher != null)
            {
                watcher.Dispose();
                watcher = null;
            }

            var path = await SelectedProject.GetAttributeAsync("OutputPath");
            var assemblyName = await SelectedProject.GetAttributeAsync("AssemblyName");

            ManifestSource = Path.Combine(path, assemblyName);
            outputWindowPane.WriteLine($"Watching {ManifestSource}");

            LoadManifest();

            watcher = new FileSystemWatcher(path, assemblyName);
            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Changed;
            watcher.EnableRaisingEvents = true;
        }

        public async void LoadManifest()
        {
            try
            {
                var info = new FileInfo(ManifestSource);
                if (info.Exists)
                {
                    Loader = new CompiledManifestLoader().FromFile(info);
                    var manifest = await Loader.LoadManifest() as IHelpTextProvider;

                    var helpText = manifest.GetHelpText();
                    var items = helpText.Select(ht => new ConfigurationItemViewModel { Key = ht.ConfigValue, Description = ht.Description }).ToDictionary(civm => civm.Key;

                    foreach (var item in ConfigurationItems)
                    {
                        if (items.ContainsKey(item.Key))
                        {
                            items[item.Key].ConfigValue = item.ConfigValue;
                        }
                    }

                    ConfigurationItems = new ObservableCollection<ConfigurationItemViewModel>(items.Select(item => item.Value).ToList());
                }
            }
            catch (Exception ex)
            {
                ex.Log();
            }
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            LoadManifest();
        }

        public async void GenerateManifest()
        {
            try
            {
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                var provider = new ViewModelConfigurationProvider(ConfigurationItems);
                var processor = new ManifestConfigurationProcessor(new[] { provider });
                var serializer = new ManifestSerializer(new NoOpManifestFilter());

                var pipeline = new ManifestPipeline(processor, Loader, serializer, null);
                var manifest = await pipeline.ExecutePipeline();

                var item = dte.ItemOperations.AddNewItem("General\\Text File", "manifest.yml");
                var selection = item.Document.Selection as TextSelection;
                selection?.SelectAll();
                selection?.Delete();
                selection?.Insert(manifest);
            }
            catch (Exception ex)
            {
                ex.Log();
            }
        }
    }
}
