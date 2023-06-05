using Microsoft.VisualBasic.Devices;
using MotherBoardInfo.Models;
using System.Threading.Tasks;

namespace MotherBoardInfo.ViewModels
{
    class MemoryViewModel : Base.ViewModel
    {

        private Memory _memory;

        public Memory Memory
        {
            get { return _memory; }
            set { Set(ref _memory, value); OnPropertyChanged(); }
        }

        private RAM _selectedSlot;

        public RAM SelectedSlot
        {
            get { return _selectedSlot; }
            set { Set(ref _selectedSlot, value); OnPropertyChanged(); }
        }

       

        public MemoryViewModel(): this(null)
        {

        }

        public MemoryViewModel(Memory memory)
        {
            Memory = memory;

            Task.Run(async () =>
            {
                while (true)
                {
                    
                    ComputerInfo computerInfo = new ComputerInfo();
                    Memory.FreeVirtualMemory = string.Format("{0:0.00} MB ", computerInfo.AvailableVirtualMemory / 1024 / 1024 );
                    Memory.UsedRAM = string.Format("{0:0.00} MB",(computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory) / 1024 / 1024 );
                    
                    await Task.Delay(1000);
                   
                }
            });



            SelectedSlot = Memory.RAMSlots[0];
        }
    }
}
