using Models;

namespace Core.Repositories;

public interface IExceptionRepository
{
    public Task<Student> Get();
}