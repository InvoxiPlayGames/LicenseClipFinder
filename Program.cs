// See https://aka.ms/new-console-template for more information
using LicenseClipFinder;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

XmlSerializer licserializer = new XmlSerializer(typeof(License));
XmlSerializer sigserializer = new XmlSerializer(typeof(SignedLicense));


// REPLACE THIS PATH WITH YOUR OWN
foreach (string clipFile in Directory.EnumerateFiles(".\\Clips"))
{

    FileStream f = File.OpenRead(clipFile);
    License? license = (License)licserializer.Deserialize(f);
    SignedLicense? signedLicense = (SignedLicense)sigserializer.Deserialize(new MemoryStream(Convert.FromBase64String(license.SignedLicense)));
    CustomPolicies policies = JsonSerializer.Deserialize<CustomPolicies>(Encoding.UTF8.GetString(Convert.FromBase64String(signedLicense.SVLicense.CustomPolicies)));
    foreach(Package pkg in policies.packages)
    {
        string url = $"https://displaycatalog.mp.microsoft.com/v7.0/products?bigIds={pkg.productId}&market=US&languages=en-US,neutral&MS-CV=DGU1mcuYo0WMMp+F.1";
        string gameName = "Unknown Title";
        try
        {
            gameName = await GetGameNameAsync(url);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"!WARNING! Error while retrieving product name: {ex.Message}");
        }
        Console.WriteLine($"{clipFile} is for product: {gameName} ContentID: {pkg.packageIdentifier}");



    }
    f.Close();
}


static async Task<string> GetGameNameAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string jsonResponse = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(jsonResponse);

            // Navigate the JSON structure to get the game name
            var productTitle = "Unknown Title";
            try
            {
                productTitle = json["Products"]?[0]?["LocalizedProperties"]?[0]?["ProductTitle"]?.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"!WARNING! Error while retrieving product name: {ex.Message}");
            }
            return productTitle ?? "Unknown Title";
        }
        else
        {
            return $"Failed to retrieve data, status code: {response.StatusCode}";
        }
    }
}
