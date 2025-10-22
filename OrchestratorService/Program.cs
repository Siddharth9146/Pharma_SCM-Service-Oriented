using System.Net.Http;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
var app = builder.Build();

app.MapPost("/route", async (HttpContext context, IHttpClientFactory clientFactory) =>
{
    var xml = await new StreamReader(context.Request.Body).ReadToEndAsync();
    var client = clientFactory.CreateClient();

    if (xml.Contains("Inventory"))
    {
        var res = await client.GetStringAsync("http://localhost:5001/inventory");
        return Results.Content(res, "application/xml");
    }
    else if (xml.Contains("Order"))
    {
        var res = await client.PostAsync("http://localhost:5002/order",
            new StringContent(xml, Encoding.UTF8, "application/xml"));
        return Results.Content(await res.Content.ReadAsStringAsync(), "application/xml");
    }
    else if (xml.Contains("Supplier"))
    {
        var res = await client.GetStringAsync("http://localhost:5003/supplier");
        return Results.Content(res, "application/xml");
    }

    return Results.Content("<Error>Unknown Service</Error>", "application/xml");
});

app.Run();