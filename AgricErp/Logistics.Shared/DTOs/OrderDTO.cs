using Orders.Shared.Enums;

namespace Logistics.Shared.DTOs;

public class OrderDTO
{
    public int Id { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public string Remarks { get; set; } = string.Empty;
}