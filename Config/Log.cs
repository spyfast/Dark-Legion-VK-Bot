using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkLegion
{
    class Log
    {
        public static Queue<string> messages = new Queue<string>();
        public static void Push(string message)
        {
            messages.Enqueue($"[{DateTime.Now}]: {message}");
        }
    }
}
