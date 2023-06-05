using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherBoardInfo.Models
{
    internal class Memory : ViewModels.Base.ViewModel
    {
        private string usedRAM;
        private string freeVirtualMemory;

        public string TotalRAM { get; set; }
        public string UsedRAM { get => usedRAM; set { Set(ref usedRAM, value); OnPropertyChanged(); } }
        public string VirtualMemoryAmount { get; set; }
        public string FreeVirtualMemory { get => freeVirtualMemory; set { Set(ref freeVirtualMemory, value); OnPropertyChanged(); } }
        public string RamSlotOccupancy { get; set; }
        public List<RAM> RAMSlots { get; set; } = new List<RAM>();
    }
}
