# SalesReport

SalesReport is a web application built on ASP.NET Core MVC that uses MySQL for data storage. This application displays a sales report by countries.

## Main Components

### Controllers

- `HomeController`: Controller for handling requests to the home page and error page.
- `ReportController`: Controller for handling requests to the report page.

### Models

- `Customer`: Model representing a customer.
- `Invoice`: Model representing an invoice.
- `ErrorViewModel`: Model for displaying errors.

### Repositories

- `IReportRepository`: Interface for the report repository.
- `ReportRepository`: Implementation of the report repository that uses Entity Framework Core to interact with the database.

### DbContext

- `ChinookContext`: Database context used for interacting with the MySQL database.

## Usage

After cloning the repository, you need to install the project dependencies by running the `dotnet restore` command.

Before running the application, you need to configure the connection string to your MySQL database in the `appsettings.json` file.

After that, you can run the application by executing the `dotnet run` command.

