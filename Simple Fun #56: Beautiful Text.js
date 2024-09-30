/*
Description

Task

Consider a string containing only letters and whitespaces. It is allowed to replace some (possibly, none) whitespaces with 
newline symbols to obtain a multiline text.

Call a multiline text beautiful if and only if each of its lines (i.e. substrings delimited by a newline character) contains 
an equal number of characters (only letters and whitespaces should be taken into account when counting the total while newline characters shouldn't).

Call the length of the line the text width.

Given a string s and some integers l and r (l ≤ r), check if it's possible to obtain a beautiful text from the string with a 
text width that's within the range [l, r].

Example
For s = "Look at this example of a correct text", l = 5 and r = 15,
the output should be true.

We can replace 13th and 26th characters with '\n', and obtain the following multiline text of width 12:
Look at this
example of a
correct text

For s = "abc def ghi", l = 4 and r = 10, the output should be false.

There are two ways to obtain a text with lines of equal length from this input, one has width = 3 and another has width = 11 
(this is a one-liner). Both of these values are not within our bounds.

Input/Output
[input] string s
Constraints: 10 ≤ inputString.length ≤ 150.
[input] integer l
A positive integer.
Constraints: 1 ≤ l ≤ r.
[input] integer r
A positive integer.
Constraints: l ≤ r ≤ 15.
[output] a boolean value
*/

function beautifulText(s, l, r) {
  return [...Array(r - l + 1)].some((_, i) =>
    new RegExp(`^(.{${i + l}}( |$))+$`).test(s)
  );
}