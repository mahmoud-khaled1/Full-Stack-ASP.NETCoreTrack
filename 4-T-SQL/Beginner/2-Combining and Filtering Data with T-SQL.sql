use NorthWind;

/*
- Some important  Keywords
1 - CTRL + K +C  ---> for comment all selected lines 
2 - CTRL + K + U ---> for uncomment all selected lines.
3 - CTRL + Z     ---> Undo 
4 - CTRL + Y     ---> redo

*/

-- T-SQL Cnoncatenation method 
select
		 FirstName+' '+LastName  AS [Full Name], -- string concatenation method
		 Concat(FirstName,' ',LastName) As [Full Name],--Concat method
		 CONCAT_WS(' ',FirstName, LastName)AS [Full Name] --Concat with separator method
from Employees;

-- -----------------------------------------------------------------
/*
-- Difference Between CAST and CONVERT 
a CONVERT function can be used for formatting purposes especially for
date/time, data type, and money/data type. Meanwhile, 
CAST is used to remove or reduce format while still converting. Also, 
CONVERT can stimulate set date format options while CAST cannot do this 
function.

*/
-- Cast() and Try_Cast()  Convert() Try_Convert() syntax
select GetDate(); -- retrun Date and time  

select cast(GetDate() as varchar); -- Casting Date to varchar then return it .
 
-- Error :Explicit conversion from data type datetime to image is not allowed.
select try_cast(GetDate() as image);

select Try_convert(int , 'Hi'); -- Null return 

-- -----------------------------------------------------------------

-- Formatting Strings

-- 1- Trim method is used to remove Leading Space 

-- return mahmoud without any space from left and right
select trim('  mahmod     ') AS [Name]; 

-- return mahmoud without any space from left ;
select ltrim('  mahmoud    ') as [Name];

-- return mahmoud without any space from right ;
select rtrim('  mahmoud    ') as [Name];


-- 2- Substring Method ---> Substring(expression,start,Length)

select FirstName,
	   LastName,
	   substring(trim(FirstName),1,1) as FirstNameBginningChar,
	   substring(trim(LastName),1,1) as LastNameBginningChar
from EmployeesUppercase;


select FirstName,
	   LastName,
	   substring(trim(FirstName),2,len(FirstName)) as FirstNameAllButFirstChar,
	   substring(trim(LastName),2,len(FirstName)) as LastNameAllButFirstChar
from EmployeesUppercase;

-- 3- Upper and Lower Methods 

select FirstName,
	   Lower(FirstName) AS SmallFirstName,
	   Upper(FirstName) AS CapitalFirstName
from EmployeesUppercase;

--4- Working with characters 

use NorthWind;
select * from EmployeesExtraCharacters;

declare @str as varchar(50);
set @str='** . **.Mahmoud&Khaled.***   '

print @str;

/*
	The REPLACE() function replaces all occurrences of a substring
	within a string, with a new substring.

	Syntax:
    REPLACE(string, old_string, new_string)
	
*/
-- Example
--Replace "SQL" with "HTML":

SELECT REPLACE('SQL Tutorial', 'SQL', 'HTML');

declare @str as varchar(50);
set @str='  ***Mahmoud***  '

set @str=trim(replace(@str,'***','')) -- replace *** with '' then remove spaces

print @str;

declare @str as varchar(50);
set @str=' - _() 1235***	&&& ### MahmouD _ ^^&&**   ';

set @str=trim(' - _ () _ *** &&& && ### ^ 1235' from lower(@str));

print @str;

-- --------------------------------------------------------------------
-- Simple Case Expression Example 


select 
      case when 1=5 then 
		   '1  equals 5 '
	  else 
	      '1 does not equals 5'
      end as result

select 
      case when 5>1 then 
		   '5 is greater than 1 '
	  when 5<1 then
	      '5 is lesser than 1'
      end as result

-- ---------------------------------------------------------------------
-- Formatting Numbers and Dates

select GetDate();

select format(GetDate(),'MM/d/yyyy') -- format date as month/day/year

select format(1000000000,'#,###,###,###') -- format number as 1,000,000,000

select ISNUMERIC('123') -- return 1

select ISNUMERIC('22ggf') -- return 0

--/* DATEDIFF */
SELECT DATEDIFF( d, '01/01/2025', '02/01/2025' ); --calculating returns 31 as an integer

SELECT CONCAT('There are ',DATEDIFF( d,GETDATE() ,'01/01/2025' ) , 
' days between 1/1/25 and '	, FORMAT(GETDATE(), 'MMM/dd/yyyy)')) -- won't work unless you concat with string and int must convert int first




/*Example:	if there is a hire date, return the hire date formatted, otherwise, 
	return the number of years an employee has worked for the company */
SELECT 
	CONCAT(dbo.Proper(LastName) , ', ' , dbo.Proper(FirstName)) as NameOfEmp,
	CASE WHEN  ISDATE(HireDate ) = 0 THEN
		'No hire date'
	WHEN DATEDIFF( YEAR, HireDate, GETDATE()) = 0 THEN
		'Less than 1 year'
	ELSE
		CAST(DATEDIFF( YEAR, HireDate, GETDATE()  )AS VARCHAR(50))
	END AS YearsWithCompany,
	CASE WHEN ISDATE(HireDate) = 1 THEN
		FORMAT(HireDate, 'MMM dd yyyy')
	ELSE		
		'Unknown' END AS HireDate
FROM Employees
ORDER BY 
	DATEDIFF( YEAR, HireDate, GETDATE() ) DESC;
 
/*
How long does it take from the time an order was placed to when it was shipped?
DATEDIFF(interval, date from, date to) returns an INT data type
*/
SELECT DATEDIFF(d, GETDATE(), '01/01/2060')
SELECT DATEDIFF(YEAR, GETDATE(), '01/01/2060')
SELECT DATEDIFF(n, GETDATE(), '01/01/2060') -- n => nanoseconds 

SELECT 
		OrderId, 
		CONVERT(VARCHAR,OrderDate, 101) AS OrderDate,
		CONVERT(VARCHAR,ShippedDate, 101) AS ShippedDate,
		DATEDIFF( d, OrderDate, ShippedDate ) AS ShippingTime
FROM Orders


SELECT 
		OrderId, 
		CASE WHEN OrderDate IS NULL THEN
			'no order date'
		ELSE 
			CONVERT(VARCHAR,OrderDate, 101) END AS OrderDate,
		CASE WHEN ShippedDate IS NULL THEN
			'not shipped'
		ELSE
			CONVERT(VARCHAR,ShippedDate, 101) END AS ShippedDate,
		CASE WHEN ShippedDate IS NULL THEN
			0
		ELSE
			DATEDIFF( d, OrderDate, ShippedDate ) END AS ShippingTime
FROM Orders



SELECT 
	DATENAME(DW, '06/25/2021') AS DayName,
	DATENAME(MONTH,'06/25/2021') AS MonthName,
	DATENAME(YEAR,'06/25/2021') AS YearName


SELECT
	FORMAT(OrderDate, 'MM/dd/yyyy') AS OrderDate,
	FORMAT(DATEADD(d,14,OrderDate), 'MM/dd/yyyy') AS ShippingDueDate
FROM Orders
ORDER BY OrderDate DESC, ShippingDueDate DESC


SELECT
		OrderId,
		FORMAT(OrderDate, 'MM/dd/yyyy') AS OrderDate,
		CASE WHEN DATENAME(dw, DATEADD(d,14, OrderDate)) = 'Sunday' THEN
			FORMAT(DATEADD(d,15,OrderDate), 'MM/dd/yyyy')
		WHEN DATENAME (dw, DATEADD(d, 14, OrderDate)) = 'Saturday' THEN
			FORMAT(DATEADD(d,15,OrderDate), 'MM/dd/yyyy')
		ELSE
			FORMAT(DATEADD(d,14,OrderDate), 'MM/dd/yyyy')
		END AS ShippingDueDate
FROM Orders
WHERE ShippedDate IS NULL
ORDER BY ShippingDueDate DESC


-- --------------------------------------------------------------
-- Joins 
-- Inner Join 

select * from Orders O 
JOIN [Order Details] OD 
on O.OrderID=OD.OrderID
order by O.OrderId;


SELECT o.OrderID,  
       FORMAT(o.OrderDate,'d', 'en-US') AS OrderDate,
	   FORMAT(o.ShippedDate,'d', 'en-US') AS ShippedDate,
	   o.ShipAddress,
	   p.ProductName,
	   FORMAT(od.UnitPrice, 'C', 'en-US') AS UnitPrice,
	   od.Quantity,
	   od.Discount,
	   FORMAT((od.unitprice * Quantity) - (od.unitprice * Quantity * Discount), 'C', 'en-us') AS Product_Cost       
FROM Orders o
     JOIN [Order Details] od ON o.OrderID = od.orderid 
	 JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate DESC;

-- Left Join 
use NorthWind;
SELECT o.OrderID,  
       FORMAT(o.OrderDate,'d', 'en-US') AS OrderDate,
	   FORMAT(o.ShippedDate,'d', 'en-US') AS ShippedDate,
	   o.ShipAddress,
	   p.ProductName,
	   FORMAT(od.UnitPrice, 'C', 'en-US') AS UnitPrice,
	   od.Quantity,
	   od.Discount,
	   FORMAT((od.unitprice * Quantity) - (od.unitprice * Quantity * Discount), 'C', 'en-us') AS Product_Cost       
FROM Products p
    left JOIN [Order Details] od ON p.ProductId = od.ProductId 
	left JOIN [Orders] o ON od.OrderID = o.OrderId 
	ORDER BY o.OrderDate DESC;

-- right Join
use NorthWind;
SELECT o.OrderID,  
       FORMAT(o.OrderDate,'d', 'en-US') AS OrderDate,
	   FORMAT(o.ShippedDate,'d', 'en-US') AS ShippedDate,
	   o.ShipAddress,
	   p.ProductName,
	   FORMAT(od.UnitPrice, 'C', 'en-US') AS UnitPrice,
	   od.Quantity,
	   od.Discount,
	   FORMAT((od.unitprice * Quantity) - (od.unitprice * Quantity * Discount), 'C', 'en-us') AS Product_Cost       
FROM Products p
    right JOIN [Order Details] od ON p.ProductId = od.ProductId 
	right JOIN [Orders] o ON od.OrderID = o.OrderId 
	ORDER BY o.OrderDate DESC;

-- Full Outer Join
SELECT p.ProductID as productId,
	   o.OrderID as orderId,
	   od.OrderID as OrderDetailsOrderId

FROM Products p
    full outer JOIN [Order Details] od ON p.ProductId = od.ProductId 
	 full outer JOIN [Orders] o ON od.OrderID = o.OrderId 
	ORDER BY o.OrderID DESC;
-- ----------------------------------------------------------------
-- Combining and Filtering Data with T-SQL

set ANSI_NULLS on;
select * from Orders where OrderDate is not null;

-- 
