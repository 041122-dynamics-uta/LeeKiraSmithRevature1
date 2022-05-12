/*
Enter your query here.
*/
SELECT DISTINCT CITY FROM STATION
WHERE NOT (CITY LIKE 'A%' OR  CITY  LIKE 'E%' OR CITY  LIKE 'I%' OR CITY  LIKE 'O%' OR CITY  LIKE 'U%');

/* % means find in any value that starts with A,E,I,O,U - so putting where not means don't find these value 
*/
