using System.Diagnostics;

namespace SystemMonitoring.ViewModels
{
    public class DiskReadWriteViewModel : BaseViewModel
    {
        private PerformanceCounter _diskReadsCounter;
        private PerformanceCounter _diskWritesCounter;

        private double _diskReadBytes;
        public double DiskReadBytes
        {
            get { return _diskReadBytes; }
            set
            {
                _diskReadBytes = value;
                OnRaiseProperty(nameof(DiskReadBytes));
            }
        }

        private double _diskWriteBytes;
        public double DiskWriteBytes
        {
            get { return _diskWriteBytes; }
            set
            {
                _diskWriteBytes = value;
                OnRaiseProperty(nameof(DiskWriteBytes));
            }
        }

        public DiskReadWriteViewModel()
        {
            _diskReadsCounter = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
            _diskWritesCounter = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");

            StartDispatcher(UpdateReadWrites);
        }

        private void UpdateReadWrites()
        {
            DiskReadBytes = _diskReadsCounter.NextValue();
            DiskWriteBytes = _diskWritesCounter.NextValue();
        }
    }
}
