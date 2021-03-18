using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Workingday
    {
        public int NoOfWorkingDay { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Workingday(int noOfWorkingDay, int monday, int tuesday, int wednesday, int thursday, int friday, int saturday, int sunday, int hour, int minute)
        {
            NoOfWorkingDay = noOfWorkingDay;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            Saturday = saturday;
            Sunday = sunday;
            Hour = hour;
            Minute = minute;
        }
    }
}
