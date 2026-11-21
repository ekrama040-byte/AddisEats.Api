using AddisEats.Api.MenuItemServices;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.Services.OrderServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options=>
{
    options.JsonSerializerOptions.PropertyNamingPolicy =
    System.Text.Json.JsonNamingPolicy.CamelCase;
    options.JsonSerializerOptions.DefaultIgnoreCondition =
       System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});
   
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IRestaurantService,RestaurantService>();
builder.Services.AddScoped<IOrderService,OrderService>();

//var phonenumber=builder.Configuration.GetValue<string>{"data:content:phone"};
//Console.WriteLine(phonenumber)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("frontend");

app.MapControllers();

app.Run();
