using Management.BLL.Contracts.Persistence;
using Management.Domain;
using Management.Products.EF;

namespace Management.Products.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DatabaseContext _databaseContext;
        public ProductRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
           this._databaseContext = databaseContext;

        }

    }
}
