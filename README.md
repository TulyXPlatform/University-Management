A **University Management System** built with **ASP.NET Core MVC** and **Entity Framework Core**.  
This project demonstrates how to build a real-world CRUD application using **MVC architecture**, database relationships, and modern .NET development practices.

The project is based on Microsoft's **Contoso University tutorial** and showcases core backend development skills using **C#, EF Core, and SQL Server**.

---

# 🚀 Features

✔ Student Management (Create, Edit, Delete, View)  
✔ Course Management  
✔ Instructor Management  
✔ Student Enrollment System  
✔ Department Management  
✔ Database Relationships using Entity Framework Core  
✔ Server-side Validation  
✔ Clean MVC Architecture  

---

# 🛠️ Technologies Used

| Technology | Description |
|-----------|-------------|
| ASP.NET Core MVC | Web application framework |
| C# | Programming language |
| Entity Framework Core | ORM for database operations |
| SQL Server | Relational database |
| Razor Views | Dynamic UI rendering |
| Bootstrap | Frontend styling |

---

# 📂 Project Structure


ContosoUniversity
│
├── Controllers

│ ├── StudentsController.cs

│ ├── CoursesController.cs

│ ├── InstructorsController.cs

│

├── Models

│ ├── Student.cs

│ ├── Course.cs

│ ├── Enrollment.cs

│ ├── Instructor.cs

│

├── Data

│ └── SchoolContext.cs

│

├── Views

│ ├── Students

│ ├── Courses

│ ├── Instructors

│

├── wwwroot

│ ├── css

│ ├── js

│ └── images

│

└── appsettings.json



# ⚙️ Installation & Setup

## 1️⃣ Clone the Repository

bash
git clone https://github.com/YOUR_USERNAME/contoso-university.git

2️⃣ Open the Project
Open the project in Visual Studio 2022 or later
Open the solution file:
ContosoUniversity.sln

3️⃣ Configure the Database
Edit the connection string inside:
appsettings.json
Example:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ContosoUniversity;Trusted_Connection=True;"
}
4️⃣ Apply Database Migration
Open Package Manager Console and run:
Update-Database
This will automatically create the required database tables.

5️⃣ Run the Application
Press:
Ctrl + F5
The project will start in your browser.

📚 Learning Outcomes

This project demonstrates:

ASP.NET Core MVC architecture
Entity Framework Core ORM usage
CRUD operations
Database relationships
Model validation
Razor view engine
Clean project structure

👩‍💻 Author

Tamima Mollick Tuly
📧 Email: tamima.web5202@gmail.com
💼 LinkedIn: https://www.linkedin.com/in/tamima-mollick-tuly/

📄 License

This project is created for learning and educational purposes following the Microsoft Contoso University tutorial.
![home-page](https://github.com/user-attachments/assets/5ccfa843-77d2-4ee2-b902-25e30c7e3f45)
![student-page](https://github.com/user-attachments/assets/8c4be76b-3fed-486d-9af5-6b8e6d654de9)
![course-page](https://github.com/user-attachments/assets/f4235784-eba9-4bb9-8b2a-9064ea63e095)
![department-page](https://github.com/user-attachments/assets/028929dc-dd39-4d01-8703-0d87fe0e3bb9)
![master-detailed-overview](https://github.com/user-attachments/assets/c480c962-8386-4f88-a9c0-01a9314bc403)
<img width="1920" height="1032" alt="instructor-page" src="https://github.com/user-attachments/assets/52ec1005-d1d7-4f80-946f-f797f5cd93b9" />



