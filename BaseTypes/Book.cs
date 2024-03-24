namespace ShelfLife.BaseTypes
{

    public class Book
    {
        //summary
        // The title of the book.
        //summary
        public string Title { get; set; }

        //summary
        // The price of the book.
        //summary
        public decimal Price { get; set; }

        //summary
        // The ISBN of the book.
        //summary
        public string? ISBN { get; set; }


        public Book(string title, decimal price, string isbn)
        {
            Title = title;
            Price = price;
            ISBN = isbn;
        }
    };
}
