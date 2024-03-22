using Core.Repositories;
using Models;

namespace Infrastructure;

public class ExceptionRepository : IExceptionRepository
{
    public async Task<Student> Get()
    {
        await Task.Delay(500);
        
        Database.Database.ThrowException();

        return await Task.FromResult(new Student());
    }
}