using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using _3_Repository.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class ChildService : IChildService
    {
        IChildRepository rep;
        IMapper mapper;
        public ChildService(IChildRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task< ChildModel> AddAsync(ChildModel model)
        {
            return mapper.Map<ChildModel>( await rep.AddAsync(mapper.Map<Child>(model)));
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChildModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChildModel> UpdateAsync(ChildModel permission)
        {
            throw new NotImplementedException();
        }
    }
}
