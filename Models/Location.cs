using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Location
    {
        public string BuildingName { get; set; }

        public string RoomName { get; set; }

        public int RoomType { get; set; }

        public int RoomCapacity { get; set; }

        public Location(string buildingName, string roomName, int roomType, int roomCapacity)
        {
            BuildingName = buildingName;
            RoomName = roomName;
            RoomType = roomType;
            RoomCapacity = roomCapacity;
        }
    }
}
