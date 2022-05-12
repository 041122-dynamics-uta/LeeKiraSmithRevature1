/*
Enter your query here.
Write a query calculating the amount of error (i.e.:actual - miscalculated  average monthly salaries), and round it up to the next integer. table EMPLOYEES

The CEILING() or CEIL function returns the smallest integer value that is larger than or equal to a number.
ceiling function syntax: CEILING(number)

The REPLACE() function replaces all occurrences of a substring within a string, with a new substring.
replace function syntax: REPLACE(string, old_string, new_string)
*/
/*SELECT CEIL(AVG(Salary)-AVG(REPLACE(Salary,'0',''))) FROM EMPLOYEES; - ceil find the next nearest interger */
SELECT ROUND(AVG(SALARY) - AVG(REPLACE(SALARY,'0',''))+1) FROM EMPLOYEES 
/* truncates the decimal hence the +1) to round up to the next interger*/