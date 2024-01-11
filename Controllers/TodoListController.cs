using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TodoListController : Controller
    {

        private readonly ILogger<TodoListController> _logger;
        public List<TaskModel> Tasks = new List<TaskModel>()
        {
            new TaskModel()
            {
                Id = 1,
                Name = "Test",
            }
        };

        public TodoListController(ILogger<TodoListController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var taskModel = (new TaskModel(), Tasks);

            return View(taskModel);

        }

        [HttpPost]
        public IActionResult AddTask(TaskModel tarea)
        {

            Tasks.Add(new TaskModel() { Id = tarea.Id, Name = tarea.Name });
            return RedirectToAction("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
