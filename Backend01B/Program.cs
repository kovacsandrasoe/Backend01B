namespace Backend01B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a person list with 10 elements
            List<Person> persons = new List<Person>
            {
                new Person("John", 25, "Developer", "Black", 1.75),
                new Person("Jane", 30, "Manager", "Blonde", 1.65),
                new Person("Jack", 35, "CEO", "Brown", 1.85),
                new Person("Jill", 40, "CTO", "Red", 1.70),
                new Person("James", 45, "CFO", "Black", 1.80),
                new Person("Jenny", 50, "COO", "Blonde", 1.60),
                new Person("Joe", 55, "CIO", "Brown", 1.90),
                new Person("Jade", 60, "CISO", "Red", 1.55),
                new Person("Josh", 65, "CPO", "Black", 1.95),
                new Person("Jasmine", 70, "CLO", "Blonde", 1.50)
            };
        }
    }
}
