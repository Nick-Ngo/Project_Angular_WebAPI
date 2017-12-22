using ZShop.Data.Infrastructure;
using ZShop.Model.Model;

namespace ZShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    { }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}