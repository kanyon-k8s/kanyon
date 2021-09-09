using System;
using System.Runtime.InteropServices;
using System.Threading;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace KanyonVSIX
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [ProvideToolWindow(typeof(MyToolWindow.Pane), Style = VsDockStyle.Tabbed, Window = WindowGuids.SolutionExplorer)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.KanyonVSIXString)]
    public sealed class KanyonVSIXPackage : ToolkitPackage
    {
        public static Guid OutputWindow = Guid.Parse("7157dc8e-2c42-4a92-bdc4-e6034c418e52");
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.RegisterCommandsAsync();

            this.RegisterToolWindows();

            //var outputWindow = await VS.Services.GetOutputWindowAsync();

            //await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            //outputWindow.CreatePane(ref OutputWindow, "Kanyon", 0, 1);
        }
    }
}