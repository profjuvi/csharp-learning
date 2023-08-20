
namespace h05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // task 1
            var HarryPotter = new Play("Harry Potter and the Philosopher's Stone", "J. K. Rowling", "fantasy", 2001);
            try
            {
                HarryPotter.ShowInfo();
            }
            finally
            {
                HarryPotter.Dispose();
            }
            using(var HarryPotter1 = new Play("Harry Potter and the Philosopher's Stone", "J. K. Rowling", "fantasy", 2001)) // second example
            {
                HarryPotter1.ShowInfo();
            }
            using var HarryPotter3 = new Play("Harry Potter and the Philosopher's Stone", "J. K. Rowling", "fantasy", 2001); // third exapmle

            // task 2
            var LPS1 = new Shop("LPS", "Bohdana Khmelnitskeho 7", "Accessories");
            try
            {
                LPS1.ShowInfo();
            }
            finally
            {
                LPS1.Dispose();
            }
            using(var LPS2 = new Shop("LPS", "Bohdana Khmelnitskeho 12", "Accessories")) // second example
            {
                LPS2.ShowInfo();
            }
            using var LPS3 = new Shop("LPS", "Bohdana Khmelnitskeho 14", "Accessories"); // third exapmle
        }
    }
}