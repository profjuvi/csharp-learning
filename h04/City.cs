
namespace h04
{
    public class City
    {
        string? name;
        int population;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value < 0 ? 0 : value; } 
        }
        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }
        // + || -
        public static City operator +(City city, int increase)
        {
            city.Population += increase;
            return city;
        }
        public static City operator -(City city, int decrease)
        {
            city.Population -= decrease;
            return city;
        }
        //  == || != 
        public static bool operator ==(City city1, City city2)
        {
            if ( ReferenceEquals(city1, city2) ) return true;
            if ( ReferenceEquals(city1, null) || ReferenceEquals(city2, null) )return false;
            return city1.Population == city2.Population;
        }
        public static bool operator !=(City city1, City city2)
        {
            return !( city1 == city2 );
        }
        // > || <
        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }
        // Equals
        public override bool Equals(object? obj)
        {
            if ( !(obj is City) ) return false;
            return this == (City)obj;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Name?.GetHashCode() ?? 0;
                hash = hash * 23 + Population.GetHashCode();
                return hash;
            }
        }
    }
}
