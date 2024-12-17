/*
Description

Task
Given integers n, l and r, find the number of ways to represent n as a sum of two integers A and B such that l ≤ A ≤ B ≤ r.

Example
For n = 6, l = 2 and r = 4, the output should be 2
There are just two ways to write 6 as A + B, where 2 ≤ A ≤ B ≤ 4:
6 = 2 + 4 and 6 = 3 + 3

Input/Output
[input] integer n
A positive integer.
Constraints: 5 ≤ n ≤ 106.
[input] integer l
A positive integer.
Constraints: 1 ≤ l ≤ r.
[input] integer r
A positive integer.
Constraints: l ≤ r ≤ 106
[output] an integer
*/

namespace myjinxin
{
    using System;

    public class Kata
    {
        public int CountSumOfTwoRepresentations(int n, int l, int r)
        {
            int count = 0;

            for (int i = l; i <= r; i++)
            {
                int complement = n - i;
                if (l <= complement && complement <= r)
                {
                    count++;
                }
            }

            return (int)Math.Ceiling(count / 2.0);
        }
    }
}