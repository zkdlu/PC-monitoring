using System.Management;
using System.Net;

namespace SystemMonitoring.Models
{
    public class Computer
    {
        public string Hostname { get; set; }

        public Cpu Cpu { get; set; }

        public Ram Ram { get; set; }

        public string Gpu { get; set; }

        public string OS { get; set; }

        public Computer()
        {
            Hostname = Dns.GetHostName();

            Cpu = new Cpu();

            Ram = new Ram();

            var videoObject = new ManagementObjectSearcher("select Name from Win32_VideoController");
            foreach (var info in videoObject.Get())
            {
                Gpu = info["Name"] as string;
            }

            var osObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (var info in osObject.Get())
            {
                OS = info["Caption"].ToString();
            }
        }
    }
}
