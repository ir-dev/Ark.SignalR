using Microsoft.AspNetCore.SignalR;

namespace Ark.SignalR
{
    public static class ArkSignalRExtn
    {
        public static void AddArkSignalR(this IServiceCollection services)
        {
            services.AddArkSignalR(new HubOptions() { EnableDetailedErrors = true });
        }
        public static void AddArkSignalR(this IServiceCollection services, HubOptions opts)
        {
            services
                .AddSignalR(opt =>
                {
                    opt = opts;
                })
                .AddNewtonsoftJsonProtocol(oo =>
                {
                    oo.PayloadSerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
            services.AddSingleton<SignalR.ArkSignalHub>();
        }
        public static void UseArkSignalR(this IApplicationBuilder app, string pattern)
        {
            app.UseArkSignalR<SignalR.ArkSignalHub>(pattern);
        }
        public static void UseArkSignalR<T>(this IApplicationBuilder app, string pattern) where T : Hub
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<T>($"/{pattern}");
            });
        }
    }
}
