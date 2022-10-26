using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Student:Person
    {
        public override void Greet()
        {
            base.Greet();
            Console.Write("Я студент ");
        }
        public void Study()
        {
            Console.WriteLine("Я учусь");
        }
        public void ShowAge()
        {
            Console.WriteLine($"Мой возраст:{Age}");
        }
    }
}
