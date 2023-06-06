using MotherBoardInfo.Models;
using System;
using System.Linq;
using System.Management;
using System.Threading.Tasks;

namespace MotherBoardInfo.ViewModels
{
    class CPUViewModel : Base.ViewModel
    {
        private CPU _cpu;

        public CPU CPU
        {
            get { return _cpu; }
            set { Set(ref _cpu, value); OnPropertyChanged(); }
        }

        public CPUViewModel() : this(null)
        {

        }

        public CPUViewModel(CPU cpu)
        {
            CPU = cpu;

            Task.Run(async () =>
            {
                while (true)
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");
                    try
                    {
                        CPU.UsedCPU = searcher.Get()
                            .Cast<ManagementObject>().Where(x => x["Name"].ToString() == "_Total")
                            .Select(mo => mo["PercentProcessorTime"] + " %")
                            .SingleOrDefault().ToString();
                        await Task.Delay(500);
                    }
                    catch (Exception)
                    {
                        
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");
                    try
                    {
                        CPU.Cores = searcher.Get()
                            .Cast<ManagementObject>().Where(x => x["Name"].ToString() != "_Total")
                            .Select(mo => new Core
                            {
                                CoreNumber = $"Core #{mo["Name"]}",
                                CoreUsage = Convert.ToByte(mo["PercentProcessorTime"])
                            }
                            )
                            .ToList();
                    }
                    catch (Exception)
                    {
                        CPU.Cores = default;
                    }
                }
            });

        }
    }
}
