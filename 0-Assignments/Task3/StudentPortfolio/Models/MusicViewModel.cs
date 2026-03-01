namespace StudentPortfolio.Models;

public class MusicViewModel
{
    public List<string> Genres { get; set; } = new();
    public List<ArtistItem> Artists { get; set; } = new();
    public List<SongItem> Songs { get; set; } = new();
    public List<AlbumItem> Albums { get; set; } = new();
}

public class ArtistItem
{
    public string Name { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
}

public class SongItem
{
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
}

public class AlbumItem
{
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
}
