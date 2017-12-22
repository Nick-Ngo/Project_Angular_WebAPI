﻿using ZShop.Data.Infrastructure;
using ZShop.Model.Model;

namespace ZShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    { }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}