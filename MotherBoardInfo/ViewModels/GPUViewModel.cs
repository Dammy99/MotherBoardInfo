using MotherBoardInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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