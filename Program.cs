using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        
        public static void Main()
        {

            Console.WriteLine("Задание:5");

            int size_5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('*', size_5));
            for (int i = 0; i < size_5 - 2; i++)
            {
                Console.WriteLine("*" + (new string(' ', size_5 - 2)) + "*");
            }
            Console.WriteLine(new string('*', size_5));








            Console.WriteLine("Задание:4");

            int size_4 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size_4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = size_4; j > i; j--)
                {
                    Console.Write("*");
                }

                for (int j = size_4; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }








            Console.WriteLine("Задание:3");

            int size_3 = Convert.ToInt32(Console.ReadLine());

            for (int i = size_3; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = size_3; j > i; j--)
                {
                    Console.Write("*");
                }

                for (int j = size_3; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }




            Console.WriteLine("Задание:2");

            int size_2 = Convert.ToInt32(Console.ReadLine());

            for (int i = size_2; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = size_2; j > i; j--)
                {
                    Console.Write("*");
                }



                Console.WriteLine("");
            }




            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }





                Console.WriteLine("");
            }









            Console.ReadKey();


        }
        
    } 
}

