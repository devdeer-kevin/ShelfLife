namespace ShelfLife
{
    using BaseTypes; 
    using System.Collections.Generic;
    using System.Linq;
    
    public class BookShelf
    {
        //summary
        // The list of books on the shelf.
        //summary
        private List<Book> books = new List<Book>();
        
        //summary
        // Adds a book to the shelf.
        //param name="book"
        // The book to add.
        //summary
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        //summary
        // Removes a book from the shelf.
        //param name="isbn"
        // The ISBN of the book to remove.
        //returns
        // True if the book was removed; otherwise, false.
        //returns
        // summary
        public bool RemoveBook(string isbn)
        {
            var book = books.FirstOrDefault(b => b.Isbn == isbn);
            return book == null;
        }

        //summary
        // Calculates the total cost of all books on the shelf.
        //returns
        // The total cost of all books on the shelf.
        //returns
        //summary
        public decimal TotalCost()
        {
            return books.Sum(b => b.Price);
        }
    }
}