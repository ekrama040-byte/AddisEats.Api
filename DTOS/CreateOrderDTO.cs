using System.ComponentModel.DataAnnotations;
using AddisEats.Api.Models;
using AddisEats.Api.Validation;

namespace AddisEats.Api.DTOs;


public record CreateOrderDTO
(
    [Range(1, int.MaxValue, ErrorMessage = "RestaurantId must be greater than 0")]
    int RestaurantId,
    int MenuItemId,
    [Required(ErrorMessage = "CustomerName is required")]
    string CustomerName,
    [StringLength(100,MinimumLength=1 ,ErrorMessage = "DeliveryName is required")]
    string DeliveryName,
    [Required(ErrorMessage = "CustomerPhone is required")]
    [EthiopianMobile]
    string CustomerPhone,
    [Required(ErrorMessage ="Amount is required")]
    [ETBAmount]
    decimal TotalAmount,
    [Range(1,50, ErrorMessage = "Quantity must be between 1 and 50")]
    int Quantity
);