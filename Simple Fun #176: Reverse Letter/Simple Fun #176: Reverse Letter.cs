/*
Description

Task
Given a string str, reverse it and omit all non-alphabetic characters.

Example
For str = "krishan", the output should be "nahsirk".
For str = "ultr53o?n", the output should be "nortlu".

Input/Output
[input] string str
A string consists of lowercase latin letters, digits and symbols.
[output] a string
*/

namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public string ReverseLetter(string str)
        {
            string filteredString = new string(str.Where(Char.IsLetter).ToArray());
            return new string(filteredString.Reverse().ToArray());
        }
    }
}