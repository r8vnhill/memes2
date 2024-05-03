namespace Ravenhill.Data.Bib;

/// <summary>
///     Provides an interface for defining a bibliography resource.
/// </summary>
public interface IBibliographyResource {
    /// <summary>
    ///     Gets the title of the bibliography resource.
    /// </summary>
    /// <value>The title of the resource.</value>
    string Title { get; }

    /// <summary>
    ///     Gets the URL where the bibliography resource can be accessed.
    /// </summary>
    /// <value>The URL of the resource.</value>
    string Url { get; }
}