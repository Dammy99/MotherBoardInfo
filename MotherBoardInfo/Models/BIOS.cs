namespace MotherBoardInfo.Models
{
    internal class BIOS : ViewModels.Base.ViewModel
    {
        public string BIOSPublisher { get; set; }
        public string BIOSDate { get; set; }
        public string BIOSVersion { get; set; }
        public string SM_BIOSVersion { get; set; }
        public string BIOSMode { get; set; }
        public string BIOS_Major_Minor_Version { get; set; }
        public string SM_BIOS_Major_Minor_Version { get; set; }
    }
}
