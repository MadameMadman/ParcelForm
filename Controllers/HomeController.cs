using Microsoft.AspNetCore.Mvc;
using ParcelForm.Models;

namespace ParcelForm.Controllers

{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/receipt")]
    public ActionResult Receipt()
    {
      ParcelVariables myParcel = new ParcelVariables();
      myParcel.SetDimensions(Request.Query["width"], Request.Query["height"]);

      return View("Receipt", myParcel);
    }
  }
}
