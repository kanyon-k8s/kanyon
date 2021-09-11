using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Community.VisualStudio.Toolkit;
using KanyonVSIX.ViewModels;
using Microsoft.VisualStudio.Imaging;
using Microsoft.VisualStudio.Shell;

namespace KanyonVSIX
{
    public class MyToolWindow : BaseToolWindow<MyToolWindow>
    {
        public override string GetTitle(int toolWindowId) => "Kanyon";
        public override Type PaneType => typeof(Pane);

        public override async Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
        {
            EnvDTE80.DTE2 dte = await VS.GetServiceAsync<EnvDTE.DTE, EnvDTE80.DTE2>();
            var vm = new MainViewModel(dte);
            await vm.Initialize();

            CommandID cmdProjectComboPopulateId = new CommandID(PackageGuids.KanyonVSIX, PackageIds.cmdProjectComboPopulate);
            OleMenuCommand cmdProjectComboPopulate = new OleMenuCommand(ProjectComboPopulate, cmdProjectComboPopulateId);

            var mcs = await VS.GetServiceAsync<OleMenuCommandService, IMenuCommandService>();
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

            mcs.AddCommand(cmdProjectComboPopulate);

            return new MyToolWindowControl(dte, vm);
        }

        private void ProjectComboPopulate(object sender, EventArgs e)
        {
            var args = e as OleMenuCmdEventArgs;

            if (args.OutValue == IntPtr.Zero) throw new ArgumentException();
        }

        [Guid("5f76a3f4-965f-4a18-8d65-da4810eaafc3")]
        internal class Pane : ToolWindowPane
        {
            public Pane()
            {
                BitmapImageMoniker = KnownMonikers.ToolWindow;
            }
        }
    }


}