using Microsoft.EntityFrameworkCore;
using System.Data;
using UsingCurdoperationEmployee.Model.Entity;
using System.Collections;
using UsingCurdoperationEmployee.Model;



namespace UsingCurdoperationEmployee.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Employee> employess {  get; set; }
        public DbSet<User> Users { get; set; }
    }

    
}
