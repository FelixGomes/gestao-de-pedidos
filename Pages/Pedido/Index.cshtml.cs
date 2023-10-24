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
    public class IndexModel : PageModel
    {
        private readonly gestao_pedidos.Data.ApplicationDbContext _context;

        public IndexModel(gestao_pedidos.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Pedido> Pedido { get;set; }

        public async Task OnGetAsync()
        {
            Pedido = await _context.Pedido.ToListAsync();
        }
    }
}
