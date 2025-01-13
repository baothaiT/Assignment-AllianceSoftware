USE UserManament;

SELECT 
	d.department_name AS DepartmentName, 
	COUNT(e.employee_id) AS EmployeeCount
FROM 
	Departments d
LEFT JOIN 
	Employees e 
ON 
	d.department_id = e.department_id
GROUP BY 
	d.department_name;



SELECT 
    e.employee_id AS EmployeeID,
    CONCAT(e.first_name, ' ', e.last_name) AS FullName,
    a.date AS WorkDate,
    a.check_in_time AS CheckInTime
FROM 
    Attendance a
JOIN 
    Employees e 
ON 
    a.employee_id = e.employee_id
WHERE 
    DATEPART(WEEKDAY, a.date) = 2
    AND a.check_in_time > '09:00:00';


