using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BookLibrary;

namespace BookLibrary.Tests
{
    
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void BookToString_AuthorTitleYearPublishingHous()
        {
            Book book = new Book("C# in Depth", "Jon Skeet", 2019, "Manning", 4, 900, 40);
            Assert.AreEqual("Book record: Jon Skeet, C# in Depth, 2019, Manning", book.ToString("AuthorTitleYearPublishingHous"));
        }

        [Test]
        public void BookToString_AuthorTitleYear()
        {
            Book book = new Book("C# in Depth", "Jon Skeet", 2019, "Manning", 4, 900, 40);

            Assert.AreEqual("Book record: Jon Skeet, C# in Depth, 2019", book.ToString("AuthorTitleYear"));
        }

        [Test]
        public void BookToString_AuthorTitle()
        {
            Book book = new Book("C# in Depth", "Jon Skeet", 2019, "Manning", 4, 900, 40);

            Assert.AreEqual("Book record: Jon Skeet, C# in Depth", book.ToString("AuthorTitle"));
        }

        [Test]
        public void BookToString_TitleYearPublishingHous()
        {
            Book book = new Book("C# in Depth", "Jon Skeet", 2019, "Manning", 4, 900, 40);

            Assert.AreEqual("Book record: C# in Depth, 2019, Manning", book.ToString("TitleYearPublishingHous"));
        }

        [Test]
        public void BookToString_Title()
        {
            Book book = new Book("C# in Depth", "Jon Skeet", 2019, "Manning", 4, 900, 40);

            Assert.AreEqual("Book record: C# in Depth", book.ToString("Title"));
        }
    }
}
