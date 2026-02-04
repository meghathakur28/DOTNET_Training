use TopBrains;

Drop table Student;

Create table Student
(
Id int Primary Key,
Name varchar(20) Not null,
RollNo int
);

Insert into Student values
(101, 'Megha Thakur',12211812),
(102, 'Abhinav Sharma',12308765),
(103, 'Nisha Agarwal',12220732),
(104, 'Nisha Khairwa',12207241);

Create Table Marks
(
RollNo int Primary Key,
Maths int,
Phy int,
Chem int,
TotalMarks as (Maths+Phy+Chem),
Percentage as ((Maths+Phy+Chem)/3),
);

Insert into Marks values
(12211812, 89, 98, 88),
(12308765, 80, 80, 78),
(12220732, 78, 99, 66);

Select * from Marks;
Select * from Student;

--delete the student record whose data is not in marks table
Delete from Student
where RollNo Not In (Select RollNo from Marks);

Select * from Student;