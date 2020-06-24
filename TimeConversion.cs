using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
         char format = s.ElementAt(s.Count() - 2);
         String final = s.Remove(s.Count() - 2);

         int i = Int32.Parse(Char.ToString(final.ElementAt(0)) + Char.ToString(final.ElementAt(1)));

         if(format == 'P'){
            if(i != 12 && format == 'P')
                i += 12;
            final = final.Remove(0, 2);
            final = i.ToString() + final;
         }
         if (i == 12 && format == 'A'){
            final = final.Remove(0, 2);
            final = "00" + final;
         }
         
         return final;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
