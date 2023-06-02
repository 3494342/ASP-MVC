using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ActivityViewModel
    {
        public string Site { get; set; }
        public string pm_no { get; set; }
        public string Monitoring_Type { get; set; }
        public string Value { get; set; }
        public System.DateTime Act_Time { get; set; }
        public string workshop { get; set; }
        public string MC_Code { get; set; }
        public string Data_Source { get; set; }
    }
}
