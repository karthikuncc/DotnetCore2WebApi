
using System.Collections.Generic;
using System.Linq;
using EmployeeDetails.API.Interfaces;
using EmployeeDetails.API.Models;
using EmployeeDetails.API.Data;
using System;

using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.API.Repositories
{
    public class EmployeeRepository :IRepository<Employees>
    {      
         private DataContext _dbContext;
        public EmployeeRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Employees> List()
        {
            Console.WriteLine(_dbContext.Employees);
            return _dbContext.Employees;
        }

        public void Add(Employees entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Employees entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Employees GetByID(int id)
        {
            return _dbContext.Employees.FirstOrDefault(c => c.EmpId== id);
        }

        public void Update(Employees entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

    }

    
}



