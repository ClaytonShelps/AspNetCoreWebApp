using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreWebApp.Models;

namespace AspNetCoreWebApp.Pages.ProdutosCRUD
{
    public class IndexModel : PageModel
    {
        private readonly AspNetCoreWebApp.Data.AppDbContext _context;

        public IndexModel(AspNetCoreWebApp.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
//comandos do console para gerar a migração e 2º criar a tabela no banco de bando dedados
//add-migration tbProduto
//update-database
