using MotherBoardInfo.Models;

namespace MotherBoardInfo.ViewModels
{
    class GPUViewModel : Base.ViewModel
    {
        private GPU _gpu;

        public GPU GPU
        {
            get { return _gpu; }
            set { _gpu = value; OnPropertyChanged(); }
        }

        public GPUViewModel() : this(null)
        {

        }
        public GPUViewModel(GPU gpu)
        {
            GPU = gpu;
        }
    }
}