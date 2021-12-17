using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lesson11._12._21
{
    class Program : Additional_Methods
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nLaboratory Work 14.1");
            Console.ForegroundColor = ConsoleColor.White;

            BankAccount acc = new BankAccount(2.28, 666, BankAccount.Type.Current);
            BankAccount.DumpToScreen(acc);



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nLaboratory Work 14.2");
            Console.ForegroundColor = ConsoleColor.Blue;

            Type typeInfo = typeof(RationalNumbers);
            Console.WriteLine("typeof(RationalNumber): " + typeInfo);
            Console.ForegroundColor = ConsoleColor.White;
            object[] attributes = typeInfo.GetCustomAttributes(false);
            Console.WriteLine("Дата разработки: " + (attributes[0] as DeveloperInfoAttribute).Time + "\nРазработчик: " + (attributes[0] as DeveloperInfoAttribute).Developer);



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHomework 14.1");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("typeof(OrganizationInfoAttribute) = " + typeof(DeveloperInfoAttribute) + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Разработчик: " + (attributes[1] as OrganizationInfoAttribute).Developer + "\nКомпания: " + (attributes[1] as OrganizationInfoAttribute).Organization);







            Close(); //Закрытие программы
        }

        //Через is
        public bool IsFormattable(object param) => param is IFormattable;

        //Через as
        public bool AsFormattable(object param) => param as IFormattable != null;
    }
    }

