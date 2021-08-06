using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMathOperationApp
{
    class Program
    {
        delegate void DMathOperation(int n1, int n2);
        static void Main(string[] args)
        {
            DMathOperation m;
            m = Add;
            m += Sub;
            m += Multiply;
            m += Divide;
            m(20,4);
            Console.ReadLine();
        }

        static void Add(int n1, int n2)
        {
            Console.WriteLine("Add: "+(n1 + n2));
        }

        static void Sub(int n1, int n2)
        {
            Console.WriteLine("Sub: " + (n1 - n2));
        }

        static void Divide(int n1, int n2)
        {
            if(n2 != 0)
            {
                Console.WriteLine("Divide: "+(n1 / n2));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!!!");
            }
        }

        static void Multiply(int n1, int n2)
        {
            Console.WriteLine("Multiply: " + (n1 * n2));
        }
    }
}
