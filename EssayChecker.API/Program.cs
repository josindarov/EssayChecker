using EssayChecker.API.Brokers.StorageBroker;
using EssayChecker.API.Models.Feedbacks;
using EssayChecker.API.Services.Foundations.Essays;
using EssayChecker.API.Services.Foundations.Feedbacks;
using EssayChecker.API.Services.Foundations.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StorageBroker>();
builder.Services.AddTransient<IStorageBroker, StorageBroker>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IFeedbackService, FeedbackService>();
builder.Services.AddTransient<IEssayService, EssayService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();