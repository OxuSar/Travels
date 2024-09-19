using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

// Add services to the container.
        builder.Services.AddControllersWithViews()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

        builder.Services.AddRazorPages()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization();

        builder.Services.Configure<RequestLocalizationOptions>(options =>
        {
            var supportedCultures = new[]
            {
                new CultureInfo("uz"),
                new CultureInfo("ru")
            };

            options.DefaultRequestCulture = new RequestCulture("uz");
            options.SupportedCultures = supportedCultures;
            options.SupportedUICultures = supportedCultures;

            // Add custom request culture provider if needed
            options.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(async context =>
            {
                var culture = context.Request.Cookies["ui-culture"];
                var requestCulture = new RequestCulture(culture ?? "uz");
                return new ProviderCultureResult(requestCulture.Culture.Name, requestCulture.UICulture.Name);
            }));
        });

var app = builder.Build();

// Use Request Localization only once
app.UseRequestLocalization();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
