use TopBrains;

create table Userses
(
  Id int Primary Key,
  Name Varchar(30),
  Email Varchar(20),
);

Insert into Userses values
(101,'megha','meghathakur292'),
(102,'abhinav','meghathakur292'),
(103,'poorvi','meghathakur292'),
(104,'shivi','meghathakur292'),
(105,'nisha','nishaagarwal292');

Select * from Userses;

Select Email, Count(Email) from Userses group by Email having Count(Email)>1;