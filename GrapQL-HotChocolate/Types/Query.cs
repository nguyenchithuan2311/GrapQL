using GrapQL_HotChocolate.Entity;
using GrapQL_HotChocolate.Type;

namespace GrapQL_HotChocolate.Type
{
    public class Query(Playlist playlist)
    {
        private readonly Playlist _playlist = playlist;

        public string Hello()
        {
            return "Hello world";
        }

        public List<PlaylistData> GetPlayList()
        {
            return _playlist.playlistDatas;
        }
    }
}

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor.Field(t => t.Hello()).Type<StringType>();
    }
}
