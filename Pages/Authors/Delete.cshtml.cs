﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stinga_Alexandru_Lab2.Data;
using Stinga_Alexandru_Lab2.Models;

namespace Stinga_Alexandru_Lab2.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private readonly Stinga_Alexandru_Lab2.Data.Stinga_Alexandru_Lab2Context _context;

        public DeleteModel(Stinga_Alexandru_Lab2.Data.Stinga_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Stinga_Alexandru_Lab2.Models.Authors Authors { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);

            if (authors == null)
            {
                return NotFound();
            }
            else
            {
                Authors = authors;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FindAsync(id);
            if (authors != null)
            {
                Authors = authors;
                _context.Authors.Remove(Authors);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
