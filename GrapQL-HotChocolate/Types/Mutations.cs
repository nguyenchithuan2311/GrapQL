using GrapQL_HotChocolate.Entity;

namespace GrapQL_HotChocolate.Types
{
    public class Mutations(Playlist playlist)
    {
        private readonly Playlist _playlist = playlist;
        public bool AddPlaylist(string name)
        {
            _playlist.playlistDatas.Add(new PlaylistData(_playlist.playlistDatas.Count.ToString(), name));
            return true;
        }
    }
}
