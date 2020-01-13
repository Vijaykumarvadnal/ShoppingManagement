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
