
using System;
using System.Linq;

namespace h03
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public interface IMath
    {
        int Max();
        int Min();
        double Avg();
        bool Search(int valueToSearch);
    }

    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class Array : IOutput, IMath
    {
        private int[] numbers;
        public Array()
        {
            numbers = new int[] {1, 42, 7, -6, 13, 64, -6};
        } 
        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }
        // show array elements
        public void Show()
        {
            Console.Write("Array elements: ");
            foreach ( int i in numbers )
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        // show array elements and info
        public void Show(string info)
        {
            Show();
            Console.WriteLine($"Info: {info}.");
        }
        // Max
        public int Max()
        {
            return numbers.Max();
        }
        // Min
        public int Min()
        {
            return numbers.Min();
        }
        // Average
        public double Avg()
        {
            // double AverageValueArray = 0;
            // foreach ( int i in numbers )
            // {
            //     AverageValueArray += i;
            // }
            // return AverageValueArray / numbers.Length;
            return Math.Round(numbers.Average(), 4);
        }
        // Search
        public bool Search(int valueToSearch)
        {
            foreach ( int i in numbers )
            {
                if ( i == valueToSearch )
                {
                    return true;
                }
            }
            return false;
        }
        // Sort by growth
        public void SortAsc()
        {   
            /* Цей метод найкраще підходить для вирішення даного завдання та помилка 
            полягає в тому, що клас Array співпадає з нашим класом Array */

            // Array.Sort(numbers);
            
            int value = 0;
            for ( int i = 0; i < numbers.Length; ++i )
            {
                for ( int j = i; j < numbers.Length; ++j )
                {
                    if ( numbers[i] > numbers[j] )
                    {
                        value = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = value;
                    } 
                }
            }
            foreach ( int i in numbers )
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        // Sort in descending order
        public void SortDesc()
        {
            /* Цей метод найкраще підходить для вирішення даного завдання та помилка 
            полягає в тому, що клас Array співпадає з нашим класом Array */

            // Method #1 - Reverse
            // Array.Sort(numbers);
            // Array.Reverse(numbers);

            // Method #2 - Reverse
            // SortAsc();
            // int value = 0;
            // int repeat = (int)Math.Floor((double)numbers.Length / 2);
            // for ( int i = 0; i < repeat; ++i )
            // {
            //     value = numbers[i];
            //     numbers[i] = numbers[numbers.Length - (i + 1)];
            //     numbers[numbers.Length - (i + 1)] = value;
            // }

            // Method #3 
            int value = 0;
            for ( int i = 0; i < numbers.Length; ++i )
            {
                for ( int j = i; j < numbers.Length; ++j )
                {
                    if ( numbers[i] < numbers[j] )
                    {
                        value = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = value;
                    } 
                }
            }
            foreach ( int i in numbers )
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        // Sorting depending on the passed parameter
        public void SortByParam(bool isAsc)
        {
            if ( isAsc == true )
            {
                SortAsc();
            } 
            else 
            {
                SortDesc();
            }
        }
    }
}
