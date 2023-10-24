using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gestao_pedidos.Data;
using gestao_pedidos.Models;

namespace gestao_pedidos.Pages_Cliente
{
    public class DetailsModel : PageModel
    {
        private readonly gestao_pedidos.Data.ApplicationDbContext _context;

        public DetailsModel(gestao_pedidos.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.Id == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
