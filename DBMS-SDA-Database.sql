-- Employee table
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Gender VARCHAR(10),
    ContactNumber VARCHAR(20),
    EmailAddress VARCHAR(100),
    Address VARCHAR(100),
    DepartmentID INT,
    Position VARCHAR(50),
    EmploymentType VARCHAR(50),
    DateOfJoining DATE
);

-- Leave table
CREATE TABLE Leave (
    LeaveID INT PRIMARY KEY,
    EmployeeID INT,
    LeaveType VARCHAR(50),
    StartDate DATE,
    EndDate DATE,
    Duration INT,
    Reason VARCHAR(100),
    Status VARCHAR(50),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Payroll Attendance table
CREATE TABLE PayrollAttendance (
    AttendanceID INT PRIMARY KEY,
    EmployeeID INT,
    AttendanceDate DATE,
    TimeIn TIME,
    TimeOut TIME,
    HoursWorked DECIMAL(10, 2),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Employee Information Management table
CREATE TABLE EmployeeInformationManagement (
    EmployeeID INT PRIMARY KEY,
    SupervisorID INT,
    Education VARCHAR(100),
    Experience VARCHAR(100),
    Skills VARCHAR(100),
    Certification VARCHAR(100),
    Training VARCHAR(100),
    Salary DECIMAL(10, 2),
    BankAccountNumber VARCHAR(50),
    TaxID VARCHAR(50),
    EmergencyContact VARCHAR(50),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (SupervisorID) REFERENCES Employee(EmployeeID)
);

-- Attendance and Leave Management table
CREATE TABLE AttendanceAndLeaveManagement (
    EmployeeID INT PRIMARY KEY,
    TotalWorkingDays INT,
    TotalPresentDays INT,
    TotalAbsentDays INT,
    TotalLeaveDays INT,
    LateArrivalCount INT,
    EarlyDepartureCount INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Payroll Management table
CREATE TABLE PayrollManagement (
    PayrollID INT PRIMARY KEY,
    EmployeeID INT,
    Month INT,
    Year INT,
    BasicSalary DECIMAL(10, 2),
    Allowances DECIMAL(10, 2),
    Deductions DECIMAL(10, 2),
    NetSalary DECIMAL(10, 2),
    PaymentDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Recruitment and Applicant Tracking table
CREATE TABLE RecruitmentAndApplicantTracking (
    ApplicantID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    ContactNumber VARCHAR(20),
    EmailAddress VARCHAR(100),
    PositionApplied VARCHAR(50),
    ApplicationDate DATE,
    Status VARCHAR(50)
);

-- Benefits Management table
CREATE TABLE BenefitsManagement (
    BenefitID INT PRIMARY KEY,
    EmployeeID INT,
    BenefitType VARCHAR(50),
    StartDate DATE,
    EndDate DATE,
    Amount DECIMAL(10, 2),
    Description VARCHAR(100),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Time and Attendance Tracking table
CREATE TABLE TimeAndAttendanceTracking (
    EmployeeID INT,
    Date DATE,
    TimeIn TIME,
    TimeOut TIME,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Onboarding and Offboarding table
CREATE TABLE OnboardingAndOffboarding (
    EmployeeID INT PRIMARY KEY,
    DateOfJoining DATE,
    DateOfResignation DATE,
    ExitInterviewStatus VARCHAR(50),
    Feedback VARCHAR(100),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- HR Analytics and Reporting table
CREATE TABLE HRAnalyticsAndReporting (
    ReportID INT PRIMARY KEY,
    EmployeeID INT,
    ReportType VARCHAR(50),
    ReportDate DATE,
    ReportDescription VARCHAR(100),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Insert Leave
CREATE PROCEDURE sp_InsertLeave
(
    @EmployeeID INT,
    @LeaveType VARCHAR(50),
    @StartDate DATE,
    @EndDate DATE,
    @Duration DECIMAL(10, 2),
    @Reason VARCHAR(100),
    @Status VARCHAR(50)
)
AS
BEGIN
    INSERT INTO [Leave] (EmployeeID, LeaveType, StartDate, EndDate, Duration, Reason, Status)
    VALUES (@EmployeeID, @LeaveType, @StartDate, @EndDate, @Duration, @Reason, @Status);
END;

-- Update Leave
CREATE PROCEDURE sp_UpdateLeave
(
    @LeaveID INT,
    @LeaveType VARCHAR(50),
    @StartDate DATE,
    @EndDate DATE,
    @Duration DECIMAL(10, 2),
    @Reason VARCHAR(100),
    @Status VARCHAR(50)
)
AS
BEGIN
    UPDATE [Leave]
    SET LeaveType = @LeaveType,
        StartDate = @StartDate,
        EndDate = @EndDate,
        Duration = @Duration,
        Reason = @Reason,
        Status = @Status
    WHERE LeaveID = @LeaveID;
END;

-- Delete Leave
CREATE PROCEDURE sp_DeleteLeave
(
    @LeaveID INT
)
AS
BEGIN
    DELETE FROM [Leave]
    WHERE LeaveID = @LeaveID;
END;

 
-- Insert Payroll Attendance
CREATE PROCEDURE sp_InsertPayrollAttendance
(
    @EmployeeID INT,
    @AttendanceDate DATE,
    @TimeIn TIME,
    @TimeOut TIME,
    @HoursWorked DECIMAL(10, 2)
)
AS
BEGIN
    INSERT INTO PayrollAttendance (EmployeeID, AttendanceDate, TimeIn, TimeOut, HoursWorked)
    VALUES (@EmployeeID, @AttendanceDate, @TimeIn, @TimeOut, @HoursWorked);
END;

-- Update Payroll Attendance
CREATE PROCEDURE sp_UpdatePayrollAttendance
(
    @AttendanceID INT,
    @EmployeeID INT,
    @AttendanceDate DATE,
    @TimeIn TIME,
    @TimeOut TIME,
    @HoursWorked DECIMAL(10, 2)
)
AS
BEGIN
    UPDATE PayrollAttendance
    SET EmployeeID = @EmployeeID,
        AttendanceDate = @AttendanceDate,
        TimeIn = @TimeIn,
        TimeOut = @TimeOut,
        HoursWorked = @HoursWorked
    WHERE AttendanceID = @AttendanceID;
END;

-- Delete Payroll Attendance
CREATE PROCEDURE sp_DeletePayrollAttendance
(
    @AttendanceID INT
)
AS
BEGIN
    DELETE FROM PayrollAttendance
    WHERE AttendanceID = @AttendanceID;
END;

 
-- Insert Employee Information
CREATE PROCEDURE sp_InsertEmployeeInformation
(
    @EmployeeID INT,
    @SupervisorID INT,
    @Education VARCHAR(100),
    @Experience VARCHAR(100),
    @Skills VARCHAR(100),
    @Certification VARCHAR(100),
    @Training VARCHAR(100),
    @Salary DECIMAL(10, 2),
    @BankAccountNumber VARCHAR(50),
    @TaxID VARCHAR(50),
    @EmergencyContact VARCHAR(100)
)
AS
BEGIN
    INSERT INTO EmployeeInformationManagement (EmployeeID, SupervisorID, Education, Experience, Skills, Certification, Training, Salary, BankAccountNumber, TaxID, EmergencyContact)
    VALUES (@EmployeeID, @SupervisorID, @Education, @Experience, @Skills, @Certification, @Training, @Salary, @BankAccountNumber, @TaxID, @EmergencyContact);
END;

-- Update Employee Information
CREATE PROCEDURE sp_UpdateEmployeeInformation
(
    @EmployeeID INT,
    @SupervisorID INT,
    @Education VARCHAR(100),
    @Experience VARCHAR(100),
    @Skills VARCHAR(100),
    @Certification VARCHAR(100),
    @Training VARCHAR(100),
    @Salary DECIMAL(10, 2),
    @BankAccountNumber VARCHAR(50),
    @TaxID VARCHAR(50),
    @EmergencyContact VARCHAR(100)
)
AS
BEGIN
    UPDATE EmployeeInformationManagement
    SET SupervisorID = @SupervisorID,
        Education = @Education,
        Experience = @Experience,
        Skills = @Skills,
        Certification = @Certification,
        Training = @Training,
        Salary = @Salary,
        BankAccountNumber = @BankAccountNumber,
        TaxID = @TaxID,
        EmergencyContact = @EmergencyContact
    WHERE EmployeeID = @EmployeeID;
END;

-- Delete Employee Information
CREATE PROCEDURE sp_DeleteEmployeeInformation
(
    @EmployeeID INT
)
AS
BEGIN
    DELETE FROM EmployeeInformationManagement
    WHERE EmployeeID = @EmployeeID;
END;


 
-- Insert Attendance and Leave Management
CREATE PROCEDURE sp_InsertAttendanceAndLeaveManagement
(
    @EmployeeID INT,
    @TotalWorkingDays INT,
    @TotalPresentDays INT,
    @TotalAbsentDays INT,
    @TotalLeaveDays INT,
    @LateArrivalCount INT,
    @EarlyDepartureCount INT
)
AS
BEGIN
    INSERT INTO AttendanceAndLeaveManagement (EmployeeID, TotalWorkingDays, TotalPresentDays, TotalAbsentDays, TotalLeaveDays, LateArrivalCount, EarlyDepartureCount)
    VALUES (@EmployeeID, @TotalWorkingDays, @TotalPresentDays, @TotalAbsentDays, @TotalLeaveDays, @LateArrivalCount, @EarlyDepartureCount);
END;

-- Update Attendance and Leave Management
CREATE PROCEDURE sp_UpdateAttendanceAndLeaveManagement
(
    @EmployeeID INT,
    @TotalWorkingDays INT,
    @TotalPresentDays INT,
    @TotalAbsentDays INT,
    @TotalLeaveDays INT,
    @LateArrivalCount INT,
    @EarlyDepartureCount INT
)
AS
BEGIN
    UPDATE AttendanceAndLeaveManagement
    SET TotalWorkingDays = @TotalWorkingDays,
        TotalPresentDays = @TotalPresentDays,
        TotalAbsentDays = @TotalAbsentDays,
        TotalLeaveDays = @TotalLeaveDays,
        LateArrivalCount = @LateArrivalCount,
        EarlyDepartureCount = @EarlyDepartureCount
    WHERE EmployeeID = @EmployeeID;
END;

-- Delete Attendance and Leave Management
CREATE PROCEDURE sp_DeleteAttendanceAndLeaveManagement
(
    @EmployeeID INT
)
AS
BEGIN
    DELETE FROM AttendanceAndLeaveManagement
    WHERE EmployeeID = @EmployeeID;
END;

 
-- Insert Payroll Management
CREATE PROCEDURE sp_InsertPayrollManagement
(
    @EmployeeID INT,
    @PayrollID INT,
    @Month INT,
    @Year INT,
    @BasicSalary DECIMAL(10, 2),
    @Allowances DECIMAL(10, 2),
    @Deductions DECIMAL(10, 2),
    @NetSalary DECIMAL(10, 2),
    @PaymentDate DATE
)
AS
BEGIN
    INSERT INTO PayrollManagement (EmployeeID, PayrollID, Month, Year, BasicSalary, Allowances, Deductions, NetSalary, PaymentDate)
    VALUES (@EmployeeID, @PayrollID, @Month, @Year, @BasicSalary, @Allowances, @Deductions, @NetSalary, @PaymentDate);
END;

-- Update Payroll Management
CREATE PROCEDURE sp_UpdatePayrollManagement
(
    @EmployeeID INT,
    @PayrollID INT,
    @Month INT,
    @Year INT,
    @BasicSalary DECIMAL(10, 2),
    @Allowances DECIMAL(10, 2),
    @Deductions DECIMAL(10, 2),
    @NetSalary DECIMAL(10, 2),
    @PaymentDate DATE
)
AS
BEGIN
    UPDATE PayrollManagement
    SET PayrollID = @PayrollID,
        Month = @Month,
        Year = @Year,
        BasicSalary = @BasicSalary,
        Allowances = @Allowances,
        Deductions = @Deductions,
        NetSalary = @NetSalary,
        PaymentDate = @PaymentDate
    WHERE EmployeeID = @EmployeeID;
END;

-- Delete Payroll Management
CREATE PROCEDURE sp_DeletePayrollManagement
(
    @EmployeeID INT
)
AS
BEGIN
    DELETE FROM PayrollManagement
    WHERE EmployeeID = @EmployeeID;
END;
 
-- Insert Recruitment and Applicant Tracking
CREATE PROCEDURE sp_InsertRecruitmentAndApplicantTracking
(
    @ApplicantID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @ContactNumber VARCHAR(20),
    @EmailAddress VARCHAR(100),
    @PositionApplied VARCHAR(50),
    @ApplicationDate DATE,
    @Status VARCHAR(50)
)
AS
BEGIN
    INSERT INTO RecruitmentAndApplicantTracking (ApplicantID, FirstName, LastName, ContactNumber, EmailAddress, PositionApplied, ApplicationDate, Status)
    VALUES (@ApplicantID, @FirstName, @LastName, @ContactNumber, @EmailAddress, @PositionApplied, @ApplicationDate, @Status);
END;

-- Update Recruitment and Applicant Tracking
CREATE PROCEDURE sp_UpdateRecruitmentAndApplicantTracking
(
    @ApplicantID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @ContactNumber VARCHAR(20),
    @EmailAddress VARCHAR(100),
    @PositionApplied VARCHAR(50),
    @ApplicationDate DATE,
    @Status VARCHAR(50)
)
AS
BEGIN
    UPDATE RecruitmentAndApplicantTracking
    SET FirstName = @FirstName,
        LastName = @LastName,
        ContactNumber = @ContactNumber,
        EmailAddress = @EmailAddress,
        PositionApplied = @PositionApplied,
        ApplicationDate = @ApplicationDate,
        Status = @Status
    WHERE ApplicantID = @ApplicantID;
END;

-- Delete Recruitment and Applicant Tracking
CREATE PROCEDURE sp_DeleteRecruitmentAndApplicantTracking
(
    @ApplicantID INT
)
AS
BEGIN
    DELETE FROM RecruitmentAndApplicantTracking
    WHERE ApplicantID = @ApplicantID;
END;

 
-- Insert Benefits Management
CREATE PROCEDURE sp_InsertBenefitsManagement
(
    @BenefitID INT,
    @EmployeeID INT,
    @BenefitType VARCHAR(50),
    @StartDate DATE,
    @EndDate DATE,
    @Amount DECIMAL(10, 2),
    @Description VARCHAR(100)
)
AS
BEGIN
    INSERT INTO BenefitsManagement (BenefitID, EmployeeID, BenefitType, StartDate, EndDate, Amount, Description)
    VALUES (@BenefitID, @EmployeeID, @BenefitType, @StartDate, @EndDate, @Amount, @Description);
END;

-- Update Benefits Management
CREATE PROCEDURE sp_UpdateBenefitsManagement
(
    @BenefitID INT,
    @EmployeeID INT,
    @BenefitType VARCHAR(50),
    @StartDate DATE,
    @EndDate DATE,
    @Amount DECIMAL(10, 2),
    @Description VARCHAR(100)
)
AS
BEGIN
    UPDATE BenefitsManagement
    SET EmployeeID = @EmployeeID,
        BenefitType = @BenefitType,
        StartDate = @StartDate,
        EndDate = @EndDate,
        Amount = @Amount,
        Description = @Description
    WHERE BenefitID = @BenefitID;
END;

-- Delete Benefits Management
CREATE PROCEDURE sp_DeleteBenefitsManagement
(
    @BenefitID INT
)
AS
BEGIN
    DELETE FROM BenefitsManagement
    WHERE BenefitID = @BenefitID;
END;
 
-- Insert Time and Attendance Tracking
CREATE PROCEDURE sp_InsertTimeAndAttendanceTracking
(
    @EmployeeID INT,
    @Date DATE,
    @TimeIn TIME,
    @TimeOut TIME
)
AS
BEGIN
    INSERT INTO TimeAndAttendanceTracking (EmployeeID, Date, TimeIn, TimeOut)
    VALUES (@EmployeeID, @Date, @TimeIn, @TimeOut);
END;

-- Update Time and Attendance Tracking
CREATE PROCEDURE sp_UpdateTimeAndAttendanceTracking
(
    @EmployeeID INT,
    @Date DATE,
    @TimeIn TIME,
    @TimeOut TIME
)
AS
BEGIN
    UPDATE TimeAndAttendanceTracking
    SET TimeIn = @TimeIn,
        TimeOut = @TimeOut
    WHERE EmployeeID = @EmployeeID AND Date = @Date;
END;

-- Delete Time and Attendance Tracking
CREATE PROCEDURE sp_DeleteTimeAndAttendanceTracking
(
    @EmployeeID INT,
    @Date DATE
)
AS
BEGIN
    DELETE FROM TimeAndAttendanceTracking
    WHERE EmployeeID = @EmployeeID AND Date = @Date;
END;
 
-- Insert Onboarding and Offboarding
CREATE PROCEDURE sp_InsertOnboardingAndOffboarding
(
    @EmployeeID INT,
    @DateOfJoining DATE,
    @DateOfResignation DATE,
    @ExitInterviewStatus VARCHAR(50),
    @Feedback VARCHAR(100)
)
AS
BEGIN
    INSERT INTO OnboardingAndOffboarding (EmployeeID, DateOfJoining, DateOfResignation, ExitInterviewStatus, Feedback)
    VALUES (@EmployeeID, @DateOfJoining, @DateOfResignation, @ExitInterviewStatus, @Feedback);
END;

-- Update Onboarding and Offboarding
CREATE PROCEDURE sp_UpdateOnboardingAndOffboarding
(
    @EmployeeID INT,
    @DateOfJoining DATE,
    @DateOfResignation DATE,
    @ExitInterviewStatus VARCHAR(50),
    @Feedback VARCHAR(100)
)
AS
BEGIN
    UPDATE OnboardingAndOffboarding
    SET DateOfJoining = @DateOfJoining,
        DateOfResignation = @DateOfResignation,
        ExitInterviewStatus = @ExitInterviewStatus,
        Feedback = @Feedback
    WHERE EmployeeID = @EmployeeID;
END;

-- Delete Onboarding and Offboarding
CREATE PROCEDURE sp_DeleteOnboardingAndOffboarding
(
    @EmployeeID INT
)
AS
BEGIN
    DELETE FROM OnboardingAndOffboarding
    WHERE EmployeeID = @EmployeeID;
END;
 
-- Insert HR Analytics and Reporting
CREATE PROCEDURE sp_InsertHRAnalyticsAndReporting
(
    @ReportID INT,
    @EmployeeID INT,
    @ReportType VARCHAR(50),
    @ReportDate DATE,
    @ReportDescription VARCHAR(100)
)
AS
BEGIN
    INSERT INTO HRAnalyticsAndReporting (ReportID, EmployeeID, ReportType, ReportDate, ReportDescription)
    VALUES (@ReportID, @EmployeeID, @ReportType, @ReportDate, @ReportDescription);
END;

-- Update HR Analytics and Reporting
CREATE PROCEDURE sp_UpdateHRAnalyticsAndReporting
(
    @ReportID INT,
    @EmployeeID INT,
    @ReportType VARCHAR(50),
    @ReportDate DATE,
    @ReportDescription VARCHAR(100)
)
AS
BEGIN
    UPDATE HRAnalyticsAndReporting
    SET EmployeeID = @EmployeeID,
        ReportType = @ReportType,
        ReportDate = @ReportDate,
        ReportDescription = @ReportDescription
    WHERE ReportID = @ReportID;
END;

-- Delete HR Analytics and Reporting
CREATE PROCEDURE sp_DeleteHRAnalyticsAndReporting
(
    @ReportID INT
)
AS
BEGIN
    DELETE FROM HRAnalyticsAndReporting
    WHERE ReportID = @ReportID;
END;

CREATE VIEW ClockInOutView AS
SELECT
    EmployeeID,
    AttendanceDate,
    MIN(TimeIn) AS ClockInTime,
    MAX(TimeOut) AS ClockOutTime
FROM
    PayrollAttendance
GROUP BY
    EmployeeID, AttendanceDate;

CREATE VIEW BreakDurationView AS
SELECT
    EmployeeID,
    TrackingDate,
    CAST(MIN(TrackingTime) AS TIME) AS BreakStart,
    CAST(MAX(TrackingTime) AS TIME) AS BreakEnd,
    DATEDIFF(MINUTE, MIN(TrackingTime), MAX(TrackingTime)) AS BreakDuration
FROM
    TimeAndAttendanceTracking
WHERE
    TimeIn IS NOT NULL -- Exclude rows without clock-in time
GROUP BY
    EmployeeID,
    TrackingDate;

CREATE VIEW OvertimeHoursView AS
SELECT
    EmployeeID,
    AttendanceDate,
    SUM(HoursWorked - RegularHours) AS OvertimeHours
FROM
    AttendanceAndLeaveManagement
GROUP BY
    EmployeeID, AttendanceDate;


	CREATE VIEW LeaveRequestsView AS
SELECT
    a.RecordID,
    a.EmployeeID,
    a.Date,
    a.Status,
    a.TotalWorkingDays,
    a.TotalPresentDays,
    a.TotalAbsentDays,
    a.TotalLeaveDays,
    a.LateArrivalCount,
    a.EarlyDepartureCount,
    e.FirstName,
    e.LastName
FROM AttendanceAndLeaveManagement a
JOIN Employee e ON a.EmployeeID = e.EmployeeID
WHERE a.Status = 'Pending';

CREATE VIEW LeaveBalancesView AS
SELECT
    a.EmployeeID,
    SUM(a.TotalLeaveDays) AS TotalLeaveBalance
FROM AttendanceAndLeaveManagement a
WHERE a.Status = 'Approved'
GROUP BY a.EmployeeID;

CREATE VIEW ApprovedLeaveView AS
SELECT
    RecordID,
    EmployeeID,
    Date,
    TotalLeaveDays
FROM AttendanceAndLeaveManagement
WHERE Status = 'Approved';


CREATE VIEW AttendanceUpdateView AS
SELECT
    RecordID,
    EmployeeID,
    Date,
    TotalWorkingDays,
    TotalPresentDays,
    TotalAbsentDays,
    CASE WHEN Status = 'Approved' THEN TotalLeaveDays ELSE 0 END AS ApprovedLeaveDays,
    LateArrivalCount,
    EarlyDepartureCount
FROM AttendanceAndLeaveManagement;

CREATE VIEW PayPeriodSalaryView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    e.Position,
    e.DepartmentID,
    pm.Month,
    pm.Year,
    pm.NetSalary
FROM
    Employee e
    JOIN PayrollManagement pm ON e.EmployeeID = pm.EmployeeID;

CREATE VIEW OvertimeCalculationView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    p.AttendanceDate,
    p.HoursWorked,
    CASE
        WHEN p.HoursWorked > 40 THEN (p.HoursWorked - 40)
        ELSE 0
    END AS OvertimeHours
FROM
    Employee e
    JOIN PayrollAttendance p ON e.EmployeeID = p.EmployeeID;

CREATE VIEW PayrollReportView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    pm.Month,
    pm.Year,
    pm.BasicSalary,
    pm.Deductions,
    (pm.BasicSalary - pm.Deductions) AS NetSalary
FROM
    Employee e
    JOIN PayrollManagement pm ON e.EmployeeID = pm.EmployeeID;

CREATE VIEW PayslipView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    e.DepartmentID,
    pm.Month,
    pm.Year,
    pm.BasicSalary,
    pm.Allowances,
    pm.Deductions,
    (pm.BasicSalary + pm.Allowances - pm.Deductions) AS GrossAmount,
    (pm.BasicSalary + pm.Allowances - pm.Deductions) * 0.8 AS NetAmount -- Assuming 20% tax deduction
FROM
    Employee e
    JOIN PayrollManagement pm ON e.EmployeeID = pm.EmployeeID
    JOIN EmployeeInformationManagement em ON e.EmployeeID = em.EmployeeID;

	CREATE VIEW LeaveUsageView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    l.LeaveType,
    l.StartDate,
    l.EndDate,
    l.Duration,
    l.Reason,
    l.Status
FROM
    Employee e
    JOIN Leave l ON e.EmployeeID = l.EmployeeID;

	CREATE VIEW PayrollExpenseView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    pm.Month,
    pm.Year,
    pm.BasicSalary,
    pm.Allowances,
    pm.Deductions,
    pm.NetSalary
FROM
    Employee e
    JOIN PayrollManagement pm ON e.EmployeeID = pm.EmployeeID;

CREATE VIEW EmployeeAttendanceView AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    al.TotalWorkingDays,
    al.TotalPresentDays,
    al.TotalAbsentDays,
    al.TotalLeaveDays,
    al.LateArrivalCount,
    al.EarlyDepartureCount
FROM
    Employee e
    JOIN AttendanceAndLeaveManagement al ON e.EmployeeID = al.EmployeeID;

SELECT * FROM Payslip