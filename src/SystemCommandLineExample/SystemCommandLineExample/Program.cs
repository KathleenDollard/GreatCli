using SystemCommandLineExample;

var cli = new Cli();
var returnCode = cli.Run(args);
if (returnCode == 0 && cli.Person is not null)
{
    // Work of the application 
    Console.WriteLine(cli.Person!.PreferredMessage(cli.Greeting!));
}
return returnCode;
