using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiToDo.Models;

[Table("Tarefas")]
public class Tarefa
{
    [Key]
    public int IdTarefa { get; set;}

    [StringLength(50)]
    public string? TituloTarefa { get; set;}

    [StringLength(200)]
    public string? ConteudoTarefa { get; set;}

    public bool Conluido { get; set; } = false;
}
