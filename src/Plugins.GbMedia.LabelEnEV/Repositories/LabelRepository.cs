using Compori.Shopware.Plugins.GbMedia.LabelEnEV.Entities;
using Compori.Shopware.Repositories;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV.Repositories
{
    public class LabelRepository<TEntity> : EntityRepository<TEntity> where TEntity : Label
    {
        public LabelRepository(Client client) : base(client)
        {
        }
    }

    public class LabelRepository : LabelRepository<Label>
    {
        public LabelRepository(Client client) : base(client)
        {
        }
    }
}
