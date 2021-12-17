using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._12._21
{
    public class DeveloperInfoAttribute : Attribute
    {
        public string Developer;
        public string Time;

        public DeveloperInfoAttribute(string developer, string time)
        {
            Developer = developer;
            Time = time;
        }
    }
}
