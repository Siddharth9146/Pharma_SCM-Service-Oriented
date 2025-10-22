var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddXmlSerializerFormatters();
var app = builder.Build();

app.MapPost("/order", async (HttpContext context) =>
{
    var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
    Console.WriteLine("Received Order: " + body);
    return Results.Content("<OrderResponse>Status: Received</OrderResponse>", "application/xml");
});

app.Run();