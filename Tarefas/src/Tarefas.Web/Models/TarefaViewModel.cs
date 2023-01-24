using System.ComponentModel;

namespace Tarafas.Web.Models;

public class TarefaViewModel
{
    [DisplayName("Título")]
    public string Titulo { get; set;}
    [DisplayName("Descrição")]
    public string Descricao { get; set;}
}