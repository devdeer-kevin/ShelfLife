namespace ShelfLife.BaseTypes
{

    public class Book(string title, decimal price, string isbn)
    {
        //summary
        // The title of the book.
        //summary
        public string Title { get; set; } = title;

        //summary
        // The price of the book.
        //summary
        public decimal Price { get; set; } = price;

        //summary
        // The ISBN of the book.
        //summary
        public string Isbn { get; set; } = isbn;
    };
}
