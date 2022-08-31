using BrokeProtocol.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _logthingies
{
    public class sex : Plugin
    {
        public sex()
        {
            Info = new PluginInfo("log thiny for james <3 - random", "sex");
            Application.logMessageReceived += Application_logMessageReceived;
        }

        private void Application_logMessageReceived(string logContents, string stackTrace, LogType type)
        {
            System.IO.File.AppendAllText("Server2.log", String.IsNullOrWhiteSpace(stackTrace) ? $"{logContents}\n" : $"{logContents}\n{stackTrace}\n");
        }
    }
}
