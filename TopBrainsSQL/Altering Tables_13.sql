use TopBrains;

--altering the zipcode_info

Select * from ZIPCODE_INFO;

Alter table ZIPCODE_INFO 
Add STATE Varchar(2);

--altering the instructor_info

Select * from INSTRUCTOR_INFO;

Alter table INSTRUCTOR_INFO
Add STREET_ADDRESS Varchar(50),
ZIP_CODE Varchar(5);

--altering teh course_info

Select * from COURSE_INFO;

Alter table COURSE_INFO
Add COURSE_NAME Varchar(8),
COURSE_PREREQUISITE Numeric(9);

--altering the student_info

Select * from STUDENT_INFO;

Alter table STUDENT_INFO
Add STREET_ADDRESS Varchar(50),
ZIP_CODE Varchar(5);

--altering the section_info

Select * from SECTION_INFO;

Alter table SECTION_INFO
Add LOCATIONS Varchar(50),
CAPACITY Numeric(3);

--altering the enrollment_info

Select * from ENROLLMENT_INFO;

Alter table ENROLLMENT_INFO
Add ENROLLMENT_DATE DATE;

--altering the grade_info

Select * from GRADE_INFO;

Alter table GRADE_INFO
Add NUMERIC_GRADE numeric(3)