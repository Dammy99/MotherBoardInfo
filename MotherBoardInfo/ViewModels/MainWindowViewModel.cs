using MotherBoardInfo.Infrastructure.Commands;
using MotherBoardInfo.Models;
using MotherBoardInfo.Services;
using System.Windows;
using System.Windows.Input;

namespace MotherBoardInfo.ViewModels
{
    class MainWindowViewModel : Base.ViewModel
    {

        #region Title
        private string _title;
        public string Title
        {
            get { return _title; }
            set { Set( ref _title, value); OnPropertyChanged(); }
        }
        #endregion

        private readonly MotherboardService Service;


        #region current view
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        #endregion
        #region motherboard
        private Motherboard motherboard;
        public Motherboard Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; OnPropertyChanged(); }
        }
        #endregion
        #region bios
        private BIOS _bios;
        public BIOS Bios
        {
            get { return _bios; }
            set { _bios = value; OnPropertyChanged(); }
        }

        #endregion
        #region cpu 
        private CPU _cpu;

        public CPU CPU
        {
            get { return _cpu; }
            set { _cpu = value; OnPropertyChanged(); }
        }
        #endregion
        #region gpu
        private GPU _gpu;

        public GPU GPU
        {
            get { return _gpu; }
            set { _gpu = value; OnPropertyChanged(); }
        }
        #endregion
        #region memory
        private Memory _memory;

        public Memory Memory
        {
            get { return _memory; }
            set { _memory = value; OnPropertyChanged(); }
        }
        #endregion



        #region Commands
        public ICommand MotherboardCommand { get; set; }
        public ICommand CPUCommand { get; set; }
        public ICommand GPUCommand { get; set; }
        public ICommand MemoryCommand { get; set; }

        private void MB_(object obj)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Minimized)
            {
                Application.Current.MainWindow.Show();
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            CurrentView = new MotherboardViewModel(Motherboard, Bios);
        }

        private void CPU_(object obj)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Minimized)
            {
                Application.Current.MainWindow.Show();
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            CurrentView = new CPUViewModel(CPU);
        }
        private void GPU_(object obj)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Minimized)
            {
                Application.Current.MainWindow.Show();
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            CurrentView = new GPUViewModel(GPU);
        }
        private void Memory_(object obj)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Minimized)
            {
                Application.Current.MainWindow.Show();
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            CurrentView = new MemoryViewModel(Memory);
        }

        #endregion

        public MainWindowViewModel()
        {
            Title = "MotherboardInfo";

            #region commands
            MotherboardCommand = new DelegateCommand(MB_);
            CPUCommand = new DelegateCommand(CPU_);
            GPUCommand = new DelegateCommand(GPU_);
            MemoryCommand = new DelegateCommand(Memory_);
            #endregion

            Service = new MotherboardService();

            (Motherboard, Bios) = Service.GetMotherboardsAndBios();
            CPU = Service.GetCPUs();
            GPU = Service.GetGPUs();
            Memory = Service.GetMemory();


            CurrentView = new MotherboardViewModel(Motherboard, Bios);
        }
    }
}
