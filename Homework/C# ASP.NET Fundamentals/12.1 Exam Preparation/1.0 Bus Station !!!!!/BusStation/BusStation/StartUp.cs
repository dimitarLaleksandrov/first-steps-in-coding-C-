namespace BusStation
{
    using BasicWebServer.Server;
    using BasicWebServer.Server.Routing;
    using BusStation.Data;
    using System.Threading.Tasks;

    public class Startup
    {
        public static async Task Main()
        {
            var server = new HttpServer(routes => routes
               .MapControllers()
               .MapStaticFiles());

            server.ServiceCollection
                  .Add<BusStationDbContext>();
            await server.Start();
        }
    }
}