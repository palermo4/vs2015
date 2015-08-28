using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Console;

namespace NewInCSharp
{
    public static class GlobalHelper
    {
        public static void Log(string info)
        {
            //ConsoleLogger cl = new ConsoleLogger();
            LogConsole lc = new LogConsole();
            lc.WriteLine("Testorama");
        }
    }
}
