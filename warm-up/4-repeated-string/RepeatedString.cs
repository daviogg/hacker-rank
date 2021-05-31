using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        int len = s.Length;
        long cnt = 0;
        string remStr;
        long repeats = 1, finalCnt,remCnt;

        if (len > 1)
        {
            long rem = (long)n % len;
            repeats = (n-rem)/len;           

            cnt = s.Split('a').Length - 1;
            finalCnt = cnt * repeats;

            remStr = s.Substring(0, (int)rem);
            remCnt = remStr.Split('a').Length - 1;

            finalCnt = finalCnt + remCnt;
            return finalCnt;
        }
        else
        {
            if ((s == "a")&&(len==1))
            {
                return n;
            }
            else
                return 0;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
