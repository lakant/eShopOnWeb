# Links
deviq https://deviq.com/practices/practices-overview

What's Domain Driven Design(DDD) https://stackoverflow.com/questions/1222392/what-is-domain-driven-design-ddd/1222488#1222488 

# Onion Architecture or Clean Architecture
https://github.com/ardalis/CleanArchitecture

Application Core types
- Entities (business model classes that are persisted)
- Interfaces
- Services
- DTOs

Infrastructure types
- EF Core types (DbContext, Migration)
- Data access implementation types (Repositories)
- Infrastructure-specific services (for example, FileLogger or SmtpNotifier)

UI Layer types
- Controllers
- Filters
- Views
- ViewModels
- Startup
