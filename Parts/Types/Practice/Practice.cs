namespace CSharpClass2.Practice
{
    public class Sample
    {
        public static void Practice()
        {
            Console.WriteLine("Hi there, we are going to write  a program here.");
            string val;
            Console.Write("Enter Integer: ");
            val = Console.ReadLine();
            int a = Convert.ToInt32(val);
            Console.WriteLine("Your input: {0}", a);
            var A=0;
            var B=1;
            int C;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("hello"); 
                C=(A+B);
                Console.WriteLine(C); 
                A=B;
                B=C; 
            }
        } 
    }
}