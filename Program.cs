using System;


using ShelfLife;
using ShelfLife.BaseTypes;

var bookShelf = new BookShelf();

while (true)
{
    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1. Add a book");
    Console.WriteLine("2. Remove a book");
    Console.WriteLine("3. Calculate total cost");
    Console.WriteLine("4. Exit\n");
    var option = Console.ReadLine(); 
    Console.WriteLine();
    
    switch (option)
    {
        case "1": 
            Console.WriteLine("Enter the title of the book:");
            var title = Console.ReadLine();
            Console.WriteLine("\nEnter the price of the book:");
            var priceInput = Console.ReadLine();
            if (!decimal.TryParse(priceInput, out var price))
            {
                Console.WriteLine("\nInvalid price. Please enter a valid decimal number.");
                break; 
            }
            Console.WriteLine("\nEnter the ISBN of the book:");
            var isbn = Console.ReadLine();
            if (title != null)
            {
                if (isbn != null)
                {
                    bookShelf.AddBook(new Book(title, price, isbn));
                }
            }
            break;
        case "2":
            Console.WriteLine("\nEnter the ISBN of the book to remove:");
            var isbnToRemove = Console.ReadLine();
            if (isbnToRemove != null && bookShelf.RemoveBook(isbnToRemove))
            {
                Console.WriteLine("\nBook removed successfully.");
            }
            else
            {
                Console.WriteLine("\nBook not found.");
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