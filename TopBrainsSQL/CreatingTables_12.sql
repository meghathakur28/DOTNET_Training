Create database TopBrains;

use TopBrains;

-- creation a table of zipcode_info
Create Table ZIPCODE_INFO 
( ZIP_CODE Varchar(5),
  CITY Varchar(10)
)

--create a table of instructor_info
Create Table INSTRUCTOR_INFO
(
INSTRUCTOR_ID Numeric(8),
INSTRUCTOR_FIRST_NAME Varchar(15),
INSTRUCTOR_LAST_NAME Varchar(15)
);

--create a table of course_info

Create Table COURSE_INFO
(
COURSE_NO Numeric(8),
COST Numeric(5),
);

--create a table od student_info

Create Table STUDENT_INFO
(
STUDENT_ID Numeric(8),
STUDENT_FIRST_NAME Varchar(15),
STUDENT_LAST_NAME Varchar(15)
);

--create table of section_info

Create Table SECTION_INFO
(
   SECTION_ID Numeric(8),
   COURSE_NO Numeric(8),
   SECTION_NO Numeric(5),
   INSTRUCTOR_ID Numeric(8)
);

--create a table of enrollment_info

Create Table ENROLLMENT_INFO
(
   STUDENT_ID Numeric(8),
   SECTION_ID Numeric(8)
);

-- create a table of grade_info
Create Table GRADE_INFO
(
   STUDENT_ID Numeric(8),
   SECTION_ID Numeric(8),
   GRADE_TYPE_CODE char(2),
   GRADE_CODE_OCCURANCE Numeric(5)
);


