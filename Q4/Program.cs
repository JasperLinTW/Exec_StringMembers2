using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q4
            //假設有表示日期的字串"1100225", 請將它轉成表示西元年的日 期"20210225"

            //字串處理成整數的西元年、月、日
            string value = "1100225";
            int year = Convert.ToInt32(value.Substring(0, 3)) + 1911;
            int month = Convert.ToInt32(value.Substring(3, 2));
            int day = Convert.ToInt32(value.Substring(5, 2));

            //將年月日塞回變成新的datetime，並設定格式轉回字串
            DateTime datetime = new DateTime(year, month, day);
            string result = datetime.ToString("yyyyMMdd");
            Console.WriteLine(result);
        }
    }
}
