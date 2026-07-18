using Microsoft.EntityFrameworkCore;
using SmartCity.API.Data;
using SmartCity.API.DTOs.Department;
using SmartCity.API.Interfaces;
using SmartCity.API.Models;

namespace SmartCity.API.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly SmartCityDbContext _context;

        public DepartmentRepository(SmartCityDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllAsync()
        {
            return await _context.Departments
                .Select(d => new DepartmentDto
                {
                    DepartmentId = d.DepartmentId,
                    DepartmentName = d.DepartmentName,
                    Description = d.Description,
                    PhoneNumber = d.PhoneNumber,
                    Email = d.Email,
                    IsActive = d.IsActive,
                    CreatedAt = d.CreatedAt
                })
                .ToListAsync();
        }

        public async Task<DepartmentDto?> GetByIdAsync(int id)
        {
            return await _context.Departments
                .Where(d => d.DepartmentId == id)
                .Select(d => new DepartmentDto
                {
                    DepartmentId = d.DepartmentId,
                    DepartmentName = d.DepartmentName,
                    Description = d.Description,
                    PhoneNumber = d.PhoneNumber,
                    Email = d.Email,
                    IsActive = d.IsActive,
                    CreatedAt = d.CreatedAt
                })
                .FirstOrDefaultAsync();
        }

        public async Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto)
        {
            var department = new Department
            {
                DepartmentName = dto.DepartmentName,
                Description = dto.Description,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email
            };

            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return new DepartmentDto
            {
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName,
                Description = department.Description,
                PhoneNumber = department.PhoneNumber,
                Email = department.Email,
                IsActive = department.IsActive,
                CreatedAt = department.CreatedAt
            };
        }

        public async Task<bool> UpdateAsync(int id, UpdateDepartmentDto dto)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
                return false;

            department.DepartmentName = dto.DepartmentName;
            department.Description = dto.Description;
            department.PhoneNumber = dto.PhoneNumber;
            department.Email = dto.Email;
            department.IsActive = dto.IsActive;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
                return false;

            _context.Departments.Remove(department);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}