using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class PersonService : IPersonService
    {
       private readonly IPersonRepository _personRepository;
       private readonly  IMapper mapper;
        public PersonService(IPersonRepository personRepository,  IMapper mapper )
        {
         _personRepository = personRepository;
            this.mapper = mapper;
        }
        
        public async Task< PersonModel> AddAsync(PersonModel model)
        {
            return  mapper.Map<PersonModel>( await _personRepository.AddAsync(mapper.Map<Person>(model)));
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> UpdateAsync(PersonModel permission)
        {
            throw new NotImplementedException();
        }
        //////////




    }
}
