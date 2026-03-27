using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Is_Is_Not
{
    internal class UserProgramCode
    {
        public static string negativeString(string input)
        {
            return Regex.Replace(input, @"(?<![a-zA-Z])is(?![a-zA-Z])", "is not");
        }
    
    }
}
