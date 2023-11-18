namespace CSharpClass2.Part4
{
    public class DelegateTypes
    {
        public delegate void Callback(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Callback callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
        public static void ShowDelegates()
        {
            // Instantiate the delegate.
            Callback handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            // Call method with delegate callback
            MethodWithCallback(1, 2, handler);
        }
    }
}