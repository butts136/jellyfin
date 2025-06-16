namespace Jellyfin.Database.Implementations.Enums;

/// <summary>
/// An enum representing how library media should be displayed on the home screen.
/// </summary>
public enum LibraryHomeDisplayMode
{
    /// <summary>
    /// Display items ordered by the date they were added.
    /// </summary>
    DateAdded = 0,

    /// <summary>
    /// Display items ordered by their release date.
    /// </summary>
    ReleaseDate = 1,

    /// <summary>
    /// Display two rows, one by date added and one by release date.
    /// </summary>
    Both = 2
}
