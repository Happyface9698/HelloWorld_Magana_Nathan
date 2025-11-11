namespace HelloWorld_Magana_Nathan
{
    internal class Program
    {
        static void Main(string[] args)
        { // This line asks what the first name of user is and stores it in a variable
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            // This line asks what the last name of user is and stores it in a variable
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            // This line prints out a greeting to the user using their first and last name
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}
