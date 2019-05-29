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
    public class IndexModel : PageModel
    {
        private readonly lesson19.ToDoListContext _context;

        public IndexModel(lesson19.ToDoListContext context)
        {
            _context = context;
        }

        public IList<ToDoItem> ToDoItem { get;set; }

        public async Task OnGetAsync()
        {
            ToDoItem = await _context.ToDoList.ToListAsync();
        }
    }
}
