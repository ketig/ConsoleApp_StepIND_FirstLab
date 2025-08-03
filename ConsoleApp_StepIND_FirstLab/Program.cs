try
{
    int[] Masivi = { 1, 2, 3, 4, 5 };
    GetElement(Masivi, 5);
}
catch (Exception e)
{
    Console.WriteLine($"Invalid data: {e.Message}");
}

static int GetElement(int[] array, int index)
{
    //try
    //{
    //    return array[index];
    //}
    //catch (IndexOutOfRangeException e)
    //{
    //    Console.WriteLine($"Index out of range: {e.Message}");
    //    throw; // rethrow the exception to be handled by the caller
    //}
    //catch (Exception e)
    //{
    //    Console.WriteLine($"An error occurred: {e.Message}");
    //    throw; // rethrow the exception to be handled by the caller
    //}


    if (index > 0 && index < array.Length)
    {
        return index;
    }
    else
    {
        throw new ArgumentOutOfRangeException();
    }
}

//try
//{
//    Student student = new Student(1, "John", DateTime.Now, "user@gmail.com", 100, "smth");

//    student.Grade = 110;
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine($"Argument out of range: {e.ParamName}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("Finally block executed.");
//}

//try
//{
//    int x = 4;
//    int y = 1;

//    Console.WriteLine(x / y);
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("Finally block executed after division.");
//}




//using (MyDisposableClass disposable = new MyDisposableClass())
//{
//    Console.WriteLine("using block");



//}

//// IDisposable interface
//class MyDisposableClass : IDisposable
//{
//    public void Dispose()
//    {
//        Console.WriteLine("dispose method");
//    }
//}