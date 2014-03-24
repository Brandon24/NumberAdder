using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum=0;
            string input;
                while(true)
                {
                    Console.WriteLine("enter a number");
                    input = Console.ReadLine();
                    n=Convert.ToInt32(input);
                    for(int i = n; i>=1; i--)
            { 
                 sum = sum + i;
                 Console.WriteLine(input);
            }
                }
                
        }
    }
}

            
  