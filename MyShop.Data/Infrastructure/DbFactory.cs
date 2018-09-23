namespace MyShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TMyShopDBContext dbContext;

        public TMyShopDBContext Init()
        {
            return dbContext ?? (dbContext = new TMyShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}