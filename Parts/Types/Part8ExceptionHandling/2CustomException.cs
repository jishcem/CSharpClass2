namespace CSharpClass2.Part8ExceptionHandling;

class CustomException : Exception
{
    public CustomException(string message)
    {
    }
}


public class ShowCustomException
{
    private static void TestThrow()
    {
        throw new CustomException("Custom exception in TestThrow()");
    }

    public static void ShowException()
    {
        try
        {
            TestThrow();
        }
        catch (CustomException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }

    public static void AnotherExample()
    {
        try
        {
            using (var sw = new StreamWriter("./test.txt"))
            {
                sw.WriteLine("Hello");
            }
        }
        // Put the more specific exceptions first.
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex);
        }
        // Put the least specific exception last.
        catch (IOException ex)
        {
            Console.WriteLine(ex);
        }
        Console.WriteLine("Done");
    }

    public static void TestFinally()
    {
        FileStream? file = null;
        //Change the path to something that works on your machine.
        FileInfo fileInfo = new System.IO.FileInfo("./file.txt");

        try
        {
            file = fileInfo.OpenWrite();
            file.WriteByte(0xF);
        }
        finally
        {
            // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
            file?.Close();
        }

        try
        {
            file = fileInfo.OpenWrite();
            Console.WriteLine("OpenWrite() succeeded");
        }
        catch (IOException)
        {
            Console.WriteLine("OpenWrite() failed");
        }
    }

    public int GetInt(int[] array, int index)
    {
        try
        {
            return array[index];
        }
        catch (IndexOutOfRangeException e) when (index < 0)
        {
            throw new ArgumentOutOfRangeException(
                "Parameter index cannot be negative.", e);
        }
        catch (IndexOutOfRangeException e)
        {
            throw new ArgumentOutOfRangeException(
                "Parameter index cannot be greater than the array size.", e);
        }
    }
}