using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    
    static int getTotalX(int[] arr1, int[] arr2) {
        int betweenSets = 0;
        for (int i = arr1.Max(); i <= arr2.Min(); i++)
        {
            bool isValid = true;
            foreach (int num in arr1)
            {
                if (i % num != 0)
                    isValid = false;
            }
            foreach (int num in arr2) 
            {
                if (num % i != 0)
                    isValid = false;
            }
            if (isValid)
                betweenSets++;
        }
        
        return betweenSets;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
