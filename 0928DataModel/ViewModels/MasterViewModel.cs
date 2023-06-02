using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    class MasterViewModel
    {
        public string site { get; set; }
        public string pm_no { get; set; }
        public string Workshop { get; set; }
        public string MC_Code { get; set; }
        public string CNC_Type { get; set; }
        public string Monitoring { get; set; }
        public System.Guid rowguid { get; set; }
    }
}
