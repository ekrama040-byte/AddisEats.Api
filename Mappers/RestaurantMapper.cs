using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Mappers;

public static class RestaurantMapper
{
    public static RestaurantDTO ToDTO(this Restaurant restaurant)
    {
        return new RestaurantDTO
        (
            restaurant.Id,
             restaurant.Name,
             restaurant.Phone,
             restaurant.Address,
             restaurant.IsActive

         );
    
    }
}
