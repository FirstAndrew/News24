using Microsoft.AspNetCore.Mvc;

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
