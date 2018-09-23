using MyShop.Model.Models;
using System.Data.Entity;

namespace MyShop.Data
{
    public class TMyShopDBContext : DbContext
    {
        public TMyShopDBContext() : base("TMyShopConnection")
        {
            // Lien quan den load bang
            this.Configuration.LazyLoadingEnabled = false;
        }

        // Them cac bang trong model vao , voi 1 bang la  dong
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
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatic> VisitorStatics { get; set; }
        // Tao phuong thuc ghi de khi ta khoi tao
        protected override void OnModelCreating(DbModelBuilder buider)
        {

        }
    }
}