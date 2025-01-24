
using PavoWebsiteDatabase.Handlers;
using PavoWebsiteDatabase.DatabaseConnect;
using PavoWebsiteDatabase.Repositories;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File(@"C:/logs/Log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();


Log.Information("welcome to Pavo!");
var builder = WebApplication.CreateBuilder(args);

builder.Logging
    .ClearProviders()
    .AddSimpleConsole()
    .AddDebug();

builder.Services.AddScoped<IMenuRepository, Repositories>();
builder.Services.AddScoped<MenuHandler>();
builder.Services.AddScoped<IHeaderSectionRepository, Repositories>();
builder.Services.AddScoped<HeaderSectionHandler>();
builder.Services.AddScoped<IUserRepository,Repositories>();
builder.Services.AddScoped<UserHandler>();
builder.Services.AddScoped<IPlatformHighlightsRepository,Repositories>();
builder.Services.AddScoped<PlatformHighlightsHandler>();
builder.Services.AddScoped<IPageContentRepository, Repositories>();
builder.Services.AddScoped<PageContentHandler>();
builder.Services.AddScoped<ISubscriptionDetailsRepository, Repositories>();
builder.Services.AddScoped<SubscriptionDetailHandler>();
builder.Services.AddScoped<ISubscriptionDescriptionListRepository, Repositories>();
builder.Services.AddScoped<SubscriptionDescriptionListHandler>();
builder.Services.AddScoped<ITestmonialRepository, Repositories>();
builder.Services.AddScoped<TestmonialHandler>();
builder.Services.AddScoped<IActivityMetricsRepository,Repositories>();
builder.Services.AddScoped<ActivityMetricsHandler>();
builder.Services.AddScoped<IFooterRepository,Repositories>();
builder.Services.AddScoped<FooterHandler>();



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