using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace CollectHisAlarmMsg.LogHelper
{
    class LogHelper
    {
        private static ILog loginfo = LogManager.GetLogger("loginfo");
        private static ILog logerror = LogManager.GetLogger("logerror");

        public string Logpath { get; internal set; }

        public LogHelper()
        {
            loginfo = LogManager.GetLogger("loginfo");
            logerror = LogManager.GetLogger("logerror");
        }


        /// <summary>
        /// 写信息
        /// </summary>
        /// <param name="info">信息描述</param>
        public void WriteLog(string info)
        {
            info = Encoding.ASCII.GetString(Encoding.Default.GetBytes(info));
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
            
        }
        /// <summary>
        /// 写错误信息
        /// </summary>
        /// <param name="info">错误信息描述</param>
        /// <param name="ex">错误信息</param>
        public void WriteLog(string info, Exception ex)
        {
            info = Encoding.ASCII.GetString(Encoding.Default.GetBytes(info));
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, ex);
            }
        }


    }
}

