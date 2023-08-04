
namespace h02
{
    public class Instrument
    {
        protected string name;
        protected string desc;
        protected string history;
        public Instrument(string name, string desc, string history)
        {
            this.name = name;
            this.desc = desc;
            this.history = history;
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
        public void Desc()
        {
            Console.WriteLine(desc);
        }
        public void History()
        {
            Console.WriteLine(history);
        }
    }

    public class Violin : Instrument
    {
        public Violin() : base("Violin", "Stringed instrument", "The first work for the violin was created at the end of 1620 by the composer Marini.")
        {
        }
        public void Sound()
        {
            Console.WriteLine("* Violin sound *");
        }
    }

    public class Trombone : Instrument
    {
        public Trombone() : base("Trombone", "Loud instrument", "Trombone was created in the 19th century.")
        {
        }
        public void Sound()
        {
            Console.WriteLine("* Trombone sound *");
        }
    }

    public class Ukulele : Instrument
    {
        public Ukulele() : base("Ukulele", "A ringing instrument", "Developed in the 19th century in Hawaii.")
        {
        }
        public void Sound()
        {
            Console.WriteLine("* Ukulele sound *");
        }
    }

    public class Cello : Instrument
    {
        public Cello() : base("Cello", "Four-stringed musical instrument", "The origins of the cello can be found in the early 16th century.")
        {
        }
        public void Sound()
        {
            Console.WriteLine("* Cello sound *");
        }
    }
}