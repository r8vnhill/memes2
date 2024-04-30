namespace Ravenhill.Data.Bib;

/// <summary>
///     Represents a bibliographic resource detailing a book, providing metadata such as title, URL, authors, and
///     publication details.
/// </summary>
/// <param name="Title">The title of the book.</param>
/// <param name="Url">The URL where more information about the book can be found.</param>
/// <param name="Authors">A list of authors of the book.</param>
/// <param name="Edition">The edition of the book if applicable.</param>
/// <param name="Place">The place of publication.</param>
/// <param name="Publisher">The publisher of the book.</param>
/// <param name="Year">The year the book was published.</param>
/// <param name="Isbn">The International Standard Book Number (ISBN) of the book.</param>
public record BookResource(
    string Title,
    string Url,
    List<string> Authors,
    string Edition,
    string Place,
    string Publisher,
    int Year,
    string Isbn
) : IBibliographyResource;