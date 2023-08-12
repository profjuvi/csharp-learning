
namespace h04
{
    public class Employee
    {
        public int Salary { get; set; }
        // + || -
        public static Employee operator +(Employee employee, int salary_increase)
        {
            return new Employee { Salary = employee.Salary + salary_increase};
        }
        public static Employee operator -(Employee employee, int salary_decrease)
        {
            return new Employee { Salary = employee.Salary - salary_decrease };
        }
        // == || !=
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if ( ReferenceEquals(employee1, employee2) ) return true;
            if ( ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null) ) return false;
            return employee1.Salary == employee2.Salary;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !( employee1.Salary == employee2.Salary );
        }
        // > || <
        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        // Equals
        public override bool Equals(object? obj)
        {
            if ( obj is Employee employee ) return this == employee;
            return false;
        }
        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
    }
}