using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Astersisk_Stars_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("\n\n\t++++++++++++++++++++++++++++++" +
                                "\n\t++                          ++" +
                                "\n\t++        Welcome to        ++" +
                                "\n\t++      Stars Printing      ++" +
                                "\n\t++          System          ++" +
                                "\n\t++                          ++" +
                                "\n\t++++++++++++++++++++++++++++++\n\n"+
                                Environment.NewLine+
                                "\t>>Press Any Key to Continue<<");

            Console.ReadKey();
            Console.Clear();

            char chosen;
            int num;

        options:
            Console.WriteLine("\tChoose type of Print Below:"+
                              Environment.NewLine+
                              "\n\t  [L] - Line" +
                              "\n\t  [S] - Square" +
                              "\n\t  [R] - Right Triangle" +
                              "\n\t  [T] - Simple Triangle" +
                              "\n\t  [I] - Inverted Triangle" +
                              "\n\t  [P] - Pyramid" +
                              "\n\t  [D] - Diamond" +
                              "\n\t  [O] - Hollow Square" +
                              "\n\t  [M] - Hollow Pyramid" +
                              Environment.NewLine);

            Console.WriteLine("Your choice is:\n");
            chosen = char.Parse(Console.ReadLine().Trim().ToUpper());
            Console.Clear();

            Console.WriteLine("How many lines you want to print stars?");
            while (!int.TryParse(Console.ReadLine(), out num) || num < 1)
            {
                Console.WriteLine("Invalid Input. Please Enter Positive Integer.");
            }
            Console.Clear();

            switch (chosen)
            {
                case 'L':
                    Line(num);
                    break;

                case 'S':
                    Square(num);
                    break;

                case 'R':
                    rightTriangle(num);
                    break;

                case 'T':
                    Triangle(num);
                    break;

                case 'I':
                    Inverted(num);
                    break;

                case 'P':
                    Pyramid(num);
                    break;

                case 'D':
                    Diamond(num);
                    break;

                case 'O':
                    hollowSquare(num);
                    break;

                case 'M':
                    hollowPyramid(num);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    goto options;
                    break;

            }

            Console.ReadKey();
            Console.Clear();
            goto options;

        }

        static void Line(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("*");
            }
        }

        static void Square(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void rightTriangle(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = i; j < count; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Triangle(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Inverted(int count)
        {
            for (int i = count; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Pyramid(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = i; j < count; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Diamond(int count)
        {
            // Upper part of diamond
            for (int i = 1; i <= count; i++)
            {
                for (int j = i; j < count; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower part of diamond
            for (int i = count - 1; i >= 1; i--)
            {
                for (int j = count; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void hollowSquare(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if (i == 1 || i == count || j == 1 || j == count)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void hollowPyramid(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                for (int j = i; j < count; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    if (k == 1 || k == (2 * i - 1) || i == count)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
