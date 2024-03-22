using Core.Repositories;
using Models;

namespace Core.Service.Exception;

public class ExceptionService : IExceptionService
{
    private readonly IExceptionRepository _exceptionRepository;

    public ExceptionService(IExceptionRepository exceptionRepository)
    {
        _exceptionRepository = exceptionRepository;
    }

    public Task<Student> Get()
    {
        return _exceptionRepository.Get();
    }
}