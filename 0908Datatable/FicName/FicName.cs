using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT.FicName
{
    public  class FicName
    {
        private string _name;//厂区名字

        private string _LocalIP;//server ip
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string LocalIP
        {
            get
            {
                return _LocalIP;
            }

            set
            {
                _LocalIP = value;
            }
        }
    }
}
