/*
Enter your query here.
*/
--Order by SUBSTR (which needs 3 parameters); column (name); Length name -2, and last 3 characters,id;

SELECT name FROM students WHERE marks > 75 ORDER BY SUBSTR(name, LENGTH(name)-2, 3), id;

--Order starting from the right using the name and last 3 characters, and id
select name
from students
where marks > 75 
order by right(name,3), id ;