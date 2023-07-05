using _3_Repository.Entities;
using _3_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class ChildRepository : IChildRepository
    {
      private readonly  IDataSource source;
        public ChildRepository(IDataSource source)
        {
            this.source = source;
        }

        public async Task<Child> AddAsync(Child model)
        {
            source.Children.Add(model);
            await source.SaveChangesAsync();
            return model;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Child>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Child> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Child> UpdateAsync(Child permission)
        {
            throw new NotImplementedException();
        }
    }
}
