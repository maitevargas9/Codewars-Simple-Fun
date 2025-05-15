/*
Description

Task
Given some sticks by an array V of positive integers, where V[i] represents the length of the sticks, find the number 
of ways we can choose three of them to form a triangle.

Example
For V = [2, 3, 7, 4], the result should be 1.
There is only (2, 3, 4) can form a triangle.
For V = [5, 6, 7, 8], the result should be 4.
(5, 6, 7), (5, 6, 8), (5, 7, 8), (6, 7, 8)

Input/Output
[input] integer array V
stick lengths
3 <= V.length <= 100
0 < V[i] <=100
[output] an integer
number of ways we can choose 3 sticks to form a triangle.
*/

namespace myjinxin {
  using System;

  public class Kata {
    public int CountingTriangles(int[] V) {
      Array.Sort(V);
      int count = 0;
      int n = V.Length;

      for (int i = 0; i < n - 2; i++) {
        int k = i + 2;
        for (int j = i + 1; j < n - 1; j++) {
          while (k < n && V[i] + V[j] > V[k]) {
            k++;
          }
          count += k - j - 1;
        }
      }

      return count;
    }
  }
}