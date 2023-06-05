using System.Windows;

namespace MotherBoardInfo.Infrastructure.Commands
{
    class MoveAppCommand : Command
    {
        public override bool CanExecute(object parameter)
         => true;

        public override void Execute(object parameter)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                Application.Current.MainWindow.Top = 0;
            }
            Application.Current.MainWindow.DragMove();
        }
    }
}
