using MyShop.Data.Infrastructure;
using MyShop.Model.Models;
namespace MyShop.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatic>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}