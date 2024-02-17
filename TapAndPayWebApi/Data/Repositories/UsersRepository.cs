using TapAndPayWebApi.Data.Repositories;
using TapAndPayWebApi.Models;

public class UsersRepository:DBRepository<User>
{
    public UsersRepository(AppDbContext appDbContext):base(appDbContext)
    {
        
    }
}