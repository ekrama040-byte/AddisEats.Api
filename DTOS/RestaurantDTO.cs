using AddisEats.Api.Mappers;
namespace AddisEats.Api.DTOs;
public record RestaurantDTO
(
    int Id,
    string Name,
    string Phone,
    string Address,
    bool IsActive


);