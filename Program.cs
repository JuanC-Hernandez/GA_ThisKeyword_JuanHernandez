namespace GA_ThisKeyword_JuanHernandez
{
    internal class Program
    {

        // Juan Hernandez
        // Guided Assignment: This Keyword
        // 01/22/2024
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Person person1 = new Person("Alice", 25);
            person1.Display(); // Outputs: Name: Alice, Age: 25

            Person person2 = new Person("Bob");
            person2.Display(); // Outputs: Name: Bob, Age: 0
            person2.SetAge(30);
            person2.Display(); // Outputs: Name: Bob, Age: 30

        }// Main
    }// Program
}// Done