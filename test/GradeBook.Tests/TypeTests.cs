using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    
    public class TypeTests
    {
        int count = 0;
        
        [Fact]
        public void WriteLogDelegatecanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            
            var result = log("Hello!");
            Assert.Equal("Hello!", result);
        }
        
        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }
        
        [Fact]
        public void TestSomething()
        {
            var x = GetInt();
            SetInt(ref x);
            
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void TestSetNameFromReference()
        {
            Book book1;
            GetBookSetName(out book1, "New Name");
            // Assert.Equal("Book 1", book1.Name);
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void TestBookType()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }
        
        [Fact]
        public void TestSameReference()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
            var book3 = GetBook("Book 1");
            
            Assert.Same(book1, book2);
            Assert.NotSame(book1, book3);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
