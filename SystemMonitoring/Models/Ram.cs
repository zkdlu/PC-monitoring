using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitoring.Models
{
    class Ram
    {
        private PerformanceCounter _ramCounter;

        public double TotalMBSize { get; set; }

        public double AvailableMBSize
        {
            get
            {
                return _ramCounter.NextValue();
            }
        }

        public Ram()
        {
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            var osObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (var info in osObject.Get())
            {
                TotalMBSize = Convert.ToDouble(info["TotalVisibleMemorySize"]) / 1024;
            }
        }
    }
}
