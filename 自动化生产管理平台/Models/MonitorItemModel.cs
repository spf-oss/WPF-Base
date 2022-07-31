using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自动化生产管理平台
{
    internal class MonitorItemModel : NotifyPropertyChanged
    {
        public string? Header { get; set; }

        private double _value;

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
