#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using instructor.Data;
using instructor.Models;

namespace instructor.Pages.Instructors
{
    public class CreateModel : PageModel
    {
        private readonly instructor.Data.InstructorTestContext _context;

        public CreateModel(instructor.Data.InstructorTestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Instructor Instructor { get; set; }
       
        [BindProperty]
        public int Grades {get;set;}
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           await _context.AddInstructorAsync(Instructor);
           
            

            return RedirectToPage("./Index");
        }
        
    }
}
