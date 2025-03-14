# 📝 LogService - Log Recording System

<p align="center">
  <img src="LogService_Icon.png" alt="LogService Icon" width="150">
</p>

## 📌 Project Description
**LogService** is a microservice written in **ASP.NET Core 8.0** that enables **saving, viewing, and filtering application logs**.

The application is fully containerized and runs in a **Docker** environment, allowing for easy deployment and scaling.  
Data is stored in **Microsoft SQL Server**, and the API interface is managed via **Swagger** and **Postman**.

---

## 🚀 **Technologies**
- **C# / .NET 8.0** - the main backend of the application
- **ASP.NET Core Web API** - REST API for log handling
- **Entity Framework Core 8.0** - ORM for database operations
- **MSSQL Server 2022** - database for storing logs
- **Docker & Docker Compose** - application containerization
- **Postman / Swagger** - API testing

---

## 📡 **Application Functionality**
1. **LogService** receives requests from other applications or systems, recording logs in the database.
2. Each log contains:
   - 📅 **Creation timestamp**
   - 📂 **Log level**
   - ✉️ **Log message**
   - 👤 **User generating the log (optional)**
   - ❗ **Exception details (if occurred)**
3. The API allows:
   - **Adding new logs** (`POST /api/logs`)
   - **Retrieving all logs** (`GET /api/logs`)
   - **Filtering logs** (by date, level, user)
   - **Exporting logs to JSON format**
4. **Swagger** enables interactive API testing.

---

## ⚙️ **Configuration and Setup**

### 1️⃣ **Cloning the Repository**
```bash
git clone https://github.com/Dominik99d14/LogService.git
cd LogService
```

---

## 📞 Contact

For any questions or suggestions, please contact:

<p align="left">
  <strong>Dominik Kowalczyk:</strong> <a href="mailto:dominik99d14@gmail.com">dominik99d14@gmail.com</a>
</p>
