using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._12._21
{
    [DeveloperInfo("Тимофеева Анастасия", "11.12.21")]
    [OrganizationInfo("Тимофеева Анастасия", "Yandex")]
    class RationalNumbers
    {
        public int Numerator { get; set; } //Числитель
        public uint Denominator { get; set; } //Знаменатель
        public double Rational => ((double)Numerator) / ((double)Denominator);
    }
}
