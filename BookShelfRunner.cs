namespace ShelfLife
{
    using System;

    using BaseTypes;

    public static class BookShelfRunner
    {
        public static void RunBookShelf()
        {
            var theProcess = new Book();
            theProcess.Title = "The Process";
            theProcess.Price = 9.99;
            theProcess.ISBN = "978-1-250-30663-1";
            Console.WriteLine(theProcess.Title + " costs " + theProcess.Price + " and has an ISBN of " + theProcess.ISBN);
        }
    }
}