using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class Subject
    {
        public string Name { get; set; }
        public string SubCode { get; set; }

        public Subject(string name, string subCode)
        {
            Name = name;
            SubCode = subCode;
        }
    }

}
