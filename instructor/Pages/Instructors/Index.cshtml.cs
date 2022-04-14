#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using instructor.Data;
using instructor.Models;

namespace instructor.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly instructor.Data.InstructorTestContext _context;

        public IndexModel(instructor.Data.InstructorTestContext context)
        {
            _context = context;
        }

        public IList<Instructor> Instructor { get;set; }

        public async Task OnGetAsync()
        {
            Instructor = await _context.Instructor.ToListAsync();
        }
    }
}
