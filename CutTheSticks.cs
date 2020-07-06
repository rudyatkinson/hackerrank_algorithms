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

    static int findShortestStick(int[] arr)
    {
        int shortest = -1;
        foreach(int i in arr)
        {
            shortest = shortest == -1 || i < shortest ? i : shortest;
        }
        return shortest;
    }

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr) {
        int timesCut;
        List<int> count = new List<int>();
        int[] finalArr = arr;
        while(finalArr.Count() > 0)
        {
            timesCut = 0;
            int tempArrSize = 0;
            int shortest = findShortestStick(finalArr);
            for(int i = 0; i < finalArr.Count(); i++)
            {
                if(finalArr[i] != 0)
                {
                    finalArr[i] = finalArr[i] - shortest;
                    timesCut++;
                    if(finalArr[i] != 0)
                        tempArrSize++;
                }
            }
            int[] tempArr = new int[tempArrSize];
            int queue = 0;
            foreach(int k in finalArr)
            {
                if(k != 0)
                    tempArr[queue++] = k;  
            }
            count.Add(timesCut);
            finalArr = tempArr;
        }
        return count.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
