CREATE UNIQUE INDEX unique_manager_per_department
ON Departments (manager_id)
WHERE manager_id IS NOT NULL;


CREATE UNIQUE INDEX unique_employmentCode ON Employees (employee_code)