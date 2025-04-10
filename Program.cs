

namespace anh_ngoc_packaging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // AppConfig
            AppConfig.Init(builder.Configuration);

            // Register services with attributes
            var assembly = Assembly.GetExecutingAssembly();
            builder.Services.RegisterServicesWithAttributes(assembly);

            // Add AutoMapper
            builder.Services.AddAutoMapper(assembly);

            // Add Errors Defined
            ErrorCode.InitErrorDefine();

            // Add MongoDB
            builder.Services.AddSingleton<IMongoClient>(s =>
                new MongoClient()
            );
            builder.Services.AddWebOptimizer(pipeline =>
            {
                pipeline.AddFiles("text/css", "/css/*.css");
                pipeline.AddFiles("text/javascript", "/{js,lib,plugins}/*.js");
            });
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            //app.UseResponseCompression();
            app.UseAuthorization();
            app.UseWebOptimizer();
            app.UseStaticFiles();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Page}/{action=GetHomePage}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}