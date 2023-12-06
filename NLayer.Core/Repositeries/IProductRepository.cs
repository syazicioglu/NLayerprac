using NLayer.Core.Models;

namespace NLayer.Core.Repositeries
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategory();
    }
}
