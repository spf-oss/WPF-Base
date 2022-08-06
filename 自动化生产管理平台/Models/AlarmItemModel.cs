using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自动化生产管理平台
{
    internal class AlarmItemModel
    {
        public string Num { get; set; } = String.Empty;

        public string Message { get; set; } = String.Empty;

        public string Time { get; set; } = String.Empty;

        public int Len { get; set; }
    }
}
