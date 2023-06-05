using System.Windows;

namespace MotherBoardInfo.Infrastructure.Commands
{
    class MinimizeWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
            
        }
    }
}
