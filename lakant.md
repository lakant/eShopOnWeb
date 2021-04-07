https://deviq.com/practices/practices-overview
deviq


# Onion Architecture or Clean Architecture
https://github.com/ardalis/CleanArchitecture

Application Core types
• Entities (business model classes that are persisted)
• Interfaces
• Services
• DTOs

Infrastructure types
• EF Core types (DbContext, Migration)
• Data access implementation types (Repositories)
• Infrastructure-specific services (for example, FileLogger or SmtpNotifier)

UI Layer types
• Controllers
• Filters
• Views
• ViewModels
• Startup

the container principle of _“a container does one thing, and does it in one process_”
