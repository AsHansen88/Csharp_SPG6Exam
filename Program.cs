public class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of FunctionalDemo
        Part6Exam demo = new Part6Exam();

        // Using the lambda function
        Console.WriteLine($"Sum: {demo.Add(5, 3)}");  // Output: Sum: 8

        // Using the tuple
        var person = demo.GetPerson();
        Console.WriteLine($"Person: {person.Item1}, Age: {person.Item2}");  // Output: Person: Alice, Age: 25

        // Creating a record instance
        Part6Exam.Person alice = new Part6Exam.Person("Alice", 25);
        Console.WriteLine(alice);  // Output: Person { Name = Alice, Age = 25 }

        // Using pattern matching
        Console.WriteLine($"Description: {demo.GetDescription(-5)}");  // Output: Description: Negative integer
    }
}