using Prova6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Prova6.ViewModels
{
    public class BaseEsercizioViewModel:INotifyPropertyChanged
    {
        private EsercizioInfo _esercizioInfo;

        public EsercizioInfo EsercizioInfo
        {
            get { return _esercizioInfo; }
            set { _esercizioInfo = value;OnPropertyChanged(); }
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                SetProperty(ref isBusy, value);
            }
        }

        protected bool SetProperty<T>(ref T backingStore, T value, 
            [CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if(changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));   
        }
    }
}
