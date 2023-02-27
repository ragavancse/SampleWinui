using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWinui.Helpers
{
    public class RelayCommand : ICommand
    {
        public readonly Action _action;
        public readonly Action<object> _actionObj;

        public RelayCommand(Action action)
        {
            _action = action;
        }
        public RelayCommand(Action<object> action)
        {
            _actionObj = action;
        }

        public void Execute(object parameter)
        {
            if (_action is not null)
            {
                _action();
            }
            if (_actionObj is not null)
            {
                _actionObj(parameter);
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
