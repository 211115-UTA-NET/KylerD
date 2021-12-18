CREATE TABLE Employee
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    SSN VARCHAR(50) NOT NULL,
    DeptID INT NOT NULL
)

CREATE TABLE Department
(
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50) NOT NULL,
    DeptLocation VARCHAR(100) NOT NULL
)

CREATE TABLE EmpDetails
(
    EmployeeID INT PRIMARY KEY,
    Salary MONEY NOT NULL,
    Address1 VARCHAR(250) NOT NULL,
    Address2 VARCHAR(250),
    aCity VARCHAR(100) NOT NULL,
    aState VARCHAR(100) NOT NULL,
    aCountry VARCHAR(100) NOT NULL
)

INSERT Employee (EmployeeID, FirstName, LastName, SSN, DeptID)
VALUES (1, 'Kyler', 'Dennis', 111111111, 10),
(2, 'Tina', 'Smith', 222222222, 11),
(3, 'Richard', 'Hawkins', 333333333, 10);

INSERT Department (DeptID, DeptName, DeptLocation)
VALUES (10, 'Software Development', 'Online Training'),
(11, 'Human Resources', 'Virtual Office'),
(12, 'Management', 'Virtual Office');

INSERT EmpDetails (EmployeeID, Salary, Address1, Address2, aCity, aState, aCountry)
VALUES (1, 60000, 'Kyler Address', 'Kyler Address Two', 'Kyler City', 'Kyler State', 'USA'),
(2, 70000, 'Tina Address', 'Tina Address Two', 'Tina City', 'Tina State', 'USA'),
(3, 65000, 'Richard Address', 'Richard Address Two', 'Richard City', 'Richard State', 'USA');

ALTER TABLE Employee
ADD FOREIGN KEY (DeptID) REFERENCES Department(DeptID);

ALTER TABLE EmpDetails
ADD FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);

SELECT * FROM Employee;
SELECT * FROM Department;
SELECT * FROM EmpDetails;

SELECT Employee.FirstName + ' ' + Employee.LastName AS EmployeeName, Department.DeptName
FROM Employee INNER JOIN Department
ON Employee.DeptID = Department.DeptID
WHERE Department.DeptName = 'Software Development'
ORDER BY Department.DeptName;

SELECT SUM(EmpDetails.Salary)
FROM EmpDetails FULL JOIN Employee
ON EmpDetails.EmployeeID = Employee.EmployeeID
FULL JOIN Department
ON Employee.DeptID = Department.DeptID
WHERE Department.DeptName = 'Software Development';