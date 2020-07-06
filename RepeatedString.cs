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

class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        char firstElement = s.ElementAt(0);
        long totalRepeatedTimes = 0;
        long repeatedTimesInOne = 0;
        foreach(char c in s)
        {
            if(c == firstElement)
                repeatedTimesInOne++;
        }

        totalRepeatedTimes = repeatedTimesInOne * (n / s.Count());
        if(n % s.Count() != 0)
        {
            for(int i = 0; i < n % s.Count(); i++)
            {
                if(s.ElementAt(i) == firstElement)
                    totalRepeatedTimes++;
            }
        }
        return totalRepeatedTimes;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
