using GrapQL_HotChocolate.Entity;
using GrapQL_HotChocolate.Interface;

namespace GrapQL_HotChocolate.Command
{
    public class CreatePLayListCommand(string name) : ICommand<bool>
    {
        public string Name { get; set; } = name;
    }

    public class CretePlayListCommandHandler(Playlist playlist) : ICommandHandler<CreatePLayListCommand, bool>
    {
        private readonly Playlist _playlist = playlist;
        public async Task<bool> Handle(CreatePLayListCommand request, CancellationToken cancellationToken)
        {
            _playlist.playlistDatas.Add(new PlaylistData(_playlist.playlistDatas.Count.ToString(), request.Name));
            return true;
        }
    }
}
