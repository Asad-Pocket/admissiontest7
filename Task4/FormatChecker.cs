using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        public bool IsValid(string mobileNumber)
        {
            int s = 0;
            int s1 = mobileNumber.Length;

            if(s1!=11)
                return false;
            if (mobileNumber[0] == '0' && mobileNumber[1] == '1'  )
            {
                for (int i = 2; i <= mobileNumber.Length - 1; i++)
                {
                    if (mobileNumber[i] >= 48 && mobileNumber[i] <= 57)
                        s++;

                }

            }
            else
            return false;

            if (s == 9)
            {
                return true;
            }
            else
                return false;

            


          }
    }
}
