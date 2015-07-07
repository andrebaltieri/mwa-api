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
    }
}
