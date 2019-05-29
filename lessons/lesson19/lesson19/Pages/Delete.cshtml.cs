using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lesson19;
using lesson19.Models;

namespace lesson19.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly lesson19.ToDoListContext _context;

        public DeleteModel(lesson19.ToDoListContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDoItem ToDoItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoItem = await _context.ToDoList.SingleOrDefaultAsync(m => m.Id == id);

            if (ToDoItem == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoItem = await _context.ToDoList.FindAsync(id);

            if (ToDoItem != null)
            {
                _context.ToDoList.Remove(ToDoItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
