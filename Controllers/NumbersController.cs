using RandomThings.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomThings.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NumbersController : ControllerBase
{
    public NumbersController() { }

    // GET all action
    [HttpGet]
    public ActionResult<int> Get() => NumbersService.Get(0, 101);
}
