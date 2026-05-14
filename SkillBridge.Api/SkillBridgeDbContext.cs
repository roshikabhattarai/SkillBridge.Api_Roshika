using Microsoft.EntityFrameworkCore;
using SkillBridge.Api.Entities;

public class SkillBridgeDbContext : DbContext
{
    public SkillBridgeDbContext(DbContextOptions<SkillBridgeDbContext>options) : base(options)
    {
        
    }
    public DbSet<Users> Users {get; set; } 
    public DbSet<Job> Jobs {get;set;}
    public DbSet<JobApplication> JobApplications {get; set;}
    public DbSet<UserProfile> UserProfiles {get;set;}
}