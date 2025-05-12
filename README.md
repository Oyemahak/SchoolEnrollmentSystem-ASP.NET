# 🏤 School Enrollment System  
**A modern ASP.NET Core solution for educational administration**  

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
