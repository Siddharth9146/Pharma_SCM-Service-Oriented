var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddXmlSerializerFormatters();
var app = builder.Build();

app.MapGet("/inventory", () =>
{
    return Results.Content(
        "<Inventory><Medicine>Paracetamol</Medicine><Stock>120</Stock></Inventory>",
        "application/xml");
});

app.Run();