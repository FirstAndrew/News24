using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

public class NewsController : Controller
{
    public NewsController()
    {

    }

    public IActionResult index()
    {
        return View();
    }
}
