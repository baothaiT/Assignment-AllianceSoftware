
-- truncate table Departments
-- truncate table Employees
-- truncate table Attendance
-- truncate table Meetings
-- truncate table Badges
-- truncate table Activities

INSERT INTO Employees (employee_id, first_name, last_name, date_of_birth, start_date, department_id, position, is_manager, email, phone) VALUES
('E001', 'A', 'Nguyen Van', '1985-05-15', '2020-01-10', 'D001', 'HR Manager', 1, 'nguyenvana@example.com', '1234567890'),
('E002', 'B', 'Nguyen Van', '1990-10-20', '2021-07-15', 'D002', 'Accountant', 0, 'nguyenvanb@example.com', '0987654321'),
('E003', 'C', 'Nguyen Van', '1990-10-20', '2021-07-15', 'D002', 'Accountant', 0, 'nguyenvanc@example.com', '0987654321'),
('E004', 'D', 'Nguyen Van', '1990-10-20', '2021-07-15', 'D002', 'Accountant', 0, 'nguyenvand@example.com', '0987654321'),
('E005', 'E', 'Nguyen Van', '1990-10-20', '2021-07-15', 'D003', 'Accountant', 1, 'nguyenvane@example.com', '0987654321');

-- Insert data into Departments
INSERT INTO Departments (department_id, department_name, manager_id) VALUES
('D001', 'Human Resources', 'E001'),
('D002', 'Finance', 'E003'),
('D003', 'IT', 'E005');

-- Insert data into Attendance
INSERT INTO Attendance (attendance_id, employee_id, date, check_in_time, check_out_time) VALUES
('A001', 'E001', '2025-01-06', '08:50:00', '17:30:00'),
('A002', 'E002', '2025-01-06', '09:10:00', '17:15:00'),
('A003', 'E003', '2025-01-06', '08:55:00', '17:00:00'),
('A004', 'E004', '2025-01-06', '09:05:00', '16:45:00'),
('A005', 'E005', '2025-01-06', '08:45:00', '17:20:00');

-- Insert data into Meetings
INSERT INTO Meetings (meeting_id, meeting_date, meeting_time, location, attendees, manager_id) VALUES
('M001', '2023-01-09', '10:00:00', 'Room A', 'E001, E002, E003', 'E001'),
('M002', '2023-01-09', '15:00:00', 'Room B', 'E003, E004, E005', 'E005');

-- Insert data into Badges
INSERT INTO Badges (badge_id, employee_id, issue_date) VALUES
('B001', 'E001', '2020-01-10'),
('B002', 'E002', '2021-07-15'),
('B003', 'E003', '2019-03-01'),
('B004', 'E004', '2022-09-10'),
('B005', 'E005', '2018-06-15');

-- Insert data into Activities
INSERT INTO Activities (activity_id, activity_date, activity_name, employee_id) VALUES
('ACT001', '2023-01-09', 'Annual Performance Review', 'E001'),
('ACT002', '2023-01-09', 'Team Meeting', 'E002'),
('ACT003', '2023-01-09', 'Budget Planning', 'E003'),
('ACT004', '2023-01-09', 'Code Review', 'E004'),
('ACT005', '2023-01-09', 'Server Maintenance', 'E005');
