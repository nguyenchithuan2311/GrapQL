namespace GrapQL_HotChocolate.Entity
{
    public class PlaylistData(string id, string name)
    {
        [ID]
        public string Id { get; } = id;
        public string Name { get; set; } = name;
        public string? Description { get; set; }
    }

    public class Playlist
    {
        public List<PlaylistData> playlistDatas { get; set; } = new List<PlaylistData>()
        {
            new PlaylistData("1", "Playlist 1"),
            new PlaylistData("2", "Playlist 2"),
            new PlaylistData("3", "Playlist 3"),
        };
    }
}
