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

CREATE PROCEDURE sp_UpdateBenefits
    @BenefitID INT,
    @EmployeeID INT,
    @BenefitType VARCHAR(50),
    @StartDate DATE,
    @EndDate DATE,
	@Descripition varchar(50),
	@Amount INT
AS
BEGIN
    IF (@EmployeeID IS NOT NULL)
    BEGIN
        UPDATE BenefitsManagement
        SET EmployeeID = @EmployeeID
        WHERE BenefitID = @BenefitID;
    END

    IF (@BenefitType IS NOT NULL)
    BEGIN
        UPDATE BenefitsManagement
        SET BenefitType = @BenefitType 
        WHERE BenefitID = @BenefitID ;
    END

    -- Add more IF conditions for other parameters and corresponding columns

    IF (@StartDate IS NOT NULL)
    BEGIN
        UPDATE BenefitsManagement
        SET StartDate = @StartDate
        WHERE BenefitID = @BenefitID ;
    END

    IF (@EndDate IS NOT NULL)
    BEGIN
        UPDATE BenefitsManagement
        SET EndDate = @EndDate
        WHERE BenefitID = @BenefitID;
    END

    IF (@Amount IS NOT NULL)
    BEGIN
        UPDATE BenefitsManagement
        SET Amount = @Amount
        WHERE BenefitID = @BenefitID;
    END

    IF (@Descripition IS NOT NULL)
    BEGIN
        UPDATE BenefitsManagement
        SET Description = @Descripition
        WHERE BenefitID = @BenefitID;
    END
END;
