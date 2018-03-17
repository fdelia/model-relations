using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRelations;
using MvcRelations.Models;

namespace Vue2Spa.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IServiceProvider serviceProvider){
            var context = serviceProvider.GetRequiredService<DbContextOptions<MvcRelationsContext>>();
            context.TestItems
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
