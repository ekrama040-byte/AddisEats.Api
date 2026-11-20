using AddisEats.Api.Models;
using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.MenuItemServices;


namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class MenuItemController : ControllerBase
{
    private readonly IMenuItemService _menuItemService;
    public MenuItemController (IMenuItemService menuItemService)
    {
        _menuItemService = menuItemService;
    }
 

    [HttpGet]
    public IActionResult GetAll([FromQuery] string? catagory)
    {
        var result=_menuItemService.GetAll(catagory);
        return Ok(result);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
    var result=_menuItemService.GetById(id);

    
   
    if (result == null)
    {
       return NotFound();
    }
    return Ok(result);
    }

}
