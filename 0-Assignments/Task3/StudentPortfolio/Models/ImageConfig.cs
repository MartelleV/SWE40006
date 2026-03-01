namespace StudentPortfolio.Models;

/// <summary>
/// Centralized image path configuration for music-related images.
/// Image naming convention: all lowercase, spaces replaced with hyphens, and special characters removed.
/// </summary>
public static class ImageConfig
{
    // Base path for all music images
    private const string BasePath = "/images/music";

    // Artist images: wwwroot/images/music/artists/{artist-name}.webp
    public static string GetArtistImage(string artistName)
    {
        var fileName = SanitizeFileName(artistName);
        return $"{BasePath}/artists/{fileName}.webp";
    }

    // Album cover images: wwwroot/images/music/albums/{album-title}.webp
    public static string GetAlbumImage(string albumTitle)
    {
        var fileName = SanitizeFileName(albumTitle);
        return $"{BasePath}/albums/{fileName}.webp";
    }

    // Helper method to sanitize file names
    private static string SanitizeFileName(string name)
    {
        return name.ToLower()
            .Replace(" ", "-")
            .Replace("'", "")
            .Replace("&", "and")
            .Replace(",", "")
            .Replace(".", "");
    }
}
