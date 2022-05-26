using FrontToBackTask.DAL;
using FrontToBackTask.Models;
using FrontToBackTask.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Sliders = await _context.Sliders.ToListAsync();
            homeVM.Cards = await _context.Cards.ToListAsync();
            homeVM.Categories = await _context.Categories.ToListAsync();

            return View(homeVM);
        }
    }
}
