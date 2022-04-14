#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using instructor.Models;

namespace instructor.Data
{
    public class InstructorTestContext : DbContext
    {
        public InstructorTestContext (DbContextOptions<InstructorTestContext> options)
            : base(options)
        {
        }

        public DbSet<instructor.Models.Instructor> Instructor { get; set; }
       
 #region snippet1
        public async virtual Task<List<Instructor>> GetInstructorsAsync(){
            return await Instructor
                .ToListAsync();

        }
        #endregion
        #region snippet2
        public async virtual Task AddInstructorAsync(instructor.Models.Instructor instructor)
        {
            Instructor.Add(instructor);
            await SaveChangesAsync();
        }
        #endregion 
        
        
     
         
    }
}
