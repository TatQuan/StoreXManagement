CREATE TABLE CategoryList(
CategoryID INT IDENTITY(1,1) PRIMARY KEY,
CategoryName NVARCHAR(100)
)

CREATE TABLE Product(
ProductID INT IDENTITY(1,1) PRIMARY KEY,
ProductName NVARCHAR(255),
Price DECIMAL(15,2),
InventoryQuantity INT,
CategoryID INT FOREIGN KEY REFERENCES CategoryList(CategoryID),
Image VARBINARY(max)
)

CREATE TABLE Customer(
CustomerID INT IDENTITY(1,1) PRIMARY KEY,
CustomerName NVARCHAR(100),
PhoneNumber INT,
Address NVARCHAR(max)
)

CREATE TABLE Employee(
EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
EmployeeName NVARCHAR(100),
Position NVARCHAR(50),
Username NVARCHAR(max),
Password NVARCHAR(max)
)

CREATE TABLE Invoice(
InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
InvoicingDate DATE
)

CREATE TABLE InvoiceDetails(
InvoiceDetailsID INT PRIMARY KEY IDENTITY(1,1),
InvoiceID INT FOREIGN KEY REFERENCES Invoice(InvoiceID) ON DELETE CASCADE,
EmployeeID INT FOREIGN KEY REFERENCES Employee(EmployeeID),
ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
QuantityPurchase INT
)

CREATE TABLE InventoryTransactions(
TransactionID INT PRIMARY KEY IDENTITY(1,1),
ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
TransactionType NVARCHAR(20),
Quantity INT,
TransactionDate DATE,
EmployeeID INT FOREIGN KEY REFERENCES Employee(EmployeeID)
)

DROP TABLE InvoiceDetails
DROP TABLE Invoice
DROP TABLE Product

SELECT 
    'IV' + RIGHT('00000' + CAST(Invoice.InvoiceID AS VARCHAR(5)), 5) AS formattedInvoice_id,
    Customer.CustomerName,
    Employee.EmployeeName,
    Invoice.InvoicingDate,
    (InvoiceDetails.QuantityPurchase * Product.Price) AS TotalPrice
FROM 
    InvoiceDetails
JOIN
    Invoice ON Invoice.InvoiceID = InvoiceDetails.InvoiceID
JOIN
    Product ON Product.ProductID = InvoiceDetails.ProductID
JOIN
    Customer ON Customer.CustomerID = Invoice.CustomerID
JOIN
    Employee ON Employee.EmployeeID = InvoiceDetails.EmployeeID

SELECT * FROM InvoiceDetails
SELECT * FROM Invoice
SELECT * FROM Product

SELECT 
    'IV' + RIGHT('00000' + CAST(MIN(Invoice.InvoiceID) AS VARCHAR(5)), 5) AS formattedInvoice_id, 
    Customer.CustomerName,
    Employee.EmployeeName,
    MIN(Invoice.InvoicingDate) AS InvoicingDate, 
    SUM(InvoiceDetails.QuantityPurchase * Product.Price) AS TotalPrice
FROM 
    InvoiceDetails
JOIN
    Invoice ON Invoice.InvoiceID = InvoiceDetails.InvoiceID
JOIN

    Product ON Product.ProductID = InvoiceDetails.ProductID
JOIN
    Customer ON Customer.CustomerID = Invoice.CustomerID
JOIN
    Employee ON Employee.EmployeeID = InvoiceDetails.EmployeeID
GROUP BY 
    Customer.CustomerID, Employee.EmployeeID, Customer.CustomerName, Employee.EmployeeName


--Select update
SELECT 
    Customer.CustomerName, Employee.EmployeeName, Invoice.InvoicingDate, 
    Product.ProductName, InvoiceDetails.QuantityPurchase, Product.Price 
FROM 
    InvoiceDetails
JOIN 
    Invoice ON Invoice.InvoiceID = InvoiceDetails.InvoiceID
JOIN 
    Product ON Product.ProductID = InvoiceDetails.ProductID
JOIN 
    Customer ON Customer.CustomerID = Invoice.CustomerID
JOIN 
    Employee ON Employee.EmployeeID = InvoiceDetails.EmployeeID
WHERE 
    Customer.CustomerName = 'Phan Quang Binh'
    AND Employee.EmployeeName = 'NguyenTatQuan'

SELECT * FROM InventoryTransactions
DROP TABLE InventoryTransactions


SELECT 
    InvoiceDetails.ProductID,
    Product.ProductName, 
    InvoiceDetails.QuantityPurchase, 
    InvoiceDetails.QuantityPurchase * Product.Price AS TotalPrice
FROM 
    InvoiceDetails
JOIN 
    Invoice ON Invoice.InvoiceID = InvoiceDetails.InvoiceID
JOIN 
    Product ON Product.ProductID = InvoiceDetails.ProductID
JOIN 
    Customer ON Customer.CustomerID = Invoice.CustomerID
JOIN 
    Employee ON Employee.EmployeeID = InvoiceDetails.EmployeeID
WHERE 
    Customer.CustomerName = 'Phan Quang Binh'
    AND Employee.EmployeeName = 'NguyenTatQuan'

UPDATE Invoice SET CustomerID = @CusID WHERE InvoiceID = @InID 


