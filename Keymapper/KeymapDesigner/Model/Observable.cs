using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class Observable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            foreach (var propertyName in propertyNames)
            {
                OnPropertyChanged(propertyName);
            }
        }

        protected bool SetValue<T>(ref T actual, T newValue, string name)
        {
            if (!EqualityComparer<T>.Default.Equals(actual, newValue))
            {
                actual = newValue;
                OnPropertyChanged(name);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool SetValue<T>(ref T actual, T newValue, params string[] propertyNames)
        {
            if (!EqualityComparer<T>.Default.Equals(actual, newValue))
            {
                actual = newValue;
                OnPropertyChanged(propertyNames);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
