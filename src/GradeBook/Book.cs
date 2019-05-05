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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0.0;
            statistics.High = double.MinValue;
            statistics.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Low = Math.Min(grade, statistics.Low);
                statistics.High = Math.Max(grade, statistics.High);
                statistics.Average += grade;
            }

            if (grades.Count == 0)
            {
                statistics.Low = 0.0;
                statistics.High = 0.0;
                statistics.Average = 0.0;
            }
            else
            {
                statistics.Average /= grades.Count;
            }
            
            return statistics;
        }
    }
}