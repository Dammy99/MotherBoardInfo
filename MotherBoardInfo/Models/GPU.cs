namespace MotherBoardInfo.Models
{
    internal class GPU : ViewModels.Base.ViewModel
    {
        public string Model { get; set; }
        public string Publisher { get; set; }
        public string DriverVersion { get; set; }
        public string Date { get; set; }
        public string VRAM { get; set; }
        public string Status { get; set; }
        public string DACType { get; set; }
        public string Drivers { get; set; }
        public string INFFile { get; set; }
        public string INFSection { get; set; }
    }
}
