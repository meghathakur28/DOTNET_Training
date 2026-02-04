use TopBrains;

--create a product table
Create table Product(
Id int Primary Key,
Name Varchar(30),
Price Varchar(20),
);

Insert into Product values
(101, 'Kettle', '400'),
(102, 'Chimni', '6500'),
(103, 'Almirah', '10000'),
(104, 'Suit Case', '6000'),
(105, 'Steam Press', '900');

Select * from Product;

Create table Sales
(
SalesId int Primary Key,
Purchaser varchar(30),
ProductId int Foreign Key references Product(id),
);

Insert into Sales values
(1231,'Megha','101'),
(1234,'Abhinav','101'),
(1223,'Neena','104'),
(1276,'Ashish','104');

Select * from Sales;
Select * from Product;

--sold products

Select p.Id, p.Name, p.Price from Product as p 
join
Sales as s 
on p.Id = s.ProductId;

--unsold products
Select p.Id, p.Name, p.Price from Product as p 
Where p.Id Not In (Select ProductId from Sales);
