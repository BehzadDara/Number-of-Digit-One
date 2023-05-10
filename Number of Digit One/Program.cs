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

Console.WriteLine(CountDigitOne(20));
static int CountDigitOne(int n)
{
    var result = 0;

    for (var i = 1; i <= n; i *= 10)
    {
        var a = n / i;
        var b = n % i;
        var x = a % 10;

        if (x == 1)
        {
            result += (a / 10) * i + (b + 1);
        }
        else if (x == 0)
        {
            result += (a / 10) * i;
        }
        else
        {
            result += (a / 10 + 1) * i;
        }
    }

    return result;
}

#endregion