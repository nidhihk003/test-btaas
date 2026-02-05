using Microsoft.AspNetCore.Mvc;
using DummyApi.Services;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService service = new OrderService();

    [HttpGet("/order/{id}")]
    public IActionResult Get(int id)
    {
        return Ok(service.Create(id));
    }
}
