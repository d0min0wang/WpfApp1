﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            for (int i=1; i<10; i++)
            {
                GlobalVars.AlarmMessage am = new GlobalVars.AlarmMessage();
                am.AlarmFlag = true;
                am.AlarmMessages = "测试" + i.ToString();
                am.TimeStamp = DateTime.Now;
                am.MachineNo = i.ToString();
                GlobalVars.alarmMessages.Add(am);
            }
            ObservableCollection<GlobalVars.AlarmMessage> alarmMessagesDS = new ObservableCollection<GlobalVars.AlarmMessage>(GlobalVars.alarmMessages);
            //alarmMessagesDS.Clear();
            //List<GlobalVars.AlarmMessage> alarmMessagesDS = new List<GlobalVars.AlarmMessage>();
            foreach (var item in GlobalVars.alarmMessages)
            {
                if (item.AlarmFlag)
                {
                    //GlobalVars.AlarmMessage alarmMessage = new GlobalVars.AlarmMessage();
                    alarmMessagesDS.Add(item);
                }
            }
            //alarmMessagesDS.Sort((a, b) => b.TimeStamp.CompareTo(a.TimeStamp));
            //alarmMessagesDS.ForEach(x=>)
            GlobalVars.alarmsMessagesList.AlarmMessagesDS = alarmMessagesDS;

            dataGridViewAlarmMessage.DataContext = GlobalVars.alarmMessages;

        }
    }
}
