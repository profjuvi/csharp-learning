
namespace homework1
{
    public class Calculator
    {
        public double fvalue;
        public double svalue;

        // constructors
        public Calculator(double fvalue, double svalue)
        {
            this.fvalue = fvalue;
            this.svalue = svalue;
        }
        public Calculator(double fvalue)
        {
            this.fvalue = fvalue;
            svalue = 3.1415;
        }
        public Calculator()
        {
            fvalue = 16.2462;
            svalue = 56.5126;
        }

        // methods

        /* Описано 5 методів, що включають в себе 5 математичних операцій: +, -, *, /, 
        і піднесення до степеня. Кожен метод повертає десяткове значення типу double, і 
        виводить результат в термінал. Дія додавання описана одним і тим самим методом двічі,
        один із яких проводить операцію над проініціалізованими параметрами обʼєкта, а інший
        бере значення з уведених параметрів у самому методі. Цей метод написаний для прикладу 
        у користанні методами */

        public double Addition(double A, double B) 
        {
            double C = Math.Round(A + B, 2);
            Console.WriteLine($"Your result: {C}");
            return C;
        }
        public double Addition()
        {
            double A = Math.Round(fvalue + svalue, 2);
            Console.WriteLine($"Your result: {A}");
            return A;
        }
        public double Substraction()
        {
            double A = Math.Round(fvalue - svalue, 2);
            Console.WriteLine($"Your result: {A}");
            return A;
        }
        public double Multiplication()
        {
            double A = Math.Round(fvalue * svalue, 2);
            Console.WriteLine($"Your result: {A}");
            return A;
        }
        public double Division()
        {
            double A = Math.Round(fvalue / svalue, 2);
            Console.WriteLine($"Your result: {A}");
            return A;
        }
        public double RaiseToAPower()
        {
            double A = Math.Round(Math.Pow(fvalue, svalue), 2);
            Console.WriteLine($"Your result: {A}");
            return A;
        }
    }
}