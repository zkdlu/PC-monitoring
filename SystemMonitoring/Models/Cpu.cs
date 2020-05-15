using System;
using System.Diagnostics;
using System.Management;

namespace SystemMonitoring.Models
{
    class Cpu
    {
        private PerformanceCounter _cpuCounter;

        public string Name { get; set; }

        public int Usage
        {
            get
            {
                return (int)Math.Round(_cpuCounter.NextValue(), 2);
            }
        }

        public Cpu()
        {
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            var processorObject = new ManagementObjectSearcher("select Name from Win32_Processor");
            foreach (var info in processorObject.Get())
            {
                Name = info["Name"].ToString();
            }
        }
    }
}
