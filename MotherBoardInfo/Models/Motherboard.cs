namespace MotherBoardInfo.Models
{
    internal class Motherboard : ViewModels.Base.ViewModel
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string MotherboardModelVersion { get; set; }
        public string PrimaryBusType { get; set; }
    }
}
