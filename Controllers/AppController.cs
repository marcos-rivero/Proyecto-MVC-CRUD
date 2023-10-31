using System.Data;
using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.ViewModel;
namespace ProyectoMVC.Controllers
{
    public class AppController : Controller{
        private static List<PeliculaViewModel> _peliculas = new List<PeliculaViewModel>();
        public IActionResult Index(){          
            return View(_peliculas); 
        }
        public IActionResult Edit(){      
            return View();
        }
        [HttpGet("about")]
        public IActionResult About(){
            return View();
        }
        [HttpPost]
        public IActionResult Edit(PeliculaViewModel modelo){
            if(ModelState.IsValid){
                _peliculas.Add(modelo);
                return RedirectToAction(nameof(Index));
                // codigo para insertar en BD
            }
            return View();
        }
    }
}
