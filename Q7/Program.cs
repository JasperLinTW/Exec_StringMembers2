using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q7
            //計算兩數之和,並只呈現小數二位數
            Console.WriteLine("請輸入任意兩數");
            Console.Write("數字一: ");
            string input = Console.ReadLine();
            Console.Write("數字二: ");
            string input2 = Console.ReadLine();
            double d1 = Convert.ToDouble(input);
            double d2 = Convert.ToDouble(input2);
            double result = d1 + d2;
            Console.WriteLine(result.ToString("#.00"));
        }
    }
}
