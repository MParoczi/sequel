using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Contexts.Repositories
{
    public class ShowRepository : RepositoryBase<Show>, IShowRepository
    {
        public ShowRepository(SequelContext sequelContext) : base(sequelContext)
        {
        }
    }
}