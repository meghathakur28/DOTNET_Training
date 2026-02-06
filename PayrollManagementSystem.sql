create database LPU_DB;

use LPU_DB;

--create a Employee table 

create table Employee
(
EmpId int Primary Key,
Name Varchar(20),
Department Varchar(20),
BasicSalary decimal(10, 2),
Bonus decimal(10, 2),
Deductions decimal(10, 2)
);

--create a SalaryLog Table 

create table SalaryLog
(
LogId int,
EmpId int,
OldSalary decimal(10, 2),	
NewSalary decimal(10, 2),
UpdatedDate datetime,
);

--create an index on Department column in Employee table

Create NonClustered Index idx_Department on Employee(Department);

--create a function 
create function fn_CalculateNetSalary(@emp int)
returns decimal(10, 2)
as
begin
declare @NetSalary decimal(10, 2);
select @NetSalary = BasicSalary + Bonus - Deductions from Employee where EmpId = @emp;
return @NetSalary;
end;

--create a stored procedures
create Procedure sp_UpdateSalary
@emp int,
@basic decimal(10,2),
@bonnus decimal(10,2),
@deduction decimal(10,2)
as 
begin
      Update Employee set BasicSalary  = @basic, Bonus = @bonnus, Deductions = @deduction where EmpId = @emp;
      declare @netSlary int;
      SET @netSlary = dbo.fn_CalculateNetSalary(@emp);
      return @netSlary;
end;
