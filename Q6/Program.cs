using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q6			
            //比對使用者輸入值是否為 "Allen", 區分大小寫
            Console.Write("請輸入Allen，大小寫有差: ");
            string input = Console.ReadLine();
            string answer = "Allen";
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您未輸入任何內容");
                return;
            }
            if (input == answer)
            {
                Console.WriteLine("您的輸入正確");
            }
            else
            {
                Console.WriteLine("您輸入錯誤");
            }
        }
    }
}
