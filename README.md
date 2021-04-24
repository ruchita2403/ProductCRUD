# ProductCRUD
Product CRUD operations ,pagination, search with ASP.NET C# MVC 5 Entity Framework 6 SQL Server and Visual studio 2017.
The solution WebapiMVCShopBridgeProducts contains two projects . One is WebapiShopBridgeProducts and another is MVCShopBridgeProducts.
In the solution we need to make multiple start up projects as both the web api and mvc application needs to run simultaneously.
Also, we need to change base address of web apiclient in Global Vriables.cs in MVCShopBridgeProducts as::  WebapiClient.BaseAddress = new Uri("http://localhost:60325//api/"); where the base address should be the address at our local machine where WebapiShopBridgeProducts is running.
