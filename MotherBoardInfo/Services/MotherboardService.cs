using Microsoft.VisualBasic.Devices;
using MotherBoardInfo.Models;
using System;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;

namespace MotherBoardInfo.Services
{
    class MotherboardService
    {
        public GPU GetGPUs()
        {

            var gpu = new GPU();

            ManagementObjectSearcher search_vc = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject query_vc_rotate in search_vc.Get())
            {

                try
                {
                    // GPU NAME
                    gpu.Model = Convert.ToString(query_vc_rotate["Name"]);

                }
                catch (Exception) { }
                try
                {
                    // GPU MAN
                    gpu.Publisher = Convert.ToString(query_vc_rotate["AdapterCompatibility"]).Trim();

                }
                catch (Exception) { }
                try
                {
                    // GPU DRIVER VERSION
                    gpu.DriverVersion = Convert.ToString(query_vc_rotate["DriverVersion"]);

                }
                catch (Exception) { }
                try
                {
                    // GPU DRIVER DATE
                    string gpu_date = Convert.ToString(query_vc_rotate["DriverDate"]);
                    if (gpu_date != "" && gpu_date != string.Empty)
                        gpu.Date = gpu_date.Substring(6, 2) + "." + gpu_date.Substring(4, 2) + "." + gpu_date.Substring(0, 4);

                }
                catch (Exception) { }

                try
                {
                    // GPU DAC TYPE
                    gpu.DACType = Convert.ToString(query_vc_rotate["AdapterDACType"]);

                }
                catch (Exception) { }
                try
                {
                    // GPU DRIVERS
                    gpu.Drivers = Path.GetFileName(Convert.ToString(query_vc_rotate["InstalledDisplayDrivers"]));

                }
                catch (Exception) { }
                try
                {
                    // GPU INF FILE NAME
                    gpu.INFFile = Convert.ToString(query_vc_rotate["InfFilename"]);

                }
                catch (Exception) { }
                try
                {
                    // GPU INF FILE GPU INFO PARTITION
                    gpu.INFSection = Convert.ToString(query_vc_rotate["InfSection"]);

                }
                catch (Exception) { }
                try
                {
                    // GPU RAM
                    gpu.VRAM = Convert.ToUInt32(query_vc_rotate["AdapterRAM"]) / 1024 / 1024 + " MB";

                }
                catch (Exception) { }
            }
            return gpu;
        }
        public (Motherboard, BIOS) GetMotherboardsAndBios()
        {
            var mb = new Motherboard();
            var bios = new BIOS();
            ManagementObjectSearcher search_bb = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            ManagementObjectSearcher search_bios = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            ManagementObjectSearcher search_md = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
            foreach (ManagementObject query_bb_rotate in search_bb.Get())
            {

                try
                {
                    // MB NAME
                    mb.Model = Convert.ToString(query_bb_rotate["Product"]);
                }
                catch (Exception) { }
                try
                {
                    // MB MAN
                    mb.Manufacturer = Convert.ToString(query_bb_rotate["Manufacturer"]);
                }
                catch (Exception) { }
                try
                {
                    // MB SERIAL
                    mb.SerialNumber = Convert.ToString(query_bb_rotate["SerialNumber"]);
                }
                catch (Exception) { }
                try
                {
                    // MB VERSION
                    mb.MotherboardModelVersion = Convert.ToString(query_bb_rotate["Version"]);
                }
                catch (Exception) { }
            }
            foreach (ManagementObject query_bios_rotate in search_bios.Get())
            {

                try
                {
                    // BIOS MAN
                    bios.BIOSPublisher = Convert.ToString(query_bios_rotate["Manufacturer"]);
                }
                catch (Exception) { }
                try
                {
                    // BIOS DATE
                    string bios_date = Convert.ToString(query_bios_rotate["ReleaseDate"]);
                    bios.BIOSDate = bios_date.Substring(6, 2) + "." + bios_date.Substring(4, 2) + "." + bios_date.Substring(0, 4);

                }
                catch (Exception) { }
                try
                {
                    // BIOS VERSION
                    bios.BIOSVersion = Convert.ToString(query_bios_rotate["Caption"]);
                }
                catch (Exception) { }
                try
                {
                    // SM BIOS VERSION
                    bios.SM_BIOSVersion = Convert.ToString(query_bios_rotate["Version"]);
                }
                catch (Exception) { }
                try
                {
                    // BIOS MAJOR MINOR
                    bios.BIOS_Major_Minor_Version = query_bios_rotate["SystemBiosMajorVersion"] + "." + query_bios_rotate["SystemBiosMinorVersion"];

                }
                catch (Exception) { }
                try
                {
                    // SM-BIOS MAJOR MINOR
                    bios.SM_BIOS_Major_Minor_Version = query_bios_rotate["SMBIOSMajorVersion"] + "." + query_bios_rotate["SMBIOSMinorVersion"];

                }
                catch (Exception) { }
            }
            try
            {
                foreach (ManagementObject query_md_rotate in search_md.Get())
                {
                    // PRIMARY BUS TYPE
                    mb.PrimaryBusType = Convert.ToString(query_md_rotate["PrimaryBusType"]);
                }
            }
            catch (Exception) { }
            try
            {
                // BIOS FIRMWARE TYPE
                GetBIOSType("", "{00000000-0000-0000-0000-000000000000}", IntPtr.Zero, 0);
                if (Marshal.GetLastWin32Error() == ERROR_INVALID_FUNCTION)
                {
                    // Legacy
                    bios.BIOSMode = "Legacy";
                }
                else
                {
                    // UEFI
                    bios.BIOSMode = "UEFI";
                }
            }
            catch (Exception) { }

            return (mb, bios);
        }

        public CPU GetCPUs()
        {
            CPU cpu = new CPU(); ;
            ManagementObjectSearcher search_process = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject query_process_rotate in search_process.Get())
            {
                try
                {
                    // CPU NAME
                    cpu.Model = Convert.ToString(query_process_rotate["Name"]).Trim();
                }
                catch (Exception) { }

                try
                {
                    // CPU MANUFACTURER
                    string cpu_man = Convert.ToString(query_process_rotate["Manufacturer"]);
                    if (cpu_man.Contains("GenuineIntel"))
                        cpu.Manufacturer = "Intel Corporation";
                    else
                        cpu.Manufacturer = cpu_man;

                }
                catch (Exception) { }

                try
                {
                    // CPU ARCHITECTURE
                    cpu.Architecture = query_process_rotate["Architecture"].ToString();

                }
                catch (Exception) { }

                try
                {
                    // CPU DEFAULT SPEED
                    double cpu_max_speed = Convert.ToDouble(query_process_rotate["MaxClockSpeed"]);
                    if (cpu_max_speed > 1024)
                    {
                        cpu.Speed = string.Format("{0:0.00} GHz", cpu_max_speed / 1000);
                    }
                    else
                    {
                        cpu.Speed = cpu_max_speed.ToString() + " MHz";
                    }
                }
                catch (Exception) { }

                try
                {
                    // L2 CACHE
                    double l2_size = Convert.ToDouble(query_process_rotate["L2CacheSize"]);
                    if (l2_size >= 1024)
                    {
                        cpu.L2Cache = (l2_size / 1024).ToString() + " MB";
                    }
                    else
                    {
                        cpu.L2Cache = l2_size.ToString() + " KB";
                    }
                }
                catch (Exception) { }

                try
                {
                    // L3 CACHE
                    cpu.L3Cache = Convert.ToDouble(query_process_rotate["L3CacheSize"]) / 1024 + "MB";
                }
                catch (Exception) { }

                try
                {
                    // CPU CORES
                    cpu.CoreCount = Convert.ToUInt16(query_process_rotate["NumberOfCores"]);
                }
                catch (Exception) { }

                try
                {
                    // CPU LOGICAL CORES
                    cpu.LogicalCoreCount = Convert.ToUInt16(query_process_rotate["ThreadCount"]);

                }
                catch (Exception) { }

                try
                {
                    // CPU SOCKET
                    cpu.SocketDescription = Convert.ToString(query_process_rotate["SocketDesignation"]);
                }
                catch (Exception) { }

                try
                {
                    // CPU FAMILY
                    cpu.ProcessorFamily = Convert.ToString(query_process_rotate["Description"]).Replace("64", " X64");

                }
                catch (Exception) { }

                try
                {
                    // CPU VIRTUALIZATION
                    cpu.Virtuarization = Convert.ToBoolean(query_process_rotate["VirtualizationFirmwareEnabled"]);

                }
                catch (Exception) { }

                try
                {
                    // CPU VIRTUALIZATION MONITOR EXTENSIONS
                    cpu.VirtualMonitorExtensions = Convert.ToBoolean(query_process_rotate["VMMonitorModeExtensions"]);

                }
                catch (Exception) { }

                try
                {
                    // CPU SERIAL ID
                    cpu.SerialNumber = Convert.ToString(query_process_rotate["ProcessorId"]);
                }
                catch (Exception) { }
                ManagementObjectSearcher search_cm = new ManagementObjectSearcher("root\\CIMV2", $"SELECT * FROM Win32_CacheMemory WHERE Level = {3}");
                foreach (ManagementObject query_cm_rotate in search_cm.Get())
                {
                    // L1 CACHE
                    double l1_size = Convert.ToDouble(query_cm_rotate["MaxCacheSize"]);
                    if (l1_size >= 1024)
                    {
                        cpu.L1Cache = (l1_size / 1024).ToString() + " MB";
                    }
                    else
                    {
                        cpu.L1Cache = l1_size.ToString() + " KB";
                    }
                }

            }
            return cpu;
        }


        public Memory GetMemory()
        {
            Memory memory = new Memory();
            ManagementObjectSearcher search_os = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher search_pm = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            try
            {
                // TOTAL RAM
                ComputerInfo main_query = new ComputerInfo();
                ulong total_ram_x64_tick = ulong.Parse(main_query.TotalPhysicalMemory.ToString());
                double total_ram_isle = total_ram_x64_tick / (1024 * 1024);
                if (total_ram_isle > 1024)
                {
                    if ((total_ram_isle / 1024) > 1024)
                    {
                        memory.TotalRAM = string.Format("{0:0.00} TB", total_ram_isle / 1024 / 1024);
                    }
                    else
                    {
                        memory.TotalRAM = string.Format("{0:0.00} GB", total_ram_isle / 1024);
                    }
                }
                else
                {
                    memory.TotalRAM = total_ram_isle.ToString() + " MB";
                }


            }
            catch (Exception) { }
            try
            {
                foreach (ManagementObject query_os_rotate in search_os.Get())
                {
                    // TOTAL VIRTUAL RAM
                    memory.VirtualMemoryAmount = String.Format("{0:0.00} GB", Convert.ToDouble(query_os_rotate["TotalVirtualMemorySize"]) / 1024 / 1024);
                }


            }
            catch (Exception) { }
            foreach (ManagementObject queryObj in search_pm.Get())
            {
                var ram = new RAM();
                try
                {
                    // RAM AMOUNT
                    ram.Slot = Convert.ToUInt16(queryObj["BankLabel"]);
                }
                catch (Exception) { }
                try
                {
                    // RAM CAPACITY
                    double ram_amount = Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024;
                    if (ram_amount > 1024)
                    {
                        ram.Amount = ram_amount / 1024 + " GB";
                    }
                    else
                    {
                        ram.Amount = ram_amount + " MB";
                    }

                }
                catch (Exception) { }
                try
                {
                    // MEMORY TYPE
                    int sm_bios_memory_type = Convert.ToInt32(queryObj["SMBIOSMemoryType"]);
                    int memory_type = Convert.ToInt32(queryObj["MemoryType"]);
                    if (sm_bios_memory_type == 2 || memory_type == 2)
                    {
                        ram.Type = "DRAM";
                    }
                    else if (sm_bios_memory_type == 3 || memory_type == 3)
                    {
                        ram.Type = "Synchronous DRAM";
                    }
                    else if (sm_bios_memory_type == 4 || memory_type == 4)
                    {
                        ram.Type = "Cache Ram";
                    }
                    else if (sm_bios_memory_type == 5 || memory_type == 5)
                    {
                        ram.Type = "EDO";
                    }
                    else if (sm_bios_memory_type == 6 || memory_type == 6)
                    {
                        ram.Type = "EDRAM";
                    }
                    else if (sm_bios_memory_type == 7 || memory_type == 7)
                    {
                        ram.Type = "VRAM";
                    }
                    else if (sm_bios_memory_type == 8 || memory_type == 8)
                    {
                        ram.Type = "SRAM";
                    }
                    else if (sm_bios_memory_type == 9 || memory_type == 9)
                    {
                        ram.Type = "RAM";
                    }
                    else if (sm_bios_memory_type == 10 || memory_type == 10)
                    {
                        ram.Type = "ROM";
                    }
                    else if (sm_bios_memory_type == 11 || memory_type == 11)
                    {
                        ram.Type = "FLASH";
                    }
                    else if (sm_bios_memory_type == 12 || memory_type == 12)
                    {
                        ram.Type = "EEPROM";
                    }
                    else if (sm_bios_memory_type == 13 || memory_type == 13)
                    {
                        ram.Type = "FEPROM";
                    }
                    else if (sm_bios_memory_type == 14 || memory_type == 14)
                    {
                        ram.Type = "EPROM";
                    }
                    else if (sm_bios_memory_type == 15 || memory_type == 15)
                    {
                        ram.Type = "CDRAM";
                    }
                    else if (sm_bios_memory_type == 16 || memory_type == 16)
                    {
                        ram.Type = "3DRAM";
                    }
                    else if (sm_bios_memory_type == 17 || memory_type == 17)
                    {
                        ram.Type = "SDRAM";
                    }
                    else if (sm_bios_memory_type == 18 || memory_type == 18)
                    {
                        ram.Type = "SGRAM";
                    }
                    else if (sm_bios_memory_type == 19 || memory_type == 19)
                    {
                        ram.Type = "RDRAM";
                    }
                    else if (sm_bios_memory_type == 20 || memory_type == 20)
                    {
                        ram.Type = "DDR";
                    }
                    else if (sm_bios_memory_type == 21 || memory_type == 21)
                    {
                        ram.Type = "DDR2";
                    }
                    else if (sm_bios_memory_type == 22 || memory_type == 22)
                    {
                        ram.Type = "DDR2 FB-DIMM";
                    }
                    else if (sm_bios_memory_type == 24 || memory_type == 24)
                    {
                        ram.Type = "DDR3";
                    }
                    else if (sm_bios_memory_type == 25 || memory_type == 25)
                    {
                        ram.Type = "FBD2";
                    }
                    else if (sm_bios_memory_type == 26 || memory_type == 26)
                    {
                        ram.Type = "DDR4";
                    }
                    else if (sm_bios_memory_type == 27 || memory_type == 27 || sm_bios_memory_type == 28 || memory_type == 28)
                    {
                        ram.Type = "DDR5";
                    }


                }
                catch (Exception) { }
                try
                {
                    // RAM SPEED
                    ram.Frequency = Convert.ToInt32(queryObj["Speed"]) + " MHz";

                }
                catch (Exception) { }
                try
                {
                    // RAM VOLTAGE
                    string ram_voltaj = Convert.ToString(queryObj["ConfiguredVoltage"]);
                    if (ram_voltaj == "" || ram_voltaj == "0" || ram_voltaj == "0.0" || ram_voltaj == "0.00" || ram_voltaj == string.Empty)
                    {
                        ram.Voltage = "Unkhown";
                    }
                    else
                    {
                        ram.Voltage = ram_voltaj + " v";
                    }

                }
                catch (Exception) { }
                try
                {
                    // FORM FACTOR
                    int form_factor = Convert.ToInt32(queryObj["FormFactor"]);
                    if (form_factor == 8)
                    {
                        ram.FormFactor = "DIMM";
                    }
                    else if (form_factor == 12)
                    {
                        ram.FormFactor = "SO-DIMM";
                    }

                    else
                    {
                        ram.FormFactor = form_factor.ToString();
                    }

                }
                catch (Exception) { }
                try
                {
                    // RAM SERIAL
                    ram.SericalNumber = Convert.ToString(queryObj["SerialNumber"]).Trim();

                }
                catch (Exception) { }
                try
                {
                    // RAM MAN
                    string ram_man = Convert.ToString(queryObj["Manufacturer"]).Trim();
                    if (ram_man == "" || ram_man == string.Empty)
                    {
                        ram.Manufacturer = "Unknown";
                    }
                    else if (ram_man == "017A")
                    {
                        ram.Manufacturer = "Apacer";
                    }
                    else if (ram_man == "059B")
                    {
                        ram.Manufacturer = "Crucial";
                    }
                    else if (ram_man == "04CD")
                    {
                        ram.Manufacturer = "G.Skill";
                    }
                    else if (ram_man == "0198")
                    {
                        ram.Manufacturer = "HyperX";
                    }
                    else if (ram_man == "029E")
                    {
                        ram.Manufacturer = "Corsair";
                    }
                    else if (ram_man == "04CB")
                    {
                        ram.Manufacturer = "A-DATA";
                    }
                    else if (ram_man == "00CE")
                    {
                        ram.Manufacturer = "Samsung";
                    }
                    else
                    {
                        ram.Manufacturer = ram_man;
                    }

                }
                catch (Exception) { }
                try
                {
                    // RAM BANK LABEL
                    string bank_label = Convert.ToString(queryObj["BankLabel"]);
                    if (bank_label == "" || bank_label == string.Empty)
                    {
                        ram.Location = "Unknown";
                    }
                    else
                    {
                        ram.Location = bank_label;
                    }

                }
                catch (Exception) { }
                try
                {
                    // RAM TOTAL WIDTH
                    string ram_data_width = Convert.ToString(queryObj["TotalWidth"]);
                    if (ram_data_width == "" || ram_data_width == string.Empty)
                    {
                        ram.Width = "Unknowm";
                    }
                    else
                    {
                        ram.Width = ram_data_width + " Bit";
                    }

                }
                catch (Exception) { }

            // RAM SELECT
                memory.RAMSlots.Add(ram);
            }
            return memory;
        }

        public const int ERROR_INVALID_FUNCTION = 1;
        [DllImport("kernel32.dll", EntryPoint = "GetFirmwareEnvironmentVariableA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBIOSType(string lpName, string lpGUID, IntPtr pBuffer, uint size);
        public MotherboardService()
        {

        }
    }
}
