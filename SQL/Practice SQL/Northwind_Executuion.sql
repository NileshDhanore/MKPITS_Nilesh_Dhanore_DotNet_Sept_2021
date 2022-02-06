SELECT City FROM Customers;
select distinct country from customers;
SELECT * FROM Customers;
SELECT CompanyName,City FROM Customers;
SELECT Country FROM Customers;
SELECT distinct Country FROM Customers;  /*If repeat then show one time*/
SELECT COUNT(DISTINCT Country) FROM Customers;   /*Used to give the count of distinct country*/
/* SELECT COUNT(DISTINCT Country) FROM Customers; this Query is not used by MS Access because of Firefox so 
in place of this in MS Access SELECT Count(*) AS DistinctCountries FROM (SELECT DISTINCT Country FROM Customers); Query is Used*/


SELECT * FROM Customers WHERE Country='Germany' AND City='Berlin';
SELECT * FROM Customers WHERE City='Berlin' OR City='München';
SELECT * FROM Customers WHERE NOT Country='Germany';
SELECT * FROM Customers WHERE Country='Germany' AND (City='Berlin' OR City='München');
SELECT * FROM Customers WHERE NOT Country='Germany' AND NOT Country='USA';

/*Order By
SELECT column1, column2, ... FROM table_name ORDER BY column1, column2, ... ASC|DESC;*/
SELECT * FROM Customers ORDER BY Country;
SELECT * FROM Customers ORDER BY Country DESC;
SELECT * FROM Customers ORDER BY Country, ContactName;
SELECT * FROM Customers ORDER BY Country ASC, ContactName DESC;

/*INSERT INTO table_name (column1, column2, column3, ...) VALUES (value1, value2, value3, ...);
or
INSERT INTO table_nameVALUES (value1, value2, value3, ...);    when you want to enter all values  */
/*When value Not null then compulsory insert that value every time*/ 

INSERT INTO Customers (CustomerID,CompanyName, ContactName, [Address], City, PostalCode, Country) VALUES ('BKYY', 'Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');


/* What is use of NULL
It is not possible to test for NULL values with comparison operators, such as =, <, or <>. We will have to use the IS NULL and IS NOT NULL operators instead.*/
SELECT CompanyName, ContactName, Address FROM Customers WHERE Address IS NOT NULL; /*Select non empty value*/
SELECT CompanyName, ContactName, Address FROM Customers WHERE Address IS NULL; /*Select empty value*/

/*SQL UPDATE Statement
UPDATE table_name SET column1 = value1, column2 = value2, ... WHERE condition;*/
UPDATE Customers SET ContactName = 'Alfred Schmidt', City= 'Frankfurt' WHERE CustomerID = 'arout';
UPDATE Customers SET ContactName='Juan' WHERE Country='Mexico';

/* The SQL DELETE Statement
DELETE FROM table_name WHERE condition;*/
DELETE FROM Customers WHERE ContactName='Juan';

/*SQL TOP, LIMIT, FETCH FIRST or ROWNUM Clause top is used for SQL and MS access  and others are for other databases
SELECT TOP numberor percent column_name(s) FROM table_name WHERE condition;*/

SELECT TOP 3 * FROM Customers;
SELECT TOP 50 PERCENT * FROM Customers;

/*The SQL MIN() and MAX() Functions
SELECT MIN or MAX(column_name) FROM table_name WHERE condition;*/
SELECT MIN(UnitPrice) AS SmallestPrice FROM Products;  /*As is used to change the name of column name*/
SELECT MAX(UnitPrice) AS LargestPrice FROM Products;

/*SQL COUNT(), AVG() and SUM() Functions
SELECT COUNT or AVG or SUM(column_name) FROM table_name WHERE condition;*/
SELECT COUNT(ProductName) As Productcount FROM Products;
SELECT AVG(UnitPrice) FROM Products;
SELECT SUM(UnitPrice) FROM Products;     