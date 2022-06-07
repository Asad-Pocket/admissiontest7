using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {
        public bool Is_alpha(char ch)
        {
            return ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'));
        }
        public int Count(string text)
        {


            int Length = text.Length;

            if (Length == 0)
                return 0;

            int Count = 0;
            Char[] ch = text.ToCharArray();

            if (Is_alpha(ch[0]))
                Count++;

            for (int i = 1; i < Length; i++)
            {
                if (Is_alpha(ch[i]) && !(Is_alpha(ch[i - 1])))
                    Count++;
            }
            return Count;
        }
    }
}
