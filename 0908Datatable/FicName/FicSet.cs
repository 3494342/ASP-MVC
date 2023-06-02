using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FFT.FicName
{
    public class FicSet
    {
        private FicName _ficName = new FicName();
        private string algName = "ALG";
        private string athName = "ATH";
        private string amcName = "AMC";

        public string AlgName
        {
            get
            {
                return algName;
            }

         
        }

        public string AthName
        {
            get
            {
                return athName;
            }

          
        }

        public string AmcName
        {
            get
            {
                return amcName;
            }

            
        }

        public FicName GetFicName()
        {
            FicName name = _ficName;
            return name;
        }
      
        public FicSet()
        {
            GetName();
            GetLocalIP();
        }
      
        public string GetName()
        {
            if (Environment.MachineName.ToUpper().Contains(AlgName))
            {
                _ficName.Name = AlgName;
            }
            else if (Environment.MachineName.ToUpper().Contains(AthName))
            {
                _ficName.Name = AthName;
            }
            else if (Environment.MachineName.ToUpper().Contains(AmcName))
            {
                _ficName.Name = AmcName;
            }
            else
            {
                _ficName.Name = AthName;
            }
            //test
//#if DEBUG
//            _ficName.Name = "ALG";
//#endif
            return _ficName.Name;
        }

        /// <summary>
        /// 获取当前使用的IP
        /// </summary>
        /// <returns></returns>
        public string GetLocalIP()
        {
            string nativeIP = null;
            /*通常addressList[]所得到的列表就是当前的IP地址；
            如果当前是拨号上网的话addressList[0].ToString()就是本地IP地址；addressList[1].ToString() 就是上网地址。
            如果当前是使用[EnterNet 300]拨号上网的话addressList[1].ToString()
            就是本地IP地址；addressList[0].ToString() 就是上网地址。
            如果程序只能够检测到只有一个IP地址的话，证明当前
            电脑没有在线！*/
            System.Net.IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            if (addressList.Length > 1)
            {
                nativeIP = addressList[0].ToString();
                _ficName.LocalIP = addressList[1].ToString();
            }
            else if(addressList.Length == 1)
            {
                _ficName.LocalIP = addressList[0].ToString();
            }
            return _ficName.LocalIP;
        }

    }
}
