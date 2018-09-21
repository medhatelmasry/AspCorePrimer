using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class ProcessController : Controller {
    public IActionResult Index() {
        Process[] p = Process.GetProcesses();
        ViewBag.Processes = p;
        return View();
    }
}