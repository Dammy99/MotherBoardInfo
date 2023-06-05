using System;

namespace MotherBoardInfo.Infrastructure.Commands
{
    internal class DelegateCommand : Command
    {
        private Action<object> _Execute;
        private Func<object, bool> _CanExecute;

        public DelegateCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);
    }
}
