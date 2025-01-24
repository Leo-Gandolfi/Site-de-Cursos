var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        // Define explicitamente o local das Views
        options.ViewLocationFormats.Add("/MinhasViews/{1}/{0}.cshtml");
        options.ViewLocationFormats.Add("/MinhasViews/Shared/{0}.cshtml");
    });

var app = builder.Build();

// Configura o pipeline de requisição HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
