using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class excercise23
    {
        public bool IsPalindrome(int x)
        {
            var number = x.ToString();
            var reverse = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverse += number[i].ToString();
            }
            if (number == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
