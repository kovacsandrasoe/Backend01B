namespace Backend01B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a person list with 10 elements
            List<Person> people = new List<Person>
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

            //szűrés: 50 év felettiek

            var q1 = people.Where(p => p.Age > 50);

            //első elem, utolsó elem
            var q2 = people.First();
            var q3 = people.Last();

            //első T tulajdonságú elem (lineáris keresés)
            //első vörös hajú ember
            var q4 = people.First(p => p.HairColor == "Red");
            var q4b = people.FirstOrDefault(p => p.HairColor == "Reddd");
            
            //rendezés magasságok szerint csökkenőben
            var q5 = people.OrderByDescending(p => p.Height);
            

            //bonyi: 50 év felettiek, magasság szerint csökkenő, első 3
            var q6 = people
                .Where(p => p.Age > 50)
                .OrderByDescending(p => p.Height)
                .Take(3);

            //query syntax - érdekességként - ritkán nézünk ilyet
            var q6s = from p in people
                      where p.Age > 50
                      orderby p.Height descending
                      select p;

            //Select: projekció vagy tulajdonságkiválasztás
            //Person -> valamely tujajdonsága (pl. neve)
            var q7 = people
                .Where(p => p.Age > 50)
                .OrderByDescending(p => p.Height)
                .Take(3) //vedd az első hármat
                .Skip(1) //dobd ki az elsőt
                .Select(p => p.Name);

            //aggregálás (tipikusan 1 atomi eredmény születik)
            //átlagos magasság
            var q8 = people.Average(p => p.Height);

            //maximális életkor
            var q9 = people.Max(p => p.Age);

            //darabszám: hány emberre igaz az állítás
            var q10 = people.Count(t => t.HairColor == "Blonde");

            
            //GROUP BY
            //mindig valamilyen "enum-szerű" változó alapján
            //mindig valailyen aggregátum

            //hajszínenként átlagéletkor
            //groupnál érdemes a query syntax-ot használni, mert átláthatóbb
            var q11 = from p in people
                      group p by p.HairColor into g
                      select new
                      {
                          HairColor = g.Key,
                          AvgAge = g.Average(p => p.Age),
                          AvgHeight = g.Average(p => p.Height),
                          Elements = g //maga a csoport, ez is érdekes lehet
                      };
            
            //JOIN







        }
    }
}
