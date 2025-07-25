using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter the number of rows: ");
           int rows = int.Parse(Console.ReadLine());
           int currentNumber = 1;

           for (int i = 1; i <= rows; i++)
                {
           for (int j = 1; j <= i; j++)
           {
               Console.Write(currentNumber);
               currentNumber++;
           }
              Console.WriteLine();
           }
        }
    }
}


