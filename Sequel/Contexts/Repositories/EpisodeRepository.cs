using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Contexts.Repositories
{
    public class EpisodeRepository : RepositoryBase<Episode>, IEpisodeRepository
    {
        public EpisodeRepository(SequelContext sequelContext) : base(sequelContext)
        {
        }
    }
}