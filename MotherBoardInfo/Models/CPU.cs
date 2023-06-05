using System.Collections.Generic;

namespace MotherBoardInfo.Models
{
    internal class CPU : ViewModels.Base.ViewModel
    {
        private string usedCPU;
        private List<Core> cores = new List<Core>();
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string Architecture { get; set; }
        public string Speed { get; set; }
        public string UsedCPU { get => usedCPU; set { Set(ref usedCPU, value); OnPropertyChanged(); } }
        public string L1Cache { get; set; }
        public string L2Cache { get; set; }
        public string L3Cache { get; set; }
        public string SocketDescription { get; set; }
        public string ProcessorFamily { get; set; }
        public bool Virtuarization { get; set; }
        public bool VirtualMonitorExtensions { get; set; }
        public string UniqueProcessorID { get; set; }
        public ushort CoreCount { get; set; }
        public ushort LogicalCoreCount { get; set; }
        public List<Core> Cores { get => cores; set { Set(ref cores, value); OnPropertyChanged(); } }
    }
}
