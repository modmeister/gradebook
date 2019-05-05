using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void TestSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            // Assert.Equal("Book 1", book1.Name);
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
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
