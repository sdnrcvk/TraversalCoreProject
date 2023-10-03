# TraversalCoreProject

It is a tour reservation project consisting of Entities, DataAccess, Business and UI layers using ASP.Net Core.
   
**Project Status:** It continues to be developed.

## Used Technologies

- **ASP.Net Core**: ASP.Net Core is a cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications.

- **Entity Framework**: Entity Framework is an Object-Relational Mapping (ORM) framework for .NET, which simplifies database access and management.

- **Fluent Validation**: Fluent Validation is a popular .NET library used for creating strongly-typed validation rules in a fluent and expressive manner.

- **LINQ**: LINQ (Language-Integrated Query) is a powerful query language used to query and manipulate data in .NET applications.

- **ASP.Net Core Identity**: ASP.Net Core Identity is a framework for managing user authentication and authorization in ASP.Net Core applications.

## Project Layers

**Entities:** This layer represents the core business objects and data structures used throughout the application. It defines the essential models and entities that are fundamental to the tour reservation system.

**DataAccess:** The DataAccess layer is responsible for managing data interactions. It uses technologies like Entity Framework and LINQ to facilitate database operations. This layer ensures that data is retrieved, stored, and manipulated efficiently.

**Business:** The Business layer contains the application's business logic. It orchestrates the interactions between the data access layer and the UI layer, ensuring that operations are performed correctly and securely.

**UI:** The UI layer is the user interface part of the application. It provides the frontend for users to interact with the system, make tour reservations, and manage their bookings. ASP.NET Core Identity is used for user authentication and management.
