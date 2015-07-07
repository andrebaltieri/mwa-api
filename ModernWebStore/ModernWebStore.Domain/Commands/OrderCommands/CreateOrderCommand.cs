using ModernWebStore.Domain.Entities;
using System.Collections.Generic;

namespace ModernWebStore.Domain.Commands.OrderCommands
{
    public class CreateOrderCommand
    {
        public CreateOrderCommand(IList<OrderItem> orderItems, int userId)
        {
            this.OrderItems = orderItems;
            this.UserId = userId;
        }

        public IList<OrderItem> OrderItems { get; set; }
        public int UserId { get; set; }
    }
}
