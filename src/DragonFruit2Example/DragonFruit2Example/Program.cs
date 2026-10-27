using DragonFruit2;
using DragonFruit2Example;

Console.WriteLine();

if (Cli.TryParseArgs<Person>(out var result))
{
    var person = result.Command!;
    Console.WriteLine($"Hello {person.FirstName}, You are {person.Age} years old and your favorite color is {person.FavoriteColor}");
}
else
{
    result.ReportErrorsToConsole();
}
