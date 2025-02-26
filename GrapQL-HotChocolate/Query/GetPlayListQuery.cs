using GrapQL_HotChocolate.Entity;
using GrapQL_HotChocolate.Interface;

namespace GrapQL_HotChocolate.Query
{
    public class GetPlayListQuery : IQuery<List<PlaylistData>>
    {
    }

    public class GetPlayListQueryHandler (Playlist playlist) : IQueryHandler<GetPlayListQuery, List<PlaylistData>>
    {

        private readonly Playlist _playlist= playlist;
        public async Task<List<PlaylistData>> Handle(GetPlayListQuery request, CancellationToken cancellationToken)
        {
            return _playlist.playlistDatas;
        }
    }
}
