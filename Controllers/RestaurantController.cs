using AddisEats.Api.MenuItemServices;
using AddisEats.Api.Mappers;
using AddisEats.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.RestaurantServices;


[ApiController]
[Route("api/v1/[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;
    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService=restaurantService;
    }
    [HttpGet("{id}/menu")]
    public IActionResult GetByIdMenu(int id)
    {
        var menu = _restaurantService.GetById(id);
        if (menu == null) 
        {
            return NotFound();
        }
        return Ok(menu);
    }

    [HttpGet("{id:int:min(1)}")]
    public IActionResult GetById(int id)
    {
        var result = _restaurantService.GetById(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpGet]
    public IActionResult GetAll([FromQuery] RestaurantQuery? query )
    {
        var Restaurant = _restaurantService.GetAll(query);
        return Ok(Restaurant);
    }
    [HttpGet("Active")]
    public IActionResult GetAllActiveRestaurant()
    {
        var Restaurant = _restaurantService.GetAllActive();
        var RestaurantDTO = Restaurant.Select(r => r.ToDTO()).ToList();
        return Ok(RestaurantDTO);
    }

}
