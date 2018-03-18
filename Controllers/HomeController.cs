using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRelations;
using MvcRelations.Models;

namespace MvcRelations.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IServiceProvider serviceProvider){
            var context = new MvcRelationsContext(serviceProvider.GetRequiredService<DbContextOptions<MvcRelationsContext>>());
            // context.TestItems.Add(new TodoItemModel{
            //     Text = "test 1",
            //     Completed = false
            // });
            // context.TestItems.Add(new TodoItemModel{
            //     Text = "test 2",
            //     Completed = true
            // });
            context.SaveChanges();
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
