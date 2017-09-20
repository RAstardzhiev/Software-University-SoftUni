<h1>Exercises: Data Definition and Data Types</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016">"Databases Basics - MSSQL" course @ Software University.</a></p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create Database</h2>
<p>You now know how to create database using the GUI of the SSMS. Now it&rsquo;s time to create it using SQL queries. In that task (and the several following it) you will be required to create the database from the previous exercise <strong>using only SQL queries</strong>. Firstly, just <strong>create new database named Minions.</strong></p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create Tables</h2>
<p>In the newly created database Minions add table <strong>Minions (Id, Name, Age)</strong>. Then add new table <strong>Towns (Id, Name).</strong> Set <strong>Id</strong> columns of both tables to be <strong>primary key </strong>as<strong> constraint</strong>.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Alter Minions Table</h2>
<p>Change the structure of the Minions table to have <strong>new column TownId</strong> that would be of the same type as the <strong>Id </strong>column of <strong>Towns table</strong>. Add <strong>new constraint</strong> that makes <strong>TownId</strong> <strong>foreign key</strong> and references to <strong>Id </strong>column of <strong>Towns</strong> table.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Insert Records in Both Tables</h2>
<p><strong>Populate both tables</strong> with sample records given in the table below.</p>
<table>
<tbody>
<tr>
<td colspan="4" width="208">
<p><strong>Minions</strong></p>
</td>
<td width="19">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="2" width="104">
<p><strong>Towns</strong></p>
</td>
</tr>
<tr>
<td width="26">
<p><strong>Id</strong></p>
</td>
<td width="66">
<p><strong>Name</strong></p>
</td>
<td width="47">
<p><strong>Age</strong></p>
</td>
<td width="68">
<p><strong>TownId</strong></p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="28">
<p><strong>Id</strong></p>
</td>
<td width="76">
<p><strong>Name</strong></p>
</td>
</tr>
<tr>
<td width="26">
<p>1</p>
</td>
<td width="66">
<p>Kevin</p>
</td>
<td width="47">
<p>22</p>
</td>
<td width="68">
<p>1</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="28">
<p>1</p>
</td>
<td width="76">
<p>Sofia</p>
</td>
</tr>
<tr>
<td width="26">
<p>2</p>
</td>
<td width="66">
<p>Bob</p>
</td>
<td width="47">
<p>15</p>
</td>
<td width="68">
<p>3</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="76">
<p>Plovdiv</p>
</td>
</tr>
<tr>
<td width="26">
<p>3</p>
</td>
<td width="66">
<p>Steward</p>
</td>
<td width="47">
<p>NULL</p>
</td>
<td width="68">
<p>2</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="76">
<p>Varna</p>
</td>
</tr>
</tbody>
</table>
<p>Use only SQL queries. Submit your <strong>INSERT statements</strong> as Run skeleton, run queries &amp; check DB.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Truncate Table Minions</h2>
<p><strong>Delete all the data</strong> from the Minions table using <strong>SQL query.</strong></p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Drop All Tables</h2>
<p><strong>Delete all tables</strong> from the Minions database using <strong>SQL query</strong>.</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create Table People</h2>
<p>Using <strong>SQL query</strong> create table <strong>People</strong> with columns:</p>
<ul>
<li><strong>Id </strong>&ndash; unique number for every person there will be <strong>no more than 2<sup>31</sup>-1</strong> (Auto incremented)</li>
<li><strong>Name</strong> &ndash; full name of the person will be <strong>no more than 200 Unicode characters</strong>. (Not null)</li>
<li><strong>Picture</strong> &ndash; image with <strong>size up to</strong> <strong>2 MB. </strong>(Allow nulls)</li>
<li><strong>Height</strong> &ndash; In meters. Real number precise up to <strong>2 digits </strong>after floating point. (Allow nulls)</li>
<li><strong>Weight</strong> &ndash; In kilograms. Real number precise up to <strong>2 digits </strong>after floating point. (Allow nulls)</li>
<li><strong>Gender </strong>&ndash; Possible states are <strong>m</strong> or (Not null)</li>
<li><strong>Birthdate &ndash; </strong>(Not null)</li>
<li><strong>Biography</strong> &ndash; detailed biography of the person it can contain <strong>max allowed Unicode characters. </strong>(Allow nulls)</li>
</ul>
<p>Make <strong>Id</strong> primary key. Populate the table with only <strong>5 records</strong>. Submit your <strong>CREATE</strong> and <strong>INSERT statements</strong> as Run queries &amp; check DB.</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create Table Users</h2>
<p>Using <strong>SQL query</strong> create table <strong>Users</strong> with columns:</p>
<ul>
<li><strong>Id </strong>&ndash; unique number for every user. There will be <strong>no more than 2<sup>63</sup>-1 users. </strong>(Auto incremented)</li>
<li><strong>Username</strong> &ndash; unique identifier of the user will be <strong>no more than 30 characters (non Unicode). </strong>(Required)</li>
<li><strong>Password </strong>&ndash; password will be <strong>no longer than 26 characters (non Unicode). </strong>(Required)</li>
<li><strong>ProfilePicture</strong> &ndash; image with <strong>size up to 900 KB. </strong></li>
<li><strong>LastLoginTime</strong></li>
<li><strong>IsDeleted </strong>&ndash; shows if the user deleted his/her profile. Possible states are<strong> true </strong>or<strong> false</strong>.</li>
</ul>
<p>Make <strong>Id</strong> primary key. Populate the table with exactly <strong>5 records</strong>. Submit your <strong>CREATE</strong> and <strong>INSERT statements</strong> as Run queries &amp; check DB.</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Change Primary Key</h2>
<p>Using <strong>SQL queries</strong> modify table <strong>Users</strong> from the previous task. First <strong>remove current primary key</strong> then create <strong>new primary key</strong> that would be the <strong>combination</strong> of fields <strong>Id</strong> and <strong>Username</strong>.</p>
<h2>Problem 10.&nbsp;&nbsp;&nbsp; Add Check Constraint</h2>
<p>Using <strong>SQL queries</strong> modify table <strong>Users</strong>. Add <strong>check constraint</strong> to ensure that the values in the Password field are <strong>at least 5 symbols</strong> long.</p>
<h2>Problem 11.&nbsp;&nbsp;&nbsp; Set Default Value of a Field</h2>
<p>Using <strong>SQL queries </strong>modify table <strong>Users</strong>. Make the <strong>default value</strong> of <strong>LastLoginTime</strong> field to be the <strong>current time.</strong></p>
<h2>Problem 12.&nbsp;&nbsp;&nbsp; Set Unique Field</h2>
<p>Using <strong>SQL queries</strong> modify table <strong>Users</strong>. Remove <strong>Username</strong> field from the primary key so only the field <strong>Id</strong> would be primary key. Now <strong>add unique constraint</strong> to the <strong>Username</strong> field to ensure that the values there are <strong>at least 3 symbols</strong> long.</p>
<h2>Problem 13.&nbsp;&nbsp;&nbsp; Movies Database</h2>
<p>Using <strong>SQL queries</strong> create <strong>Movies</strong> database with the following entities:</p>
<ul>
<li><strong>Directors</strong> (Id, DirectorName, Notes)</li>
<li><strong>Genres</strong> (Id, GenreName, Notes)</li>
<li><strong>Categories</strong> (Id, CategoryName, Notes)</li>
<li><strong>Movies</strong> (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId, Rating, Notes)</li>
</ul>
<p>Set most <strong>appropriate data types</strong> for each column. <strong>Set primary key</strong> to each table. Populate each table with exactly <strong>5 records</strong>. Make sure the columns that are present in 2 tables would be of the <strong>same data type</strong>. Consider which fields are always required and which are optional. Submit your<strong> CREATE TABLE</strong> and <strong>INSERT statements</strong> as Run queries &amp; check DB.</p>
<h2>Problem 14.&nbsp;&nbsp;&nbsp; Car Rental Database</h2>
<p>Using <strong>SQL queries</strong> create <strong>CarRental</strong> database with the following entities:</p>
<ul>
<li><strong>Categories</strong> (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)</li>
<li><strong>Cars</strong> (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)</li>
<li><strong>Employees</strong> (Id, FirstName, LastName, Title, Notes)</li>
<li><strong>Customers</strong> (Id, DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes)</li>
<li><strong>RentalOrders</strong> (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)</li>
</ul>
<p>Set most <strong>appropriate data types</strong> for each column. <strong>Set primary key</strong> to each table. Populate each table with only <strong>3 records</strong>. Make sure the columns that are present in 2 tables would be of the <strong>same data type</strong>. Consider which fields are always required and which are optional. Submit your <strong>CREATE TABLE</strong> and <strong>INSERT statements</strong> as Run queries &amp; check DB.</p>
<h2>Problem 15.&nbsp;&nbsp;&nbsp; Hotel Database</h2>
<p>Using <strong>SQL queries</strong> create <strong>Hotel</strong> database with the following entities:</p>
<ul>
<li><strong>Employees</strong> (Id, FirstName, LastName, Title, Notes)</li>
<li><strong>Customers </strong>(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)</li>
<li><strong>RoomStatus</strong> (RoomStatus, Notes)</li>
<li><strong>RoomTypes </strong>(RoomType, Notes)</li>
<li><strong>BedTypes</strong> (BedType, Notes)</li>
<li><strong>Rooms </strong>(RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)</li>
<li><strong>Payments </strong>(Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)</li>
<li><strong>Occupancies</strong> (Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)</li>
</ul>
<p>Set most <strong>appropriate data types</strong> for each column. <strong>Set primary key</strong> to each table. Populate each table with only <strong>3 records</strong>. Make sure the columns that are present in 2 tables would be of the <strong>same data type</strong>. Consider which fields are always required and which are optional. Submit your <strong>CREATE TABLE</strong> and <strong>INSERT statements</strong> as Run queries &amp; check DB.</p>
<h2>Problem 16.&nbsp;&nbsp;&nbsp; Create SoftUni Database</h2>
<p>Now create bigger database called <strong>SoftUni.</strong> You will use same database in the future tasks. It should hold information about</p>
<ul>
<li><strong>Towns </strong>(Id, Name)</li>
<li><strong>Addresses </strong>(Id, AddressText, TownId)</li>
<li><strong>Departments </strong>(Id, Name)</li>
<li><strong>Employees </strong>(Id, FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId)</li>
</ul>
<p><strong>Id</strong> columns are <strong>auto incremented</strong> starting from 1 and increased by 1 (1, 2, 3, 4&hellip;). Make sure you <strong>use appropriate data types</strong> for each column. Add <strong>primary </strong>and<strong> foreign keys</strong> <strong>as constraints</strong> for each table. Use <strong>only SQL queries</strong>. Consider which fields are always required and which are optional.</p>
<h2>Problem 17.&nbsp;&nbsp;&nbsp; Backup Database</h2>
<p>Backup the database <strong>SoftUni </strong>from the previous tasks into a file named &ldquo;<strong>softuni-backup.bak</strong>&rdquo;. Delete your database from SQL Server Management Studio. Then restore the database from the created backup.</p>
<h2>Problem 18.&nbsp;&nbsp;&nbsp; Basic Insert</h2>
<p>Use the <strong>SoftUni</strong> database and insert some data <strong>using SQL queries</strong>.</p>
<ul>
<li><strong>Towns:</strong> Sofia, Plovdiv, Varna, Burgas</li>
<li><strong>Departments:</strong> Engineering, Sales, Marketing, Software Development, Quality Assurance</li>
<li><strong>Employees:</strong></li>
</ul>
<table>
<tbody>
<tr>
<td width="149">
<p><strong>Name</strong></p>
</td>
<td width="123">
<p><strong>Job Title</strong></p>
</td>
<td width="154">
<p><strong>Department</strong></p>
</td>
<td width="92">
<p><strong>Hire Date</strong></p>
</td>
<td width="76">
<p><strong>Salary</strong></p>
</td>
</tr>
<tr>
<td width="149">
<p>Ivan Ivanov Ivanov</p>
</td>
<td width="123">
<p>.NET Developer</p>
</td>
<td width="154">
<p>Software Development</p>
</td>
<td width="92">
<p>01/02/2013</p>
</td>
<td width="76">
<p>3500.00</p>
</td>
</tr>
<tr>
<td width="149">
<p>Petar Petrov Petrov</p>
</td>
<td width="123">
<p>Senior Engineer</p>
</td>
<td width="154">
<p>Engineering</p>
</td>
<td width="92">
<p>02/03/2004</p>
</td>
<td width="76">
<p>4000.00</p>
</td>
</tr>
<tr>
<td width="149">
<p>Maria Petrova Ivanova</p>
</td>
<td width="123">
<p>Intern</p>
</td>
<td width="154">
<p>Quality Assurance</p>
</td>
<td width="92">
<p>28/08/2016</p>
</td>
<td width="76">
<p>525.25</p>
</td>
</tr>
<tr>
<td width="149">
<p>Georgi Teziev Ivanov</p>
</td>
<td width="123">
<p>CEO</p>
</td>
<td width="154">
<p>Sales</p>
</td>
<td width="92">
<p>09/12/2007</p>
</td>
<td width="76">
<p>3000.00</p>
</td>
</tr>
<tr>
<td width="149">
<p>Peter Pan Pan</p>
</td>
<td width="123">
<p>Intern</p>
</td>
<td width="154">
<p>Marketing</p>
</td>
<td width="92">
<p>28/08/2016</p>
</td>
<td width="76">
<p>599.88</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 19.&nbsp;&nbsp;&nbsp; Basic Select All Fields</h2>
<p>Use the <strong>SoftUni</strong> database and first select all records from the <strong>Towns</strong>, then from <strong>Departments </strong>and finally from <strong>Employees</strong> table. Use SQL queries and submit them to Judge at once. Submit your query statements as Prepare DB &amp; Run queries.</p>
<h2>Problem 20.&nbsp;&nbsp;&nbsp; Basic Select All Fields and Order Them</h2>
<p>Modify queries from previous problem by sorting:</p>
<ul>
<li><strong>Towns </strong>- alphabetically by name</li>
<li><strong>Departments </strong>- alphabetically by name</li>
<li><strong>Employees </strong>- descending by salary</li>
</ul>
<p>Submit your query statements as Prepare DB &amp; Run queries.</p>
<h2>Problem 21.&nbsp;&nbsp;&nbsp; Basic Select Some Fields</h2>
<p>Modify queries from previous problem to show only <strong>some of the columns</strong>. For table:</p>
<ul>
<li><strong>Towns</strong> &ndash; Name</li>
<li><strong>Departments</strong> &ndash; Name</li>
<li><strong>Employees</strong> &ndash; FirstName, LastName, JobTitle, Salary</li>
</ul>
<p><strong>Keep the ordering</strong> from the previous problem. Submit your query statements as Prepare DB &amp; Run queries.</p>
<h2>Problem 22.&nbsp;&nbsp;&nbsp; Increase Employees Salary</h2>
<p>Use <strong>SoftUni </strong>database and <strong>increase the salary</strong> of all employees by <strong>10%. </strong>Then show <strong>only Salary</strong> column for all in the <strong>Employees</strong> table. Submit your query statements as Prepare DB &amp; Run queries.</p>
<p>&nbsp;</p>
<h2>Problem 23.&nbsp;&nbsp;&nbsp; Decrease Tax Rate</h2>
<p>Use <strong>Hotel </strong>database and <strong>decrease tax rate by</strong> <strong>3%</strong> to all payments. Then select <strong>only</strong> <strong>TaxRate</strong> column from the <strong>Payments</strong> table. Submit your query statements as Prepare DB &amp; Run queries.</p>
<h2>Problem 24.&nbsp;&nbsp;&nbsp; Delete All Records</h2>
<p>Use <strong>Hotel </strong>database and <strong>delete all records</strong> from the <strong>Occupancies </strong>table. Use SQL query. Submit your query statements as Run skeleton, run queries &amp; check DB.</p>
<p>&nbsp;</p>