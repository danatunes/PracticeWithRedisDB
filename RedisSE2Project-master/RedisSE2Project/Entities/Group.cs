using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSE2Project.Entities
{
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Group()
        {

        }

        public Group(string name)
        {
            Name = name;
        }
    }
}
