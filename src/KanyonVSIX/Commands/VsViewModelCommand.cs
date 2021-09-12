using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KanyonVSIX.Commands
{
    public class VsViewModelCommand
    {
        private readonly IMenuCommandService menuService;
        private readonly Guid groupGuid;
        private readonly int commandId;
        private OleMenuCommand command;

        public VsViewModelCommand(ICommand vmCommand, IMenuCommandService menuService, Guid groupGuid, int commandId)
        {
            VmCommand = vmCommand;
            this.menuService = menuService;
            this.groupGuid = groupGuid;
            this.commandId = commandId;
        }

        public ICommand VmCommand { get; }

        public async System.Threading.Tasks.Task InitializeAsync()
        {
            CommandID cmd = new CommandID(groupGuid, commandId);
            command = new OleMenuCommand(this.Execute, cmd);

            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

            menuService.AddCommand(command);
        }

        private void Execute(object sender, EventArgs e)
        {
            VmCommand.Execute(e);
        }
    }
}
