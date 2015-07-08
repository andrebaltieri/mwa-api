using ModernWebStore.Domain.Entities;
using ModernWebStore.SharedKernel.Validation;

namespace ModernWebStore.Domain.Scopes
{
    public static class OrderItemScopes
    {
        public static bool RegisterOrderItemScopeIsValid(this OrderItem orderItem)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(orderItem.Price, 0, "Preço inválido"),
                AssertionConcern.AssertIsGreaterThan(orderItem.ProductId, 0, "Produto inválido"),
                AssertionConcern.AssertIsGreaterThan(orderItem.Quantity, 0, "Quantidade inválida")
            );
        }

        public static bool AddProductScopeIsValid(this OrderItem orderItem, Product product, decimal price, int quantity)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterOrEqualThan((product.QuantityOnHand - quantity), 0, "Produto fora de estoque: " + product.Title),
                AssertionConcern.AssertIsGreaterThan(price, 0, "Preço deve ser maior que zero"),
                AssertionConcern.AssertIsGreaterThan(quantity, 0, "Quantidade deve ser maior que zero")
            );
        }
    }
}
