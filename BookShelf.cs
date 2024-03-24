namespace ShelfLife
{
    using BaseTypes; 
    using System.Collections.Generic;
    using System.Linq;
    
    public class BookShelf
    {
        private List<Book> books = new List<Book>();
        
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(string isbn)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
            {
                return true;
            }
            return false;
        }

        public decimal TotalCost()
        {
            return books.Sum(b => b.Price);
        }
    }
}