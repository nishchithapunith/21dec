using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21dec
{
    internal class Program
    {
        public class Employee
        {
            public Employee() { Console.WriteLine(" am a C"); }
            public void Display() { Console.WriteLine(" am display ()"); }
            static void Main(string[] args)
            {
                Employee e1;
                e1 = new Employee();// initializes class object , memory or instance,implicit
                e1.Display();//explicit
            }
        }




    }
}
