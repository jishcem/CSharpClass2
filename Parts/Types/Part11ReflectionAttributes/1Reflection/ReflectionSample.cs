using System.Reflection;

namespace CSharpClass2.Part11.Part1;

public class ReflectionSample
{
    public static void Sample1()
    {
        // Using GetType to obtain type information:
        int i = 42;
        Type type = i.GetType();
        Console.WriteLine(type);

        // Using Reflection to get information of an Assembly:
        Assembly info = typeof(int).Assembly;
        Console.WriteLine(info);
    }
}