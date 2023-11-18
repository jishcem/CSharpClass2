namespace CSharpClass2.Part4
{
    public class AnonymousTypes
    {
        public static void Anonymous()
        {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v.Amount + v.Message);


            var product = new Product();
            var bonus = new { note = "You won!" };
            var shipment = new { address = "Nowhere St.", product };
            var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };

            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };


            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);
        }
    }

    public class Product { }
}