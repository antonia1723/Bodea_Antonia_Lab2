using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bodea_Antonia_Lab2.Data;
using Bodea_Antonia_Lab2.Models;

namespace Bodea_Antonia_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Bodea_Antonia_Lab2.Data.Bodea_Antonia_Lab2Context _context;

        public IndexModel(Bodea_Antonia_Lab2.Data.Bodea_Antonia_Lab2Context context)
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
