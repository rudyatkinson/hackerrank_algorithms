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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int i in arr)
        {
            if(dict.Count() == 0 || !dict.ContainsKey(i))
                dict.Add(i, 1);
            else
                dict[i]++;
        }

        int maxIndex = 0;
        for(int i = 1; i < dict.Keys.Count(); i++)
        {
            if(dict.Values.ElementAt(i) > dict.Values.ElementAt(maxIndex))
                maxIndex = i;
        }

        List<int> mostFrequent = new List<int>();
        foreach(KeyValuePair<int, int> j in dict)
        {
            if(dict.Keys.ElementAt(maxIndex) != j.Key)
            {
                if(dict.Values.ElementAt(maxIndex) == j.Value)
                    mostFrequent.Add(j.Key);
            }
        }
        if(mostFrequent.Count() > 0)
        {
            mostFrequent.Add(dict.Keys.ElementAt(maxIndex));
            int less = dict.Keys.ElementAt(maxIndex);
            foreach(int k in mostFrequent)
            {
                if(k < less)
                    less = k;
            }
            return less;
        }
        return dict.Keys.ElementAt(maxIndex);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
