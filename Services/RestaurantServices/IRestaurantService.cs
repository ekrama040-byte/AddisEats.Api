using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Services.RestaurantServices;
public interface IRestaurantService
{

    List<MenuItem>? GetByIdMenu(int id);
    Restaurant? GetById(int id);
    PaginatedResultDTO<RestaurantDTO> GetAll(RestaurantQuery? query); 
    List<Restaurant> GetAllActive(); 
}