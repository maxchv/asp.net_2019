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
    public class DetailsModel : PageModel
    {
        private readonly lesson19.ToDoListContext _context;

        public DetailsModel(lesson19.ToDoListContext context)
        {
            _context = context;
        }

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
    }
}
