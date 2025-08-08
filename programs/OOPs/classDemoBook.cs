using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.OOPs
{
    class Book
    {
        int bookID, bookPrice;
        string bookTitle, bookAuthor;

        public Book()
        {
            Console.WriteLine("Enter BookID");
            bookID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Title");
            bookTitle = Console.ReadLine();

            Console.WriteLine("Enter Book Author");
            bookAuthor = Console.ReadLine();

            Console.WriteLine("Enter Book Price");
            bookPrice = (Convert.ToInt32(Console.ReadLine()));
        }

        public void showData()
        {
            Console.WriteLine("Book ID : " + bookID);
            Console.WriteLine("Book Title : " + bookTitle);
            Console.WriteLine("Book Author : " + bookAuthor);
            Console.WriteLine("Book Price : " +  bookPrice);

        }
    }
    internal class classDemoBook
    {
        public static void Main()
        {
            Book[] book = new Book[5];

            for (int i = 0; i < book.Length; i++)
            {
                book[i] = new Book();
            }

            for (int i = 0; i < book.Length; i++)
            {
                book[i].showData(); 
            }

        }     
             

    }
}
