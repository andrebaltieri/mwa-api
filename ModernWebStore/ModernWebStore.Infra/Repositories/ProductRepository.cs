using ModernWebStore.Domain.Entities;
using ModernWebStore.Domain.Repositories;
using ModernWebStore.Domain.Specs;
using ModernWebStore.Infra.Persistence.DataContexts;
using System.Collections.Generic;
using System.Linq;

namespace ModernWebStore.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private StoreDataContext _context;

        public ProductRepository(StoreDataContext context)
        {
            this._context = context;
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }

        public List<Product> Get()
        {
            return _context.Products.ToList();
        }

        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> Get(int skip, int take)
        {
            return _context.Products.OrderBy(x => x.Title).Skip(skip).Take(take).ToList();
        }

        public List<Product> GetProductsInStock()
        {
            return _context.Products.Where(ProductSpecs.GetProductsInStock()).ToList();
        }

        public List<Product> GetProductsOutOfStock()
        {
            return _context.Products.Where(ProductSpecs.GetProductsOutOfStock()).ToList();
        }

        public void Update(Product product)
        {
            _context.Entry<Product>(product).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
