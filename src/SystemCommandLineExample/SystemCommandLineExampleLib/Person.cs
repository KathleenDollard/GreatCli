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
    public int Age { get; set; }

    public string PreferredMessage(string greeting)
        => $"{greeting} {Name}, you are {Age} years old. ";
}
