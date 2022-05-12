/*
Enter your query here.
*/
/*The problem asked that you query the sum of Lat_N from the table station having greater values then > 38.7880 and less values then <137.2345 as well as truncate the value by 4 decimal points.

Query the tuncated sum SELECT TRUNCATE(sum(LAT_N), 4) - truncate has to have two arguments and here we are getting the sum of LAT_N and truncating it by 4 decimal places - TRUNCATE(N,D) N -TRUNCATED D- DECIMAL PLACE
*/
SELECT TRUNCATE(sum(LAT_N), 4)
FROM station
where LAT_N > 38.7880 and LAT_N < 137.2345;
/*
FROM station (table that your pulling the data from.) Where clause because comparing two values greater than 38.7880 and less than 137.2345
*/