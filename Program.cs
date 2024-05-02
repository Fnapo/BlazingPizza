using BlazingPizza.Data;
using BlazingPizza.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<EstadoOrden>();

// Register the pizzas service
builder.Services.AddSingleton<PizzaService>();
builder.Services.AddHttpClient();
builder.Services.AddSqlServer<PizzaStoreContext>(@"Server=PACO2015\SQLEXPRESS;Database=Pizza;Trusted_Connection=True;TrustServerCertificate=true;");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
    if (db.Database.EnsureCreated())
    {
        SemillaData.Initialize(db);
    }
}

app.Run();
