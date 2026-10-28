using System.CommandLine;
using SystemCommandLineExampleLib;

namespace SystemCommandLineExample;

internal class Cli
{
    private readonly RootCommand rootCommand;

    public Person? Person { get; private set; }
    public string? Greeting { get; private set; }

    public Cli()
    {
        Option<string> nameOption = GetNameOption();
        Option<int> ageOption = GetAgeOption();
        Option<string> greetingOption = GetGreetingOption();

        rootCommand = new RootCommand("System.CommandLine example");
        rootCommand.Add(nameOption);
        rootCommand.Add(ageOption);
        rootCommand.Add(greetingOption);

        rootCommand.SetAction(parseResult =>
        {
            var name = parseResult.GetValue(nameOption);
            var age = parseResult.GetValue(ageOption);
            var greeting = parseResult.GetValue(greetingOption);

            Person = new Person
            {
                Name = name,
                Age = age,

            };
            Greeting = greeting;
        });
    }

    private static Option<string> GetNameOption()
    {
        return new Option<string>("--name")
        {
            Description = "Your name",
            Required = true
        };
    }    

    private static Option<int> GetAgeOption()
    {
        return new Option<int>("--age")
        {
            Description = "Your age"
        };
    }

    private static Option<string> GetGreetingOption()
    {
        return new Option<string>("--greeting")
        {
            Description = "Greeting message",
            DefaultValueFactory = _ => "Hello"
        };
    }

    public int Run(string[] args)
    {
        return rootCommand.Parse(args).Invoke();
    }
}
