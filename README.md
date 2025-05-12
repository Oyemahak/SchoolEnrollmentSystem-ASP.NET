# 🏤 School Management System  
**A modern ASP.NET Core solution for educational administration**  

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-5.2.8-blue)
![EF Core](https://img.shields.io/badge/Entity_Framework-6.0.8-green)
![License](https://img.shields.io/badge/License-MIT-orange)

## 📋 Project Overview
**Problem Statement**: Manual school administration processes lead to enrollment errors and operational inefficiencies.  
**Solution**: An integrated web platform automating:
- Student registration & profile management  
- Course catalog and enrollment system  
- Administrative dashboard for oversight  

## 🛠 Tech Stack
| Component       | Technology |
|-----------------|------------|
| Frontend        | Razor Pages |
| Backend         | ASP.NET Core MVC |
| ORM             | Entity Framework Core 6 |
| Database        | SQL Server |
| Authentication  | ASP.NET Core Identity |
| Version Control | GitHub |

## 🗃 Repository Structure
```
/SchoolManagementSystem
├── Controllers/
│   ├── StudentsController.cs
│   ├── CoursesController.cs
├── Models/
│   ├── Student.cs
│   ├── Course.cs
│   └── Enrollment.cs
├── Migrations/
├── Views/
├── wwwroot/
└── appsettings.json
```

## 🚀 Key Features
```csharp
// Sample Model Relationship
public class Enrollment {
    [ForeignKey("Student")]
    public int StudentID { get; set; }
    
    [ForeignKey("Course")]
    public int CourseID { get; set; }
    
    public DateTime EnrollmentDate { get; set; }
}
```

✅ **Implemented**  
- CRUD operations for student/course management  
- Relational database with EF Core migrations  
- Responsive registration interface  

🔜 **Roadmap**  
- [ ] Role-based access control (Admin/Staff/Student)  
- [ ] Enrollment prerequisite validation  
- [ ] Automated report generation  

## 📚 Course Alignment
| Module | Applied Concepts |
|--------|------------------|
| 1      | Wireframing & ERD |
| 2      | EF Code-First Migrations | 
| 3      | LINQ Data Queries |
| 6      | Authentication |

## 📥 Installation
To run this project locally:

```bash
git clone https://github.com/[yourusername]/SchoolManagementSystem.git
cd SchoolManagementSystem
dotnet ef database update
dotnet run
```

Make sure you have:
- [.NET SDK](https://dotnet.microsoft.com/download)
- SQL Server (or LocalDB)
- EF CLI Tools (`dotnet tool install --global dotnet-ef`)

## 🆘 Support & Contact
For project guidance:  
📧 Email: [mahakpateluiux@gmail.com] 

---

*"This project fulfills requirements for HTTP-5226 Back-End Web Development 2 at Humber College"*
