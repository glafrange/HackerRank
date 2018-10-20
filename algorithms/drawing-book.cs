using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        int pageStart = 0;
        int pageEnd = n%2 == 0 ? n+1 : n;
        int turnsStart = 0;
        int turnsEnd = 0;
        
        while (true)
        {
            pageStart += 2;
            if (pageStart > p)
                break;
            turnsStart++;
        }
        
        while (true)
        {
            pageEnd -= 2;
            if (pageEnd < p)
                break;
            turnsEnd++;
        }
        return turnsStart < turnsEnd ? turnsStart : turnsEnd;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
