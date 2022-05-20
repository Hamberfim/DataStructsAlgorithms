namespace _01_chapt
{
    internal class Program
    {
        public class Person 
        {
            private string _location = string.Empty;
            public string Name { get; set; }
            public int Age { get; set; }

            public Person() => Name = "---";

            public Person(string name, int age) 
            {
                Name = name;
                Age = age;
            }

            public void Relocation(string location) 
            { 
                if(!string.IsNullOrEmpty(location))
                {
                    _location = location;
                }
            
            }

            public string GetDistance(string location) 
            {
                return "from " + _location + " to " + location;
            }

        }


        static void Main(string[] args)
        {
            Person person = new Person("Bill", 56);
            person.Relocation("Iowa");
            string distance = person.GetDistance("London");

            Console.WriteLine($"{person.Name} is {person.Age} years old. He is moving {distance}");


            Console.WriteLine();  // space in output
        }
    }
}