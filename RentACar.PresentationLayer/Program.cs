using AutoMapper;
using RentACar.BusinessLayer.Abstract;
using RentACar.BusinessLayer.Concrete;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.DataAccessLayer.Repositories;
using RentACar.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.Json;
using System.Text.Json.Serialization;
using RentACar.PresentationLayer.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RentACarContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<RentACarContext>().AddErrorDescriber<CustomIdentityValidator>();
builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IPriceService, PriceService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICarStatusService, CarStatusService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<ICarDetailService, CarDetailService>();
builder.Services.AddScoped<ICarFeatureService, CarFeatureService>();
builder.Services.AddScoped<IReviewService, ReviewService>();


builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new AuthorizeFilter());
}).AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/Login/Index");
    options.LogoutPath = new PathString("/Login/Logout");
});



builder.Services.AddAutoMapper(typeof(Program));

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
