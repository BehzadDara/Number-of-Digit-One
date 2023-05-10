#region Problem
/*
Given an integer n, count the total number of digit 1 appearing in all non-negative integers less than or equal to n.

Example 1:
Input: n = 13
Output: 6

Example 2:
Input: n = 0
Output: 0

LeetCode link: https://leetcode.com/problems/number-of-digit-one/
*/
#endregion

#region Solution

Console.WriteLine(CountDigitOne(192));
static int CountDigitOne(int n)
{
    var result = 0;

    for (var i = 1; i <= n; i *= 10)
    {
        var before = n / i;
        var current = before % 10;

        if (current == 0)
        {
            result += (before / 10) * i;
        }
        else if (current == 1)
        {
            var after = n % i;
            result += (before / 10) * i + (after + 1);
        }
        else
        {
            result += (before / 10 + 1) * i;
        }
    }

    return result;
}

#endregion