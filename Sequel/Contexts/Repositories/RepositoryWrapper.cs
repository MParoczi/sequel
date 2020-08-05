using System.Threading.Tasks;
using Sequel.Contexts.Contracts;

namespace Sequel.Contexts.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public RepositoryWrapper(SequelContext context, IGenreRepository genre, IShowRepository show,
            IShowGenreRepository showGenre, ISeasonRepository season, IEpisodeRepository episode,
            IActorRepository actor, IShowCharacterRepository showCharacter)
        {
            Context = context;
            Genre = genre;
            Show = show;
            ShowGenre = showGenre;
            Season = season;
            Episode = episode;
            Actor = actor;
            ShowCharacter = showCharacter;
        }

        private SequelContext Context { get; }

        public IGenreRepository Genre { get; set; }

        public IShowRepository Show { get; set; }

        public IShowGenreRepository ShowGenre { get; set; }

        public ISeasonRepository Season { get; set; }

        public IEpisodeRepository Episode { get; set; }

        public IActorRepository Actor { get; set; }

        public IShowCharacterRepository ShowCharacter { get; set; }

        public Task Save()
        {
            return Context.SaveChangesAsync();
        }
    }
}