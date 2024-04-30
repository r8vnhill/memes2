namespace Ravenhill.Data;

/// <summary>
///     Represents a single educational lesson, containing details about the lesson's name,
///     description, and a link to more information or the lesson's content.
/// </summary>
/// <param name="Name">The name of the lesson.</param>
/// <param name="Description">A short description of the lesson's content and objectives.</param>
/// <param name="Link">A URL link to the lesson's materials or additional information.</param>
public record Lesson(string Name, string Description, string Link);