namespace FootballManager.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    public class HomeController : Controller
    {
        public HttpResponse Index()
        {
            if (this.User.IsAuthenticated)
            {
                return Redirect("/Players/All");
            }
            return View();
        }
    }
}
