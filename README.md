# 🚗 Toll Plaza Management System

A Windows Forms based Toll Plaza Management System developed using C# and Microsoft SQL Server.

## 📌 Project Overview

The Toll Plaza Management System is designed to digitally manage toll plaza operations. The system provides role-based access for administrators and operators.

Administrators can manage users, toll plazas, toll booths, vehicle categories, toll rates, and view reports.

Operators can process and manage toll transactions.

---

## 🛠️ Technologies Used

- C#
- .NET Windows Forms
- Microsoft Visual Studio(there is already uploaded .exe file to install exactly vs )
- Microsoft SQL Server 2022(already uploaded .exe file to install exactly sql server)
- SQL Server Management Studio (SSMS) (uploaded .exe file to install exactly ssms)
- Microsoft.Data.SqlClient

---

# 👥 User Roles

## 👨‍💼 Administrator

The Administrator can:

- Manage Users
- Manage Toll Plazas
- Manage Toll Booths
- Manage Vehicle Categories
- Manage Toll Rates
- View Toll Transactions
- View Reports

---

## 👨‍🔧 Operator

The Operator can:

- Access the Operator Dashboard
- Process Toll Transactions
- Select Toll Plaza
- Select Toll Booth
- Select Vehicle Category
- Enter Vehicle Number
- Select Payment Method
- Complete Toll Transactions

---

# 📊 Database Tables

The database contains the following main tables:

- Users
- TollPlazas
- TollBooths
- VehicleCategories
- Vehicles
- TollRates
- TollTransactions
- UserActivities

---

# 🔗 Database Relationships

- One Toll Plaza can have multiple Toll Booths.
- One Toll Plaza can have multiple Toll Rates.
- One Vehicle Category can have multiple Vehicles.
- One Vehicle Category can have multiple Toll Rates.
- One Vehicle can have multiple Toll Transactions.
- One Toll Booth can process multiple Toll Transactions.
- One Operator can process multiple Toll Transactions.

---

# 🗄️ Database Setup

1. Open Microsoft SQL Server Management Studio.
2. Create or connect to your SQL Server.
3. Restore the database backup file:

```text
Database/TollPlazaDB.bak
#  Update the SQL Server connection string in:
DatabaseHelper.cs
## MOST IMPORTANT HOW TO OPEN THIS [[PROJECT]] ##
From the uploaded files OPEN;
TollPlazaManagementSystem.slnx
Build & Run this Project

## 🚀 Features
Role-Based Login System
Admin Dashboard
Operator Dashboard
User Management
Toll Plaza Management
Toll Booth Management
Vehicle Category Management
Toll Rate Management
Toll Transaction Processing
Payment Method Management
Transaction Reports
Database Integration

# 🎓 Academic Project
This project was developed as a university course project for demonstrating:
C# Windows Forms Development
SQL Server Database Integration
CRUD Operations
Role-Based Access Control
Database Relationships
Management System Development

# 👨‍💻 Developer
Tashin Islam
CSE Student
American International University-Bangladesh (AIUB)

Screenshots of Projects:

<img width="987" height="537" alt="image" src="https://github.com/user-attachments/assets/4d3c5c6d-3bd5-413d-886e-0f8458bdc192" />




