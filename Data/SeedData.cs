using AddisEats.Api.Models;

namespace AddisEats.Api.Data;

public class SeedData
{
    public static List<Restaurant> restaurants = new List<Restaurant>
{
    new Restaurant
    {
        Id = 1, Name = "Addis Ababa Restaurant", Address = "Bole", Phone = "555-1234", IsActive = true, OwnerAddress = null,
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 1, Name = "Beyaynetu Special", Catagory = "Traditional", Price = 350.0m },
            new MenuItem { Id = 2, Name = "Shiro Tegabino", Catagory = "Traditional", Price = 250.0m }
        }
    },
    new Restaurant
    {
        Id = 2, Name = "Blue Nile Restaurant", Address = "Ayat", Phone = "555-5678", IsActive = false, OwnerAddress = "789 Pine St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 3, Name = "Nile Tilapia Tibs", Catagory = "Seafood", Price = 480.0m },
            new MenuItem { Id = 4, Name = "Asa Goulash", Catagory = "Seafood", Price = 420.0m }
        }
    },
    new Restaurant
    {
        Id = 3, Name = "Lucy Restaurant", Address = "Mexico", Phone = "555-9012", IsActive = true, OwnerAddress = "321 Cedar St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 5, Name = "Special Kitfo", Catagory = "Traditional", Price = 550.0m },
            new MenuItem { Id = 6, Name = "Gored Gored", Catagory = "Traditional", Price = 520.0m }
        }
    },
    new Restaurant
    {
        Id = 4, Name = "Ethio Restaurant", Address = "Megenagna", Phone = "555-3456", IsActive = true, OwnerAddress = "654 Spruce St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 7, Name = "Shekla Tibs", Catagory = "Traditional", Price = 490.0m },
            new MenuItem { Id = 8, Name = "Bozena Shiro", Catagory = "Traditional", Price = 310.0m }
        }
    },
    new Restaurant
    {
        Id = 5, Name = "Tena Yistilign Restaurant", Address = "Bole", Phone = "555-7890", IsActive = true, OwnerAddress = "987 Birch St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 9, Name = "Chechebsa with Honey", Catagory = "Breakfast", Price = 220.0m },
            new MenuItem { Id = 10, Name = "Special Ful", Catagory = "Breakfast", Price = 200.0m }
        }
    },
    new Restaurant
    {
        Id = 6, Name = "Kategna Restaurant", Address = "Megenagna", Phone = "555-2345", IsActive = true, OwnerAddress = "123 Main St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 11, Name = "Kategna Special Platter", Catagory = "Traditional", Price = 650.0m },
            new MenuItem { Id = 12, Name = "Derek Tibs", Catagory = "Traditional", Price = 530.0m }
        }
    },
    new Restaurant
    {
        Id = 7, Name = "Sishu Restaurant", Address = "Bole", Phone = "555-6789", IsActive = false, OwnerAddress = "246 Aspen St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 13, Name = "Sishu Classic Burger", Catagory = "Burger", Price = 450.0m },
            new MenuItem { Id = 14, Name = "Hand-Cut Fries & Milkshake", Catagory = "Sides", Price = 280.0m }
        }
    },
    new Restaurant
    {
        Id = 8, Name = "Abay Restaurant", Address = "Megenagna", Phone = "555-0123", IsActive = true, OwnerAddress = "357 Cherry St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 15, Name = "Awaze Tibs", Catagory = "Traditional", Price = 470.0m },
            new MenuItem { Id = 16, Name = "Quanta Firfir", Catagory = "Traditional", Price = 360.0m }
        }
    },
    new Restaurant
    {
        Id = 9, Name = "Fendika Restaurant", Address = "Mexico", Phone = "555-4567", IsActive = false, OwnerAddress = "468 Walnut St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 17, Name = "Tej (Honey Wine) Pitcher", Catagory = "Beverage", Price = 300.0m },
            new MenuItem { Id = 18, Name = "Kolo & Roasted Barley Mix", Catagory = "Snack", Price = 120.0m }
        }
    },
    new Restaurant
    {
        Id = 10, Name = "Doro Wat Restaurant", Address = "Megenagna", Phone = "555-8901", IsActive = true, OwnerAddress = "579 Chestnut St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 19, Name = "Doro Wat with Ayib", Catagory = "Traditional", Price = 580.0m },
            new MenuItem { Id = 20, Name = "Chicken Tibs", Catagory = "Traditional", Price = 460.0m }
        }
    },
    new Restaurant
    {
        Id = 11, Name = "Injera Restaurant", Address = "Mexico", Phone = "555-2345", IsActive = true, OwnerAddress = "680 Poplar St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 21, Name = "Teff Injera Firfir", Catagory = "Traditional", Price = 260.0m },
            new MenuItem { Id = 22, Name = "Mahberawi Platter", Catagory = "Traditional", Price = 600.0m }
        }
    },
    new Restaurant
    {
        Id = 12, Name = "Bunna Restaurant", Address = "Ayat", Phone = "555-6789", IsActive = true, OwnerAddress = "791 Fir St",
        Menu = new List<MenuItem>
        {
            new MenuItem { Id = 23, Name = "Traditional Jebena Bunna", Catagory = "Beverage", Price = 80.0m },
            new MenuItem { Id = 24, Name = "Macchiato & Baklava", Catagory = "Cafe", Price = 150.0m }
        }
    }
};

}
