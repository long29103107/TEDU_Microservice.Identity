using Serilog;
using TeduMicroservice.IDP.Extensions;
using TeduMicroservice.IDP.Persistence;

Log.Information("Starting up");
var builder = WebApplication.CreateBuilder(args);

try
{
    builder.Host.AddAppConfigurations();
    builder.Host.ConfigureSerilog();

    var app = builder
        .ConfigureServices()
        .ConfigurePipeline();


    SeedUserData.EnsureSeedData(builder.Configuration.GetConnectionString("IdentitySqlConnection"));
    app.MigrateDatabase()
        .Run();
}
catch (Exception ex)
{
    string type = ex.GetType().Name;
    if (type.Equals("StopTheHostException", StringComparison.Ordinal))
        throw;
    Log.Fatal(ex, "Unhanded exception");
}
finally
{
    Log.Information("Shut down Identity complete");
    Log.CloseAndFlush();
}