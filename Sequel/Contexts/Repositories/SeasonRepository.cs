using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Contexts.Repositories
{
    public class SeasonRepository : RepositoryBase<Season>, ISeasonRepository
    {
        public SeasonRepository(SequelContext sequelContext) : base(sequelContext)
        {
        }
    }
}