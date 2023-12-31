﻿using Microsoft.AspNetCore.Mvc;

namespace EnvironmentTagHelperCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    private readonly IWebHostEnvironment _webHostEnvironment;

    //constructor
    public HomeController(IWebHostEnvironment webHostEnvironment)
    {
      _webHostEnvironment = webHostEnvironment;
    }

    [Route("/")]
    public IActionResult Index()
    {
      ViewBag.CurrentEnviornment = _webHostEnvironment.EnvironmentName;
      return View();
    }
  }
}
