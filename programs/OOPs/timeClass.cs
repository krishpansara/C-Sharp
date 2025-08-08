using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.OOPs
{
    class Time
    {
        int hours;
        int minutes;
        int seconds;

        public void setTime(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void getTime()
        {
            Console.WriteLine($"Time = {hours}:{minutes}:{seconds}");
        }

        public void incrementSecond()
        {
            seconds++;
            if(seconds >= 60)
            {
                seconds = 0;
                minutes++;

                if(minutes >= 60)
                {
                    minutes = 0;
                    hours++;

                    if(hours >= 24)
                    {
                        hours = 0;
                    }
                }
            }
        }
    }

    internal class timeClass
    {
        public static void Main()
        {
            Time t1 = new Time();
            t1.setTime(11, 28, 35);
            t1.getTime();
        }
    }
}
