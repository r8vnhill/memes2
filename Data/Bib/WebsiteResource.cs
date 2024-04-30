namespace Ravenhill.Data.Bib;

public record WebsiteResource(
    string Title,
    string Url
) : IBibliographyResource;