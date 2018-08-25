using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        int[] roundedGrades = new int[grades.Length];
        for (int gradeIndex = 0; gradeIndex < grades.Length; gradeIndex++) {
            int grade = grades[gradeIndex];
            int minForRounding = 38;
            
            if (grade >= minForRounding && grade % 5 > 2) {
                roundedGrades[gradeIndex] = grade + (5 - grade % 5);
            }
            else {
                roundedGrades[gradeIndex] = grade;
            }
        }
        return roundedGrades;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}