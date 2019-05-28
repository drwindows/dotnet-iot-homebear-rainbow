﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBear.Rainbow.Controller
{
    static class StringExtension
    {
        /// <summary>
        /// Converts specified parts of given string into hex-based
        /// int values.
        /// </summary>
        /// <param name="input">Hex string.</param>
        /// <param name="from">Start index of substring that should
        /// be converted.</param>
        /// <param name="length">Length of the substring.</param>
        /// <returns>Parsed hex-based int value.</returns>
        public static int ToHexInt(this string input, int from, int length = 2)
        {
            return int.Parse(input.Substring(from, length),
                System.Globalization.NumberStyles.AllowHexSpecifier);
        }
    }
}
