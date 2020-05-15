using System.Collections.ObjectModel;
using System.IO;
using SystemMonitoring.Models;

namespace SystemMonitoring.ViewModels
{
    public class DiskUsageViewModel : BaseViewModel
    {
        private ObservableCollection<Disk> _disks;
        public ObservableCollection<Disk> Disks
        {
            get { return _disks; }
            set
            {
                _disks = value;
                OnRaiseProperty(nameof(Disks));
            }
        }

        public DiskUsageViewModel()
        {
            var disks = new ObservableCollection<Disk>();

            var driveInfos = DriveInfo.GetDrives();
            foreach (var driveInfo in driveInfos)
            {
                long totalSize = driveInfo.TotalSize;
                long availableSize = driveInfo.AvailableFreeSpace;
                long used = totalSize - availableSize;
                int usedPercentage = (int)(((double)used / totalSize) * 100.0);
                string mounted = driveInfo.Name;

                Disk disk = new Disk
                {
                    TotalSize = totalSize,
                    AvailableSize = availableSize,
                    Used = used,
                    UsedPercentage = usedPercentage,
                    Mounted = mounted
                };

                disks.Add(disk);
            }

            Disks = disks;
        }
    }
}
