using Models;

namespace Core.Service.Exception;

public interface IExceptionService
{
    public Task<Student> Get();
}