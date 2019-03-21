using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucking_tired_of_binary
{
    public class calculator
    {
        public string Binary(string number)
        {
            int result = 0;
            char[] array = number.ToCharArray();
            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    result += (int)Math.Pow(2.0, i);
                }
                else if (array[i] == '0') { }
                else
                {
                    return "Invalid Input";
                }
            }
            return result.ToString();
        }

        public string Decimal(string number)
        {
            string result = "";
            char[] array = number.ToCharArray();
            bool notdone = true;
            if (int.TryParse(number, out int num))
            {
                do
                {
                    if (num % 2 == 1)
                    {
                        result += "1";
                    }
                    else
                    {
                        result += "0";
                    }
                    num = num / 2;

                    if (num == 0)
                    {
                        notdone = false;
                    }
                }
                while (notdone);
            }
            else
            {
                return "Invalid input";
            }


            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
