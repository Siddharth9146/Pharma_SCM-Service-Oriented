using System.Text;

var xmlRequest = "<Request><Service>Inventory</Service></Request>";
var client = new HttpClient();
var response = await client.PostAsync("http://localhost:5004/route",
    new StringContent(xmlRequest, Encoding.UTF8, "application/xml"));
Console.WriteLine(await response.Content.ReadAsStringAsync());