using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace DemoServer
{
    public class StartUp
    {
        public void Configure(IApplicationBuilder app, IApplicationLifetime lifetime)
        {
            lifetime.ApplicationStarted.Register(() =>
                BrowserUtil.OpenBrowser("http://localhost:5000/?t=" + DateTime.Now.Ticks));
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}