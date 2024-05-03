using Microsoft.AspNetCore.Mvc;

namespace asplab7.Controllers
{
  public class AccountController : TodoBaseController
  {

    public IActionResult Index()
    {
      return View();
    }
  }
}
