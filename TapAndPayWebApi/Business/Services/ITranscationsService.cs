using TapAndPayWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Business.Services
{
    public interface ITransactionsService
    {
        Task<List<Transaction>> GetAllTransactionsAsync();
        Task<Transaction> GetTransactionByIdAsync(string id);
        Task AddTransactionAsync(Transaction transaction);
        Task UpdateTransactionAsync(Transaction transaction);
        Task DeleteTransactionAsync(string id);
    }
}