# A simple service-oriented Pharma Supply Chain Management 

This project demonstrates the implementation of a service-oriented architecture (SOA) for managing the supply chain in the pharmaceutical industry. It consists of key services that communicate with each other to handle aspects of the supply chain, such as inventory management, order processing, and supplier tracking. Each service is built using ASP.NET Core and exposes RESTful APIs for interaction.
The orchestrator service acts as a simple ESB (Enterprise Service Bus) that routes requests to the appropriate services based on the request type.


To Run the Project:
1. Ensure you have .NET 6.0 SDK or later installed on your machine.
2. Clone the repository to your local machine.
3. Navigate to each service directory (InventoryService, OrderService, SupplierService) and run
    `dotnet run` to start the services.
4. Navigate to the OrchestratorService directory and run
    `dotnet run` to start the orchestrator service.
5. Use the ClientApp to send requests to the OrchestratorService (Make sure to update the URLs in ClientApp/Program.cs if necessary.)
   Run the ClientApp using
    `dotnet run` to see the interaction between services.
