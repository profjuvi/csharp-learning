
namespace h05
{
    public class Play : IDisposable
    {
        string Title { get; set; }
        string Author { get; set; }
        string Genre { get; set; }
        int Year { get; set; }
        // Constructor 
        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }
        // Methods
        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }
        public void Dispose()
        {
            Console.WriteLine($"{Title}, {Author}, {Genre}, {Year} was disposed!");
        }
        ~Play()
        {
            Console.WriteLine($"{Title}, {Author}, {Genre}, {Year} was deleted"); 
        }
    }
}