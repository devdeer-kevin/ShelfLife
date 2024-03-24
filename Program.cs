using System;


using ShelfLife;
using ShelfLife.BaseTypes;

var bookShelf = new BookShelf();

while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add a book");
    Console.WriteLine("2. Remove a book");
    Console.WriteLine("3. Calculate total cost");
    Console.WriteLine("4. Exit\n");
    var option = Console.ReadLine(); 
    Console.WriteLine();
    
    switch (option)
    {
        case "1": 
            Console.WriteLine("Enter the title of the book:\n");
            var title = Console.ReadLine();
            Console.WriteLine("Enter the price of the book:\n");
            var priceInput = Console.ReadLine();
            if (!decimal.TryParse(priceInput, out var price))
            {
                Console.WriteLine("Invalid price. Please enter a valid decimal number.\n");
                break; 
            }
            Console.WriteLine("Enter the ISBN of the book:\n");
            var isbn = Console.ReadLine();
            bookShelf.AddBook(new Book(title, price, isbn));
            break;
        case "2":
            Console.WriteLine("Enter the ISBN of the book to remove:\n");
            var isbnToRemove = Console.ReadLine();
            if (bookShelf.RemoveBook(isbnToRemove))
            {
                Console.WriteLine("Book removed successfully.\n");
            }
            else
            {
                Console.WriteLine("Book not found.\n");
            }
            break;
        case "3":
            Console.WriteLine($"Total cost of books: \n{bookShelf.TotalCost()}\n");
            break;
        case "4":
            return; 
        default:
            Console.WriteLine("Invalid option. Please try again.\n");
            break;
    }
}