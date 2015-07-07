using ModernWebStore.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace ModernWebStore.Domain.Specs
{
    public static class ProductSpecs
    {
        public static Expression<Func<Product, bool>> GetProductsInStock()
        {
            return x => x.QuantityOnHand > 0;
        }

        public static Expression<Func<Product, bool>> GetProductsOutOfStock()
        {
            return x => x.QuantityOnHand == 0;
        }
    }
}
