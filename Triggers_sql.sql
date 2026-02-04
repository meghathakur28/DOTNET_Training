use TopBrains;
Drop Table Department 

CREATE TABLE Department
(
    DeptId INT PRIMARY KEY,
    DeptName VARCHAR(50) NOT NULL,
    No_of_Emp INT default 0
);

INSERT INTO Department VALUES
(1, 'HR', 1),
(2, 'IT',1),
(3, 'Finance',1),
(4, 'Sales',1);

Drop table Employee;
CREATE TABLE Employee
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Salary INT,
    DeptId INT,
);

INSERT INTO Employee VALUES
(101, 'Amit', 45000, 1),
(102, 'Neha', 60000, 2),
(103, 'Rahul', 55000, 2),
(104, 'Priya', 40000, 3),
(105, 'Karan', 50000, 1);

Select * from Employee;
Select * from Department;

--create a insert trigger

Create Trigger trginsert
on Employee
for insert
as
begin
      declare @deptNo int;
      select @deptNo = DeptId from inserted;
      update Department set No_of_Emp = No_of_Emp+1 where DeptId = @deptNo;
end

--create a delete trigger

create trigger trgdelete
on Employee
for delete
as
begin
      declare @deptNo int;
      select @deptNo = DeptId from deleted;
      update Department set No_of_Emp = No_of_Emp - 1 where DeptId = @deptNo;
end

--create a update trigger
create trigger trgupdate
on Employee
for update
as
begin
      declare @newdeptNo int;
      declare @olddeptNo int;
      select @newdeptNo = DeptId from inserted;
      select @olddeptNo = DeptId from deleted;
      update Department set No_of_Emp = No_of_Emp - 1 where DeptId = @olddeptNo;
      update Department set No_of_Emp = No_of_Emp - 1 where DeptId = @newdeptNo;
end

select * from Employee;
select * from Department;

Insert into Employee values
(106,'Megha Thakur',90000,2);

Delete from Employee where EmpId = 105;


