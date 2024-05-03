namespace Ravenhill.Data.Bib;

/// <summary>
///     Represents a bibliographic resource detailing an academic or scientific paper,
///     providing metadata such as title, authors, publication details, and the digital object identifier.
/// </summary>
/// <param name="Title">The title of the paper.</param>
/// <param name="Authors">A list of authors of the paper.</param>
/// <param name="Url">The URL where more information about the paper can be found or where the paper can be accessed.</param>
/// <param name="Place">The place of publication.</param>
/// <param name="Publisher">The publisher of the paper.</param>
/// <param name="Year">The year the paper was published.</param>
/// <param name="Doi">
///     The digital object identifier (DOI) of the paper, providing a permanent identifier in the digital
///     environment.
/// </param>
/// <param name="Journal">The name of the journal in which the paper was published.</param>
public record PaperResource(
    string Title,
    List<string> Authors,
    string Url,
    string Place,
    string Publisher,
    int Year,
    string Doi,
    string Journal
) : IBibliographyResource;