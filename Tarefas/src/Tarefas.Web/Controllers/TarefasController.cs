using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarafas.Web.Controllers;

public class TarefasController : Controller 
{
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Index()
    {
        var listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel() { Titulo = "Escovar os dentes", Descricao = "Usar sensodine de manhã"},
            new TarefaViewModel() { Titulo = "Arrumar a cama", Descricao = "Bem arrumadinho"},
            new TarefaViewModel() { Titulo = "Por o lixo pra fora", Descricao = "Verificar todas as lixeiras"}
        };
        return View(listaDeTarefas);
    }
}