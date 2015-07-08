using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;
using System.Collections.Generic;
using ModernWebStore.Domain.Specs;

namespace ModernWebStore.Tests.Domain.Specs
{
    [TestClass]
    public class ProductSpecTests
    {
        private List<Product> _products;

        public ProductSpecTests()
        {
            this._products = new List<Product>();
            _products.Add(new Product("Produto 1", "Descricao", 29, 0, 1));
            _products.Add(new Product("Produto 2", "Descricao", 129, 1, 1));
            _products.Add(new Product("Produto 3", "Descricao", 229, 2, 1));
            _products.Add(new Product("Produto 4", "Descricao", 329, 0, 1));
            _products.Add(new Product("Produto 5", "Descricao", 429, 3, 1));
        }

        [TestMethod]
        [TestCategory("Product Specs - GetProductsInStock")]
        public void ShouldReturnThreeWhenGetProductsInStock()
        {
            var exp = ProductSpecs.GetProductsInStock();
            var user = _products.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, user);
        }

        [TestMethod]
        [TestCategory("Product Specs - GetProductsOutOfStock")]
        public void ShouldReturnTwoWhenGetProductsOutOfStock()
        {
            var exp = ProductSpecs.GetProductsOutOfStock();
            var user = _products.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, user);
        }
    }
}
