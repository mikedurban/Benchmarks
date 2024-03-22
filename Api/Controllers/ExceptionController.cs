using Core.Service.Exception;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
[Route("[controller]/[action]")]

public class ExceptionController : Controller
{
    private readonly IExceptionService _exceptionService;

    public ExceptionController(IExceptionService exceptionService)
    {
        _exceptionService = exceptionService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return  Ok(await _exceptionService.Get());
    }
}