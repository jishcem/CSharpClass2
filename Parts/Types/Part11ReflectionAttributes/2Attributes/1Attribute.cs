using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharpClass2.Part11.Part2;

[Serializable]
public class SampleClass
{
    // Objects of this type can be serialized.


    [System.Runtime.InteropServices.DllImport("user32.dll")]
    extern static void SampleMethod();

    void MethodA([In][Out] ref double x) { }
    void MethodB([Out][In] ref double x) { }
    void MethodC([In, Out] ref double x) { }

    [Conditional("DEBUG"), Conditional("TEST1")]
    void TraceMethod()
    {
        // ...
    }

    // Attribute Params
    /*
    [DllImport("user32.dll")]
    [DllImport("user32.dll", SetLastError=false, ExactSpelling=false)]
    [DllImport("user32.dll", ExactSpelling=false, SetLastError=false)]    
    */

    // Attribute targets 
    // Assembly, module, field, event, method, param, property, return , type
}




// Custom Attribute
[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)
]
public class AuthorAttribute : System.Attribute
{
    private string Name;
    public double Version;

    public AuthorAttribute(string name)
    {
        Name = name;
        Version = 1.0;
    }
}


[Author("P. Ackerman", Version = 1.1)]
class SampleClass2
{
    // P. Ackerman's code goes here...
}


// Multi use attribute

[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)  // Multiuse attribute.
]
public class AuthorMultiAttribute : System.Attribute
{
    string Name;
    public double Version;

    public AuthorMultiAttribute(string name)
    {
        Name = name;

        // Default value.
        Version = 1.0;
    }

    public string GetName() => Name;
}



[AuthorMulti("P. Ackerman"), AuthorMulti("R. Koch", Version = 2.0)]
public class ThirdClass
{
    // ...
}