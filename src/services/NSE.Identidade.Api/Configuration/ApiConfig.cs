﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NSE.Identidade.Api.Configuration {
    public static class ApiConfig {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services) {
            services.AddControllers();

            return services;
        }

        public static IApplicationBuilder UserApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UserIdentityConfiguration();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}