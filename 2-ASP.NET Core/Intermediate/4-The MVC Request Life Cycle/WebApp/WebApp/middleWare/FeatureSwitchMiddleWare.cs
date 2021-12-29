using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.middleWare
{
    public class FeatureSwitchMiddleWare
    {
        private readonly RequestDelegate _next;

        public FeatureSwitchMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext,IConfiguration config)
        {
            // if the request that i wrote when app is run contain features then : 
            if (httpContext.Request.Path.Value.Contains("/features"))
            {
                // go to appsetting to FeaturesSwitches
                var switches =config.GetSection("FeaturesSwitches");
                // splite content to key : value to print them
                var report = switches.GetChildren().Select(x => $"{x.Key} : {x.Value}");
                // print them in the screen 
                await httpContext.Response.WriteAsync(string.Join("\n", report));
            }
            else
            {
                await _next(httpContext);
            }
        }
    }
}
