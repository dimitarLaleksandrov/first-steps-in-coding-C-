namespace FootballManager.Controllers
{
    using FootballManager.Services;
    using FootballManager.ViewModels.Users;
    using MyWebServer.Controllers;
    using MyWebServer.Http;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Register() => View();

        [HttpPost]
        public HttpResponse Register(RegisterInputModel model)
        {
            if (model.Password.Length < 5 || model.Password.Length > 20)
            {
                return this.View();
            }

            if (model.Username.Length < 5 || model.Username.Length > 20)
            {
                return this.View();
            }

            if (model.Password != model.ConfirmPassword)
            {
                return this.View();
            }

            if (model.Email.Length < 10 || model.Email.Length > 60 || this.usersService.EmailExists(model.Email))
            {
                return this.View();
            }

            if (this.usersService.UsernameExists(model.Username))
            {
                return this.View();
            }

            this.usersService.Register(model.Username, model.Email, model.Password);

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Login() => View();

        [HttpPost]
        public HttpResponse Login(LoginInputModel input)
        {
            var userId = this.usersService.GetUserId(input.Username, input.Password);

            if (userId != null)
            {
                this.SignIn(userId);
                return this.Redirect("/Players/All");
            }

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            this.SignOut();

            return Redirect("/");
        }
    }
}