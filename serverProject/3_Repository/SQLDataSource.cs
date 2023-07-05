using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository
{
    public class SQLDataSource : DbContext, IDataSource
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = sqlsrv; Initial Catalog = ruthKlirsDataProject; Integrated Security = True; Trust Server Certificate=true");//
                                                                                                                                                    //  "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\מסמכים\\AAAA_Park.mdf;Integrated Security=True;Connect Timeout=30;Trust Server Certificare=true"
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Child> Children { get; set; }
    }
}
