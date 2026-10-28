namespace SystemCommandLineExampleLib;

public class Person
{
    /// <summary>
    /// "Your name"
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// "Your age"
    /// </summary>
    public int Age { get; set; } = 0;

    public string PreferredMessage(string greeting)
        => $"{greeting} {this.Name}, you are {this.Age} years old. ";
}
