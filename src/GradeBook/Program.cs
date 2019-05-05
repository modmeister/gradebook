using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Khoa's Grade Book");
            book.AddGrade(5.0);
            book.AddGrade(7.0);
            book.AddGrade(9.0);
            var statistics = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {statistics.Low:N1}");
            Console.WriteLine($"The highest grade is {statistics.High:N1}");
            Console.WriteLine($"The average grade is {statistics.Average:N1}");
        }
    }
}
