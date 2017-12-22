using System.Data.Entity;
using ZShop.Model.Model;

namespace ZShop.Data
{
    //Class chinh
    public class ZShopDbContext : DbContext
    {
        //lay connectionstring cau hinh trong data
        public ZShopDbContext() : base("ZShopConnection")//de connection vao de nhan
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        //Khai báo tất cả các table trong cấu hình confic
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }


        //chạy khi khởi tạo entities
        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}