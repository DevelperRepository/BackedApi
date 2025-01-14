using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
         public int Id { get; set; }
        public required string Title { get; set; }
        public bool Completed { get; set; }
    }
}