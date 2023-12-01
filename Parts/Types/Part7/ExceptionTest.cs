namespace CSharpClass2.Part7
{
    public class ExceptionTest
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        public static void Main()
        {
            
        }        
    }
}