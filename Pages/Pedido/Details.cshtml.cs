using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gestao_pedidos.Data;
using gestao_pedidos.Models;

namespace gestao_pedidos.Pages_Pedido
{
    public class DetailsModel : PageModel
    {
        private readonly gestao_pedidos.Data.ApplicationDbContext _context;

        public DetailsModel(gestao_pedidos.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Pedido Pedido { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pedido = await _context.Pedido.FirstOrDefaultAsync(m => m.PedidoId == id);

            if (Pedido == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
