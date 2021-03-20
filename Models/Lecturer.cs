using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Lecturer
    {
        public string LecturerName { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Center { get; set; }
        public string Building { get; set; }
        public int LecturerLevel { get; set; }
        public string Rank { get; set; }
        public Lecturer(string lecturerName, string faculty, string department, string center, string building, int lecturerLevel, string rank)
        {
            LecturerName = lecturerName;
            Faculty = faculty;
            Department = department;
            Center = center;
            Building = building;
            LecturerLevel = lecturerLevel;
            Rank = rank;
        }
    }
}
