using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class SessionRoom
    {
        public int SessionID { get; set; }
        public string Room { get; set; }

        public SessionRoom(int sessionID, string room)
        {
            SessionID = sessionID;
            Room = room;
        }
    }
}
