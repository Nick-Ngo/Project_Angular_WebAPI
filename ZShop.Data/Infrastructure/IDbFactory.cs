using System;
namespace ZShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        //phương thưc giao tiếp khởi tạo đối tượng
        ZShopDbContext Init();
    }
}