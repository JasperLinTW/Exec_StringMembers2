using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q5
            //比對使用者輸入值是否為 "Allen" 不拘大小寫
            Console.Write("請輸入Allen，不拘大小寫: ");
            string input = Console.ReadLine();
            string result = input.ToLower();
            string answer = "Allen".ToLower();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您未輸入任何內容");
                return;
            }
            if (result == answer)
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
