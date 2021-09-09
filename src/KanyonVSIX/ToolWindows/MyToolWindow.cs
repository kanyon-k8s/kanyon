using System;
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

            return new MyToolWindowControl(dte, vm);
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