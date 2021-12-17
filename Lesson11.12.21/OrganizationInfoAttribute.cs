using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._12._21
{
    class OrganizationInfoAttribute : Attribute
    {
        public string Developer;
        public string Organization;

        public OrganizationInfoAttribute(string developer, string organization)
        {
            Developer = developer;
            Organization = organization;
        }
    }
}
