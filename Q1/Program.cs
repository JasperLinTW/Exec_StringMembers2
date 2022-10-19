using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //將" abc " 左右的空白刪除
            string value = "  abc  ";
            string result = value.Trim();
            Console.WriteLine(result);
        }
    }
}
