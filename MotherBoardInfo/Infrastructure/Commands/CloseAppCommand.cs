using System.Windows;

namespace MotherBoardInfo.Infrastructure.Commands
{
    internal class CloseAppCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
