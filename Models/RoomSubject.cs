using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class RoomSubject
    {
        public string TagName { get; set; }
        public string SubjectName { get; set; }
        public string RoomName { get; set; }

        public RoomSubject(string tagName, string subjectName, string roomName)
        {
            TagName = tagName;
            SubjectName = subjectName;
            RoomName = roomName;
        }
    }
}
