using AddisEats.Api.Models;
namespace AddisEats.Api.DTOs;

public record CreateOrderDTO
(
    int RestaurantId,
    int MenuItemId,
    string CustomerName,
    string DeliveryName,
    string CustomerPhone,
    decimal TotalAmount,
    int Quantity
);