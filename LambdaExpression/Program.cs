using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the number you want to squire: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Func<int, int> square = number => number * number; //lambda expression
            Console.WriteLine("square: " + square(a));

            Console.WriteLine("input the number you want to root:");
            int b = Convert.ToInt32(Console.ReadLine());

            Func<int, double> root = number => Math.Sqrt(number); //lambda expression
            Console.WriteLine("result: " + root(b));

            Console.WriteLine("input the max price of book: ");
            double maxPrice = Convert.ToDouble(Console.ReadLine());

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < maxPrice); //lambda expression

            foreach (var book in cheapBooks)
            {
                Console.WriteLine("Title: "+ book.Title + "  Price: " + book.Price);
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Solid Mechanics", Price = 4},
                new Book() {Title = "Fluid Mechanics", Price = 8},
                new Book() {Title = "Machine Design", Price = 12},
                new Book() {Title = "Mechanics", Price = 16}
            };
        }
    }
}
