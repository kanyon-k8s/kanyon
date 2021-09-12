using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyonVSIX.Commands
{
    public static class MenuCommandServiceExtensions
    {
        public static void AddCommand(this IMenuCommandService mcs, Guid packageId, int commandId, EventHandler handler)
        {
            var id = new CommandID(packageId, commandId);
            var command = new OleMenuCommand(handler, id);

            mcs.AddCommand(command);
        }
    }
}
