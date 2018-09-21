using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class Process1Controller : Controller {
    public IActionResult Index() {
        Process[] p = Process.GetProcesses();
        
        return View(p);
    }

    public IActionResult Details(int id) {
        Process p = Process.GetProcessById(id);
        return View(p);
    }
}