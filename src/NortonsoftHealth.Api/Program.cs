var builder = WebApplication.CreateBuilder(args);
var startupTime = DateTime.UtcNow;



// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "HelixCare API v1");
        c.RoutePrefix = "swagger";
    });
}

app.MapGet("/", () =>
{
    return Results.Ok("HelixCare API is running");
});

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        status = "Healthy",
        service = "HelixCare API",
        uptime = $"{(DateTime.UtcNow - startupTime).TotalSeconds:F2} seconds"
    });
});

var assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly()
    .GetCustomAttributes(typeof(System.Reflection.AssemblyInformationalVersionAttribute), false)
    .OfType<System.Reflection.AssemblyInformationalVersionAttribute>()
    .FirstOrDefault()?.InformationalVersion ?? "1.0.0";

// Split "1.0.0+build2026-05-22" into version and date
var parts = assemblyInfo.Split("+build");
var version = parts[0];
var buildDate = parts.Length > 1 ? parts[1] : "unknown";


app.MapGet("/api/version", () =>
{
    return Results.Ok(new VersionResponse(Version: version, BuildDate: buildDate));
});

app.Run();

record VersionResponse(string Version = "1.0.0",
                       string BuildDate = "22/05/2026",
                       string Description = "NortonSoft API for health monitoring and data management");