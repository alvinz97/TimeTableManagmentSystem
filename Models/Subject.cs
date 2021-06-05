using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Subject
    {
       public int Year { get; set; }
        public int Semester { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int LectureHours { get; set; }
        public int TutorialHours { get; set; }
        public int LabHours { get; set; }
        public int EvaluationHours { get; set; }

        public Subject(int year, int semester, string subjectName, string subjectCode, int lectureHours, int tutorialHours, int labHours, int evaluationHours)
        {
            Year = year;
            Semester = semester;
            SubjectName = subjectName;
            SubjectCode = subjectCode;
            LectureHours = lectureHours;
            TutorialHours = tutorialHours;
            LabHours = labHours;
            EvaluationHours = evaluationHours;
        } 
    }
}
