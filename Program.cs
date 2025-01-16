
using PavoWebsiteDatabase.DatabaseConnect;
using PavoWebsiteDatabase.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<MenuRepository>();
builder.Services.AddScoped<HeaderSectionRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<PlatformHighlightsRepository>();
builder.Services.AddScoped<PageContentRepository>();
builder.Services.AddScoped<PageContentDetailRepository>();
builder.Services.AddScoped<SubscriptionDetailRepository>();
builder.Services.AddScoped<SubscriptionDescriptionListRepository>();
builder.Services.AddScoped<TestmonialRepository>();
builder.Services.AddScoped<ActivityMetricsRepository>();

builder.Services.AddControllers();
builder.Services.AddSingleton<DatabaseConnection>();
//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("RestrictedCorsPolicy", policy =>
    {
        policy.WithOrigins("http://localhost", "http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors("RestrictedCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();