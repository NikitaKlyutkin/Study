using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Person
    {
        protected int Age;
        public virtual void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
