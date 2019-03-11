using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class GlobalVars
    {
        //建立全局静态变量以保存报警信息
        public class AlarmMessage
        {
            private String _machineNo;
            private int _index;
            private Boolean _alarmFlag = false;
            private string _alarmMessage = string.Empty;
            private DateTime _timeStamp;

            public string MachineNo
            {
                get { return _machineNo; }
                set { _machineNo = value; }
            }

            public int Index
            {
                get { return _index; }
                set { _index = value; }
            }
            public Boolean AlarmFlag
            {
                get { return _alarmFlag; }
                set { _alarmFlag = value; }
            }

            public string AlarmMessages
            {
                get { return _alarmMessage; }
                set { _alarmMessage = value; }
            }

            public DateTime TimeStamp
            {
                get { return _timeStamp; }
                set { _timeStamp = value; }
            }
        }
        public static List<AlarmMessage> alarmMessages = new List<AlarmMessage>();

        //建立全局变量保存被触发的报警信息List
        public static AlarmsMessagesList alarmsMessagesList = new AlarmsMessagesList();
    }
}
