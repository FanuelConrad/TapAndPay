using TapAndPayWebApi.Data.Repositories;
using TapAndPayWebApi.Models;

public class TransactionsRepository:DBRepository<Transaction>
{
    public TransactionsRepository(AppDbContext appDbContext):base(appDbContext)
    {
        
    }
}