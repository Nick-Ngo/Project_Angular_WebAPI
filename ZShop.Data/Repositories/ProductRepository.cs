using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZShop.Data.Infrastructure;
using ZShop.Model.Model;

namespace ZShop.Data.Repositories
{
    public interface IProductRepository
    { }

    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
