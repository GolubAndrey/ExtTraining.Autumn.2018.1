using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BookExtension;

namespace BookExtension.Tests
{
    [TestFixture]
    public class BookFormatExtensionTests
    {
        [Test]
        public void BookFormatExtensionTest_BookAuthorTitlePagesPrice()
        {
            BookFormatExtension book = new BookFormatExtension("C# in Depth", "Jon Skeet", 2019, "Manning", 4, 900, 40);

            string str = book.ToString("AuthorTitlePagesPrice");
            Assert.AreEqual("Book record: Jon Skeet, C# in Depth, 900, 40$", book.ToString("AuthorTitlePagesPrice"));
        }
    }
}
