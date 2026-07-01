using SmartDevApp.Interface;
using SmartDevApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddScoped<INotificationService, EmailService>();
builder.Services.AddScoped<INotificationService, SMSService>();
builder.Services.AddScoped<INotificationService, WhatsAppService>();
builder.Services.AddScoped<INotificationService, TelegramService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
