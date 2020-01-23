using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RoutingSample
{
    public class StartupRegex
    {

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            /* 
           // Using an inline-constraint to specify a regex constraint.

            #region snippet
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("{message:regex(^\\d{{3}}-\\d{{2}}-\\d{{4}}$)}",
                    context => { ... });

             });
            #endregion
         */

        }
    }
}