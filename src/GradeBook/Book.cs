using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private string name;
        private List<double> grades;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var averageGrade = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                averageGrade += grade;
            }

            if (grades.Count == 0)
            {
                averageGrade = 0.0;
                highGrade = 0.0;
                lowGrade = 0.0;
            }
            else
            {
                averageGrade /= grades.Count;
            }

            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            Console.WriteLine($"The average grade is {averageGrade:N1}");
        }
    }
}