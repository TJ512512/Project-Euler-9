using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int answer = 0;
            for (int i = 0; i < 1; i++)
            {
                for (a = 1; a < 1000; a++)
                {
                    for (b = 1; b < 1000; b++)
                    {
                        for (c = 1; c < 1000; c++)
                        {
                            if (a*a+b*b == c*c)
                            {
                                //Console.WriteLine("a = " + a);
                                //Console.WriteLine("b = " + b);
                                //Console.WriteLine("c = " + c);
                                //Console.WriteLine();
                                if (a + b + c == 1000)
                                {
                                    answer = a * b * c;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}