using ApiToDo.Context;
using ApiToDo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiToDo.Controllers;
[ApiController]
[Route("[controller]")]
public class TarefaController : ControllerBase
{
    private readonly ApiToDoContext _context;

    public TarefaController(ApiToDoContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult <IEnumerable<Tarefa>> GetTarefas()
    {
        var tarefas = _context.Tarefas.ToList();
        
        return tarefas is null ? NotFound(): tarefas;
    }

    [HttpGet("{id}")]
    public ActionResult GetTarefaPorId(int id)
    {
        var tarefa = _context.Tarefas.Find(id);
        
        return tarefa is null ? BadRequest(new 
                                {Erro = $"Não foi possivel encontar a tarefa: {id}"}) : 
                                Ok(tarefa);
    }

    [HttpPost]
    public ActionResult PostTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetTarefas), new { Id = tarefa.IdTarefa }, tarefa);
    }
}
