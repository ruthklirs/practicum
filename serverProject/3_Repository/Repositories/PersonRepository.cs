using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Activation;

namespace _3_Repository.Repositories
{
    public class PersonRepository : IPersonRepository
    {
       private readonly  IDataSource source;
          public PersonRepository(IDataSource source)
        {
            this.source = source;
        }
       
        public async Task<Person> AddAsync(Person model)
        {
            source.People.Add(model);
            await source.SaveChangesAsync();
            return model;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdateAsync(Person permission)
        {
            throw new NotImplementedException();
        }
    }
}
