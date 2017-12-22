using ZShop.Data.Infrastructure;
using ZShop.Model.Model;

namespace ZShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}