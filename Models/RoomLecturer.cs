using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class RoomLecturer
    {
        public string LecturerName { get; set; }
        public string RoomName { get; set; }

        public RoomLecturer(string lecturerName, string roomName)
        {
            LecturerName = lecturerName;
            RoomName = roomName;
        }

    }
}
