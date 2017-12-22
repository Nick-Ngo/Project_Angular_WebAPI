using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ZShopDbContext dbContext;

        public ZShopDbContext Init()
        {
            //Phương thức init sẽ khởi tạo 1 đối tượng cho dbcontext
            return dbContext ?? (dbContext = new ZShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
