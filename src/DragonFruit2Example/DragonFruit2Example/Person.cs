using DragonFruit2;
using System.Drawing;

namespace DragonFruit2Example;

/// <summary>
/// The command class for the example CLI.
/// </summary>
[CommandClass]
public partial class Person
{
    /// <summary>
    /// The first name of the person to greet.This is a required option.
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// The last name of the person to greet. It is optional.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// The age of the person to greet.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// The favorite color of the person to greet.
    /// </summary>
    public Color FavoriteColor { get; set; }
}
