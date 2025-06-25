var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient<OpenAIService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Symptom}/{action=Index}/{id?}");
app.Run();
