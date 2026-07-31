using System;
using System.IO;
using DemoServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

const string webRoot = "demo";
var contentRoot = $"{Directory.GetCurrentDirectory()}";

var builder = WebApplication.CreateSlimBuilder(new WebApplicationOptions()
{
    ContentRootPath = contentRoot,
    WebRootPath = webRoot
});
// Clear all logging, since we don't need any.
builder.Logging.ClearProviders();
builder.WebHost.UseKestrel()
    .UseUrls("http://localhost:5000");

var url = "http://localhost:5000/?t=" + DateTime.Now.Ticks;
var app = builder.Build();
app.Lifetime.ApplicationStarted.Register(() => BrowserUtil.OpenBrowser(url));
app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions {
            ServeUnknownFileTypes = true,
            DefaultContentType = "application/octet-stream"
        });

Console.WriteLine($"Chrome should now open at '{url}'. If it doesn't, open the url manually in any browser.");
Console.WriteLine("Press Ctrl-C to exit");
await app.RunAsync();