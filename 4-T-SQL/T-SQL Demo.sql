/*
-What is Standard SQL?

Standard SQL, usually referred to simply as "SQL," is a type of programming language
called a query language. Query languages are used for communicating with a database.
SQL is used for adding, retrieving, or updating data stored in a database.
It is used across many different types of databases.

------------------

-What is T-SQL?
T-SQL, which stands for Transact-SQL and is sometimes referred to as TSQL,
is an extension of the SQL language used primarily within Microsoft SQL Server.
This means that it provides all the functionality of SQL but with some added extras.
However, in addition to SQL Server, other database management systems (DBMS) 
also support T-SQL. Another Microsoft product, Microsoft Azure SQL Database,
supports most features of T-SQL.

------------------

-What is the difference between SQL and T-SQL?

Difference #1
The obvious difference is in what they are designed for: SQL is a query language
used for manipulating data stored in a database.T-SQL is also a query language, 
but it's an extension of SQL that is primarily used in Microsoft SQL Server databases
and software.

Difference #2
SQL is open-source. T-SQL is developed and owned by Microsoft.

Difference #3
SQL statements are executed one at a time, also known as "non-procedural." 
T-SQL executes statements in a "procedural" way, meaning that the code will be
processed as a block, logically and in a structured order.
There are advantages and disadvantages to each approach, but from a learner perspective,
this difference isn't too important. You'll be able to get and work with the data
you want in either language, it's just that the way you go about doing that will 
vary a bit depending on which language you're using and the specifics of your query	

Difference #4
On top of these more general differences, SQL and T-SQL also have some slightly 
different command key words. T-SQL also features functions that are not part of
regular SQL.
An example of this is how in we select the top X number of rows.
In standard SQL, we would use the LIMIT keyword. In T-SQL, we use the TOP keyword. 

Both of these commands do the same thing, as we can see in the examples below.
Both queries will return the top ten rows in the users table ordered
by the age column.

SQL Example

SELECT *
FROM users
ORDER BY age
LIMIT 10;

T-SQL Example

SELECT TOP 10 (*)
FROM users
ORDER BY age;

Difference #5
Finally, and as referenced before, T-SQL offers functionality that does not appear
in regular SQL. One example is the ISNULL function. This will replace NULL values
coming from a specific column. The below would return an age of “0” for any rows
that have a value of NULL in the age column.

SELECT ISNULL(0, age)
FROM users;

------------------

Which is better to learn?

As T-SQL is an extension of SQL, you will need to learn the basics of SQL
before starting. If you learn T-SQL first, you will end up picking up knowledge
of standard SQL anyway.
With most things, which you choose to learn should depend on what you are trying
to achieve. If you are going to be working with Microsoft SQL server, 
then it is worth learning more about T-SQL. If you are a beginner looking to get 
started in using databases, then begin with learning about SQL.

*/


