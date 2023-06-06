using MotherBoardInfo.Models;

namespace MotherBoardInfo.ViewModels
{
    class MotherboardViewModel : Base.ViewModel
    {
        private Motherboard motherboard;
        public Motherboard Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; OnPropertyChanged(); }
        }

        private BIOS _bios;
        public BIOS Bios
        {
            get { return _bios; }
            set { _bios = value; OnPropertyChanged(); }
        }

        public MotherboardViewModel(): this(null, null)
        {

        }
        public MotherboardViewModel(Motherboard motherboard, BIOS bios)
        {
            Motherboard = motherboard;
            Bios = bios;
        }
    }
}
