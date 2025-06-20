# 🏫 School Enrollment System – Passion Project  
**HTTP-5226 – Back-End Web Development 2 | Humber College**  
**Created by: Mahak Patel**

---

## 📌 Project Summary  

This project is my final **Passion Project** submission for HTTP-5226. It reflects my interest in educational platforms and demonstrates my ability to build a fully functioning **Content Management System (CMS)** using **ASP.NET Core MVC**, **Entity Framework**, and **SQL Server**.

The platform enables **administrators** to:  
- Register students  
- Manage courses  
- Enroll students into courses  
- Authenticate securely using ASP.NET Identity

---

## ✅ How This Project Meets the Course Requirements

### 🧠 **Project Plan & Design**  
- ✅ Chose a passion topic: **School enrollment & academic management**
- ✅ Designed an ERD with:
  - A **1-M** relationship: Student → Enrollment  
  - A **M-M** relationship: Student ↔ Course via Enrollment table  
- ✅ Created wireframes in **Figma** from the Admin’s perspective  
  🔗 [Figma Prototype](https://www.figma.com/design/OMwiLp38P8gZ9rpAl6btOy/School-Enrollment-System---ASP.Net?node-id=1-2&t=taYVwHVF3I8MCMdB-1)

---

### 🔧 **Minimum Viable Product (MVP)**  
- ✅ **Code-First** database using **EF Core Migrations**
- ✅ Used **LINQ** for all CRUD operations  
- ✅ Set up **ASP.NET Core Identity** for login/register  
- ✅ Built **MVC architecture** with strong separation of concerns  
- ✅ CRUD features implemented for:
  - Students  
  - Courses  
  - Enrollments  
- ✅ All views follow semantic HTML, Bootstrap styling, and layout structure  

---

### 📡 **RESTful API + Swagger Integration**
- ✅ Created full REST API for Students, Courses, and Enrollments
- ✅ All endpoints tested using Swagger UI
- ✅ Implemented Data Transfer Objects (DTOs) to return clean, secure JSON responses
- ✅ API grouped using ASP.NET Core route conventions
- ✅ Link to Swagger Portal: [API Documentation](https://localhost:7188/swagger/index.html)

---

### 🧪 **Testing & Final Deliverables**  
- ✅ Project builds successfully and runs on local server  
- ✅ All models, controllers, and views work as expected  
- ✅ Navigation is integrated across layout for full flow  
- ✅ README and GitHub structure follow professional standards  
- ✅ Created and verified migrations using Package Manager Console 

---

### 🔐 **Privacy Policy**
- ✅ Added `/Home/Privacy` page with clear data usage policy
- ✅ Communicates security, data scope, and terms of use
- ✅ Linked through default site layout

---

## 💻 Technologies Used  

| Area              | Technology                     |
|-------------------|--------------------------------|
| Framework         | ASP.NET Core MVC (.NET 8)      |
| ORM               | Entity Framework Core          |
| Authentication    | ASP.NET Core Identity          |
| Database          | SQL Server LocalDB             |
| Frontend Styling  | Bootstrap                      |
| IDE               | Visual Studio 2022             |
| Design Tool       | Figma                          |
| Version Control   | Git & GitHub                   |

---

## 🗂️ Folder Structure
```
SchoolManagementSystem/
├── Controllers/
│ ├── StudentsController.cs
│ ├── CoursesController.cs
│ └── EnrollmentsController.cs
├── Models/
│ ├── Student.cs
│ ├── Course.cs
│ └── Enrollment.cs
├── Data/
│ └── AppDbContext.cs
├── Views/
│ ├── Students/
│ ├── Courses/
│ ├── Enrollments/
│ └── Shared/_Layout.cshtml
├── wwwroot/
├── appsettings.json
└── Program.cs
```

---

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
- Visual Studio 2022 or later
- SQL Server (or LocalDB)
- EF CLI Tools (`dotnet tool install --global dotnet-ef`)

##📊 Future Enhancements
- Role-Based Access (Admin, Staff, Students)
- Pre-requisite Validation for Courses
- Reports Export (CSV/PDF)
- Email Notifications (SMTP Integration)

---

##📎 Evidence of Functionality & Screenshots
[🔗 View PDF Evidence on Google Drive](https://drive.google.com/file/d/1xsT_9PjQwyuu3VKfOwUK2IC7f-cnK-8_/view?usp=drive_link)

---

## 🆘 Support & Contact
For any feedback or clarifications:
📧 Email: [mahakpateluiux@gmail.com] 

---

*"This project demonstrates a complete school CMS built from scratch using ASP.NET Core MVC, EF Core, Identity, and RESTful APIs — meeting and exceeding all HTTP-5226 Passion Project requirements."*