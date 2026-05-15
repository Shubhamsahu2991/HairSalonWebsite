# 🌟 Hair Salon Website – Full Stack Development

A comprehensive full-stack Hair Salon web application built with **ASP.NET Core 8 MVC**, **SQL Server**, and **Entity Framework Core**.

## 📋 Table of Contents
- [Tech Stack](#tech-stack)
- [Features](#features)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Database Setup](#database-setup)
- [Authentication](#authentication)

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|------------|
| **Backend** | ASP.NET Core 8 (MVC + Web API) |
| **Database** | SQL Server, Entity Framework Core 8 |
| **Frontend** | Razor Views, Bootstrap 5, Custom CSS |
| **Authentication** | ASP.NET Core Identity |
| **Architecture** | Repository Pattern, Service Layer |

---

## ✨ Features

### 👤 Customer Portal
- **Home Page** – Hero banner, featured services & products, testimonials
- **Services Page** – Browse services, filter by category, availability badge
- **Booking System** – Select service → staff → date/time, real-time slot availability
- **Products Page** – Browse products, filter by category & price range
- **Shopping Cart** – Add/remove items, quantity management, checkout
- **My Account** – Profile, booking history, order history
- **Email Notifications** – Booking confirmations

### 🔧 Admin Panel
- **Dashboard** – Stats, revenue overview, pending orders
- **Service Management** – CRUD operations with image upload
- **Product Management** – CRUD with stock tracking
- **Booking Management** – View, confirm, or cancel appointments
- **Order Management** – Update order status (Pending → Processing → Shipped → Delivered)
- **Staff Management** – Add/edit staff members
- **User Management** – View all registered customers

---

## 📁 Project Structure

```
HairSalonWebsite/
├── HairSalon.Core/                 # Core domain models
├── HairSalon.Data/                 # Data access layer
├── HairSalon.Service/              # Business logic layer
├── HairSalon.Web/                  # MVC web application
└── README.md
```

---

## 🚀 Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server 2019 or later
- Visual Studio 2022 or VS Code

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/Shubhamsahu2991/HairSalonWebsite.git
cd HairSalonWebsite
```

2. **Configure Database Connection**
Update `appsettings.json` in `HairSalon.Web`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=HairSalonDB;Trusted_Connection=true;TrustServerCertificate=true;"
  }
}
```

3. **Restore NuGet Packages**
```bash
dotnet restore
```

4. **Apply Database Migrations**
```bash
cd HairSalon.Web
dotnet ef database update --project ../HairSalon.Data
```

5. **Run the Application**
```bash
dotnet run
```

The application will be available at `https://localhost:5001`

---

## 🗄️ Database Setup

### Initial Admin User
- **Email:** admin@hairsalon.com
- **Password:** Admin@123456
- **Role:** Admin

### Sample Data
The application seeds:
- 1 Admin user
- 5+ Services (Hair Cut, Coloring, Treatment, etc.)
- 10+ Products
- 5 Staff members
- Time slots for appointments

---

## 🔐 Authentication & Authorization

### Roles
- **Admin** – Access to admin panel, all management features
- **Customer** – Access to customer portal, booking, shopping

---

## 🎨 UI/UX

- **Color Scheme:** Rose Gold (#B76E79), Black (#1a1a1a), Cream White (#FFF8F3)
- **Typography:** Playfair Display (headings) + Lato (body)
- **Responsive:** Mobile-first Bootstrap 5 design
- **Animations:** Smooth CSS transitions & hover effects
- **Components:** Toast notifications, loading spinners, cards

---

## 📝 License

This project is licensed under the MIT License.

---

## 👨‍💻 Author

**Shubham Sahu**

---

## 🤝 Contributing

Contributions are welcome! Please follow the existing code structure and conventions.
