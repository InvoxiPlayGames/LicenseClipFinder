// See https://aka.ms/new-console-template for more information
using LicenseClipFinder;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

XmlSerializer licserializer = new XmlSerializer(typeof(License));
XmlSerializer sigserializer = new XmlSerializer(typeof(SignedLicense));

// REPLACE THIS PATH WITH YOUR OWN
foreach (string clipFile in Directory.EnumerateFiles("C:\\Users\\Emma\\Documents\\XboxOneClips"))
{
    FileStream f = File.OpenRead(clipFile);
    License? license = (License)licserializer.Deserialize(f);
    SignedLicense? signedLicense = (SignedLicense)sigserializer.Deserialize(new MemoryStream(Convert.FromBase64String(license.SignedLicense)));
    CustomPolicies policies = JsonSerializer.Deserialize<CustomPolicies>(Encoding.UTF8.GetString(Convert.FromBase64String(signedLicense.SVLicense.CustomPolicies)));
    foreach(Package pkg in policies.packages)
    {
        Console.WriteLine(clipFile + " is for product: " + pkg.productId);
    }
    f.Close();
}
