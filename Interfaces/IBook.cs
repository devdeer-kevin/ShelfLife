namespace ShelfLife.Interfaces
{
    public interface IBook
    {
        string Title { get; set; }
        int Price { get; set; }
        string ISBN { get; set; }
    }
}