using System.Windows;
using System.Windows.Controls;
using Community.VisualStudio.Toolkit;
using KanyonVSIX.ViewModels;

namespace KanyonVSIX
{
    public partial class MyToolWindowControl : UserControl
    {
        public MyToolWindowControl(EnvDTE80.DTE2 dte, MainViewModel vm)
        {
            InitializeComponent();

            DataContext = vm;
        }

    }
}