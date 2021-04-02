using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class RoomTag
    {
        public string TagName { get; set; }
        public string RoomName { get; set; }

        public RoomTag(string tagName, string roomName)
        {
            TagName = tagName;
            RoomName = roomName;
        }
    }
}
