using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        public int Count { get; set; } = 0;

        public int Second { get; set; } = 0;

        public Person()
        {
            Count = 1;
            Second = 2;
        }

        public void Script()
        {
            Console.WriteLine("What are you doing");
        }
    }
}
