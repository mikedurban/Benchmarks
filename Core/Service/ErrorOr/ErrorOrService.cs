using Core.Repositories;
using ErrorOr;
using Models;

namespace Core.Service.ErrorOr;

public class ErrorOrService : IErrorOrService
{
    private readonly IErrorOrRepository _errorOrRepository;

    public ErrorOrService(IErrorOrRepository errorOrRepository)
    {
        _errorOrRepository = errorOrRepository;
    }

    public Task<ErrorOr<Student>> Get()
    {
        return _errorOrRepository.Get();
    }
}