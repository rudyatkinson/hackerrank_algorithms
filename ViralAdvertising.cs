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

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n, int share) {
        if(n != 1)
            return (share / 2) + (viralAdvertising(n - 1, (share / 2) * 3));
        return (share / 2);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n, 5);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
