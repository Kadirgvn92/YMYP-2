namespace ChatUIConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, I am Cat UI.");
        Console.WriteLine("I want to know you better");
        Console.WriteLine("Please tell me your name ");
        string name = Console.ReadLine();
        Console.WriteLine("Nice to meet you " + name);
        Console.WriteLine("Where are you from");
        string from = Console.ReadLine();
        Console.WriteLine("Oww thats great!I am from ABD");
        Console.WriteLine("How old are you");
        string age = Console.ReadLine();
        Console.WriteLine($"Great ok, your name {name} you write{from} and you are {age} years old");
        Console.WriteLine("Am I correct");
        string result = Console.ReadLine();
        Console.WriteLine("Your answer is " +  result);

        if(result == "Yes")
        {
            Console.WriteLine("You are right");
        }
        Console.WriteLine("thats great");
    }
}
