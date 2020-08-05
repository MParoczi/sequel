using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Contexts.Repositories
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(SequelContext sequelContext) : base(sequelContext)
        {
        }
    }
}