﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.HealthChecks
{
    public class HomePageHealthCheck : IHealthCheck
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomePageHealthCheck(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string myUrl = _httpContextAccessor.HttpContext.Request.Host.ToString();
            var client = new HttpClient();
            var response = await client.GetAsync(myUrl);
            var pageContents = await response.Content.ReadAsStringAsync();
            if (pageContents.Contains(".NET Bot Black Sweatshirt"))
            {
                return HealthCheckResult.Healthy("The check indicates a healthy result.");
            }

            return HealthCheckResult.Unhealthy("The check indicates an unhealthy result.");
        }
    }
}