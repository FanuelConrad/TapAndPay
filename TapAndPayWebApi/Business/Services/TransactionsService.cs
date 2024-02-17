using TapAndPayWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Business.Services
{
    public class TransactionsService : ITransactionsService
    {
        private readonly IRepository<Transaction> _transactionsRepository;

        public TransactionsService(IRepository<Transaction> transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        public async Task<List<Transaction>> GetAllTransactionsAsync()
        {
            return await _transactionsRepository.GetAllAsync();
        }

        public async Task<Transaction> GetTransactionByIdAsync(string id)
        {
            return await _transactionsRepository.GetByIdAsync(id);
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            await _transactionsRepository.AddAsync(transaction);
        }

        public async Task UpdateTransactionAsync(Transaction transaction)
        {
            await _transactionsRepository.UpdateAsync(transaction);
        }

        public async Task DeleteTransactionAsync(string id)
        {
            await _transactionsRepository.DeleteAsync(id);
        }
    }
}