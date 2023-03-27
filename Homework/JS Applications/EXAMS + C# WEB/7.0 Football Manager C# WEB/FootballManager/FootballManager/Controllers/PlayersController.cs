
namespace FootballManager.Controllers
{
    using FootballManager.Services;
    using FootballManager.ViewModels.Players;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class PlayersController : Controller
    {
        private readonly IPlayersService playersService;

        public PlayersController(IPlayersService playersService)
        {
            this.playersService = playersService;
        }
        public HttpResponse All()
        {
            if (!this.User.IsAuthenticated)
            {
                return this.Redirect("/Users/Login");
            }
            var viewModel = new AllPlayersViewModel
            {
                Players = this.playersService.GetAll().Select(x => new PralyersViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    ImageUrl = x.ImageUrl,
                    Speed = x.Speed,
                    Endurance = x.Endurance,
                    Position = x.Position,
                    Description = x.Description,
                })
            };
            return this.View(viewModel);
        }

        public HttpResponse Add()
        {
            if (!this.User.IsAuthenticated)
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(AddPlayerInputModel model)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.Redirect("/Users/Login");
            }
            if (model.FullName.Length < 5 || model.FullName.Length > 80 || string.IsNullOrEmpty(model.FullName))
            {
                return this.View(model);
            }
            if (model.Description.Length > 200 || string.IsNullOrEmpty(model.Description))
            {
                return this.View(model);
            }
            if (string.IsNullOrEmpty(model.ImageUrl))
            {
                return this.View(model);
            }
            if (model.Position.Length < 5 || model.Position.Length > 20 || string.IsNullOrEmpty(model.Position))
            {
                return this.View(model);
            }
            if (model.Speed < 0 || model.Speed > 10)
            {
                return this.View(model);
            }
            if (model.Endurance < 0 || model.Endurance > 10)
            {
                return this.View(model);
            }
            var userId = this.User.Id;
            var playerId = this.playersService.AddPlayer(model, userId);

            return this.Redirect("/Players/All");
        }

        public HttpResponse Collection()
        {
            if (!this.User.IsAuthenticated)
            {
                return this.Redirect("/Users/Login");
            }
            var userId = this.User.Id;
            var viewModel = new AllPlayersViewModel
            {
                Players = this.playersService.GetAllFromCollection(userId)
                .Select(x => new PralyersViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    ImageUrl = x.ImageUrl,
                    Speed = x.Speed,
                    Endurance = x.Endurance,
                    Position = x.Position,
                    Description = x.Description,
                })
            };
            return this.View(viewModel);
        }

        public HttpResponse RemoveFromCollection(int playerId)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.Redirect("/Users/Login");
            }
            var userId = this.User.Id;

            var isRemoved = this.playersService.RemoveFromCollection(userId, playerId);
            return this.Redirect("/Players/Collection");
        }

        public HttpResponse AddToCollection(int playerId)
        {
            if (!this.User.IsAuthenticated)
            {
                return this.Redirect("/Users/Login");
            }
            var userId = this.User.Id;
            var usersPlayer = this.playersService.GetUserPlayer(userId, playerId);
            if (usersPlayer != null)
            {
                return this.Redirect("/Players/All");
            }

            this.playersService.AddPlayerToCollection(userId, playerId);
            return this.Redirect("/Players/All");
        }
    }
}
