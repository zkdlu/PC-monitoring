namespace SystemMonitoring.Models
{
    class Disk
    {
        public long TotalSize { get; set; }

        public long Used { get; set; }

        public long AvailableSize { get; set; }

        public int UsedPercentage { get; set; }

        public string Mounted { get; set; }
    }
}
