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
- Microsoft Visual Studio
- Microsoft SQL Server 2022
- SQL Server Management Studio (SSMS)
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
d run the project.
🚀 Features
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

🎓 Academic Project
This project was developed as a university course project for demonstrating:
C# Windows Forms Development
SQL Server Database Integration
CRUD Operations
Role-Based Access Control
Database Relationships
Management System Development

👨‍💻 Developer
Tashin Islam
CSE Student
American International University-Bangladesh (AIUB)

Screenshots of Projects:

<img width="522" height="472" alt="add_new_user" src="https://github.com/user-attachments/assets/87cd305e-cbc7-4dfe-a847-e6b541bd2081" />

<img width="981" height="538" alt="user_management" src="https://github.com/user-attachments/assets/f82049c9-a558-4664-8ee3-461132ba6a79" />

<img width="642" height="467" alt="update_user_form" src="https://github.com/user-attachments/assets/2713858d-2e93-4c4f-a7c7-45b318c68f06" />

<img width="636" height="392" alt="transaction_history" src="https://github.com/user-attachments/assets/ad492a56-87bb-463a-afeb-575e3e53ffed" />

<img width="642" height="458" alt="Toll_setup" src="https://github.com/user-attachments/assets/a0ffc89f-0dbb-4251-9cc0-c12c04663351" />

<img width="790" height="546" alt="Reports" src="https://github.com/user-attachments/assets/8f0a181e-484e-415f-b641-bbec4198eeec" />

<img width="752" height="475" alt="operator dashboard" src="https://github.com/user-attachments/assets/7e479704-ae27-4f48-809b-f06334a4db05" />

<img width="701" height="467" alt="new_toll_transaction" src="https://github.com/user-attachments/assets/7984870c-7a47-4624-a98d-24c551a10c3a" />

<img width="790" height="515" alt="login" src="https://github.com/user-attachments/assets/20a7c1b1-7698-4e21-a3c1-e5f4211f22c1" />

<img width="642" height="397" alt="admin_transaction_management" src="https://github.com/user-attachments/assets/b3cfc895-9b67-4e71-9f80-33b566558a71" />

<img width="788" height="506" alt="admin_dashboard" src="https://github.com/user-attachments/assets/a2884c3a-ecb9-47b1-82a4-bbc0dec8e682" />




