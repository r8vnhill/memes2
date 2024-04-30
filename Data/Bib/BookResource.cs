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
public class BookResource(
    string Title,
    string Url,
    List<string> Authors,
    string Edition,
    string Place,
    string Publisher,
    int Year,
    string Isbn
) : IBibliographyResource {
    /// <summary>A list of authors of the book.</summary>
    public List<string> Authors { get; init; } = Authors;

    /// <summary>The edition of the book if applicable.</summary>
    public string Edition { get; init; } = Edition;

    /// <summary>The place of publication.</summary>
    public string Place { get; init; } = Place;

    /// <summary>The publisher of the book.</summary>
    public string Publisher { get; init; } = Publisher;

    /// <summary>The year the book was published.</summary>
    public int Year { get; init; } = Year;

    /// <summary>The International Standard Book Number (ISBN) of the book.</summary>
    public string Isbn { get; init; } = Isbn;

    /// <summary>The title of the book.</summary>
    public string Title { get; init; } = Title;

    /// <summary>The URL where more information about the book can be found.</summary>
    public string Url { get; init; } = Url;

    public void Deconstruct(out string Title, out string Url, out List<string> Authors, out string Edition,
        out string Place, out string Publisher, out int Year, out string Isbn) {
        Title = this.Title;
        Url = this.Url;
        Authors = this.Authors;
        Edition = this.Edition;
        Place = this.Place;
        Publisher = this.Publisher;
        Year = this.Year;
        Isbn = this.Isbn;
    }
}