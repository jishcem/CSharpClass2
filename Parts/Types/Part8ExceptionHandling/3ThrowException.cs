namespace CSharpClass2;

public class ThrowingExceptions
{
    static void CopyObject(object original)
    {
        _ = original ?? throw new ArgumentException("Parameter cannot be null", nameof(original));
    }
}

public class ProgramLog
{
    FileStream logFile = null!;
    public void OpenLog(FileInfo fileName, FileMode mode) { }

    public void WriteLog()
    {
        if (!logFile.CanWrite)
        {
            throw new InvalidOperationException("Logfile cannot be read-only");
        }
        // Else write data to the log and return.
    }
}

// Compiler generated Exceptions. 
// ArithemeticException, ArrayTypeMismatchException, DivideByZeroException, IndexOutOfRangeException, NullReferenceException, OutOfMemoryException, StackOverflowException