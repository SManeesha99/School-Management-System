
# School Management System

This project is a **Windows Forms Application** developed in **C#** using **.NET Framework**. It enables the management of student data, including adding, editing, and viewing student records. The application uses a **SQL Server database** for data storage and supports functionalities like image uploads and date-based record management.

---

## Features

- **Student Management**:
  - Add new student records.
  - Edit existing student details.
  - View student data in a DataGridView.

- **Teachers Management**:
  - Add new teacher records.
  - Edit existing teacher details.
  - View teacher data in a DataGridView.

- **Image Handling**:
  - Upload and store student images and teachers image in a local directory.
  - Display student images and teachers image the application interface.

- **Database Integration**:
  - Uses SQL Server for storing and retrieving student and teachers data.
  - Implements parameterized queries to prevent SQL injection.

- **Error Handling**:
  - Comprehensive error messages for invalid input or database issues.

---

## Prerequisites

- **Software**:
  - Visual Studio 2022 or later
  - SQL Server
  - .NET Framework (version as per your project)

- **Dependencies**:
  - `System.Drawing.Common` (for image handling)
  - `System.Data.SqlClient` (for database connectivity)

---

## Installation

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/SManeesha99/School-Management-System.git
   ```

2. Open the project in Visual Studio.

3. Configure the database connection string in the `app.config` or directly in the code where `SqlConnection` is initialized:
   ```xml
   <connectionStrings>
       <add name="DefaultConnection" connectionString="YourConnectionStringHere" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. Build the project to restore NuGet dependencies.

5. Create the `students` table in your SQL Server database using the following schema:
   ```sql
   CREATE TABLE students (
      id INT PRIMARY KEY IDENTITY(1,1),
      student_id VARCHAR(MAX) NULL,
      student_name VARCHAR(MAX) NULL,
      student_gender VARCHAR(MAX) NULL,
      student_address VARCHAR(MAX) NULL,
      student_grade VARCHAR(MAX) NULL,
      student_section VARCHAR(MAX) NULL,
      student_image VARCHAR(MAX) NULL,
      student_status VARCHAR(MAX) NULL,
      data_insert DATE NULL,
      data_update DATE NULL,
      data_delete DATE NULL
   );
   ```
6. Create the `teachers` table in your SQL Server database using the following schema:
   ```sql
   CREATE TABLE teachers (
    id int PRIMARY KEY IDENTITY(1,1),
    teacher_id VARCHAR(MAX) NULL,
    teacher_name VARCHAR(MAX) NULL,
    teacher_gender VARCHAR(MAX) NULL,
    teacher_address VARCHAR(MAX) NULL,
    teacher_image VARCHAR(MAX) NULL,
    teacher_status VARCHAR(MAX) NULL,
    date_insert DATE NULL,
    date_update DATE NULL,
    date_delete DATE NULL
    );

   ```
7. Create the `students` table in your SQL Server database using the following schema:
   ```sql
   CREATE TABLE users (
      id INT PRIMARY KEY IDENTITY(1,1),
      username VARCHAR(MAX) NULL,
      password VARCHAR(MAX) NULL
    );
   ```

8. Run the application.
