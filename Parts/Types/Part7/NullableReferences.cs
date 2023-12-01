namespace CSharpClass2.Part7
{
    public class NullableReference
    {
        public static void Nullable()
        {
            string message = null;

            // warning: dereference null.
            Console.WriteLine($"The length of the message is {message.Length}");

            var originalMessage = message;
            message = "Hello, World!";

            // No warning. Analysis determined "message" is not null.
            Console.WriteLine($"The length of the message is {message.Length}");

            // warning!
            Console.WriteLine(originalMessage.Length);
        }
    }
}