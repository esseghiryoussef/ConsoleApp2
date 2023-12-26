using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("hello world");
              int A, B;
              Console.WriteLine("Please Enter the value of A ");
              A = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Please Enter the value of B ");
              B = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine(A+B);

              for(int i=0; i<A; i++)
              {
                  Console.WriteLine(i++);
              }*/
            while (true)
            {
                String name = "youssef";
                String Family_name = "Esseghir";
                int A = 45;
                if (name == "youssef" && Family_name == "Esseghir")
                {
                    Console.WriteLine(A);
                }
                else
                {
                    Console.WriteLine(A);
                }
                Console.WriteLine($"They  call me{name} Enter the value of A");
                A = Convert.ToInt32(Console.ReadLine());

                int B = 12;
                Console.WriteLine("Give me B");
                B = Convert.ToInt32(Console.ReadLine());
                int S = A * B;
                Console.WriteLine("A*B=" + S);
            }
        }
    }
}
