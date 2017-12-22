namespace ZShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}