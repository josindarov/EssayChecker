using EFxceptions;
using EssayChecker.API.Models.Essays;
using EssayChecker.API.Models.Feedbacks;
using EssayChecker.API.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace EssayChecker.API.Brokers.StorageBroker;

public partial class StorageBroker : EFxceptionsContext
{
    private readonly IConfiguration configuration;

    public StorageBroker(IConfiguration configuration)
    {
        this.configuration = configuration;
        this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = 
            configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureEssay(modelBuilder.Entity<Essay>());
        ConfigureFeedback(modelBuilder.Entity<Feedback>());
        ConfigureUser(modelBuilder.Entity<User>());
        base.OnModelCreating(modelBuilder);
    }
}