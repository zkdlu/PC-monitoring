using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;
using SystemMonitoring.Common;

namespace SystemMonitoring.ViewModels
{
    public class BaseViewModel : Notifier
    {
        private DispatcherTimer _dispatcherTimer;
        private Action _execute;

        private readonly double _minWidth = 120;
        private readonly double _minHeight = 60;

        private double _cardWidth;
        public double CardWidth
        {
            get { return _cardWidth; }
            set
            {
                _cardWidth = value;
                OnRaiseProperty(nameof(CardWidth));
            }
        }

        private double _cardHeight;
        public double CardHeight
        {
            get { return _cardHeight; }
            set
            {
                _cardHeight = value;
                OnRaiseProperty(nameof(CardHeight));
            }
        }

        private ICommand _dragCommand;
        public ICommand DragCommand
        {
            get
            {
                if (_dragCommand == null)
                {
                    _dragCommand = new RelayCommand<DragDeltaEventArgs>(ChangeSize);
                }

                return _dragCommand;
            }
        }

        private void ChangeSize(DragDeltaEventArgs e)
        {
            double newWidth = CardWidth + e.HorizontalChange;
            double newHeight = CardHeight + e.VerticalChange;

            if (newWidth > _minWidth)
            {
                CardWidth = newWidth;
            }

            if (newHeight > _minHeight)
            {
                CardHeight = newHeight;
            }
        }

        public BaseViewModel()
        {
            CardWidth = 300;
            CardHeight = 150;

            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1000);
            _dispatcherTimer.Tick += Dispatcher_Tick;
        }

        public void StartDispatcher(Action execute)
        {
            _execute = execute;
            _dispatcherTimer.Start();
        }

        private void Dispatcher_Tick(object sender, EventArgs e)
        {
            _execute.Invoke();
        }
    }
}
