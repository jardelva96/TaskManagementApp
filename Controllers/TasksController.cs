using Microsoft.AspNetCore.Mvc;
using TaskManagementApp.Models;
using TaskManagementApp.Services;
using Microsoft.Extensions.Logging;

namespace TaskManagementApp.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly ILogger<TasksController> _logger;

        public TasksController(ITaskService taskService, ILogger<TasksController> logger)
        {
            _taskService = taskService;
            _logger = logger;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            try
            {
                var tasks = await _taskService.GetAllTasksAsync();
                _logger.LogInformation("Página de tarefas carregada com sucesso.");
                return View(tasks);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao carregar a lista de tarefas.");
                return View("Error");
            }
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            _logger.LogInformation("Página de criação de tarefa acessada.");
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Tentativa de criação de tarefa com dados inválidos.");
                return View(task);
            }

            try
            {
                await _taskService.CreateTaskAsync(task);
                _logger.LogInformation("Tarefa criada com sucesso: {Title}", task.Title);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar a tarefa: {Title}", task.Title);
                return View("Error");
            }
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("ID nulo ao acessar a página de edição.");
                return NotFound();
            }

            try
            {
                var task = await _taskService.GetTaskByIdAsync(id.Value);
                if (task == null)
                {
                    _logger.LogWarning("Tarefa não encontrada para edição. ID: {TaskId}", id);
                    return NotFound();
                }

                _logger.LogInformation("Página de edição de tarefa acessada. ID: {TaskId}", id);
                return View(task);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao acessar a página de edição. ID: {TaskId}", id);
                return View("Error");
            }
        }

        // POST: Tasks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TaskItem task)
        {
            if (id != task.Id)
            {
                _logger.LogWarning("Tentativa de edição com IDs incompatíveis. ID recebido: {Id}, ID da tarefa: {TaskId}", id, task.Id);
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Tentativa de edição com dados inválidos. ID: {TaskId}", id);
                return View(task);
            }

            try
            {
                var updatedTask = await _taskService.UpdateTaskAsync(id, task);
                if (updatedTask == null)
                {
                    _logger.LogWarning("Tarefa não encontrada para edição. ID: {TaskId}", id);
                    return NotFound();
                }

                _logger.LogInformation("Tarefa editada com sucesso. ID: {TaskId}, Título: {Title}", id, task.Title);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao editar a tarefa. ID: {TaskId}", id);
                return View("Error");
            }
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("ID nulo ao acessar a página de exclusão.");
                return NotFound();
            }

            try
            {
                var task = await _taskService.GetTaskByIdAsync(id.Value);
                if (task == null)
                {
                    _logger.LogWarning("Tarefa não encontrada para exclusão. ID: {TaskId}", id);
                    return NotFound();
                }

                _logger.LogInformation("Página de exclusão de tarefa acessada. ID: {TaskId}", id);
                return View(task);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao acessar a página de exclusão. ID: {TaskId}", id);
                return View("Error");
            }
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var deleted = await _taskService.DeleteTaskAsync(id);
                if (!deleted)
                {
                    _logger.LogWarning("Tarefa não encontrada para exclusão confirmada. ID: {TaskId}", id);
                    return NotFound();
                }

                _logger.LogInformation("Tarefa excluída com sucesso. ID: {TaskId}", id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao excluir a tarefa. ID: {TaskId}", id);
                return View("Error");
            }
        }
    }
}
