using MenuSystemUI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Data + integration services
builder.Services.AddSingleton<IMenuDataService, SampleDataService>();
builder.Services.AddSingleton<CartService>();
builder.Services.AddSingleton<DatabaseService>();
builder.Services.AddSingleton<InventoryService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
