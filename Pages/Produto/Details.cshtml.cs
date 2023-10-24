using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gestao_pedidos.Data;
using gestao_pedidos.Models;

namespace gestao_pedidos.Pages_Produto
{
    public class DetailsModel : PageModel
    {
        private readonly gestao_pedidos.Data.ApplicationDbContext _context;

        public DetailsModel(gestao_pedidos.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.ProdutoId == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
