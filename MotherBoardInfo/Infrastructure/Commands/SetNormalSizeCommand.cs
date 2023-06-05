using System.Windows;

namespace MotherBoardInfo.Infrastructure.Commands
{
    class SetNormalSizeCommand : Command
    {
        public override bool CanExecute(object parameter)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Minimized)
            {
                return true;
            }
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                return true;
            }
            else if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                return true;
            }

            return false;
        }
        public override void Execute(object parameter)
        {
            Application.Current.MainWindow.Show();
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }
    }
}
