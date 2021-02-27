CREATE DATABASE Store;

CREATE TABLE BeautyProducts (
productId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
productName VARCHAR(100),
price MONEY,
category VARCHAR(100),
subCategory VARCHAR(1000),
brands VARCHAR(250),
[types] VARCHAR(250),
color VARCHAR(250),
sizes VARCHAR(250),
[description] VARCHAR(250)
)

CREATE TABLE Customers (
customerId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
customerName VARCHAR(50),
[password] VARCHAR(50),
phoneNumber VARCHAR(20),
emailAddress VARCHAR(100),
homeAddress VARCHAR(100),
billingAddress VARCHAR(100),
)

CREATE TABLE Locations (
locationId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
locationName VARCHAR(100),
[address] VARCHAR(100)
)

CREATE TABLE Orders (
customerId INT FOREIGN KEY REFERENCES Customers(customerId),
locationId INT FOREIGN KEY REFERENCES Locations(locationId)
)