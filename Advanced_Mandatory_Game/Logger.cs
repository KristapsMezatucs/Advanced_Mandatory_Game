using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mandatory_Game
{
    //singleton pattern
    public class Logger
    {
        public static TraceSource ts = new TraceSource("Logger");

        public Logger()
        {
            ts.Switch = new SourceSwitch("Log", "All");

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("TraceLog.txt"));
            ts.Listeners.Add(fileLog);
        }


        public static void Logging(TraceEventType traceEventType, string message)
        {
            ts.TraceEvent(traceEventType, 0, message);
            ts.Flush();
        }
    }
}
