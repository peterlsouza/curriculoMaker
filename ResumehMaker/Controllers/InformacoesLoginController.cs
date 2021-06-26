using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumehMaker.Models;

namespace ResumehMaker.Controllers
{
    public class InformacoesLoginController : Controller
    {
        private readonly MyDBContext _context;

        public InformacoesLoginController(MyDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            return View(await _context.InformacoesLogin.Include(u => u.Usuario).Where(i => i.UsuarioId == usuarioId).ToListAsync());
        }

        public IActionResult DownloadDados()
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");
            var dados = _context.InformacoesLogin.Include(u => u.Usuario).Where(i => i.UsuarioId == usuarioId).ToList();
            StringBuilder arquivo = new StringBuilder();

            arquivo.AppendLine("EnderecoIP;Data;Horario");

            foreach (var item in dados)
            {
                arquivo.AppendLine(item.EnderecoIP + ";" + item.Data + ";" + item.Horario);
            }

            return File(Encoding.ASCII.GetBytes(arquivo.ToString()), "text/csv", "dados.csv");

        }
    }
}
