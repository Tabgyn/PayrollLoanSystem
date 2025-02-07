# Payroll Loan System - .NET Aspire & Blazor

A **cloud-native** payroll loan management system built with **.NET Aspire**, **Minimal APIs**, and **Blazor**. This system allows **banks** to offer loans, **public/private employers** to manage payroll-deducted loans, and **employees** to simulate and track their loans.

## Features
✅ **Microservices Architecture** with **Aspire** for service discovery & observability  
✅ **Minimal APIs** using a **Vertical Slice Architecture** (e.g., `CreateLoan`, `ApproveLoan`)  
✅ **Blazor Frontend** for an interactive and modern user experience  
✅ **Authentication & Security** for multi-role access control  
✅ **Event-driven architecture** using messaging and notifications  
✅ **Observability & Tracing** via OpenTelemetry  
✅ **Cloud-native deployment** with containerization  

## Architecture
```
├── PayrollLoanSystem
│   ├── src
│   │   ├── Services
│   │   │   ├── AuthenticationService
│   │   │   │   ├── Features
│   │   │   │   │   ├── Login
│   │   │   │   │   ├── Register
│   │   │   │   ├── Models
│   │   │   │   ├── Services
│   │   │   ├── LoanManagementService
│   │   │   │   ├── Features
│   │   │   │   │   ├── CreateLoan
│   │   │   │   │   ├── ApproveLoan
│   │   │   │   │   ├── RejectLoan
│   │   │   │   ├── Models
│   │   │   │   ├── Services
│   │   │   ├── PayrollIntegrationService
│   │   │   │   ├── Features
│   │   │   │   │   ├── CreatePayroll
│   │   │   │   │   ├── UpdatePayroll
│   │   │   │   │   ├── DeletePayroll
│   │   │   │   ├── Models
│   │   │   │   ├── Services
│   │   │   ├── LoanSimulationService
│   │   │   │   ├── Features
│   │   │   │   │   ├── SimulateLoan
│   │   │   │   ├── Models
│   │   │   │   ├── Services
│   │   │   ├── NotificationService
│   │   │   │   ├── Features
│   │   │   │   │   ├── SendEmail
│   │   │   │   │   ├── SendSMS
│   │   │   │   ├── Services
│   │   │   ├── AuditComplianceService
│   │   │   │   ├── Features
│   │   │   │   │   ├── LogTransaction
│   │   │   │   │   ├── ValidateCompliance
│   │   │   │   ├── Services
│   │   ├── Shared
│   │   │   ├── Infrastructure
│   │   │   ├── Messaging
│   │   │   ├── Security
│   │   ├── AspireAppHost (Service Discovery, Configuration, Observability)
│   ├── BlazorFrontend
│   │   ├── Components
│   │   ├── Pages
│   │   ├── Services
│   │   ├── wwwroot
│   │   ├── Program.cs
│   ├── tests
│   │   ├── UnitTests
│   │   ├── IntegrationTests
│   ├── docker-compose.yml (Optional, since Aspire manages services)
│   ├── README.md
```

## Services Overview
- **AuthenticationService** – User login & role management  
- **LoanManagementService** – Loan creation, approval, and tracking  
- **PayrollIntegrationService** – Employer-side payroll deductions  
- **LoanSimulationService** – Loan calculation and projections  
- **NotificationService** – Email/SMS updates  
- **AuditComplianceService** – Transaction logging and fraud detection  

## Tech Stack
- **Backend:** .NET Aspire, Minimal APIs, Vertical Slice Architecture  
- **Frontend:** Blazor WebAssembly  
- **Observability:** OpenTelemetry for logging, tracing, and metrics  
- **Security:** Authentication & Authorization (JWT-based)  

## Deployment
1. Clone the repository:  
   ```sh
   git clone https://github.com/your-repo/payroll-loan-system.git
   ```
2. Navigate to the root directory and start services:  
   ```sh
   cd PayrollLoanSystem
   dotnet run --project AspireAppHost
   ```

🚀 **Built with .NET Aspire, Minimal APIs, and Blazor.**