using KeymapDesigner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeymapDesigner.Commands
{
    public class AssignActionToKeyAssignmentCommand : RoutedUICommand
    {
        public Model.Action Action { get; }

        public AssignActionToKeyAssignmentCommand(Model.Action action)
            : base(action.CCode, action.CCode, typeof(AssignActionToKeyAssignmentCommand))
        {
            Action = action;
        }
    }
}
