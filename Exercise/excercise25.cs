using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class excercise25
    {
        public List<string> FizzBuzz(int n)
        {
            var list = new List<string>();

            for (int a = 1; a <= n; a++)
            {

                if (a % 3 == 0 && a % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (a % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (a % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(a.ToString());
                }
            }
            return list;
        }
    }
}
