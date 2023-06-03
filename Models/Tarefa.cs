using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiToDo.Models;

public class Tarefa
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string TituloTarefa { get; set;}

    [StringLength(200)]
    public string ConteudoTarefa { get; set;}
    public DateTime DataCriacao { get; set;} = DateTime.Now;

    public DateTime? DataConclusao
    {
        get { return Concluido ? DateTime.Now : null; }
    }
    public bool Concluido { get; set; } = false;

    public string Status 
    {
        get { return Concluido ? "Concluído" : "Não concluído"; }
    }

    public string? NivelUrgencia { get; set; }
    
}
