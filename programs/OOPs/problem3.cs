using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT.OOPs
{
    public class Book
    {
        private int BookID, no_of_pages;
        private string title, author;
        private double original_price, discountedprice;

        public Book(int BookID, string title, string author, int no_of_pages, double original_price)
        {
            this.BookID = BookID;
            this.title = title;
            this.author = author;
            this.no_of_pages = no_of_pages;
            this.original_price = original_price;
        }

        public void calculate_discount()
        {

            if(no_of_pages > 500)
            {
                discountedprice = original_price - (original_price * 0.3);
            }
            else if(no_of_pages > 300)
            {
                discountedprice = original_price - (original_price * 0.2);
            }
            else
            {
                discountedprice = original_price - (original_price * 0.1);
            }
        } 

        public double DiscountedPrice
        {
            get { return discountedprice; }
        }

        public void showDetails()
        {
            Console.WriteLine("Book ID : " + BookID);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Auther : " + author);
            Console.WriteLine("Book Page : " + no_of_pages);
            Console.WriteLine("Book Price : " + original_price);
            Console.WriteLine("Discounted Price : " + discountedprice);
        }

    }
    internal class problem3
    {
        public static void Main()
        {
            Book b1 = new Book(1, "XYZ", "ABC", 650, 500);
            Book b2 = new Book(2, "AMX", "AZC", 60, 500);

            b1.calculate_discount();
            b2.calculate_discount();

            if (b1.DiscountedPrice < b2.DiscountedPrice)
            {
                b1.showDetails();
            }
            else
            {
                b2.showDetails();
            }

        }
    }
}
