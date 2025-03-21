using System.Collections.Generic;

namespace PersonalPage.Models
{
    public class CVModel
    {
        public PersonalInfo PersonalInfo { get; set; }
        public List<Education> Education { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Certifications { get; set; }
    }

    public class PersonalInfo
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
        public string ProfilePicture { get; set; }
        public string Summary { get; set; }
    }

    public class Education
    {
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string Field { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }

    public class WorkExperience
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }
        public List<string> Responsibilities { get; set; }
        public List<string> Achievements { get; set; }
    }

    public class Skill
    {
        public string Category { get; set; }
        public List<string> Items { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string GitHubUrl { get; set; }
        public string LiveUrl { get; set; }
        public string ImageUrl { get; set; }
    }
} 