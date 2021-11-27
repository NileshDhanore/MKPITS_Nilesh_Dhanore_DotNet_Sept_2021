using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV26_Class_Object_Book
{
    class Book
    {
        public int bookid;
        public string book_name, author, subject, publisher;
        public decimal price,pages;

        public Book()
        {
            bookid = 1;
            book_name = "Enter book name";
            author = "Enter Author Name";
            subject = "Enter subject Name";
            price = 100;
            pages = 100;
            publisher = "Enter subject Name";
        }
        public Book(int bookid, string book_name, string author, string subject,  decimal price, decimal pages, string publisher)
        {
            this.bookid = bookid;
            this.book_name = book_name;
            this.author = author;
            this.subject = subject;
            this.price = price;
            this.pages = pages;
            this.publisher = publisher;
        }
        public void show()
        {
            Console.WriteLine("Book id: " + bookid + "\n Name of Book: " + book_name + "\n Name of Author: " + author + "\nName of Subject: " + subject +"\nPrice of Book: "+price+ "\nNo. of pages of book: "+pages+"\nPublisher: "+publisher);
        }
    }
}
