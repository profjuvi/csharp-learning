
namespace h05
{
    public class Shop : IDisposable
    {
        string Title { get; set; }
        string Adress { get; set; }
        string TypeStore { get; set; }
        // Constructor
        public Shop(string title, string adress, string typestore)
        {
            Title = title;
            Adress = adress;
            TypeStore = typestore;
        }
        // Methods
        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Adress: {Adress}");
            Console.WriteLine($"Type store: {TypeStore}");
        }
        public void Dispose()
        {
            Console.WriteLine($"{Title}, {Adress}, {TypeStore} was disposed!");
        }
        ~Shop()
        {
            Console.WriteLine($"{Title}, {Adress}, {TypeStore} was deleted"); 
        }
    }
}