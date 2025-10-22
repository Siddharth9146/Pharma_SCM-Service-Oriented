var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddXmlSerializerFormatters();
var app = builder.Build();

app.MapGet("/supplier", () =>
{
    return Results.Content(
        "<Supplier><Name>HealthCorp</Name><Rating>4.8</Rating></Supplier>",
        "application/xml");
});

app.Run();