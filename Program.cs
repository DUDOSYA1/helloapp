Console.WriteLine("Hello everyone");
White.GreetWhite();
Black.GreetBlack();
Console.ReadLine();

public static class White
{
    public static void GreetWhite()
    {
        Console.WriteLine("Hello white");
    }
}

public static class Black
{
    public static void GreetBlack()
    {
        Console.WriteLine("Hello black");
    }
}