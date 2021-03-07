using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SleepHelper
    {
        public static void SleepAwhile(int second)
        {
            int ms = second * 1000;
            System.Threading.Thread.Sleep(ms);
        }
    }
}
