using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.Controllers.Api
{
    [Route("api/[controller]")]
    public class TodoListsController : Controller
    {
        private readonly TodosContext _todosContext;

        public TodoListsController(TodosContext todosContext)
        {
            _todosContext = todosContext;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todosContext.TodoLists);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todo =_todosContext.TodoLists.Find(id);

            if (todo != null) {
                return Ok(todo);
            }
            else 
            {
                return NotFound();
            }
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]dynamic value)
        {
            string Title = value.title.Value;

            var list = new TodoList
            {
                Title = Title
            };

            _todosContext.TodoLists.Add(list);
            _todosContext.SaveChanges();

            return Json(list);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var removeList = _todosContext.TodoLists.Find(id);
            if (removeList != null)
            {
                _todosContext.TodoLists.Remove(removeList);
                _todosContext.SaveChanges();
            }
        }
    }
}
