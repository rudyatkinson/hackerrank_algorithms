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

    // Complete the encryption function below.
    static string encryption(string s) {
        string final = "";
        double row, columns;
        double sqrt = Math.Floor(Math.Sqrt(s.Count())) * Math.Ceiling(Math.Sqrt(s.Count()));
        row  = sqrt < 8 ? 3 : Math.Floor(Math.Sqrt(s.Count()));
        columns = sqrt < 8 ? 3 : Math.Ceiling(Math.Sqrt(s.Count()));

        for(int i = 0; i < s.Count() / row; i++)
        {
            int index = i;
            while(index < s.Count())
            {
                final += s.ElementAt(index);
                index += (int)columns;
            }
            final += " ";
        }
        return final;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
