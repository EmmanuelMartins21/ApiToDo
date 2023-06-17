using ApiToDo.Context;
using ApiToDo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiToDo.Controllers;
[ApiController]
[Route("controller/task")]
public class TarefaController : ControllerBase
{
    private readonly ApiToDoContext _context;
    private readonly ILogger<TarefaController> _logger;

    public TarefaController(ApiToDoContext context, ILogger<TarefaController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Tarefa>> GetTarefas()
     {
         _logger.LogInformation("GET /Tarefa - Iniciando busca de todas as tarefas " + DateTime.Now);
         try
         {
             var tarefas = _context.Tarefas.ToList();

             if (tarefas is null || tarefas.Count == 0)
             {
                 _logger.LogInformation("GET /Tarefa - Nenhuma tarefa encontrada " + DateTime.Now);
                 return NotFound();
             }
             _logger.LogInformation("GET /Tarefa - Tarefas encontradas com sucesso " + DateTime.Now);
             return tarefas;
         }
         catch (Exception ex)
         {
             _logger.LogError(ex, "GET /Tarefa - Ocorreu um erro ao buscar as tarefas");
             return StatusCode(500);
         }
     }

     [HttpGet("{id}")]
     public ActionResult GetTarefaPorId(int id)
     {
         _logger.LogInformation($"GET /Tarefa/{id} - Iniciando busca da tarefa com ID: {id}");

         try
         {
             var tarefa = _context.Tarefas.Find(id);

             if (tarefa is null)
             {
                 _logger.LogInformation($"GET /Tarefa/{id} - Tarefa não encontrada: {id}");
                 return BadRequest(new { Erro = $"Não foi possível encontrar a tarefa: {id}" });
             }

             _logger.LogInformation($"GET /Tarefa/{id} - Tarefa encontrada com sucesso: {id}");
             return Ok(tarefa);
         }
         catch (Exception ex)
         {
             _logger.LogError(ex, $"GET /Tarefa/{id} - Ocorreu um erro ao buscar a tarefa: {id}");
             return StatusCode(500);
         }
     }

     [HttpPost]
     public ActionResult PostTarefa(Tarefa tarefa)
     {
         _logger.LogInformation("POST /Tarefa - Iniciando criação de nova tarefa");

         try
         {         
             if(!(string.IsNullOrEmpty(tarefa.TituloTarefa) &&
                  string.IsNullOrEmpty(tarefa.ConteudoTarefa)))
             {
                 _context.Tarefas.Add(tarefa);
                 _context.SaveChanges();

                 _logger.LogInformation($"POST /Tarefa - Tarefa{tarefa.Id} criada com sucesso");
             }

             return CreatedAtAction(nameof(GetTarefas), new { Id = tarefa.Id }, tarefa);
         }
         catch (Exception ex)
         {
             _logger.LogError(ex, "POST /Tarefa - Ocorreu um erro ao criar a tarefa");
             return StatusCode(500);
         }
     }


     [HttpPut("{id}")]
     public ActionResult PutTarefaPorId(int id)
     {
         _logger.LogInformation($"PUT /Tarefa/{id} - Iniciando atualização da tarefa com ID: {id}");

         try
         {
             var tarefa = _context.Tarefas.Find(id);

             if (tarefa is null)
             {
                 _logger.LogInformation($"PUT /Tarefa/{id} - Tarefa não encontrada: {id}");
                 return BadRequest(new { Erro = $"Não foi possível encontrar a tarefa: {id}" });
             }

             tarefa.Concluido = true;
             _context.Tarefas.Update(tarefa);
             _context.SaveChanges();

             _logger.LogInformation($"PUT /Tarefa/{id} - Tarefa atualizada com sucesso: {id}");
             return Ok(tarefa);
         }
         catch (Exception ex)
         {
             _logger.LogError(ex, $"PUT /Tarefa/{id} - Ocorreu um erro ao atualizar a tarefa: {id}");
             return StatusCode(500);
         }
     }

     [HttpPut]
     public ActionResult PutTarefas()
     {
         _logger.LogInformation("PUT /Tarefa - Iniciando atualização de todas as tarefas");

         try
         {
             var tarefas = _context.Tarefas.ToList();

             if (tarefas is null || tarefas.Count == 0)
             {
                 _logger.LogInformation("PUT /Tarefa - Nenhuma tarefa encontrada");
                 return BadRequest(new { Erro = "Não foi possível atualizar todas as tarefas" });
             }

             foreach (var t in tarefas)
             {
                 t.Concluido = true;
                 _context.Tarefas.Update(t);
                 _context.SaveChanges();
             }

             _logger.LogInformation("PUT /Tarefa - Todas as tarefas atualizadas com sucesso");
             return Ok(tarefas);
         }
         catch (Exception ex)
         {
             _logger.LogError(ex, "PUT /Tarefa - Ocorreu um erro ao atualizar as tarefas");
             return StatusCode(500);
         }
     }

     [HttpDelete]
     public ActionResult DeleteTarefa(int id)
     {
         _logger.LogInformation($"Excluindo a tarefa ID: {id}");

         try
         {
             var tarefa = _context.Tarefas.Find(id);

             if (tarefa is null)
             {
                 _logger.LogInformation($"Tarefa não encontrada: {id}");
                 return BadRequest(new { Erro = $"Não foi possível encontrar a tarefa: {id}" });
             }

             _context.Tarefas.Remove(tarefa);
             _context.SaveChanges();

             _logger.LogInformation($"Tarefa {id} removida com sucesso: ");
             return Ok();
         }
         catch (Exception ex)
         {
             _logger.LogError(ex, $"Ocorreu um erro ao excluir a tarefa: {id}");
             return StatusCode(500);
         }        
     }    
   
}