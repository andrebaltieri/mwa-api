using ModernWebStore.Domain.Entities;
using ModernWebStore.SharedKernel.Validation;

namespace ModernWebStore.Domain.Scopes
{
    public static class ProductScopes
    {
        public static bool RegisterProductScopeIsValid(this Product product)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(product.Title, "O título do produto é obrigatório"),
                AssertionConcern.AssertNotNull(product.Description, "A descrição do produto é obrigatória"),
                AssertionConcern.AssertIsGreaterThan(product.CategoryId, 0, "A categoria do produto é obrigatória"),
                AssertionConcern.AssertIsGreaterThan(product.Price, 0, "O preço do produto não pode ser zero"),
                AssertionConcern.AssertIsGreaterThan(product.QuantityOnHand, 0, "A quantidade do produto não pode ser zero")
            );
        }

        public static bool UpdateQuantityOnHandScopeIsValid(this Product product, int amount)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterOrEqualThan(amount, 0, "A quantidade deve ser maior que zero")
            );
        }

        public static bool UpdatePriceScopeIsValid(this Product product, decimal price)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(price, 0, "O preço deve ser maior que zero")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Product product, string title, string description, int category)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(title, "O título do produto é obrigatório"),
                AssertionConcern.AssertNotNull(description, "A descrição do produto é obrigatória"),
                AssertionConcern.AssertIsGreaterThan(category, 0, "A categoria do produto é obrigatória")
            );
        }
    }
}
