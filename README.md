# TraversalCoreProject
This project represents a website operating for tour bookings. This project represents a website operating for tour bookings. The site has three different designs: the "main design", which lists various tour routes and includes the about us, blog, guides and contact page, a "user panel" where users carry out their transactions, and an "admin panel" for the transactions to be carried out by the admin.

The project is based on an N Tier Architecture consisting of Entities, DataAccess, Business, UI, SignalRApiForSQL, and SingalRConsume layers, developed using ASP.NET Core 6. The project is supported by API development and usage.Hotel data, foreign currency, imdb top 100 movie data were brought externally using Rapid Api data. Various design patterns such as Repository, Unit of Work, CQRS, and Mediator are employed. Real-time data visualization is achieved using SignalR. Multiple language support is implemented through localization. Email configuration, validation control using FluentValidation, reporting, and Google Chart generation are also incorporated into the project.

**Project Status:** It continues to be developed.

## Used Technologies

- **ASP.Net Core**: ASP.Net Core is a cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications.

- **Entity Framework**: Entity Framework is an Object-Relational Mapping (ORM) framework for .NET, which simplifies database access and management.

- **MSSQL**: Microsoft SQL Server (MSSQL) is a relational database management system developed by Microsoft.

- **Postgre SQL**: PostgreSQL is a powerful, open-source relational database system known for its reliability and robust feature set.

- **Fluent Validation**: Fluent Validation is a popular .NET library used for creating strongly-typed validation rules in a fluent and expressive manner.

- **LINQ**: LINQ (Language-Integrated Query) is a powerful query language used to query and manipulate data in .NET applications.

- **ASP.Net Core Identity**: ASP.Net Core Identity is a framework for managing user authentication and authorization in ASP.Net Core applications.

- **Ajax**: Asynchronous JavaScript and XML (Ajax) is a technique used in web development to create asynchronous web applications. It allows for updating parts of a web page without reloading the entire page.

- **AutoMapper**: AutoMapper is a library used in .NET to automatically map objects from one type to another, simplifying the process of object-to-object mapping.

- **MediatR**: MediatR is a simple, unambitious mediator implementation in .NET. It helps in implementing the mediator pattern and simplifies the communication between components of an application.

- **SignalR**: SignalR is a library in ASP.NET Core used to add real-time web functionality to applications, enabling server-side code to push content to clients instantly.

- **Localization**: Localization in ASP.NET Core refers to the process of adapting an application to different languages and regions, allowing users from various locations to use the application in their preferred language.

## Project Layers

**Entities:** This layer represents the core business objects and data structures used throughout the application. It defines the essential models and entities that are fundamental to the tour reservation system.

**DataAccess:** The DataAccess layer is responsible for managing data interactions. It uses technologies like Entity Framework and LINQ to facilitate database operations. This layer ensures that data is retrieved, stored, and manipulated efficiently.

**Business:** The Business layer contains the application's business logic. It orchestrates the interactions between the data access layer and the UI layer, ensuring that operations are performed correctly and securely.

**UI:** The UI layer is the user interface part of the application. It provides the frontend for users to interact with the system, make tour reservations, and manage their bookings. ASP.NET Core Identity is used for user authentication and management.

## Project Images

<img src="https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/dbae6b49-e1dd-4484-96a4-fba86dbfefbb" height="750"> </img>
<img src="https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/22ff89bd-deee-4360-a4a4-8b8ebd78f9aa" height="750"> </img>
![Ekran görüntüsü 2024-02-13 220849](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/5a1605e6-9b4d-49f5-a8ad-3c3366b326a5)
![Ekran görüntüsü 2024-02-13 220926](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/8ff1938f-215d-4ef4-a06e-9827bc66b69f)
![Ekran görüntüsü 2024-02-13 220945](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/7ae9db77-32c8-42ab-ba5e-4a236a0f15c4)
![Ekran görüntüsü 2024-02-13 221006](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/240c04a3-91a7-41d5-b40e-bb3752c0ca2b)
![Ekran Görüntüsü (230)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/1c00a1ea-8ee0-4a45-a094-dafb705b99d6)
![Ekran Görüntüsü (231)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/807d5d5d-1bda-452f-84aa-cfa5e26a844e)
![Ekran Görüntüsü (232)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/43e64148-a66a-434c-95e1-a56553eb41b1)
![Ekran Görüntüsü (233)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/35cd63d2-1ce9-4f03-9795-a3b5a4605f94)
![Ekran Görüntüsü (234)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/fe1ccdea-c4cf-48b6-9084-495a286904f9)
![Ekran Görüntüsü (235)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/cff80fc1-6dd8-4ab8-8ddd-9be2a5b410c3)
![Ekran Görüntüsü (236)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/216afd0f-8879-4f2f-b685-21c6f0b813fc)
![Ekran Görüntüsü (237)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/5b35edc4-32da-4995-9da0-13c0990ddb47)
![Ekran Görüntüsü (238)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/15842813-e311-4f1e-81d3-b9cc05a2045c)
![Ekran Görüntüsü (239)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/da73560a-1701-4786-833f-20e31095f9f9)
![Ekran Görüntüsü (240)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/6d7c54e3-9e5b-4d9d-a590-7e6fbd0ca331)
![Ekran Görüntüsü (241)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/ea879577-c38f-4cc4-abd4-53180e74ddb8)
![Ekran Görüntüsü (242)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/7e53e27f-0806-4e7c-b1de-08b73d34240c)
![Ekran Görüntüsü (243)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/55736206-ca33-4634-a29b-adaca0079b96)
![Ekran Görüntüsü (244)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/ed574087-803f-4a31-8cb0-fa22ab98ec06)
![Ekran Görüntüsü (245)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/74bb01cb-0383-4874-aba9-70e8c0c27abb)
![Ekran Görüntüsü (246)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/6dbae938-b00d-4554-9171-6043c24cafbd)
![Ekran Görüntüsü (248)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/1b9ceae5-2d5d-41e8-86cd-ba9d588ec1c0)
![Ekran Görüntüsü (249)](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/6786628f-880d-483a-9164-a3a7d5ca9f84)
![19](https://github.com/sdnrcvk/TraversalCoreProject/assets/58807892/61ec5ea3-5af9-4c75-b65d-7ede8adb1a16)






