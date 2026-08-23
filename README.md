#  WinForms SQL Select App

A simple Windows Forms application built with **C#** and **SQL Server** that demonstrates database connectivity and data retrieval using a clean GUI.

---

##  Features

-  Connects to a SQL Server database
-  Displays data using `DataGridView`
-  Select and view records from a table
-  Simple and beginner-friendly architecture 
-  Built with Windows Forms (WinForms)

---
## Database
###  Main Tables:
- EnergySite
- PowerUnit
- Technician
- Inspection
- InspectionDetails
- Certification
- WarehouseLog

### Relationships:
- Energy sites contain multiple power units  
- Technicians perform inspections  
- Each inspection tracks power unit performance  
- Warehouse logs store inspection-related unit records
  
###  Setup
1. Open SQL Server Management Studio (SSMS)
2. Run the script found in:

`/database/EnergyGrid_Schema.sql`

3. Update your WinForms connection string:

```csharp
string connectionString = "Server=YOUR_SERVER;Database=EnergyGrid;Trusted_Connection=True;";
```

##  Tech Stack

- C# (.NET Framework / .NET WinForms)
- SQL Server
- SQL
- ADO.NET (`System.Data.SqlClient`)
- Visual Studio

---

##  Preview

<img width="598" height="393" alt="Untitled" src="https://github.com/user-attachments/assets/1f0e7e21-4668-459b-8e95-c25533a771ec" />
<img width="595" height="390" alt="Untitled" src="https://github.com/user-attachments/assets/4f588d03-8182-4ac7-b52e-be02165878ba" />

---

##  How It Works
1. The app connects to a SQL Server database
2. A SQL query is executed to fetch data from tables
3. Results are displayed inside a DataGridView
4. Users can view database records through the UI

-------

##  Getting Started

### 1. Clone the repo
```bash
git clone https://github.com/your-username/winforms-sql-select-app.git
```
2. Open in Visual Studio
Open the `.sln` file
3. Setup Database
Run `EnergyGrid_Schema.sql` in SSMS
Ensure SQL Server is running
4. Run the project

-------
## Author

Built as part of a C# + SQL Server learning project focusing on:
- Database connectivity  
- WinForms UI development  
- SQL schema design and implementation
---
