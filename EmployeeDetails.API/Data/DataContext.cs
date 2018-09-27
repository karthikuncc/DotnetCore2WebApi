using Microsoft.EntityFrameworkCore;
using EmployeeDetails.API.Models;

namespace EmployeeDetails.API.Data{
    public class DataContext : DbContext{

     public DataContext(DbContextOptions<DataContext>options):base (options){}
     public DbSet<Employees>Employees { get; set; }  
    }
    }

   