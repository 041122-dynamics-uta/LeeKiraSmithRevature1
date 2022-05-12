/*
-SELECT - displays columns (NAME,GRADE,MARKS)
-IF statement because Ketty doesn't want the Names of students with a grade lower than 8
-IF statement syntax : IF(condition, value_if_true, value_if_false)
-Join joined the STUDENTS AND GRADES TABLE (STUDENTS ON LEFT GRADES ON RIGHT)
-WHERE clause ranges BETWEEN min_mark and max_mark
-report in deceding order by grade (highest to lowest) if an instance occurs where two students have the same grade order by name - used ORDER BY GRADE, DESC, NAME
*/

SELECT IF(GRADE < 8, NULL, NAME), GRADE, MARKS
FROM STUDENTS JOIN GRADES
WHERE MARKS BETWEEN MIN_MARK AND MAX_MARK
ORDER BY GRADE DESC, NAME