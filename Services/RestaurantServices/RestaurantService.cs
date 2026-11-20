using AddisEats.Api.Models;
using AddisEats.Api.Data;
using AddisEats.Api.DTOs;
using AddisEats.Api.Mappers;

namespace AddisEats.Api.Services.RestaurantServices;

public class RestaurantService : IRestaurantService
{
	private readonly List<Restaurant> allRestaurants = SeedData.restaurants;
	public List<MenuItem>? GetByIdMenu(int id) 
	{ 
		var Rastaurant = allRestaurants.Where(r => r.Id == id).FirstOrDefault();
		return Rastaurant?.Menu;
    }

	public Restaurant? GetById(int id)
	{
		return allRestaurants.Where(r => r.Id == id).FirstOrDefault();
		
	}

	public PaginatedResultDTO<RestaurantDTO>  GetAll(RestaurantQuery? query)
	{
		var Restaurants = allRestaurants
			.Where(r => query.area == null || r.Address == query.area)
			.Where(r => query.Name == null || r.Name == query.Name)
			.Where(r => query.Phone == null || r.Phone == query.Phone)
			.OrderBy(r => r.Name)
            .Skip((query.Page - 1) * query.PageSize)
            .Take(query.PageSize)
            .ToList();
		var TotalCount = Restaurants.Count();

        PaginatedResultDTO<RestaurantDTO> resultDto = new PaginatedResultDTO<RestaurantDTO>
		{
			Data = Restaurants.Select(r => r.ToDTO()).ToList(),
			TotalCount = TotalCount,
			Page = query.Page,
			PageSize = query.PageSize

		};
		return resultDto;
	}
	public List<Restaurant> GetAllActive() 
	{
		var Restaurants = allRestaurants
			.Where(r=> r.IsActive == true)
			.OrderBy(r => r.Name)
			.ToList();
		return Restaurants;
	}
}