using ProEventos.API;

var builder = WebApplication.CreateBuilder(args);

var Startup = new Startup (builder.Configuration);
Startup.ConfigureServices(builder.Services);

var app = builder.Build();

Startup.Configure(app, app.Environment);
app.Run();
