using System;

namespace bookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore bookOne = new(1, "The Child", "Fiona Barton", 15.99);
            Console.WriteLine(bookOne);
            Bookstore bookTwo = new(2, "Lord of the Rings", "J.R.R. Tolkien", 25.99);
            Console.WriteLine(bookTwo);
            Bookstore bookThree = new(3, "Mocking Jay", "Suzanne Collins", 11.99);
            Console.WriteLine(bookThree);
        }
    }
}