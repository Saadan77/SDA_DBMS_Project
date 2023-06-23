CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Position VARCHAR(50),
    @JoinDate DATE,
    @TotalWorkingHours DECIMAL(10, 2),
    @AverageAttendanceHours DECIMAL(10, 2)
AS
BEGIN
    IF (@FirstName IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET FirstName = @FirstName
        WHERE EmployeeID = @EmployeeID;
    END

    IF (@LastName IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET LastName = @LastName
        WHERE EmployeeID = @EmployeeID;
    END

    -- Add more IF conditions for other parameters and corresponding columns

    IF (@DepartmentID IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET DepartmentID = @DepartmentID
        WHERE EmployeeID = @EmployeeID;
    END

    IF (@Position IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET Position = @Position
        WHERE EmployeeID = @EmployeeID;
    END

    IF (@JoinDate IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET JoinDate = @JoinDate
        WHERE EmployeeID = @EmployeeID;
    END

    IF (@TotalWorkingHours IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET TotalWorkingHours = @TotalWorkingHours
        WHERE EmployeeID = @EmployeeID;
    END

    IF (@AverageAttendanceHours IS NOT NULL)
    BEGIN
        UPDATE Employee
        SET AverageAttendanceHours = @AverageAttendanceHours
        WHERE EmployeeID = @EmployeeID;
    END
END;
