using TapAndPayWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Business.Services
{
    public interface IStudentDataService
    {
        Task<List<StudentData>> GetAllStudentDataAsync();
        Task<StudentData> GetStudentDataByIdAsync(string id);
        Task AddStudentDataAsync(StudentData studentData);
        Task UpdateStudentDataAsync(StudentData studentData);
        Task DeleteStudentDataAsync(string id);
    }
}