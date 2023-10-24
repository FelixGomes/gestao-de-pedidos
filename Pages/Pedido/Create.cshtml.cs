using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using gestao_pedidos.Data;
using gestao_pedidos.Models;

namespace gestao_pedidos.Pages_Pedido
{
    public class CreateModel : PageModel
    {
        private readonly gestao_pedidos.Data.ApplicationDbContext _context;

        public CreateModel(gestao_pedidos.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pedido Pedido { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pedido.Add(Pedido);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
