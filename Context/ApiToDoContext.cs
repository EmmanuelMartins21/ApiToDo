using ApiToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiToDo.Context;

public class ApiToDoContext : DbContext
{
    public ApiToDoContext(DbContextOptions<ApiToDoContext> options) : base(options)
    {}

    public DbSet<Tarefa> Tarefas { get; set; }
}
