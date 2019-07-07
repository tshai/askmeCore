using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using SignalRChat.Hubs;

using SignalRChat.Hubs;

namespace SignalRChat
{
    public class Startup
    {

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;


        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IHostingEnvironment>(env);
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.WithOrigins("https://www.nifgashot.com"));
            });
            services.AddMemoryCache();

            //services.AddCors(options => options.AddPolicy("AllowAllOrigins",
            //builder =>
            //{
            //    builder.AllowAnyOrigin();
            //}));

            //         options.AddPolicy("MyCorsPolicy",
            //builder => builder
            //   .SetIsOriginAllowedToAllowWildcardSubdomains()
            //   .WithOrigins("https://*.mydomain.com")
            //   .AllowAnyMethod()
            //   .AllowCredentials()
            //   .AllowAnyHeader()
            //   .Build()
            //);
            //services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseForwardedHeaders();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Error2");
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            // Shows UseCors with CorsPolicyBuilder.
            // Shows UseCors with named policy.
            //app.UseCors("MyCorsPolicy");
            app.UseCors("AllowSpecificOrigin");
            //app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //app.UseSignalR(routes =>
            //{
            //    routes.MapHub<ChatHub>("/chatHub");
            //});

            //app.UseSignalR(routes =>
            //{
            //    routes.MapHub<chatHub2>("/chatHub2");
            //});
            app.UseSignalR(routes =>
            {
                routes.MapHub<chatHub2019V2>("/ChatHub2019V2");
            });

            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}