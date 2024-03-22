using ErrorOr;
using Models;

namespace Core.Repositories;

public interface IErrorOrRepository
{
    public Task<ErrorOr<Student>> Get();
}