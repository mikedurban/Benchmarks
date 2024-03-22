using Core.Service.ErrorOr;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Api.Controllers;

[Controller]
[Route("[controller]/[action]")]
public class ErrorOr : Controller
{
    private readonly IErrorOrService _errorOrService;

    public ErrorOr(IErrorOrService errorOrService)
    {
        _errorOrService = errorOrService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return await _errorOrService
            .Get()
            .Match
            (
                value => Ok(value),
                error => Problem(error.First().Description)
            );
    }
}