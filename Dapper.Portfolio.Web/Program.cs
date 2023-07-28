using Autofac;
using AutoMapper;
using Dapper.Portfolio.Application.Mapping;
using Dapper.Portfolio.Application.Services;
using Dapper.Portfolio.Domain.Repository;
using Dapper.Portfolio.Infrastructure;
using Dapper.Portfolio.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});
builder.Services.AddSingleton(config.CreateMapper());

builder.Services.AddScoped<ISkillAppService, SkillAppService>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();

builder.Services.AddScoped<IInfoRepository, InfoRepository>();
builder.Services.AddScoped<IInfoAppService, InfoAppService>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceAppService, ServiceAppService>();

builder.Services.AddScoped<ITestimonailRepository, TestimonialRepository>();
builder.Services.AddScoped<ITestimonialAppService, TestimonialAppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
