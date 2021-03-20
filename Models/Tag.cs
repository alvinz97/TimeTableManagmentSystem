using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagmentSystem.Models
{
    class Tag
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string RelatedTag { get; set; }

        public Tag(string name, string code, string relatedTag)
        {
            Name = name;
            Code = code;
            RelatedTag = relatedTag;
        }
    }
}
