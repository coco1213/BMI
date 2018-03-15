using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            Console.WriteLine("請輸入身高(公分):");
            Console.WriteLine("請輸入體重:");
            string input = Console .ReadLine ();
            string input1 = Console.ReadLine();

            double s = double .Parse (input1)/(double .Parse(input)/100*double .Parse (input)/100);
            Console.WriteLine("BMI ="+Math .Round (s));
            Console.ReadLine();

        }
    }
}
