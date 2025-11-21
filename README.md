Event Registration Form (VB.NET & SQLite)

This repository contains the source code for a fully functional Event Registration application built using Visual Basic .NET (VB.NET) Windows Forms, featuring robust input validation and SQLite database integration.

🚀 Project Link

You can view the source code here:
https://github.com/WillySon254/Event-Registration-Form.git

📋 Prerequisites

To successfully clone, build, and run this project, you will need:

Visual Studio IDE: Visual Studio 2022 (or a recent version) with the ".NET desktop development" workload installed.

Git: Installed on your system for cloning the repository.

⬇️ Setup and Installation

Follow these steps to clone the repository and open the project in Visual Studio.

1. Clone the Repository

Open your Git client (or the Command Prompt/Terminal) and run the following command:

git clone [https://github.com/WillySon254/Event-Registration-Form.git](https://github.com/WillySon254/Event-Registration-Form.git)


2. Open the Project

Open Visual Studio.

Go to File > Open > Project/Solution...

Navigate to the folder you just cloned (Event-Registration-Form).

Select the .sln (Solution) file and open it.

3. Restore NuGet Packages

This project relies on the System.Data.SQLite package for database connectivity. Visual Studio should automatically restore this package, but if you encounter any errors related to SQLite:

In Visual Studio, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution...

Go to the Installed tab and ensure System.Data.SQLite.Core is present. If not, go to the Browse tab and install it for the project.

▶️ Running the Application

Once the project is loaded and packages are restored:

Ensure Form1.vb is the startup object (it usually is by default).

Press F5 or click the Start button (green arrow) in Visual Studio to run the application in Debug mode.

💾 Database and Data Storage

The application uses an SQLite database, which is self-contained in a single file:

Database File: RegistrationDB.sqlite

Location: This file is created automatically upon first run in the project's output directory (usually \bin\Debug\).

Table: All registered data is stored in the Registrations table.

Viewing the Data

To view the collected data, you will need a free SQLite viewer:

Download and install DB Browser for SQLite or a similar tool.

After running the application at least once, open the viewer and use it to browse to the RegistrationDB.sqlite file in the bin\Debug folder.

✅ Core Features

Feature

Description

Implementation

Unique ID Generation

Automatically generates sequential registration IDs (e.g., REG001, REG002).

GetNextRegistrationID() function in DBHelper.vb.

Name Validation

Mandatory and uses Regex to enforce text-only input (no numbers).

btnRegister_Click (Check A).

Email Validation

Mandatory and checks for both the @ and . symbols to ensure a basic domain format.

btnRegister_Click (Check B).

Phone Validation

Mandatory, Regex for format, and checks for a minimum of 10 digits after removing non-numeric characters.

btnRegister_Click (Check C).

Ticket Type Validation

Mandatory selection, enforced by checking that the placeholder (-- Select Ticket Type --) is not submitted.

btnRegister_Click (Check D).

User Feedback

Provides specific error messages and focuses the cursor on the field needing correction.

MessageBox.Show() and .Focus() methods.

🛑 Troubleshooting: Database Locked Error

If you see the error "Error details: database is locked":

Close all other applications that might be accessing RegistrationDB.sqlite (especially SQLite viewers like DB Browser).

Stop and Restart the application in Visual Studio.
