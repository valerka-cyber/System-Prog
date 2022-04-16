using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class StringLib
    {      

        public static string  SingleSpace(String str)
        {
             return str.Replace(@"\s+", " ");
        }
    }
   public static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            return new string (input.ToCharArray().Reverse().ToArray());
        }
    }

}
