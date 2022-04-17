
using System.Web.Mvc;
using Infrastructure.Interface;
using DBconfig.Models;

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
        

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Todo(Todo.getIdMax() + 1));
        }

        [HttpPost]
        public ActionResult Create(Todo model)
        {
            if(!ModelState.IsValid)
                return View(model);
            Todo.Create(model);
            return View("Index" , Todo.GetAll());
        }
    }
}