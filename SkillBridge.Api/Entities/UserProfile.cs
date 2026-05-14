using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;

public class UserProfile
{
    [Required, Key]
    public int Id {get; set;}
    [Required]
    public Users User {get; set;}
    [Required]
    public string FullName{get; set;}
    [Required]
    public string SkillSet{get; set;}
    [Required]
    public string Education{get;set;}
    [Required]
    public string Experiecnces{get; set;}
    [Required]
    public string ResumePath{get; set; }
    public string LinkedInProfile{get;set;}

    public string GitHubProfile{get; set;}
    [Required]
    public string Bio{get; set;}
    [Required]
    public string Location{get;set;}
    [Required]
    public string ContactNumber{get; set;}
}