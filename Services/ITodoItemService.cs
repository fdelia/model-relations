using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcRelations.Models;

namespace MvcRelations.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItemModel>> GetItems(string userId);

        Task AddItem(string userId, string text);

        Task UpdateItem(string userId, Guid id, TodoItemModel updatedData);

        Task DeleteItem(string userId, Guid id);
    }
}