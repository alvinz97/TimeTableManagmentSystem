using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Student
    {
        public int Year { get; set; }
        public int Semester { get; set; }
        public string Program { get; set; }
        public int GroupNo { get; set; }
        public string GroupID { get; set; }
        public int SubGroupNo { get; set; }
        public string SubGroupID { get; set; }

        public Student(int year, int semester, string program, int groupNo, string groupID, int subGroupNo, string subGroupID)
        {
            Year = year;
            Semester = semester;
            Program = program;
            GroupNo = groupNo;
            GroupID = groupID;
            SubGroupNo = subGroupNo;
            SubGroupID = subGroupID;
        }
    }
}
