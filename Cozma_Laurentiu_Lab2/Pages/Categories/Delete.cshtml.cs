using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cozma_Laurentiu_Lab2.Data;
using Cozma_Laurentiu_Lab2.Models;

namespace Cozma_Laurentiu_Lab2.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Cozma_Laurentiu_Lab2.Data.Cozma_Laurentiu_Lab2Context _context;

        public DeleteModel(Cozma_Laurentiu_Lab2.Data.Cozma_Laurentiu_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public BookCategory BookCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookCategory == null)
            {
                return NotFound();
            }

            var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);

            if (bookcategory == null)
            {
                return NotFound();
            }
            else 
            {
                BookCategory = bookcategory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.BookCategory == null)
            {
                return NotFound();
            }
            var bookcategory = await _context.BookCategory.FindAsync(id);

            if (bookcategory != null)
            {
                BookCategory = bookcategory;
                _context.BookCategory.Remove(BookCategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
