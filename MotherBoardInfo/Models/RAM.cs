namespace MotherBoardInfo.Models
{
    internal class RAM : ViewModels.Base.ViewModel
    {
        public ushort Slot { get; set; }
        public string Amount { get; set; }
        public string Type { get; set; }
        public string Frequency { get; set; }
        public string Voltage { get; set; }
        public string FormFactor { get; set; }
        public string SericalNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Location { get; set; }
        public string Width { get; set; }
    }
}
