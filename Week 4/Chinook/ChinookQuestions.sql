--For each of the following exercises, provide the appropriate query.
--Keep your successful queries in a chinook-queries.sql file.

--1) Provide a query showing Customers (just their full names, customer ID and country) who are not in the US.
SELECT * FROM Customer;
SELECT CustomerID, FirstName, LastName, Country
FROM Customer
WHERE NOT Country = 'USA';

--2) Provide a query only showing the Customers from Brazil.
SELECT * FROM Customer
WHERE Country = 'Brazil';

--3) Provide a query showing the Invoices of customers who are from Brazil. The resultant table should show the customer's full name, Invoice ID, Date of the invoice and billing country.
SELECT Customer.FirstName, Customer.LastName, Invoice.InvoiceID, Invoice.InvoiceDate, Invoice.BillingCountry
FROM Customer FULL JOIN Invoice
ON Customer.CustomerID = Invoice.InvoiceID
WHERE Customer.Country = 'Brazil';

--4) Provide a query showing only the Employees who are Sales Agents.
SELECT * FROM Employee;
SELECT * FROM Employee
WHERE Title = 'Sales Support Agent';

--5) Provide a query showing a unique list of billing countries from the Invoice table.
SELECT DISTINCT BillingCountry
FROM Invoice;

--6) Provide a query that shows the invoices associated with each sales agent. The resultant table should include the Sales Agent's full name.
SELECT * FROM Invoice; --Customer ID;
SELECT * FROM Customer; --CustomerID, SupportRepID;
SELECT * FROM Employee; --EmployeeID;

SELECT Invoice.InvoiceId, Employee.FirstName, Employee.LastName, Employee.EmployeeId
FROM Invoice FULL JOIN Customer
ON Invoice.CustomerId = Customer.CustomerId
FULL JOIN Employee
ON Customer.SupportRepId = Employee.EmployeeId
WHERE Employee.Title = 'Sales Support Agent'
ORDER BY InvoiceID;

--7) Provide a query that shows the Invoice Total, Customer name, Country and Sale Agent name for all invoices and customers.
SELECT  Invoice.Total, Customer.FirstName, Customer.LastName, Customer.Country, Employee.FirstName, Employee.LastName
FROM Invoice FULL JOIN Customer
ON Invoice.CustomerId = Customer.CustomerId
FULL JOIN Employee
ON Customer.SupportRepId = Employee.EmployeeId
WHERE Employee.Title = 'Sales Support Agent'
ORDER BY Invoice.Total;

--8) How many Invoices were there in 2009 and 2011? What are the respective total sales for each of those years?
SELECT * FROM Invoice;
SELECT InvoiceID, InvoiceDate
FROM Invoice
WHERE 2009 = YEAR(InvoiceDate) OR 2011 = YEAR(InvoiceDate); --166 invoices

--9) Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for Invoice ID 37.
SELECT * FROM InvoiceLine
WHERE InvoiceID = 37;

--10) Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for each Invoice. HINT: GROUP BY
SELECT * FROM InvoiceLine;

--11) Provide a query that includes the track name with each invoice line item.
--12) Provide a query that includes the purchased track name AND artist name with each invoice line item.
--13) Provide a query that shows the # of invoices per country. HINT: GROUP BY
--14) Provide a query that shows the total number of tracks in each playlist. The Playlist name should be included on the resultant table.
--15) Provide a query that shows all the Tracks, but displays no IDs. The resultant table should include the Album name, Media type and Genre.
--Provide a query that shows all Invoices but includes the # of invoice line items.
--Provide a query that shows total sales made by each sales agent.
--Which sales agent made the most in sales in 2009?
--Which sales agent made the most in sales in 2010?
--Which sales agent made the most in sales over all?
--Provide a query that shows the # of customers assigned to each sales agent.
--Provide a query that shows the total sales per country. Which country's customers spent the most?
--Provide a query that shows the most purchased track of 2013.
--Provide a query that shows the top 5 most purchased tracks over all.
--Provide a query that shows the top 3 best selling artists.
--Provide a query that shows the most purchased Media Type.
--Provide a query that shows the number tracks purchased in all invoices that contain more than one genre.