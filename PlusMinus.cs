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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {

        int[] fractions = new int[3]{0, 0, 0};
        foreach(int i in arr){
            if(i > 0){
                fractions[0]++;
            }
            else if(i < 0){
                fractions[1]++;
            }
            else{
                fractions[2]++;
            }
        }
        foreach(int f in fractions){
            Console.WriteLine((float)f / arr.Count());
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
