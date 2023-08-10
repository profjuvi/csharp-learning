
using System;
using System.Linq;

namespace h03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] {23, 0, 40, -19, 101, 45, 81, -33, 67, 0, -19};
            var test = new Array(A);
            // test.Show();
            test.Show("143");
            Console.WriteLine(test.Max());
            Console.WriteLine(test.Min());
            Console.WriteLine(test.Avg());
            Console.WriteLine(test.Search(0));
            test.SortAsc();
            test.SortDesc();
            test.SortByParam(true);
        }
    }
}