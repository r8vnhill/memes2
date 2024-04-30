namespace Ravenhill.Data;

/// <summary>
///     Represents a section of a course syllabus, containing the title of the section,
///     a list of contents, and a visibility state.
/// </summary>
/// <param name="Title">The title of the course section.</param>
/// <param name="Contents">A list of content items (e.g., topics, subtopics) that are covered in this section.</param>
public record CourseSection(string Title, List<string> Contents) {
    /// <summary>
    ///     Gets or sets a value indicating whether the course section is visible in the UI.
    ///     Initially set to false, indicating that the section is not visible by default.
    /// </summary>
    public bool IsVisible { get; set; } = false;
}