using System.Threading.Tasks;

namespace Sequel.Contexts.Contracts
{
    public interface IRepositoryWrapper
    {
        public IGenreRepository Genre { get; set; }

        public IShowRepository Show { get; set; }

        public IShowGenreRepository ShowGenre { get; set; }

        public ISeasonRepository Season { get; set; }

        public IEpisodeRepository Episode { get; set; }

        public IActorRepository Actor { get; set; }

        public IShowCharacterRepository ShowCharacter { get; set; }

        Task Save();
    }
}