using AddisEats.Api.Models;
namespace AddisEats.Api.MenuItemServices;

public class MenuItemService : IMenuItemService
{
    private readonly List<MenuItem> _menuItem = new List<MenuItem>
    {
        new MenuItem { Id = 1, Name = "Burger",Catagory = "Food", Price = 10.5m },
        new MenuItem { Id = 2, Name = "Pizza", Catagory = "Food", Price = 15.0m }
    };
    public List<MenuItem> GetAll(string? catagory)

    {
        return _menuItem.Where(x=> catagory == null|| x.Catagory==catagory).ToList();
    }
    public MenuItem? GetById(int id)
    {
        return _menuItem.Where(m => m.Id == id).FirstOrDefault();
    }
}