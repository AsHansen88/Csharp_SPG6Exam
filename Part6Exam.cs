using System;

// Defining the first class with various functional constructs
public class Part6Exam
{
    // Lambda function
    public Func<int, int, int> Add = (x, y) => x + y;

    // Tuple
    public (string, int) GetPerson() => ("Alice", 25);

    // Record
    public record Person(string Name, int Age);

    // Pattern Matching function
    public string GetDescription(object obj)
    {
        return obj switch
        {
            int i when i >= 0 => "Positive integer",
            int i => "Negative integer",
            string s => "It's a string",
            _ => "Unknown type"
        };
    }
}