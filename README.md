# EmployeeManagement-API

## Description
EmployeeManagement-API is an ASP.NET Core WebAPI Application that allows to Manage Employee Data. 
Hosted on **Azure App Service**, using **Azure SQL Database** as Storage, and Monitored and logged with **Application Insights**.
Connection strings are secured via Azure App Service Application Settings.

----------

## Tech Stack
-ASP.NET Core WebAPI(.Net 10)
-Entity Framework Core
-Azure App Service
-Azure SQL Database
-Application Insights
-Swagger

----------

## Features
-Cloud Hosted Rest API
-Secure configuration using App Setting
-Application Monitoring with Azure Insights

----------

## Screenshots

### Azure SQL Database
![Azure SQL Overview](Docs/AzureSQL/Overview)
Shows service Name, URL, Region and Pricing Tier

![Connection string](Docs/AzureSQL/Connection string.png)
Connection string configured for the API.(Password Masked)

![Table](Docs/AzureSQL/Table.png)
Shows 'EmployeeDetails' Table and data

![SQL Metrics](Docs/AzureSQL/Metrics.png)
Displays cpu usage and database metrics

----------

### Azure App Service

![App Service Overview](Docs/AppService/Overview.png)
Shows service Name, URL, Region and Pricing Tier

![App Setting](Docs/AppService/ApplicationSetting.png)
Shows Connection string configured via Application setting

![App Screenshot](Docs/AppService/AppScreenshot.png)
Shows main page of the running application.(Swagger UI)

----------

### Application Insights

![Overview](Docs/ApplicationInsight/Overview.png)
Overview of Application Insights Monitoring

![Logs](Docs/ApplicationInsight/Logs.png)
show requests, Logs,response times and failures.

----------

## API Endpoints
**Swagger UI**
https://employeemanagement-api-caaee0c8efewfbcn.southindia-01.azurewebsites.net/index.html

**Get Employee Info**
Get/api/Employees/GetEmployeeInfo{id}
[url](https://employeemanagement-api-caaee0c8efewfbcn.southindia-01.azurewebsites.net/api/Employees/GetEmployeeInfo/{id})

**Add Employee Info**
Post/api/Employees/AddEmployeeInfo
[url](https://employeemanagement-api-caaee0c8efewfbcn.southindia-01.azurewebsites.net/api/Employees/AddEmployeeInfo)

## Clone the repository
	```bash 
	git clone https://github.com/sathiyapriyaw01-wq/EmployeeManagement-API.git
