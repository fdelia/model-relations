using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcRelations.Services;

namespace MvcRelations.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
            {
        // private readonly ITodoItemService _todoItemService;

        public TodoController()
        {
            // _todoItemService = todoItemService;
        }

        // Handles GET /api/todo
        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var userId = "123"; // TODO: Get actual user ID
            // var todos = await _todoItemService.GetItems(userId);

            return Ok(new List<string>()); // as Json
        }
    }
}