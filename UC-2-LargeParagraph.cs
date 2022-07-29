using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMapAndBinarySearch
{
    internal class UC_2_LargeParagraph
    {
        static int countOccurrencesOfIs(string str)
        {

            string[] a = str.Split(' ');
            string word = "is";

            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (word.Equals(a[i]))
                    count++;
            }
            return count;
        }

        public static void Main()
        {
            string str = "is this is the way to talk to your " +
                         "sister? I don't know what that is";
            Console.Write(countOccurrencesOfIs(str));
        }
    }
}

