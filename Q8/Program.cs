using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q8
            //隱藏手機的資訊呈現 0935 * ***46
            Console.Write("請輸入您的手機號碼: ");
            string input = Console.ReadLine();
            if (input.Length != 10 || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您輸入的格式有誤");
                return;
            }
            string result = input.Substring(0, 4) + new string('*', 4) + input.Substring(8);
            Console.WriteLine(result);
        }
    }
}
