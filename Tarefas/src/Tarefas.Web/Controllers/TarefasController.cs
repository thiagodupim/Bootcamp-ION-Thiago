
using Microsoft.AspNetCore.Mvc;

namespace Tarafas.Web.Controllers;

public class TarefasController : Controller 
{
    public IActionResult Create()
    {
        return View();
    }
}