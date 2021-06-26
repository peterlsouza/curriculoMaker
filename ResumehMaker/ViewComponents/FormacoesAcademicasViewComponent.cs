using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumehMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.ViewComponents
{
    public class FormacoesAcademicasViewComponent : ViewComponent
    {
        private readonly MyDBContext _context;

        public FormacoesAcademicasViewComponent(MyDBContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _context.FormacoesAcademicas.Include(f => f.TipoCurso).Where(f => f.CurriculoId == id).ToListAsync());
        }
    }
}
