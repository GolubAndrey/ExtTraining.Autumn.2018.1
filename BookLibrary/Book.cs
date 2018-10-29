using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        private string title;
        private string author;
        private int year;
        private string publishingHous;
        private int edition;
        private int pages;
        private double price;

        public Book()
        {

        }
        public Book(string title,string author,int year,string publishingHous,int edition,int pages,double price)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.PublishingHous = publishingHous;
            this.Edition = edition;
            this.Pages = pages;
            this.Price = price;
        }

        public string ToString(string format)
        {
            switch (format)
            {
                case "AuthorTitleYearPublishingHous":
                    {
                        return BookAuthorTitleYearPublishingHous();
                    }
                case "AuthorTitleYear":
                    {
                        return BookAuthorTitleYear();
                    }
                case "AuthorTitle":
                    {
                        return BookAuthorTitle();
                    }
                case "TitleYearPublishingHous":
                    {
                        return BookTitleYearPublishingHous();
                    }
                case "Title":
                    {
                        return BookTitle();
                    }
                case null:
                    {
                        return null;
                    }
                default:
                    {
                        throw new ArgumentException("No such format");
                    }
            }
        }

        public string BookAuthorTitleYearPublishingHous()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book record: ");
            sb.Append($"{Author}, ");
            sb.Append($"{Title}, ");
            sb.Append($"{Year.ToString()}, ");
            sb.Append(PublishingHous);
            return sb.ToString();
        }

        public string BookAuthorTitleYear()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book record: ");
            sb.Append($"{Author}, ");
            sb.Append($"{Title}, ");
            sb.Append(Year.ToString());
            return sb.ToString();
        }

        public string BookAuthorTitle()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book record: ");
            sb.Append($"{Author}, ");
            sb.Append(Title);
            return sb.ToString();
        }

        public string BookTitleYearPublishingHous()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book record: ");
            sb.Append($"{Title}, ");
            sb.Append($"{Year.ToString()}, ");
            sb.Append(PublishingHous);
            return sb.ToString();
        }

        public string BookTitle()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book record: ");
            sb.Append(Title);
            return sb.ToString();
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Year shold be more than 0");
                }
                year = value;
            }
        }

        public string PublishingHous
        {
            get { return publishingHous; }
            set { publishingHous = value; }
        }

        public int Edition
        {
            get { return edition; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Edition shold be more than 0");
                }
                edition = value;
            }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Pages shold be more than 0");
                }
                pages = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price shold be more than 0");
                }
                price = value;
            }
        }




    }
}
