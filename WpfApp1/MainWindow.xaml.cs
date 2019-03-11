using System;
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
            dataGridViewAlarmMessage.ItemsSource = GlobalVars.AlarmMessagesDS;
            for (int i=1; i<10; i++)
            {
                AlarmMessage am = new AlarmMessage
                {
                    AlarmFlag = true,
                    AlarmMessages = "测试" + i.ToString(),
                    TimeStamp = DateTime.Now,
                    MachineNo = i.ToString()
                };
                GlobalVars.alarmMessages.Add(am);
            }
            //ObservableCollection<AlarmMessage> alarmMessagesDS = new ObservableCollection<AlarmMessage>();
            //alarmMessagesDS.Clear();
            //List<GlobalVars.AlarmMessage> alarmMessagesDS = new List<GlobalVars.AlarmMessage>();
            foreach (var item in GlobalVars.alarmMessages)
            {
                if (item.AlarmFlag)
                {
                    //GlobalVars.AlarmMessage alarmMessage = new GlobalVars.AlarmMessage();
                    GlobalVars.AlarmMessagesDS.Add(item);
                }
            }
            //alarmMessagesDS.Sort((a, b) => b.TimeStamp.CompareTo(a.TimeStamp));
            //alarmMessagesDS.ForEach(x=>)
            //GlobalVars.AlarmMessagesDS = alarmMessagesDS;
            //dataGridViewAlarmMessage.DataContext = GlobalVars.AlarmMessagesDS;
            //dataGridViewAlarmMessage.ItemsSource = GlobalVars.AlarmMessagesDS;
        }
    }
}
