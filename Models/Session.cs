using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Session
    {
        public string Lecturer { get; set; }
        public string Tag { get; set; }
        public string GroupID { get; set; }
        public string SubGroupID { get; set; }
        public string NoOfStudents { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Session(string lecturer, string tag, string groupID, string subGroupID, string noOfStudents, int hours, int minutes)
        {
            Lecturer = lecturer;
            Tag = tag;
            GroupID = groupID;
            SubGroupID = subGroupID;
            NoOfStudents = noOfStudents;
            Hours = hours;
            Minutes = minutes;
        }
    }
}
