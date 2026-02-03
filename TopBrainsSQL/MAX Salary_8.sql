use TopBrains;

create table Employees(ID Numeric Primary Key, 
Name Varchar(20) Not Null,
Dept Varchar(50) Not Null,
Salary Varchar(50)
);

Select * from Employees;

Insert into Employees values(1,'megha','IT','400000'),
(2,'abhinav','finance','700000'),
(3,'nisha agarwal','IT','400000'),
(4,'poorvi','Medical','10000000'),
(5,'shiv shant thakur','CA','3456789087');

Insert into Employees values(6,'nisha','finance','22222');

select e.Dept, e.Name, e.Salary from Employees as e
Inner Join
(select Dept, Max(Salary) as MaxSalary from Employees group by Dept) as g
on e.Dept = g.Dept AND e.Salary = g.MaxSalary;