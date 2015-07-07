using ModernWebStore.Domain.Entities;
using ModernWebStore.SharedKernel.Validation;
using System.Linq;

namespace ModernWebStore.Domain.Scopes
{
    public static class OrderScopes
    {
        public static bool PlaceOrderScopeIsValid(this Order order)
        {
            foreach (var item in order.OrderItems)
                AssertionConcern.AssertIsGreaterThan(item.Product.QuantityOnHand, 0, "Produto fora de estoque: " + item.Product.Title);

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(order.OrderItems.Count(), 0, "Nenhum produto foi adicionado ao pedido")
            );
        }
    }
}
