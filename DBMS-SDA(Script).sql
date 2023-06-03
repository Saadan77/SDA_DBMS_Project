--CREATE DATABASE Employees;

--CREATE TABLE Employee (
--    EmployeeID INT PRIMARY KEY,
--    FirstName VARCHAR(50),
--    LastName VARCHAR(50),
--    DepartmentID INT,
--    Position VARCHAR(50),
--    JoinDate DATE,
--    TotalWorkingHours DECIMAL(10, 2),
--    AverageAttendanceHours DECIMAL(10, 2),
--    LastUpdated TIMESTAMP
--);

--CREATE TABLE Leave (
--    LeaveID INT PRIMARY KEY,
--    EmployeeID INT,
--    LeaveType VARCHAR(50),
--    StartDate DATE,
--    EndDate DATE,
--    Status VARCHAR(20),
--    CONSTRAINT FK_Leave_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE PayrollAttendance (
--    AttendanceID INT PRIMARY KEY,
--    EmployeeID INT,
--    AttendanceDate DATE,
--    TimeIn TIME,
--    TimeOut TIME,
--    HoursWorked DECIMAL(10, 2),
--    RegularHours DECIMAL(10, 2),
--    CONSTRAINT FK_PayrollAttendance_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE EmployeeInformationManagement (
--    InfoID INT PRIMARY KEY,
--    EmployeeID INT,
--    Information TEXT,
--    CONSTRAINT FK_EmployeeInformationManagement_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE AttendanceAndLeaveManagement (
--    RecordID INT PRIMARY KEY,
--    EmployeeID INT,
--    Date DATE,
--    Status VARCHAR(20),
--    CONSTRAINT FK_AttendanceAndLeaveManagement_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE PayrollManagement (
--    PayrollID INT PRIMARY KEY,
--    EmployeeID INT,
--    Month VARCHAR(20),
--    Year INT,
--    BasicSalary DECIMAL(10, 2),
--    Allowances DECIMAL(10, 2),
--    Deductions DECIMAL(10, 2),
--    NetSalary DECIMAL(10, 2),
--    CONSTRAINT FK_PayrollManagement_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE RecruitmentAndApplicantTracking (
--    ApplicantID INT PRIMARY KEY,
--    Name VARCHAR(100),
--    PositionApplied VARCHAR(50),
--    DateApplied DATE,
--    Status VARCHAR(20)
--);

--CREATE TABLE BenefitsManagement (
--    BenefitID INT PRIMARY KEY,
--    EmployeeID INT,
--    BenefitType VARCHAR(50),
--    Description TEXT,
--    CONSTRAINT FK_BenefitsManagement_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE TimeAndAttendanceTracking (
--    TrackingID INT PRIMARY KEY,
--    EmployeeID INT,
--    TrackingDate DATE,
--    TrackingTime TIME,
--    CONSTRAINT FK_TimeAndAttendanceTracking_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE OnboardingAndOffboarding (
--    OnboardingID INT PRIMARY KEY,
--    EmployeeID INT,
--    OnboardingDate DATE,
--    OffboardingDate DATE,
--    CONSTRAINT FK_OnboardingAndOffboarding_Employee FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
--);

--CREATE TABLE HRAnalyticsAndReporting (
--    ReportID INT PRIMARY KEY,
--    ReportName VARCHAR(100),
--    Description TEXT
--);

--CREATE VIEW vw_payroll_summary AS
--SELECT p.EmployeeID, p.Month, p.Year, p.BasicSalary, p.Allowances, p.Deductions, p.NetSalary, e.FirstName, e.LastName
--FROM PayrollManagement p
--JOIN Employee e ON p.EmployeeID = e.EmployeeID;

--CREATE VIEW vw_attendance_leave AS
--SELECT a.EmployeeID, a.AttendanceDate, a.TimeIn, a.TimeOut, l.StartDate, l.EndDate, l.Duration, l.Reason
--FROM PayrollAttendance a
--LEFT JOIN Leave l ON a.EmployeeID = l.EmployeeID AND a.AttendanceDate BETWEEN l.StartDate AND l.EndDate;

--CREATE VIEW vw_total_working_hours AS
--SELECT pa.EmployeeID, SUM(pa.HoursWorked) AS TotalHoursWorked
--FROM PayrollAttendance pa
--GROUP BY pa.EmployeeID;

--CREATE VIEW vw_employee_payroll AS
--SELECT p.EmployeeID, p.Month, p.Year, p.BasicSalary, p.Allowances, p.Deductions, p.NetSalary, e.FirstName, e.LastName
--FROM PayrollManagement p
--JOIN Employee e ON p.EmployeeID = e.EmployeeID

--CREATE VIEW vw_total_overtime_hours AS
--SELECT EmployeeID, SUM(HoursWorked) AS TotalOvertimeHours
--FROM PayrollAttendance
--GROUP BY EmployeeID;

--CREATE VIEW vw_average_attendance_rate AS
--SELECT pa.EmployeeID, COUNT(pa.AttendanceID) / COUNT(DISTINCT(pa.AttendanceDate)) AS AverageAttendanceRate
--FROM PayrollAttendance pa
--GROUP BY pa.EmployeeID;

--CREATE VIEW vw_total_working_hours_monthly AS
--SELECT pa.EmployeeID, MONTH(pa.AttendanceDate) AS Month, YEAR(pa.AttendanceDate) AS Year, SUM(pa.HoursWorked) AS TotalHoursWorked
--FROM PayrollAttendance pa
--GROUP BY pa.EmployeeID, MONTH(pa.AttendanceDate), YEAR(pa.AttendanceDate);

--CREATE VIEW vw_employees_no_leave AS
--SELECT e.EmployeeID, e.FirstName, e.LastName
--FROM Employee e
--LEFT JOIN Leave l ON e.EmployeeID = l.EmployeeID
--WHERE l.LeaveID IS NULL;

-- Stored procedure to insert data into the Employee table
CREATE PROCEDURE sp_insert_employee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Position VARCHAR(50),
    @JoinDate DATE,
    @TotalWorkingHours DECIMAL(10, 2),
    @AverageAttendanceHours DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Employee (FirstName, LastName, DepartmentID, Position, JoinDate, TotalWorkingHours, AverageAttendanceHours)
    VALUES (@FirstName, @LastName, @DepartmentID, @Position, @JoinDate, @TotalWorkingHours, @AverageAttendanceHours);
END;

-- Stored procedure to update data in the Employee table
--CREATE PROCEDURE sp_update_employee
--    @EmployeeID INT,
--    @FirstName VARCHAR(50),
--    @LastName VARCHAR(50),
--    @DepartmentID INT,
--    @Position VARCHAR(50),
--    @JoinDate DATE,
--    @TotalWorkingHours DECIMAL(10, 2),
--    @AverageAttendanceHours DECIMAL(10, 2)
--AS
--BEGIN
--    UPDATE Employee
--    SET FirstName = @FirstName,
--        LastName = @LastName,
--        DepartmentID = @DepartmentID,
--        Position = @Position,
--        JoinDate = @JoinDate,
--        TotalWorkingHours = @TotalWorkingHours,
--        AverageAttendanceHours = @AverageAttendanceHours
--    WHERE EmployeeID = @EmployeeID;
--END;

------ Stored procedure to delete data from the Employee table
--CREATE PROCEDURE sp_delete_employee
--    @EmployeeID INT
--AS
--BEGIN
--    DELETE FROM Employee
--    WHERE EmployeeID = @EmployeeID;
--END;
