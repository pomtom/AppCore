using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppCore.Models
{
    public class AppCoreContext : DbContext
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-2.2&tabs=visual-studio
        /// </summary>
        /// <param name="options"></param>
        public AppCoreContext (DbContextOptions<AppCoreContext> options)
            : base(options)
        {
        }

        public DbSet<AppCore.Models.Employee> Employee { get; set; }
    }
}
