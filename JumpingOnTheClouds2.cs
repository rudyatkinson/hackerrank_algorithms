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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        int currentPosition = 0;
        int jumps = 0;
        while(currentPosition != c.Count() - 1)
        {
            if(c[currentPosition + 1] == 0)
            {
                if(currentPosition == c.Count() - 2)
                    currentPosition++;
                else if(c[currentPosition + 2] == 0)
                    currentPosition += 2;
                else
                    currentPosition++;
                jumps++;
            }
            else
            {
                currentPosition += 2;
                jumps++;
            }  
        }
        return jumps;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
