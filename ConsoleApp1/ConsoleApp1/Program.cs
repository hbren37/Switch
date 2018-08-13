using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//Exercise one
            Console.WriteLine("Please enter a type of pet");
            string pettype = Console.ReadLine();

            switch (pettype)
            {
                case "dog":
                    break;
                case "cat":
                    break;
                case "parrot":
                    break;
                case "rabbit":
                    break;
                default:
                    Console.WriteLine("This is an unknown pet!");
                    break;



            }

            //Exercise two

            
            Console.WriteLine("Please enter the fruit type you would like to find the price of");
            string fruit = Console.ReadLine();

            switch (fruit)
            {
                case "apple":
                    Console.WriteLine("$1.25 per kg");
                    break;
                case "banana":
                    Console.WriteLine("$3.15 per kg");
                    break;
                case "kiwifruit":
                    Console.WriteLine("$4.65 per kg");
                    break;
                case "oranges":
                    Console.WriteLine("$2.75 per kg");
                    break;
                default:
                    Console.WriteLine("Fruit unknown");
                    break;
            }

            Console.ReadKey();

            //Exercise three

            Console.WriteLine("Please enter two numbers and an operator");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            switch (op)
                case 



            
            




      
                
           
                 
            


        }
    }
}
