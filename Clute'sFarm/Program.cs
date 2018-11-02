using Clute_sFarm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clute_sFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Welcome to Clute's exotic Farm!\n \n ");
                Lizard exoticPet = new Lizard();
                exoticPet.Speak();
                exoticPet.Eat();
                exoticPet.Product();
                exoticPet.Run();
            Console.WriteLine("------------------------------------------------------------------------");
                //---------------------------------------- This seperates my classes for better readability
                Sloth milan = new Sloth();
                milan.Speak();
                milan.Eat();
                milan.Product();
                milan.Crawl();
            Console.WriteLine("------------------------------------------------------------------------");
            //---------------------------------------- This seperates my classes for better readability
            Hippo gloria = new Hippo();
                gloria.Speak();
                gloria.Eat();
                gloria.Product();
                gloria.Run();
            Console.WriteLine("------------------------------------------------------------------------");
            //---------------------------------------- This seperates my classes for better readability
            Gorilla harambee = new Gorilla();
                harambee.Speak();
                harambee.Eat();
                harambee.Product();
                harambee.Climb();
                Console.WriteLine("Thanks for stopping by my exotic farm! ");
           
        }
    }
}
