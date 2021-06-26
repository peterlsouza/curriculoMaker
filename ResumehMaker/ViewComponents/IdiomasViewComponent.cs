using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumehMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.ViewComponents
{
    public class IdiomasViewComponent : ViewComponent
    {
        private readonly MyDBContext _context;

        public IdiomasViewComponent(MyDBContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _context.Idiomas.Where(o => o.CurriculoId == id).ToListAsync());
        }
    }
}
