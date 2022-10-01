select round(avg(freight), 0) as [average freight cost]
from Orders


select max(freight)
from Orders

--Create a report that shows all the orders where the freight cost more than $500


select OrderID ,freight
from Orders
WHERE freight >500 

--1.Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.

select CategoryName,Description
FROM Categories
Order by CategoryName

--2.Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table sorted by Phone.

select ContactName, CompanyName, ContactTitle,Phone
FROM Suppliers
ORDER BY Phone

--3.Create a report that shows the top 10 OrderID, OrderDate, ShippedDate,
-- CustomerID, Freight from the orders table sorted by Freight in descending order.
 
 SELECT TOP 10 OrderID, OrderDate, ShippedDate,CustomerID, Freight
 FROM Orders
 order by Freight desc

 --4. Create a report that shows the City, CompanyName, ContactName of customers from cities starting with A or B.

 SELECT City, CompanyName, ContactName
 FROM Customers
 WHERE city like 'a%' or city like 'b%'

 --5.Create a report that shows the CompanyName, ContactName number of all customer that have no fax number.
 
 SELECT CompanyName, ContactName
 FROM Customers
 WHERE fax is null

 --6Create a report that shows the LastName, FirstName, City of employees in cities other "Seattle"

SELECT LastName, FirstName, City
 FROM Employees
 WHERE City Not like 'Seattle'

 --7.Create a report that shows the CustomerID, sum of Freight, 
 --from the orders table with sum of freight greater $200, grouped by CustomerID. HINT:
 -- you will need to use a Groupby and a Having statement

SELECT CustomerID, sum(Freight)as [sum great 200$]
FROM Orders
group by CustomerID
having sum(Freight) > 200

--b.1-Create a query to display the name of the customer doing the 
--largest sum of purchases (cost of items + freight)

select ContactName
FROM Customers
WHERE CustomerID = (SELECT top 1  CustomerID from Orders
group by CustomerID
order by SUM(freight) desc)

--b -2.Create a query to compute the largest order total cost of items in order without freight)

SELECT orderID,sum(unitprice*Quantity) as []
from [Order Details]
where OrderID in (select OrderID
				  from orders 
				  where ShipCountry = 'Mexico')
group by OrderID

-- b.3 .Create a query to show the total sum of orders purchased by customers from Mexico


select sum(x.unitprice*x.Quantity)as totalprice
from [Order Details] as x,Orders as y
where x.OrderID = y.OrderID and y.ShipCountry ='Mexico'


-- b.4 Create a query to compute the total amount of sales to all customers in France

select count(orderId)
from Orders
where OrderID in (select OrderID
					from orders
					where ShipCountry = 'France')
 

-- b.5 Create a query to display the average cost of order for all orders purchased by customers in France


select AVG(unitprice*Quantity)
from [Order Details]
where OrderID in (select OrderID
					from orders
					where ShipCountry = 'France')


 

--b6.Create a query to display the total money for all discounts on order from Mexico

select sum(unitprice*Quantity*Discount)
from [Order Details]
where OrderID in (select OrderID
					from orders
					where ShipCountry = 'Mexico')




--b7.Query to display the count of customers from each city

select city,COUNT(CustomerID) as [count customers]
from Customers
group by City 
order by COUNT(CustomerID)
