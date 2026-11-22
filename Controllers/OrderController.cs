using AddisEats.Api.Models;
using AddisEats.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.OrderServices;
using AddisEats.Api.Commons;


namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _OrderService;
    public OrderController(IOrderService OrderService)
    {
        _OrderService = OrderService;
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = _OrderService.GetById(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
    [HttpPost]
    public IActionResult CreateOrder([FromBody]CreateOrderDTO createOrder)
    {
        var result= _OrderService.CreateOrder(createOrder);
        if (!result.IsSuccess) 
        {
            return Problem
               (
                title: result.Error?.Code,
                detail: result.Error?.Message,
                statusCode: result.Error?.Status
               );
        }
        var order = result.Value;
        return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);

    }
}