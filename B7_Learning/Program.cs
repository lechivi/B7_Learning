using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B7_Learning.modal;

namespace B7_Learning //multilevel Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Shape s2 = new Shape(12, 40);
            Shape s3 = new Shape(11);
            Console.WriteLine(s1.ToString() + '\n');
            Console.WriteLine(s2.ToString() + '\n');
            Console.WriteLine(s3.ToString() + '\n');
        }
    }
}
