using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IRepository<T>
    {
       


        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T permission);
        Task<T> UpdateAsync(T permission);
        Task DeleteAsync(int id);
    }
}
