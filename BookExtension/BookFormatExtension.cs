using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace BookExtension
{
    public class BookFormatExtension: Book
    {
        public BookFormatExtension(string title, string author, int year, string publishingHous, 
            int edition, int pages, double price):base(title,author,year,publishingHous,edition,pages,price)
        {  
        }

        public string ToString(string format)
        {
            try
            {
                string result = base.ToString(format);
                return result;
            }
            catch (ArgumentException ex)
            {
                switch (format)
                {
                    case "AuthorTitlePagesPrice":
                        {
                            return BookAuthorTitlePagesPrice();
                        }
                    default:
                        {
                            throw new ArgumentException("No such formate");
                        }
                }
            }
        }

        public string BookAuthorTitlePagesPrice()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book record: ");
            sb.Append($"{Author}, ");
            sb.Append($"{Title}, ");
            sb.Append($"{Pages.ToString()}, ");
            sb.Append($"{Price.ToString()}$");
            return sb.ToString();
        }
    }
}
