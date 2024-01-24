using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration 
            string name = "Tebogo";
            int age = 35;
            bool istall = false;
            double weight =80.2;

            // for the smallest least precise decimal use float,
            // for more precise use decimal eg money,
            //in most cases double will do just fine

            Console.WriteLine(name + " is " + age + " she weighs " + weight);
            Console.WriteLine(" it is " + istall  +  " that she is tall. ");

            //freeze console
            Console.ReadLine();


        }
    }
}
