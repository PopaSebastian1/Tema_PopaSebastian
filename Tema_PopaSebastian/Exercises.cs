using System.Runtime.InteropServices;
using System.Xml.Linq;
using static LINQ.Exercises;

namespace LINQ;

public class Exercises
{
    #region Fields
    public Exercises() { }
    private List<Person> people = new()
    {
        new() { Name = "John Doe", Age = 25, City = "New York", Occupation = "Engineer", Salary = 75000 },
        new() { Name = "Jane Smith", Age = 32, City = "Los Angeles", Occupation = "Teacher", Salary = 60000 },
        new() { Name = "Bob Johnson", Age = 48, City = "Chicago", Occupation = "Sales Manager", Salary = 100000 },
        new() { Name = "Fernando Miguel Cortez", Age = 48, City = "Chicago", Occupation = "Engineer", Salary = 100000 },
        new()
        {
            Name = "Sarah Lee", Age = 29, City = "San Francisco", Occupation = "Software Developer", Salary = 90000
        },
        new() { Name = "Mike Brown", Age = 37, City = "Houston", Occupation = "Business Analyst", Salary = 80000 },
        new() { Name = "Lisa Kim", Age = 26, City = "Miami", Occupation = "Graphic Designer", Salary = 55000 },
        new() { Name = "David Lee", Age = 41, City = "Seattle", Occupation = "Product Manager", Salary = 120000 },
        new() { Name = "Karen Chen", Age = 34, City = "Boston", Occupation = "Financial Analyst", Salary = 95000 },
        new()
        {
            Name = "Steve Johnson", Age = 28, City = "Washington DC", Occupation = "Marketing Manager", Salary = 70000
        },
        new() { Name = "Emily Wong", Age = 31, City = "San Diego", Occupation = "UX Designer", Salary = 85000 },
        new() { Name = "Tom Williams", Age = 39, City = "Denver", Occupation = "Project Manager", Salary = 110000 },
        new() { Name = "Amy Davis", Age = 27, City = "Dallas", Occupation = "Copywriter", Salary = 60000 },
        new() { Name = "Brian Chang", Age = 43, City = "Atlanta", Occupation = "Operations Manager", Salary = 105000 },
        new() { Name = "Cathy Nguyen", Age = 36, City = "Portland", Occupation = "Data Scientist", Salary = 95000 },
        new()
        {
            Name = "Mark Rodriguez", Age = 33, City = "Phoenix", Occupation = "Sales Representative", Salary = 70000
        },
        new() { Name = "Rachel Garcia", Age = 30, City = "Austin", Occupation = "Web Developer", Salary = 80000 },
        new() { Name = "James Lee", Age = 44, City = "Las Vegas", Occupation = "Real Estate Agent", Salary = 120000 },
        new()
        {
            Name = "Megan Martin", Age = 29, City = "Philadelphia", Occupation = "Social Media Manager", Salary = 65000
        },
        new() { Name = "Kevin Kim", Age = 35, City = "San Antonio", Occupation = "IT Manager", Salary = 90000 },
        new() { Name = "Jenny Chen", Age = 26, City = "Minneapolis", Occupation = "Video Producer", Salary = 55000 },
        new()
        {
            Name = "Patrick Davis", Age = 40, City = "New Orleans", Occupation = "Restaurant Manager", Salary = 85000
        },
        new() { Name = "Julia Kim", Age = 32, City = "Salt Lake City", Occupation = "HR Manager", Salary = 95000 },
        new() { Name = "Sam Lee", Age = 27, City = "Raleigh", Occupation = "Account Executive", Salary = 70000 },
        new() { Name = "Lauren Johnson", Age = 31, City = "Nashville", Occupation = "Event Planner", Salary = 65000 },
        new()
        {
            Name = "Michael Nguyen", Age = 38, City = "Kansas City", Occupation = "Business Development Manager",
            Salary = 100000
        },
        new()
        {
            Name = "Stephanie Chen", Age = 29, City = "Orlando", Occupation = "Public Relations Specialist",
            Salary = 75000
        },
        new()
        {
            Name = "Scott Wilson", Age = 42, City = "St. Louis", Occupation = "Operations Analyst", Salary = 95000
        },
        new() { Name = "Melissa Kim", Age = 28, City = "Charlotte", Occupation = "Interior Designer", Salary = 60000 },
        new() { Name = "Evan Lee", Age = 36, City = "Tucson", Occupation = "Software Engineer", Salary = 90000 },
        new()
        {
            Name = "Christine Davis", Age = 33, City = "Oklahoma City", Occupation = "Marketing Coordinator",
            Salary = 65000
        },
        new()
        {
            Name = "Adam Brown", Age = 45, City = "Albuquerque", Occupation = "Financial Advisor", Salary = 110000
        },
        new() { Name = "Samantha Kim", Age = 30, City = "Honolulu", Occupation = "Art Director", Salary = 80000 },
        new() { Name = "George Johnson", Age = 37, City = "Louisville", Occupation = "Engineer", Salary = 85000 },
        new() { Name = "Linda Chen", Age = 25, City = "Boise", Occupation = "Journalist", Salary = 55000 },
        new()
        {
            Name = "Matthew Davis", Age = 41, City = "Madison", Occupation = "Operations Coordinator", Salary = 90000
        },
        new()
        {
            Name = "Emily Kim", Age = 34, City = "Richmond", Occupation = "Digital Marketing Specialist", Salary = 75000
        },
        new() { Name = "Jason Lee", Age = 39, City = "Columbus", Occupation = "Sales Director", Salary = 105000 },
        new() { Name = "Amanda Brown", Age = 26, City = "Anchorage", Occupation = "UX Researcher", Salary = 60000 },
        new() { Name = "Erica Johnson", Age = 43, City = "Charleston", Occupation = "HR Specialist", Salary = 100000 },
        new() { Name = "Daniel Kim", Age = 31, City = "Des Moines", Occupation = "Data Analyst", Salary = 75000 },
        new() { Name = "Jessica Lee", Age = 28, City = "Asheville", Occupation = "Content Strategist", Salary = 65000 },
        new() { Name = "Sean Davis", Age = 37, City = "Indianapolis", Occupation = "Logistics Manager", Salary = 90000 }
    };
    #endregion

    #region Public members
    public void Exercise1()
    {
        // Find all people who live in a city that starts with the letter "S", and sort them by their age in descending order.
        var query = people.Where(p => p.City.StartsWith("S"))
            .OrderByDescending(p => p.Age);
        //show the result

        Console.WriteLine("Find all people who live in a city that starts with the letter \"S\", and sort them by their age in descending order.");
        foreach (var person in query)
        {
            Console.WriteLine($" Name: {person.Name} - Age : {person.Age} - City: {person.City}");
        }
        Console.WriteLine();

    }

    public void Exercise2()
    {
        // Write a LINQ query that finds the person who has the longest name and is also an engineer.
        var query = people.Where(p => p.Occupation == "Engineer")
            .OrderByDescending(p => p.Name.Length)
            .First();
        Console.WriteLine("Write a LINQ query that finds the person who has the longest name and is also an engineer.");
        Console.WriteLine($" Name: {query.Name} - Age : {query.Age} - City: {query.City}");
    }
    public void Exercise3()
    {
        // Find all people whose age is between 30 and 40, and sort them by name in alphabetical order.
        var query = people.Where(p => p.Age >= 30 && p.Age <= 40).OrderBy(p => p.Name.First());
        Console.WriteLine("Find all people whose age is between 30 and 40, and sort them by name in alphabetical order.");
        foreach (var person in query)
        {
            Console.WriteLine($" Name: {person.Name} - Age : {person.Age} - City: {person.City}");
        }
        Console.WriteLine();
    }

    public void Exercise4()
    {
        // Find the top 5 highest paid people who live in a city that starts with the letter "C".
        var query = people.Where(p => p.City.StartsWith("C")).OrderByDescending(p => p.Salary).Take(5).ToList();


        Console.WriteLine("Find the top 5 highest paid people who live in a city that starts with the letter \"C\".");

        foreach (var person in query)
        {
            Console.WriteLine($" Name: {person.Name} - Age : {person.Age} - City: {person.City} - Salary: {person.Salary}");
        }
        Console.WriteLine();
    }

    public void Exercise5()
    {
        // Find the top 3 cities by the total salary earned by people who live in those cities.
        var topCities = people
                .GroupBy(p => p.City)
                .Select(g => new { City = g.Key, TotalSalary = g.Sum(p => p.Salary) })
                .OrderByDescending(g => g.TotalSalary)
                .Take(3)
                .ToList();

        Console.WriteLine("Find the top 3 cities by the total salary earned by people who live in those cities.");
        //show the topCities

        foreach (var city in topCities)
        {
            Console.WriteLine(city.City);
        }
        Console.WriteLine();

    }

    public void Exercise6()
    {
        // Find all people whose name contains the letter "a", group them by the first letter of their occupation,
        // and sort the groups in descending order by the number of people in each group.

        var result = people
                  .Where(p => p.Name.Contains("a"))
                  .GroupBy(p => p.Occupation[0])
                  .OrderByDescending(g => g.Count());
        Console.WriteLine("Find all people whose name contains the letter \"a\", group them by the first letter of their occupation, and sort the groups in descending order by the number of people in each group.");
        foreach (var group in result)
        {
            Console.WriteLine("Group {0}: {1} people", group.Key, group.Count());
            foreach (var person in group)
            {
                Console.WriteLine("- {0} , Ocupation    {1}", person.Name, person.Occupation);
            }
        }

    }
    #endregion

    #region Nested Types
    public class Person
    {
        #region Properties and Indexers
        public int Age { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public double Salary { get; set; }
        #endregion
    }
    #endregion
}
