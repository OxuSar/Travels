using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Travel.Providers
{
    public  class CustomRequestCultureProvider : RequestCultureProvider
    {
        private readonly Func<HttpContext, Task<ProviderCultureResult>> _requestCultureProvider;

        public CustomRequestCultureProvider(Func<HttpContext, Task<ProviderCultureResult>> requestCultureProvider)
        {
            _requestCultureProvider = requestCultureProvider ?? throw new ArgumentNullException(nameof(requestCultureProvider));
        }

        public  override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            return _requestCultureProvider(context);
        }
    }
}
