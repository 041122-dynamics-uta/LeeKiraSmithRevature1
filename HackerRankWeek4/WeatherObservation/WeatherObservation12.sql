/*
Enter your query here.
REGEXP means regular expression
'^' the beginning of the search
'$' starts at the end of the search
*/

SELECT DISTINCT CITY

FROM STATION 

WHERE CITY NOT REGEXP '^[aeiou]' 

AND CITY NOT REGEXP '[aeiou]$';
