using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class RoomGroup
    {
        public string GroupID { get; set; }
        public string SubGroupID { get; set; }
        public string RoomName { get; set; }

        public RoomGroup(string groupID, string subGroupID, string roomName)
        {
            GroupID = groupID;
            SubGroupID = subGroupID;
            RoomName = roomName;
        }
    }
}
