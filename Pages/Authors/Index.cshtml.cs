using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mot_Marius_Lab2.Data;
using Mot_Marius_Lab2.Models;

namespace Mot_Marius_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Mot_Marius_Lab2.Data.Mot_Marius_Lab2Context _context;

        public IndexModel(Mot_Marius_Lab2.Data.Mot_Marius_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
