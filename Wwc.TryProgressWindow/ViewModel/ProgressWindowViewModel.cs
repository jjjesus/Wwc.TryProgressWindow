using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wwc.TryProgressWindow.ViewModel
{
    public class ProgressWindowViewModel : INotifyPropertyChanged
    {
        public const int MAX_PROGRESS_VALUE = 100;
        private int _progressValue;
        public int ProgressValue
        {
            get { return _progressValue;  }
            set
            {
                _progressValue = value;
                if (value >= MAX_PROGRESS_VALUE) DialogResult = true;
                OnPropertyChanged("ProgressValue");
            }
        }

        private bool? _dialogResult;
        public bool? DialogResult
        {
            get { return _dialogResult; }
            set
            {
                _dialogResult = value;
                OnPropertyChanged("DialogResult");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
