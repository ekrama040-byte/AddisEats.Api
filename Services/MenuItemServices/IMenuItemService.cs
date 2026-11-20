using AddisEats.Api.Models;
namespace AddisEats.Api.MenuItemServices;
public interface IMenuItemService
{
    List<MenuItem> GetAll(string? catagory);
    MenuItem? GetById(int id);
}