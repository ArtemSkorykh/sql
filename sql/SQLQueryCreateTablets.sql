USE Warehouse;

CREATE TABLE Produsers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] NVARCHAR(MAX) NOT NULL 
)

CREATE TABLE Products
(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] NVARCHAR(MAX) NOT NULL,
	[type] NVARCHAR(100) NOT NULL,
	produser_id INT REFERENCES Produsers(id),
	quantity INT NOT NULL,
	prime_cost MONEY NOT NULL,
	date_of_delivery DATE NOT NULL,
	

)

