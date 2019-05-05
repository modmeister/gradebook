using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string Name;
        private List<double> grades;

        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            if (grades.Count == 0)
            {
                result.Low = 0.0;
                result.High = 0.0;
                result.Average = 0.0;
            }
            else
            {
                result.Average /= grades.Count;
            }
            
            return result;
        }
    }
}