using Core.Repositories;
using ErrorOr;
using Models;

namespace Infrastructure;

public class ErrorOrRepository : IErrorOrRepository
{
    public async Task<ErrorOr<Student>> Get()
    {
        await Task.Delay(500);

        try
        {
            Database.Database.ThrowException();
        }
        catch(Exception e)
        {
            return Error.Failure(description: e.Message);
        }

        return await Task.FromResult(new Student());
    }
}