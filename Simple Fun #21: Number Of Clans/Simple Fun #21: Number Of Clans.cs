/*
Description

Task
Let's call two integers A and B friends if each integer from the array divisors is either a divisor of both A and B or neither A 
nor B. If two integers are friends, they are said to be in the same clan. How many clans are the integers from 1 to k, inclusive, 
broken into?

Example
For divisors = [2, 3] and k = 6, the output should be 4
The numbers 1 and 5 are friends and form a clan, 2 and 4 are friends and form a clan, and 3 and 6 do not have friends and each 
is a clan by itself. So the numbers 1 through 6 are broken into 4 clans.

Input/Output
[input] integer array divisors
A non-empty array of positive integers.
Constraints: 2 ≤ divisors.length < 10, 1 ≤ divisors[i] ≤ 10.
[input] integer k
A positive integer.
Constraints: 5 ≤ k ≤ 50.
[output] an integer
*/

namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Kata
    {
        public int NumberOfClans(int[] divisors, int k)
        {
            HashSet<string> clans = new HashSet<string>();

            for (int num = 1; num <= k; num++)
            {
                string signature = string.Join("", divisors.Select(div => num % div == 0 ? "1" : "0"));
                clans.Add(signature);
            }

            return clans.Count;
        }
    }
}