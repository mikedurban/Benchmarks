using ErrorOr;
using Models;

namespace Core.Service.ErrorOr;

public interface IErrorOrService
{
    public Task<ErrorOr<Student>> Get();
}