using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Contexts.Repositories
{
    public class ShowCharacterRepository : RepositoryBase<ShowCharacter>, IShowCharacterRepository
    {
        public ShowCharacterRepository(SequelContext sequelContext) : base(sequelContext)
        {
        }
    }
}