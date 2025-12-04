using MenuSystemUI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Data + integration services
builder.Services.AddSingleton<IMenuDataService, SampleDataService>();
builder.Services.AddSingleton<CartService>();
builder.Services.AddSingleton<DatabaseService>();
builder.Services.AddSingleton<InventoryService>();
//for transaction
/*
 if transaction team server is 10.0.0.25
  client.BaseAddress = new Uri("http://10.0.0.25:23500");
    or hostname
client.BaseAddress = new Uri("http://transactionhostname:23500");

 */
builder.Services.AddHttpClient<TransactionService>(client =>
{
    client.BaseAddress = new Uri("http://<TRANSACTION_TEAM_IP>:23500");
});

//for transaction
/*
 if transaction team server is 10.0.0.25
  client.BaseAddress = new Uri("http://10.0.0.25:23500");
    or hostname
client.BaseAddress = new Uri("http://transactionhostname:23500");

 */
builder.Services.AddHttpClient<TransactionService>(client =>
{
    client.BaseAddress = new Uri("http://<TRANSACTION_TEAM_IP>:23500");
});


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
