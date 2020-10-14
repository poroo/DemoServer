using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace DemoServer
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
            
            lifetime.ApplicationStarted.Register(() =>
                BrowserUtil.OpenBrowser("http://localhost:5000/?t=" + DateTime.Now.Ticks));
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}