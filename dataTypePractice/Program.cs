using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypePractice
{
    class Program
    {


        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes three letters as input and display them in reverse order

            //Console.WriteLine("enter the letter b ");
            //char letter = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("enter the letter a ");
            //char letter1 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("enter the letter t ");
            //char letter2 = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("The reverse order of the letters are: {0} {1} {2} ", letter2, letter1, letter);

            //Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number
            //input
            //Console.Write("enter a number ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter the width of the number ");
            //int width = Convert.ToInt32(Console.ReadLine());

            ////constructing columns with the rows
            //int height = width;
            //for (int row = 0; row < height; row++)
            //{
            //    for (int column = 0; column < width; column++)
            //    {
            //        //print the numbers
            //        Console.Write(num);
            //    }
            //    //decrease the width as you print the numbers
            //    Console.WriteLine();
            //    width--;

                //}

                //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle. rejected
                double perim_Cir, area;
                double PI = 3.14;

                Console.Write("enter a number ");
                double rad = Convert.ToDouble(Console.ReadLine());
                perim_Cir = 2 * PI * rad;
                area = PI * rad * rad;
                Console.WriteLine("Perimeter of the circle is {0}", perim_Cir);
                Console.WriteLine("Area of the circle is {0}", area);

            }
        }
    }

