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
            book.ShowStatistics();
        }
    }
}
