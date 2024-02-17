using TapAndPayWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Business.Services
{
    public class StudentDataService : IStudentDataService
    {
        private readonly IRepository<StudentData> _studentDataRepository;

        public StudentDataService(IRepository<StudentData> studentDataRepository)
        {
            _studentDataRepository = studentDataRepository;
        }

        public async Task<List<StudentData>> GetAllStudentDataAsync()
        {
            return await _studentDataRepository.GetAllAsync();
        }

        public async Task<StudentData> GetStudentDataByIdAsync(string id)
        {
            return await _studentDataRepository.GetByIdAsync(id);
        }

        public async Task AddStudentDataAsync(StudentData studentData)
        {
            await _studentDataRepository.AddAsync(studentData);
        }

        public async Task UpdateStudentDataAsync(StudentData studentData)
        {
            await _studentDataRepository.UpdateAsync(studentData);
        }

        public async Task DeleteStudentDataAsync(string id)
        {
            await _studentDataRepository.DeleteAsync(id);
        }
    }
}