using System;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //new array generated
            int[,] massiv = new int[10, 10];

            //Array is filled with some numbers
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    massiv[j, i] = i * 10 + j;
                }
            }

            //showing full array as matrix
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    if(massiv[j,i] < 10)
                    {
                        Console.Write(massiv[j, i] + "  ");
                    }
                    else
                    {
                        Console.Write(massiv[j, i] + " ");
                    }
                }
                Console.WriteLine();
            }

            //separator
            Console.WriteLine("=============================");

            //showing array in diagonal
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                Console.WriteLine(probels(i) + massiv[i,i]);
            }

            Console.WriteLine("=============================");

        }

        static string probels(int s)
        {
            string probel = "";
            for (int i = 0; i < s; i++)
            {
                probel += "   ";
            }
            return probel;
        }
    }
}
