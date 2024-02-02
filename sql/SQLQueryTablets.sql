USE Warehouse;

INSERT INTO Produsers(name) 
VALUES('Food_Forewer'), 
	  ('Clother_for_every_part_of_year'),
	  ('HotDogFood'),
	  ('ATB'),
	  ('Rozetka')

INSERT INTO Products(name, type, produser_id, quantity, prime_cost, date_of_delivery)
VALUES('Apple','Food_and_Drinks',1, 20, 2.05, '2024-01-25'),
      ('Laptop','Electonics',5, 5, 15000,     '2023-12-19'),
	  ('Trouses','Clother',2, 30, 40.5,       '2024-02-01'),
	  ('Pineapple','Food_and_Drinks',3, 6, 25,'2023-12-13'),
	  ('Charger','Elecronics',5, 15, 31.5,    '2024-01-02')