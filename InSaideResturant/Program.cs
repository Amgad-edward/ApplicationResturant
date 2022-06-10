using InSaideResturant.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ModelData;
using ModelData.Models;
using ModelData.UnitWork;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Mvc;
using Blazored.Toast;
using System.Text.Json;
using System.Text.Json.Serialization;
using InSaideResturant.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddBlazoredSessionStorage(x=>x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddBlazoredToast();
builder.Services.AddSession(session =>
{
    session.Cookie.IsEssential = true;
});



builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("db"),
          new MariaDbServerVersion(new Version()), m => m.MigrationsAssembly("InSaideResturant")) ;
    options.EnableSensitiveDataLogging();
},ServiceLifetime.Transient,ServiceLifetime.Transient);



builder.Services.AddTransient<IUnitAll, UnitWoks<DataContext>>();

builder.Services.AddTransient<ServiceUpdate>();


builder.Services.Configure<JsonSerializerOptions>(builder =>
{
    builder.Converters.Add(new DateOnlyJsonConverter());
    builder.AllowTrailingCommas = true;
});


//builder.Services.AddMvc().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//});

//builder.Services.AddMvc(js => js.EnableEndpointRouting = false).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
//    .AddNewtonsoftJson(j => j.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
