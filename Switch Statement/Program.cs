using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement 
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine("What is your favorite school subject?");
            Console.WriteLine("Choose a number: 1 = Math. 2 = Science. 3 = English. 4 = History. 5 = Reading.");
            int num = Convert.ToInt32(Console.ReadLine());

           
            switch (num)
            {
                case 1:
                    Console.WriteLine("Math is a great subject!");
                    break;
                case 2:
                    Console.WriteLine("Science is a great subject!");
                    break;
                case 3:
                    Console.WriteLine("English is a great subject!");
                    break;
                case 4:
                    Console.WriteLine("History is a great subject!");
                    break;
                case 5:
                    Console.WriteLine("Reading is a great subject!");
                    break;
                default:
                    Console.WriteLine("Please choose a subject in the list of subjects.");
                    break;
            }



        }
    }
}