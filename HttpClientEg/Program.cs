using StocksApp;
using StocksApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();
builder.Services.AddScoped<FinnhubService>();
builder.Services.Configure<IpoCalender>(builder.Configuration.GetSection(nameof(IpoCalender))); 
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
