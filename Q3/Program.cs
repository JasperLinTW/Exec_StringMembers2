using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q3
            //將字串 "aLLeN kUO" 轉換成 "Allen Kuo"

            string raw = "aLLeN kUO";
            string toLower = raw.ToLower();
            //int spaceLocation = toLower.IndexOf(' ');
            //寫法一，拆分成四個字串處理完再合併
            //string part1 = toLower.Substring(0, 1).ToUpper();
            //string part2 = toLower.Substring(1, spaceLocation);
            //string part3 = toLower.Substring(spaceLocation + 1, 1).ToUpper();
            //string part4 = toLower.Substring(spaceLocation + 2);
            //Console.WriteLine(part1 + part2 + part3 + part4);

            //寫法二，用字元替換一次寫完
            //string result = Char.ToUpper(toLower[0]) + toLower.Substring(1, spaceLocation) + char.ToUpper(toLower[spaceLocation + 1]) + toLower.Substring(spaceLocation + 2);
            //Console.WriteLine(result);

            //寫法三
            string[] word = toLower.Split(' ', '-');
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = word[i].Substring(0, 1).ToUpper() + word[i].Substring(1);
              

            }
            foreach (string name in word)
            {
                Console.Write("{0} ", name);
            }
            Console.WriteLine();
        }
    }
}
