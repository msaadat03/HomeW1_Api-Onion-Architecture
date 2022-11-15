using Domain.Entities;
using Repository.Data;

namespace Repository.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }
    }
}
