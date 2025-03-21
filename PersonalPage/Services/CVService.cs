using PersonalPage.Models;
using System.Collections.Generic;

namespace PersonalPage.Services
{
    public class CVService
    {
        public CVModel GetCV()
        {
            // This is a sample CV data. Replace with your own information.
            return new CVModel
            {
                PersonalInfo = new PersonalInfo
                {
                    FullName = "Daniel Antunes de Almeida",
                    Title = "Software Developer",
                    Email = "daniel.antunes@gmail.com",
                    Phone = "+5522998215522",
                    Location = "Rio de Janeiro, Brazil",
                    LinkedInUrl = "https://www.linkedin.com/in/daniel-de-almeida-a75225207/",
                    GitHubUrl = "https://github.com/dan-dealmeida",
                    ProfilePicture = "images/profile.jpg",
                    Summary = "Passionate software developer with expertise in .NET, web technologies, and Agentic AI."
                },
                Education = new List<Education>
                {
                    new Education
                    {
                        Institution = "UTFPR",
                        Degree = "Bachelor's Degree",
                        Field = "Software Engineering",
                        StartDate = "2020",
                        EndDate = "2025",
                        Location = "Cornélio Procópio, PR",
                        Description = "Relevant coursework in software engineering, algorithms, and database systems."
                    }
                },
                WorkExperience = new List<WorkExperience>
                {
                    new WorkExperience
                    {
                        Company = "Norion",
                        Position = "Software Developent Intern",
                        StartDate = "2024",
                        EndDate = "Present",
                        Location = "Florianópolis, SC",
                        Responsibilities = new List<string>
                        {
                            "Developed and maintained web applications using .NET Core and React",
                            "Implemented RESTful APIs and microservices",
                            "Collaborated with cross-functional teams to deliver high-quality software"
                        },
                        Achievements = new List<string>
                        {
                            "Reduced application load time by 40%",
                            "Implemented automated testing that improved code coverage by 25%"
                        }
                    },
                    new WorkExperience
                    {
                        Company = "Neo",
                        Position = "Software Developent Intern",
                        StartDate = "2024",
                        EndDate = "2024",
                        Location = "Ciudad del Este, PY",
                        Responsibilities = new List<string>
                        {
                            "Developed and maintained web applications using .NET Core",
                            "Implemented RESTful APIs and microservices",
                            "Collaborated with my team to deliver high-quality software"
                        },
                        Achievements = new List<string>
                        {
                            "Reduced application load time by 40%",
                            "Implemented automated testing that improved code coverage by 25%"
                        }
                    }
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Category = "Programming Languages",
                        Items = new List<string> { "C#", "JavaScript", "Python", "SQL" }
                    },
                    new Skill
                    {
                        Category = "Frameworks & Tools",
                        Items = new List<string> { ".NET Core", "React", "Azure", "Git" }
                    }
                },
                Projects = new List<Project>
                {
                    // ... existing code ...
                    new Project
                    {
                        Name = "realEstate-API",
                        Description = "An API where users can favorite their realEstates and Schedule visits",
                        Technologies = new List<string> { "JavaScript" },
                        GitHubUrl = "https://github.com/dan-dealmeida/realEstate-API",
                        ImageUrl = "/images/realestate.jpg"
                    },
                    new Project
                    {
                        Name = "KNN-Iris",
                        Description = "KNN algorithm for classification of different Iris species based on height and width of petals and width of sepal",
                        Technologies = new List<string> { "Java" },
                        GitHubUrl = "https://github.com/dan-dealmeida/KNN-Iris",
                        ImageUrl = "/images/knn.jpg"
                    },
                    new Project
                    {
                        Name = "Satisfying.you",
                        Description = "A mobile application compatible with Android/iOS for conducting corporate client/user surveys",
                        Technologies = new List<string> { "JavaScript" },
                        GitHubUrl = "https://github.com/dan-dealmeida/Satisfying.you",
                        ImageUrl = "/images/survey.jpg"
                    },
                    new Project
                    {
                        Name = "Movivy",
                        Description = "Movivy is a java application that allows users to manage their favorite films, studios and actors",
                        Technologies = new List<string> { "Java" },
                        GitHubUrl = "https://github.com/dan-dealmeida/movivy",
                        ImageUrl = "/images/movivy.jpg"
                    },
                    new Project
                    {
                        Name = "VaicaiSorvetes",
                        Description = "A back and frontend application similar to iFood, but exclusively for ice cream",
                        Technologies = new List<string> { "TypeScript" },
                        GitHubUrl = "https://github.com/inteiros/VaicaiSorvetes",
                        ImageUrl = "/images/acai.jpg"
                    },
                    new Project
                    {
                        Name = "MyHealth",
                        Description = "Easy to use webapp to keep track of your vaccines",
                        Technologies = new List<string> { "HTML" },
                        GitHubUrl = "https://github.com/yourusername/MyHealth",
                        ImageUrl = "/images/vaccine.jpg"
                    }
                },
                Languages = new List<string> { "English (Native)", "Portuguese (Native)", "Spanish (Intermediate)", "French (Basic)" },
                Certifications = new List<string>
                {
                    "Microsoft Certified: Azure Developer Associate",
                    "AWS Certified Developer – Associate"
                }
            };
        }
    }
} 