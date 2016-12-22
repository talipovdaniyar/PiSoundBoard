using PiSoundBoard.Api.Controllers;
using Restup.Webserver.Http;
using Restup.Webserver.Rest;

namespace PiSoundBoard.Api
{
    public static class ApiStartup
    {
        public static async void InitServer()
        {
            var restRouteHandler = new RestRouteHandler();
            restRouteHandler.RegisterController<SoundboardController>();

            var configuration = new HttpServerConfiguration()
              .ListenOnPort(8800)
              .RegisterRoute("api", restRouteHandler)
              .EnableCors();

            var httpServer = new HttpServer(configuration);
            await httpServer.StartServerAsync();
        }
    }
}
