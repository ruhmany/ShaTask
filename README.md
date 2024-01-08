# Clean Architecture Project - Invoice Management


This repository contains a project implementing a 4-layer Clean Architecture with the following technologies: MediatR, CQRS, Repository Pattern, Entity Framework Core, LINQ, and ASP.NET Core MVC. The main purpose of this project is to create a view for managing invoice data, including basic invoice details and items, with CRUD operations.

## Project Structure

The project is organized into four layers, each serving a specific purpose in adhering to the Clean Architecture principles:

1. **Presentation Layer (Web/UI)**
   - Located in the `InvoiceManagement.Web` project.
   - Implements the ASP.NET Core MVC framework for user interface.
   - Contains controllers, views, and static resources.

2. **Application Layer**
   - Located in the `InvoiceManagement.Application` project.
   - Implements MediatR and CQRS for handling application-specific logic.
   - Contains commands, queries, and command/query handlers.

3. **Domain Layer**
   - Located in the `InvoiceManagement.Domain` project.
   - Represents the core business logic and entities.
   - Contains domain models, entities, and any business rules.

4. **Infrastructure Layer**
   - Located in the `InvoiceManagement.Infrastructure` project.
   - Implements infrastructure concerns such as database access, repositories, and external services.
   - Contains Entity Framework Core configurations, repositories, and other infrastructure-related components.

## Invoice View

The main focus of this project is to create a view for managing invoice data. The view adheres to the following requirements:

1. **Display One Invoice in One Row**
   - Ensures that if an invoice has more than one item, it is displayed in a single row.

2. **CRUD Operations for Basic Invoice Data and Items**
   - Provides the user with the ability to perform CRUD operations on both basic invoice data (e.g., CustomerName, InvoiceDate) and invoice items (e.g., ItemName, ItemCount, ItemPrice).

3. **Cashier Data CRUD Operations**
   - Implements CRUD operations for Cashier data, following the specified requirements.

## Technologies Used

- ASP.NET Core MVC
- MediatR and CQRS pattern
- Entity Framework Core
- LINQ
- Repository Pattern

## Getting Started

1. Clone the repository.
2. Set up the required dependencies and databases.
3. Build and run the project.

## Contributors

- [Your Name]
- [Other Contributors]

## License

This project is licensed under the [License Name] - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- Mention any references, tutorials, or inspirations used in the project.
- Give credit to the technologies and frameworks used.
