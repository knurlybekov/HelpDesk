# HelpDesk

A Windows Forms (C#/.NET) Help Desk desktop application for registering, processing, and closing IT support tickets, with email notifications. Built as a diploma/thesis project.

## Overview

HelpDesk streamlines IT support workflows: users submit tickets describing a problem (computer name, problem type, printer details, description), support staff process and close them, and the system sends email notifications on status changes. It also supports service-quality rating after a ticket is closed.

## Features

- Submit support tickets with structured fields
- Process, update, and close tickets
- Automated email notifications to users
- Service-quality feedback after closure
- Reporting for service-quality analysis

## Tech Stack

C# · .NET Windows Forms · SQL Server / Google Cloud SQL

## Project Structure

```
WindowsFormsApp7/
  WindowsFormsApp7.sln           # Visual Studio solution
  WindowsFormsApp7/
    Program.cs                   # Entry point
    Class1.cs / Class2.cs        # Domain models (ticket fields)
    App.config                   # DB/email configuration
```

## Building

Open `WindowsFormsApp7.sln` in Visual Studio and build/run. Configure the database connection and SMTP settings in `App.config`.

*(Original project documentation is in Russian.)*
