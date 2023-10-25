using System.Data;
using Microsoft.AspNetCore.Mvc;

public class AppController : Controller{
    public IActionResult Index(){          
		return View(); 
	}
    public IActionResult Edit(){
        throw new InvalidOperationException();       
        return View();
    }
    [HttpGet("about")]
    public IActionResult About(){
        return View();
    }
}