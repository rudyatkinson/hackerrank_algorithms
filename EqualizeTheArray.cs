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

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int key = -1;
        int keyValue = 0;
        int final = 0;
        foreach(int i in arr)
        {
            if(!dict.ContainsKey(i))
                dict.Add(i, 1);
            else
                dict[i]++;
        }
        foreach(KeyValuePair<int, int> kvp in dict)
        {
            if(key == -1 || kvp.Value > keyValue)
            {
                key = kvp.Key;
                keyValue = kvp.Value;
            }
        }
        final = keyValue > arr.Count() ? keyValue : arr.Count() - keyValue;
        return final;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
