use TopBrains;

--Display the structure of the course table.

Exec sp_help 'COURSE_INFO';

--Display the zipcode, city and state. Observe the column heading of state column

select ZIP_CODE, CITY, STATE from ZIPCODE_INFO;

--Display the unique states.

select DISTINCT STATE from ZIPCODE_INFO;

