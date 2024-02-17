using System.Collections.Generic;
using System.Threading.Tasks;
using TapAndPayWebApi.Models;

public interface IRepository<T> where T:class
{
    Task<T> GetByIdAsync(string id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(string id);
}