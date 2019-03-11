using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class GlobalVars
    {
        //建立全局静态变量以保存报警信息
        
        public static List<AlarmMessage> alarmMessages = new List<AlarmMessage>();

        //建立全局变量保存被触发的报警信息List
        public static ObservableCollection<AlarmMessage> AlarmMessagesDS = new ObservableCollection<AlarmMessage>();
    }
}
