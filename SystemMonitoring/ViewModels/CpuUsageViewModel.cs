using SystemMonitoring.Models;

namespace SystemMonitoring.ViewModels
{
    public class CpuUsageViewModel : BaseViewModel
    {
        private Cpu _cpu;

        private int _usage;
        public int Usage
        {
            get { return _usage; }
            set
            {
                _usage = value;
                OnRaiseProperty(nameof(Usage));
            }
        }

        private int _free;
        public int Free
        {
            get { return _free; }
            set
            {
                _free = value;
                OnRaiseProperty(nameof(Free));
            }
        }

        public CpuUsageViewModel()
        {
            _cpu = new Cpu();

            StartDispatcher(UpdateCpu);
        }

        private void UpdateCpu()
        {
            Usage = _cpu.Usage;
            Free = 100 - Usage;
        }
    }
}
