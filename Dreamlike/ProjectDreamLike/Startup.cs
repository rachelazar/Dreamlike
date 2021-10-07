using DreamLikeBL;
using DreamLikeDAL;
using DreamLikeDAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamLike
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<DreamlikeContext>(options => { options.UseSqlServer(
            Configuration.GetSection("ConnectionString")["DreamLikeConnection"]);
                options.UseLazyLoadingProxies();
            });

            services.AddScoped<IAgentBL, AgentBL>();
            services.AddScoped<IBlockedCategoryBL, BlockedCategoryBL>();
            services.AddScoped<ICategoryBL, CategoryBL>();
            services.AddScoped<ICityBL, CityBL>();
            services.AddScoped<ICouponBL, CouponBL>();
            services.AddScoped<IEventBL, EventBL>();
            services.AddScoped<IManagerBL, ManagerBL>();
            services.AddScoped<IProductBL, ProductBL>();
            services.AddScoped<ISelectedProductBL, SelectedProductBL>();
            services.AddScoped<IUserBL, UserBL>();
            services.AddScoped<ILoginBL, LoginBL>();
            services.AddScoped<IMailBL, MailBL>();

            services.AddScoped<IAgentDAL, AgentDAL>();
            services.AddScoped<IBlockedCategoryDAL, BlockedCategoryDAL>();
            services.AddScoped<ICategoryDAL, CategoryDAL>();
            services.AddScoped<ICityDAL, CityDAL>();
            services.AddScoped<ICouponDAL, CouponDAL>();
            services.AddScoped<IEventDAL, EventDAL>();
            services.AddScoped<IManagerDAL, ManagerDAL>();
            services.AddScoped<IProductDAL, ProductDAL>();
            services.AddScoped<ISelectedProductDAL, SelectedProductDAL>();
            services.AddScoped<IUserDAL, UserDAL>();
            services.AddScoped<ILoginDAL, LoginDAL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
