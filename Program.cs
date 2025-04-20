using PromptBotBlazor.Components;
using PromptBotBlazor.Services;

namespace PromptBotBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // تسجيل MLService مع التحقق من الإعدادات
            builder.Services.AddScoped<MLService>(); 
           

            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            else
            {
                
                app.Use(async (context, next) =>
                {
                    var mlService = context.RequestServices.GetService<MLService>();
                    Console.WriteLine($"Model condition: {(mlService?.IsModelReady() ?? false ?" Ready" : "Not ready")}");
                    await next();
                });
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}