using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Contexts.Repositories
{
    public class ShowGenreRepository : RepositoryBase<ShowGenre>, IShowGenreRepository
    {
        public ShowGenreRepository(SequelContext sequelContext) : base(sequelContext)
        {
        }
    }
}