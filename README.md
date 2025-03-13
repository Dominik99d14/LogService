# 📝 LogService - System Zapisujący i Przeglądający Logi

## 📌 Opis Projektu
**LogService** to mikroserwis API oparty na **ASP.NET Core 8.0**, który umożliwia zapisywanie i przeglądanie logów aplikacyjnych.  
Dane przechowywane są w **Microsoft SQL Server**, a całość działa w kontenerach Docker, co zapewnia łatwą konfigurację i deployment.

## 🚀 Technologie
- **C# / .NET 8.0** - główny backend aplikacji
- **ASP.NET Core Web API** - REST API do obsługi logów
- **Entity Framework Core 8.0** - ORM do operacji na bazie danych
- **MSSQL Server 2022** - baza danych dla logów
- **Docker & Docker Compose** - konteneryzacja aplikacji
- **Postman / Swagger** - testowanie API

---

## ⚙️ **Konfiguracja i Uruchomienie**

### 1️⃣ **Kluczowe Pliki**
- `docker-compose.yml` - definiuje wszystkie kontenery i ich konfiguracje
- `LogService/Dockerfile` - opisuje, jak budować obraz aplikacji
- `appsettings.json` - plik konfiguracyjny dla .NET, zawiera połączenie do bazy danych

### 2️⃣ **Wymagania**
🔹 **Zainstaluj:**
- [Docker](https://www.docker.com/get-started)
- [Git](https://git-scm.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (opcjonalnie, jeśli chcesz rozwijać kod)

### 3️⃣ **Klonowanie Repozytorium**
```bash
git clone https://github.com/Dominik99d14/LogService.git
cd LogService
