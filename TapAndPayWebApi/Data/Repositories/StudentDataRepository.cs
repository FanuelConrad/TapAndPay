using TapAndPayWebApi.Data.Repositories;
using TapAndPayWebApi.Models;

public class StudentDataRepository:DBRepository<StudentData>
{
    public StudentDataRepository(AppDbContext appDbContext):base(appDbContext)
    {
        
    }
}