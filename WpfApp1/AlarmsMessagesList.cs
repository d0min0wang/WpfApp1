﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AlarmsMessagesList : INotifyPropertyChanged
    {
        private ObservableCollection<AlarmMessage> _alarmMessagesDS = new ObservableCollection<AlarmMessage>();
        public ObservableCollection<AlarmMessage> AlarmMessagesDS
        {
            get { return _alarmMessagesDS; }
            set
            {
                _alarmMessagesDS = value;
                NotifyPropertyChanged("AlarmMessagesDS");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // NotifyPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
