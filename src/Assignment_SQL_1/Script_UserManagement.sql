CREATE DATABASE UserManament;
USE UserManament;

CREATE TABLE Employees (
    employee_id VARCHAR(50) PRIMARY KEY,                 
    first_name VARCHAR(50) NOT NULL,                  
    last_name VARCHAR(50) NOT NULL,                   
    date_of_birth DATE NOT NULL,                      
    start_date DATE NOT NULL,                         
    department_id VARCHAR(50),                        
    position VARCHAR(100),                            
    is_manager bit not null default 0,                
    email VARCHAR(100) UNIQUE,                        
    phone VARCHAR(15)                                 
);

CREATE TABLE Departments (
    department_id VARCHAR(50) PRIMARY KEY,           
    department_name VARCHAR(100) NOT NULL,  
    manager_id VARCHAR(50),              
    CONSTRAINT unique_manager_per_department UNIQUE (manager_id),
    CONSTRAINT fk_manager_id FOREIGN KEY (manager_id) REFERENCES Employees(employee_id)
);

CREATE TABLE Attendance (
    attendance_id VARCHAR(50) PRIMARY KEY,  
    employee_id VARCHAR(50) NOT NULL,  
    date DATE NOT NULL,   
    check_in_time TIME, 
    check_out_time TIME, 
    CONSTRAINT fk_attendance_employee FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);

CREATE TABLE Meetings (
    meeting_id VARCHAR(50) PRIMARY KEY,  
    meeting_date DATE NOT NULL,  
    meeting_time TIME NOT NULL,  
    location VARCHAR(100) NOT NULL,  
    attendees TEXT,   
	manager_id VARCHAR(50),
	CONSTRAINT fk_Meetings_employee FOREIGN KEY (manager_id) REFERENCES Employees(employee_id)
);

CREATE TABLE Badges (
    badge_id VARCHAR(50) PRIMARY KEY, 
    employee_id VARCHAR(50) NOT NULL,  
    issue_date DATE NOT NULL,   
    CONSTRAINT fk_badge_employee FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);

CREATE TABLE Activities (
    activity_id VARCHAR(50) PRIMARY KEY,
	activity_date DATE NOT NULL, 
	activity_name DATE NOT NULL, 
    employee_id VARCHAR(50) NOT NULL,
    CONSTRAINT fk_activity_employee FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);