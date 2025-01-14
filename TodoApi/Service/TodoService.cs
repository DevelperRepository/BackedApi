using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Repository;

namespace TodoApi.Service
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository<TodoItem> _repository;

       public TodoService(ITodoRepository<TodoItem> repository)
       {
            _repository = repository;
       }

        public async Task DeleteTodoAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TodoItem?> GetTodoItemByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TodoItem> AddTodoItemAsync(TodoItem todoItem)
        {
            return await _repository.AddAsync(todoItem);
        }

        public async Task<TodoItem> UpdateTodoItemAsync(TodoItem todoItem)
        {
            return await _repository.UpdateAsync(todoItem);
        }
    }
}