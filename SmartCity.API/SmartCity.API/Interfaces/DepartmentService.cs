using SmartCity.API.DTOs.Department;

namespace SmartCity.API.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<DepartmentDto>> GetAllAsync();

        Task<DepartmentDto?> GetByIdAsync(int id);

        Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto);

        Task<bool> UpdateAsync(int id, UpdateDepartmentDto dto);

        Task<bool> DeleteAsync(int id);
    }
}