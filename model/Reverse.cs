﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber.model
{
    internal class Reverse
    {
        public static int IsReverse(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }
    }
}
