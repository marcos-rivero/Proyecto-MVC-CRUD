using Microsoft.AspNetCore.Mvc;

public class AppController : Controller{
    public IActionResult Index(){ 
		return View(); 
	}
    public IActionResult Welcome(){
        return View();
    }
}