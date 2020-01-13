# Shopping Management
Test application to perform CRUD operations in ASPNET CORE MVC plus Entity Framework

To run this application you need to first create database named **Shopping** in the SQL Server 

Once database is created run below table script


    Create Table Products(
        ProductId BigInt Identity(1,1) Primary Key,    
        Name Varchar(100) Not Null,    
        Category Varchar(100),
        Color Varchar(20),
        UnitPrice Decimal Not Null,
        AvailableQuantity BigInt Not Null,
        CratedDate DateTime Default(GetDate()) Not null
    )

Then you need to make changes to *appsettings.json* file under *ShoppingManagement* web project to have correct database connection string.

Once all done set **ShoppingManagement** as startup project and run your project and start adding, editing i.e. CRUD operations from web app.

One of the configurations for **OAuth2** using **github** has been implemented and those code lines are commented in this project for the reference.

Also I have added unit test project with name **ShoppingManagement.Test** to the same solution that uses **XUnit**, There I already have added couple of test methods for controller.

