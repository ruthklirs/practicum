using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Interfaces
{
    public interface Iservices<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T permissionDTO);
        Task<T> UpdateAsync(T permission);
        Task DeleteAsync(int id);
    }
}
