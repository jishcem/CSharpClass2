using System.Xml.Linq;

namespace CSharpClass2.Part9Linq;

public class Linq1
{
    public static void Exercise1()
    {
        List<int> scores = new List<int> { 97, 92, 81, 60 };
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        foreach (var i in scoreQuery)
        {
            Console.WriteLine(i + " ");
        }
    }

    public static void Exercise2()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        List<int> numbers = new() { 0, 1, 2, 3, 4, 5, 6 };

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
    }

    public static void Exercise3()
    {
        // Example Data source. 
        // Create a data source from an XML document.
        // using System.Xml.Linq;
        XElement contacts = XElement.Load(@"c:\myContactList.xml");

        /*
        Northwnd db = new Northwnd(@"c:\northwnd.mdf");

        // Query for customers in London.
        IQueryable<Customer> custQuery =
            from cust in db.Customers
            where cust.City == "London"
            select cust;
        */
    }

    public static void QueryExpressionBasics()
    {
        List<int> scores = new List<int> { 97, 92, 81, 60 };
        IEnumerable<int> highScoresQuery =
            from score in scores
            where score > 80
            orderby score descending
            select score;

        IEnumerable<string> highScoresQuery2 =
            from score in scores
            where score > 80
            orderby score descending
            select $"The score is {score}";

        var highScoreCount = (
            from score in scores
            where score > 80
            select score
        ).Count();

        IEnumerable<int> highScoresQuery3 =
            from score in scores
            where score > 80
            select score;

        var scoreCount = highScoresQuery3.Count();



        List<City> cities = new List<City> { new() { Name = "City1", Population = 1000 }, new() { Name = "City2", Population = 100001 } };
        //Query syntax
        IEnumerable<City> queryMajorCities =
            from city in cities
            where city.Population > 100000
            select city;

        // Method-based syntax
        IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 100000);






        var highestScore = (
            from score in scores
            select score
        ).Max();

        // or split the expression
        IEnumerable<int> scoreQuery =
            from score in scores
            select score;

        var highScore = scoreQuery.Max();
        // the following returns the same result
        highScore = scores.Max();
    }

    public static void ShowFilterJoinOrderLet()
    {
        List<City> cities = new List<City> { new() { Name = "City1", Population = 1000 }, new() { Name = "City2", Population = 100001 } };
        // Where Clause
        IEnumerable<City> queryCityPop =
            from city in cities
            where city.Population is < 200000 and > 100000
            select city;

        List<Country> countries = new List<Country> { new Country() { Name = "City1", Population = 1000 }, new Country() { Name = "City2", Population = 100001 } };
        // order by
        IEnumerable<Country> querySortedCountries =
            from country in countries
            orderby country.Area, country.Population descending
            select country;

        var category1 = new Category() { Id = 1, Name = "Category 1" };
        var category2 = new Category() { Id = 2, Name = "Category 2" };
        var product1 = new Product() { Id = 1, Category = category1 };
        var product2 = new Product() { Id = 2, Category = category2 };
        List<Category> categories = new List<Category>() { category1, category2 };
        List<Product> products = new List<Product>() { product1, product2 };
        // Joining
        var categoryQuery =
            from cat in categories
            join prod in products on cat equals prod.Category
            select new
            {
                Category = cat,
                Name = prod.Name
            };

        // Let clause
        List<string> names = new List<string>() { "Svetlana Omelchenko", "Claire O'Donnell", "Sven Mortensen", "Cesar Garcia" };
        IEnumerable<string> queryFirstNames =
            from name in names
            let firstName = name.Split(' ')[0]
            select firstName;

        foreach (var s in queryFirstNames)
        {
            Console.Write(s + " ");
        }

        //Output: Svetlana Claire Sven Cesar
    }
}

public class City
{
    public string Name { get; set; }
    public int Population { get; set; }
}

public class Country
{
    public string Name { get; set; }
    public int Area { get; set; }
    public int Population { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
}
