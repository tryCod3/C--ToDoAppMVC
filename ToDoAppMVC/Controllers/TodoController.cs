
using System.Web.Mvc;
using Infrastructure.Interface;

namespace ToDoAppMVC.Controllers
{

    public class TodoController : Controller
    {

        private  IRepositoryTodo Todo { get; set; } 

        public TodoController(IRepositoryTodo _Todo)
        {
            Todo = _Todo;
        }

        // GET: ToDo
        public ActionResult Index()
        {
            ViewData["Title"] = "Get All List ToDo";
            return View(Todo.GetAll());
        }
    }
}