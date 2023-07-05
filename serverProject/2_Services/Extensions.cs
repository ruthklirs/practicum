using _2_Services.Interfaces;
using _2_Services.Models;
using _2_Services.ServiceClasses;
using _3_Repository;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using _3_Repository.Repositories;
using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services
{
    public static class Extensions
    {


        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IChildService, ChildService>();
            
            return services;
        }
    }
}
