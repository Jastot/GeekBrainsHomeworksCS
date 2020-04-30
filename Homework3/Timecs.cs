using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /*1ое задание вы изменили на аналог году,как я понял. вот аналог года,только с временем.
     Надеюсь я Вас верно понял.
         
        Чудаков Г.А.
         */
    class Time
    {
        private int hour, min, sec;

        public Time()
        {
            hour = 0;
            min = 0;
            sec = 0;

        }

        public Time(int hour, int min, int sec)
        {
            this.Hour = hour;
            this.Min = min;
            this.Sec = sec;
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if(value < 0 || value > 11) throw new ArgumentException("Неправильно задан час");
                hour = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 1 || value > 59) throw new ArgumentException("Неправильно заданы минуты");
                min = value;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 1 || value > 99) throw new ArgumentException("Неправильно заданы секунды");
                sec = value;

            }
        }

    }


    partial class HW3
    {
        public static void Time()
        {
            Time time = new Time();
            Time time2 = new Time(11,59,20);
            time.Hour = 5; time.Sec = 40;
            Console.WriteLine(time.Hour + ":" + time.Min + ":" + time.Sec);
            Console.WriteLine(time2.Hour + ":" + time2.Min + ":" + time2.Sec);
        }
    }
}
