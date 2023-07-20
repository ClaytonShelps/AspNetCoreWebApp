using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreWebApp.Data;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace AspNetCoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _contexto;
        
        public IList<Produto> Produtos;


        public IndexModel(ILogger<IndexModel> logger, AppDbContext contexto)
        {
            _contexto = contexto;
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            Produtos = await _contexto.Produto.ToListAsync<Produto>();

        }
    }
}
