using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRelations.Models;

namespace MvcRelations.Services
{
    public class FakeTodoItemService
    {
        public Task GetItems(string userId)
        {
            // var todos = new List<TodoItemModel>
            // {
                // new TodoItemModel { Text = "Learn Vue.js", Completed = 1 },
                // new TodoItemModel { Text = "Learn ASP.NET Core" }
            // };

            // return Task.FromResult(todos.AsEnumerable());
            return null;; 
        }

        public Task AddItem(string userId, string text)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(string userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItem(string userId, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}