<h1>Exercises: Functions, Triggers and Transactions</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016">"Databases Basics - MSSQL" course @ Software University.</a></p>
<h1>Part I &ndash; Queries for SoftUni Database</h1>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees with Salary Above 35000</h2>
<p>Create stored procedure <strong>usp_GetEmployeesSalaryAbove35000</strong> that returns <strong>all employees&rsquo; first and last names</strong> for whose <strong>salary is above 35000</strong>. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Roberto</p>
</td>
<td width="95">
<p>Tamburello</p>
</td>
</tr>
<tr>
<td width="92">
<p>David</p>
</td>
<td width="95">
<p>Bradley</p>
</td>
</tr>
<tr>
<td width="92">
<p>Terri</p>
</td>
<td width="95">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees with Salary Above Number</h2>
<p>Create stored procedure <strong>usp_GetEmployeesSalaryAboveNumber</strong> that <strong>accept a number </strong>(of type <strong>MONEY</strong>) as parameter and return<strong> all employees&rsquo; first and last names</strong> whose salary is <strong>above or equal</strong> to the given number. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<p>Supplied number for that example is 48100.</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Terri</p>
</td>
<td width="95">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="92">
<p>Jean</p>
</td>
<td width="95">
<p>Trenary</p>
</td>
</tr>
<tr>
<td width="92">
<p>Ken</p>
</td>
<td width="95">
<p>Sanchez</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Town Names Starting With</h2>
<p>Write a stored procedure <strong>usp_GetTownsStartingWith</strong> that <strong>accept string as parameter</strong> and returns <strong>all town names starting with that string. </strong>Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<p>Here is the list of all towns <strong>starting with &ldquo;b&rdquo;.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Town</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Bellevue</p>
</td>
</tr>
<tr>
<td width="92">
<p>Bothell</p>
</td>
</tr>
<tr>
<td width="92">
<p>Bordeaux</p>
</td>
</tr>
<tr>
<td width="92">
<p>Berlin</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees from Town</h2>
<p>Write a stored procedure <strong>usp_GetEmployeesFromTown</strong> that accepts <strong>town name</strong> as parameter and return the <strong>employees&rsquo; first and last name that live in the given town. </strong>Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<p>Here it is a list of employees<strong> living in Sofia.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Svetlin</p>
</td>
<td width="95">
<p>Nakov</p>
</td>
</tr>
<tr>
<td width="92">
<p>Martin</p>
</td>
<td width="95">
<p>Kulov</p>
</td>
</tr>
<tr>
<td width="92">
<p>George</p>
</td>
<td width="95">
<p>Denchev</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Salary Level Function</h2>
<p>Write a function <strong>ufn_GetSalaryLevel(@salary MONEY)</strong> that receives <strong>salary of an employee </strong>and returns the <strong>level of the salary</strong>.</p>
<ul>
<li>If salary is <strong>&lt; 30000</strong> return <strong>&ldquo;Low&rdquo;</strong></li>
<li>If salary is <strong>between 30000 and 50000 (inclusive)</strong> return<strong> &ldquo;Average&rdquo;</strong></li>
<li>If salary is <strong>&gt; 50000</strong> return<strong> &ldquo;High&rdquo;</strong></li>
</ul>
<p>Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Salary</strong></p>
</td>
<td width="95">
<p><strong>Salary Level</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>13500.00</p>
</td>
<td width="95">
<p>Low</p>
</td>
</tr>
<tr>
<td width="92">
<p>43300.00</p>
</td>
<td width="95">
<p>Average</p>
</td>
</tr>
<tr>
<td width="92">
<p>125500.00</p>
</td>
<td width="95">
<p>High</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees by Salary Level</h2>
<p>Write a stored procedure<strong> usp_EmployeesBySalaryLevel</strong> that receive as <strong>parameter</strong> <strong>level of salary</strong> (low, average or high) and print the <strong>names of all employees </strong>that have given level of salary. You can use the function - &ldquo;<strong>dbo.ufn_GetSalaryLevel</strong><strong>(@Salary)</strong>&rdquo;, which was part of the previous task, inside your &ldquo;<strong>CREATE PROCEDURE &hellip;</strong>&rdquo; query.</p>
<h3>Example</h3>
<p>Here is the list of all employees with high salary.</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Terri</p>
</td>
<td width="95">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="92">
<p>Jean</p>
</td>
<td width="95">
<p>Trenary</p>
</td>
</tr>
<tr>
<td width="92">
<p>Ken</p>
</td>
<td width="95">
<p>Sanchez</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Define Function</h2>
<p>Define a function <strong>ufn_IsWordComprised(@setOfLetters, @word)</strong> that returns <strong>true</strong> or <strong>false</strong> depending on that if the word is a comprised of the given set of letters. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>SetOfLetters</strong></p>
</td>
<td width="49">
<p><strong>Word</strong></p>
</td>
<td width="55">
<p><strong>Result</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>oistmiahf</p>
</td>
<td width="49">
<p>Sofia</p>
</td>
<td width="55">
<p>1</p>
</td>
</tr>
<tr>
<td width="92">
<p>oistmiahf</p>
</td>
<td width="49">
<p>halves</p>
</td>
<td width="55">
<p>0</p>
</td>
</tr>
<tr>
<td width="92">
<p>bobr</p>
</td>
<td width="49">
<p>Rob</p>
</td>
<td width="55">
<p>1</p>
</td>
</tr>
<tr>
<td width="92">
<p>pppp</p>
</td>
<td width="49">
<p>Guy</p>
</td>
<td width="55">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Delete Employees and Departments</h2>
<p>Write a SQL query to delete all Employees from the <strong>Production</strong> and <strong>Production Control</strong> departments. <strong>Delete these departments from the Departments table </strong>too. Submit your query as Run skeleton, run queries and check DB. After that exercise restore your database to revert those changes.</p>
<h3>Hint:</h3>
<p>You may set <strong>ManagerID</strong> column in Departments table to <strong>nullable</strong> (using query "ALTER TABLE &hellip;").</p>
<h2>Problem 8.2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Delete Employees and Departments</h2>
<p>Write a <strong>procedure </strong>with the name <strong>usp_DeleteEmployeesFromDepartment</strong> <strong>(</strong><strong>@departmentId</strong> INT<strong>) which </strong><strong>deletes all Employees</strong> from a <strong>given</strong> <strong>department</strong>. <strong>Delete these departments </strong>from the<strong> Departments table </strong>too. <strong>Finally</strong><strong> SELECT </strong>the <strong>number</strong> of <strong>employees</strong> from the <strong>given department</strong>. If the delete statements are correct the select query should return 0.</p>
<p>After completing that exercise restore your database to revert all changes.</p>
<h3>Hint:</h3>
<p>You may set <strong>ManagerID</strong> column in Departments table to <strong>nullable</strong> (using query "ALTER TABLE &hellip;").</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees with Three Projects</h2>
<p>Create a procedure <strong>usp_AssignProject(@emloyeeId, @projectID)</strong> that <strong>assigns</strong> <strong>projects</strong> to employee. If the employee has more than <strong>3</strong> project throw <strong>exception</strong> and <strong>rollback</strong> the changes. The exception message must be: "<strong>The employee has too many projects!</strong>" with Severity = 16, State = 1.</p>
<h2>Problem 9.1&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Delete Employees</h2>
<p>Create a table Deleted_Employees(EmployeeId PK, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary) that will hold information about fired(deleted) employees from the <strong>Employees</strong> table. Add a trigger to <strong>Employees</strong> table that inserts the corresponding information about the deleted records in Deleted_Employees.</p>
<h1>PART II &ndash; Queries for Bank Database</h1>
<h2>Problem 10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Full Name</h2>
<p>You are given a database schema with tables <strong>AccountHolders(Id (PK), FirstName, LastName, SSN)</strong> and <strong>Accounts(Id (PK), AccountHolderId (FK), Balance)</strong>.&nbsp; Write a stored procedure <strong>usp_GetHoldersFullName</strong> that selects the full names of all people. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>Full Name</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Susan Cane</p>
</td>
</tr>
<tr>
<td width="132">
<p>Kim Novac</p>
</td>
</tr>
<tr>
<td width="132">
<p>Jimmy Henderson</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11.&nbsp;&nbsp;&nbsp; People with Balance Higher Than</h2>
<p>Your task is to create a stored procedure <strong>usp_GetHoldersWithBalanceHigherThan</strong> that accepts a <strong>number as a parameter</strong> and returns all <strong>people who have more money in total of all their accounts than the supplied number</strong>. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Susan</p>
</td>
<td width="95">
<p>Cane</p>
</td>
</tr>
<tr>
<td width="92">
<p>Petar</p>
</td>
<td width="95">
<p>Kirilov</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12.&nbsp;&nbsp;&nbsp; Future Value Function</h2>
<p>Your task is to create a function <strong>ufn_CalculateFutureValue</strong> that accepts as parameters &ndash; <strong>sum (money)</strong>, <strong>yearly interest rate (float)</strong> and <strong>number of years(int)</strong>. It should calculate and return the future value of the initial sum. Using the following formula:</p>
<ul>
<li><strong>I </strong>&ndash; Initial sum</li>
<li><strong>R</strong> &ndash; Yearly interest rate</li>
<li><strong>T</strong> &ndash; Number of years</li>
</ul>
<p>Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="329">
<p><strong>Input</strong></p>
</td>
<td width="71">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="329">
<p><strong>Initial sum:</strong> 1000</p>
<p><strong>Yearly Interest rate:</strong> 10%</p>
<p><strong>years:</strong> 5</p>
<p>ufn_CalculateFutureValue(1000, 0.1, 5)</p>
</td>
<td width="71">
<p>1610.51</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13.&nbsp;&nbsp;&nbsp; Calculating Interest</h2>
<p>Your task is to create a stored procedure <strong>usp_CalculateFutureValueForAccount</strong> that uses the function from the previous problem to give an interest to a person's account <strong>for 5 years</strong>, along with information about his/her <strong>account id, first name, last name and current balance</strong> as it is shown in the example below. It should take the <strong>AccountId</strong> and the <strong>interest rate</strong> as parameters. Again you are provided with &ldquo;<strong>dbo.ufn_CalculateFutureValue</strong>&rdquo; function which was part of the previous task.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Account Id</strong></p>
</td>
<td width="95">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
<td width="113">
<p><strong>Current Balance</strong></p>
</td>
<td width="132">
<p><strong>Balance in 5 years</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="95">
<p>Susan</p>
</td>
<td width="95">
<p>Cane</p>
</td>
<td width="113">
<p>123.12</p>
</td>
<td width="132">
<p>198.286</p>
</td>
</tr>
</tbody>
</table>
<p>*Note: for the example above interest rate is 0.1</p>
<h2>Problem 14.&nbsp;&nbsp;&nbsp; Deposit Money</h2>
<p>Add stored procedure <strong>usp_DepositMoney</strong> (AccountId, moneyAmount) that operate in transactions. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h2>Problem 15.&nbsp;&nbsp;&nbsp; Withdraw Money</h2>
<p>Add stored procedures <strong>usp_WithdrawMoney </strong>(AccountId, moneyAmount) that operate in transactions. Submit your query statement as Run skeleton, run queries &amp; check DB in Judge.</p>
<h2>Problem 16.&nbsp;&nbsp;&nbsp; Money Transfer</h2>
<p>Write stored procedure <strong>usp_TransferMoney</strong>(senderId, receiverId, amount) that <strong>transfers money from one account to another</strong>. Consider cases when the amount of <strong>money is negative number</strong>. Make sure that the whole procedure <strong>passes without errors </strong>and <strong>if error occurs make</strong> <strong>no change in the database.</strong> You can use both: &ldquo;<strong>usp_DepositMoney</strong>&rdquo;, &ldquo;<strong>usp_WithdrawMoney</strong>&rdquo; (look at previous two problems about those procedures).</p>
<h2>Problem 17.&nbsp;&nbsp;&nbsp; Create Table Logs</h2>
<p>Create another table &ndash; <strong>Logs</strong> (LogId, AccountId, OldSum, NewSum). Add a <strong>trigger</strong> to the Accounts table that <strong>enters</strong> a new entry into the <strong>Logs</strong> table every time the sum <strong>on</strong> an <strong>account</strong> <strong>changes</strong>.</p>
<p><strong>Submit</strong> your query <strong>only</strong> for the <strong>trigger</strong> action as Run skeleton, run queries and check DB.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="55">
<p><strong>LogId</strong></p>
</td>
<td width="83">
<p><strong>AccountId</strong></p>
</td>
<td width="70">
<p><strong>OldSum</strong></p>
</td>
<td width="76">
<p><strong>NewSum</strong></p>
</td>
</tr>
<tr>
<td width="55">
<p>1</p>
</td>
<td width="83">
<p>1</p>
</td>
<td width="70">
<p>123.12</p>
</td>
<td width="76">
<p>113.12</p>
</td>
</tr>
<tr>
<td width="55">
<p>&hellip;</p>
</td>
<td width="83">
<p>&hellip;</p>
</td>
<td width="70">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 18.&nbsp;&nbsp;&nbsp; Create Table Emails</h2>
<p>Create another table &ndash; <strong>NotificationEmails</strong>(Id, Recipient, Subject, Body). Add a <strong>trigger</strong> to logs table and <strong>create new email whenever new record is inserted in logs table. </strong>The following data is required to be filled for each email:</p>
<ul>
<li><strong>Recipient</strong> &ndash; AccountId</li>
<li><strong>Subject</strong> &ndash; &ldquo;Balance change for account: <strong>{AccountId}</strong>&rdquo;</li>
<li><strong>Body</strong> - &ldquo;On <strong>{date}</strong> your balance was changed from <strong>{old}</strong> to <strong>{new}.</strong>&rdquo;</li>
</ul>
<p><strong>Submit</strong> your query <strong>only</strong> for the <strong>trigger</strong> action as Run skeleton, run queries and check DB.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="34">
<p><strong>Id</strong></p>
</td>
<td width="79">
<p><strong>Recipient</strong></p>
</td>
<td width="198">
<p><strong>Subject</strong></p>
</td>
<td width="320">
<p><strong>Body</strong></p>
</td>
</tr>
<tr>
<td width="34">
<p>1</p>
</td>
<td width="79">
<p>1</p>
</td>
<td width="198">
<p>Balance change for account: 1</p>
</td>
<td width="320">
<p>On Sep 12 2016 2:09PM your balance was changed from 113.12 to 103.12.</p>
</td>
</tr>
<tr>
<td width="34">
<p>&hellip;</p>
</td>
<td width="79">
<p>&hellip;</p>
</td>
<td width="198">
<p>&hellip;</p>
</td>
<td width="320">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>PART III &ndash; Queries for Diablo Database</h1>
<p>You are given a <strong>database "Diablo"</strong> holding users, games, items, characters and statistics available as SQL script. Your task is to write some stored procedures, views and other server-side database objects and write some SQL queries for displaying data from the database.</p>
<p><strong>Important:</strong> start with a <strong>clean copy of the "Diablo" database</strong> <strong>on each problem</strong>. Just execute the SQL script again.</p>
<h2>Problem 19.&nbsp;&nbsp;&nbsp; *Scalar Function: Cash in User Games Odd Rows</h2>
<p>Create a <strong>function</strong> <strong>u</strong><strong>fn_CashInUsersGames </strong>that <strong>sums the cash of odd rows</strong>.Rows must be ordered by cash in descending order. The function should take a game name as a parameter and<strong> return the result as table</strong>. Submit <strong>only your function</strong> <strong>in judge</strong> as Run skeleton, run queries &amp; check DB.</p>
<p>Execute the function over the following game names, ordered exactly like: &ldquo;<strong>Lily Stargazer</strong>&rdquo;, &ldquo;<strong>Love in a mist</strong>&rdquo;.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="83">
<p><strong>SumCash</strong></p>
</td>
</tr>
<tr>
<td width="83">
<p>72**.**</p>
</td>
</tr>
<tr>
<td width="83">
<p>85**.**</p>
</td>
</tr>
<tr>
<td width="83">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hint</h3>
<p>Use <strong>ROW_NUMBER</strong> to get the rankings of all rows based on order criteria.</p>
<h2>Problem 20.&nbsp;&nbsp;&nbsp; Trigger</h2>
<p>Users should not be allowed to buy items with higher level than their level. Create a trigger that restricts that. Trigger should prevent inserting items that are above specified level while allowing all others to be inserted.</p>
<p>Add bonus cash of 50000 to users: <strong>baleremuda, loosenoise, inguinalself, buildingdeltoid, monoxidecos </strong>in the game<strong> &ldquo;Bali&rdquo;.</strong></p>
<p>There are two groups of <strong>items</strong> that you should buy for the above users in the game. First group is with <strong>id between 251 and 299 including</strong>. Second group is with <strong>id between 501 and 539 including.</strong></p>
<p><strong>Take</strong> off <strong>cash</strong> from each user <strong>for</strong> the bought <strong>items</strong>.</p>
<p>Select all users in the current game (&ldquo;Bali&rdquo;) with their items. Display <strong>username</strong>, <strong>game name</strong>, <strong>cash</strong> and <strong>item name</strong>. Sort the result by username alphabetically, then by item name alphabetically.</p>
<h3>Output</h3>
<table width="412">
<tbody>
<tr>
<td width="119">
<p><strong>Username</strong></p>
</td>
<td width="66">
<p><strong>Name</strong></p>
</td>
<td width="85">
<p><strong>Cash</strong></p>
</td>
<td width="142">
<p><strong>Item Name</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>baleremuda</p>
</td>
<td width="66">
<p>Bali</p>
</td>
<td width="85">
<p>4****.**</p>
</td>
<td width="142">
<p>Iron Wolves Doctrine</p>
</td>
</tr>
<tr>
<td width="119">
<p>baleremuda</p>
</td>
<td width="66">
<p>Bali</p>
</td>
<td width="85">
<p>4****.**</p>
</td>
<td width="142">
<p>Irontoe Mudsputters</p>
</td>
</tr>
<tr>
<td width="119">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="119">
<p>buildingdeltoid</p>
</td>
<td width="66">
<p>Bali</p>
</td>
<td width="85">
<p>3****.**</p>
</td>
<td width="142">
<p>Alabaster Gloves</p>
</td>
</tr>
<tr>
<td width="119">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 21.&nbsp;&nbsp;&nbsp; *Massive Shopping</h2>
<ol>
<li>User <strong>Stamat </strong>in<strong> Safflower </strong>game wants to buy some items. He likes all items <strong>from Level 11 to 12</strong> as well as all items <strong>from Level 19 to 21.</strong> As it is a bulk operation you have to <strong>use transactions. </strong></li>
<li>A transaction is the operation of taking out the cash from the user in the current game as well as adding up the items.</li>
<li>Write transactions for each level range. If anything goes wrong turn back the changes inside of the transaction.</li>
<li>Extract all item names in the given game sorted by name alphabetically</li>
</ol>
<p>Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="161">
<tbody>
<tr>
<td width="161">
<p><strong>Item Name</strong></p>
</td>
</tr>
<tr>
<td width="161">
<p>Akarats Awakening</p>
</td>
</tr>
<tr>
<td width="161">
<p>Amulets</p>
</td>
</tr>
<tr>
<td width="161">
<p>Angelic Shard</p>
</td>
</tr>
<tr>
<td width="161">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 22.&nbsp;&nbsp;&nbsp; Number of Users for Email Provider</h2>
<p>Find number of users for email provider from the largest to smallest, then by Email Provider in ascending order. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="260">
<tbody>
<tr>
<td width="128">
<p><strong>Email Provider</strong></p>
</td>
<td width="132">
<p><strong>Number Of Users</strong></p>
</td>
</tr>
<tr>
<td width="128">
<p>yahoo.com</p>
</td>
<td width="132">
<p>14</p>
</td>
</tr>
<tr>
<td width="128">
<p>dps.centrin.net.id</p>
</td>
<td width="132">
<p>5</p>
</td>
</tr>
<tr>
<td width="128">
<p>softuni.bg</p>
</td>
<td width="132">
<p>5</p>
</td>
</tr>
<tr>
<td width="128">
<p>indosat.net.id</p>
</td>
<td width="132">
<p>4</p>
</td>
</tr>
<tr>
<td width="128">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 23.&nbsp;&nbsp;&nbsp; All User in Games</h2>
<p>Find all <strong>user in games</strong> with information about them. Display the game name, game type, username, level, cash and character name. Sort the result by level in descending order, then by username and game in alphabetical order. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="558">
<tbody>
<tr>
<td width="115">
<p><strong>Game</strong></p>
</td>
<td width="93">
<p><strong>Game Type</strong></p>
</td>
<td width="123">
<p><strong>Username</strong></p>
</td>
<td width="57">
<p><strong>Level</strong></p>
</td>
<td width="76">
<p><strong>Cash</strong></p>
</td>
<td width="95">
<p><strong>Character</strong></p>
</td>
</tr>
<tr>
<td width="115">
<p>Calla lily white</p>
</td>
<td width="93">
<p>Kinky</p>
</td>
<td width="123">
<p>obliquepoof</p>
</td>
<td width="57">
<p>99</p>
</td>
<td width="76">
<p>7527.00</p>
</td>
<td width="95">
<p>Monk</p>
</td>
</tr>
<tr>
<td width="115">
<p>Dubai</p>
</td>
<td width="93">
<p>Funny</p>
</td>
<td width="123">
<p>rateweed</p>
</td>
<td width="57">
<p>99</p>
</td>
<td width="76">
<p>7499.00</p>
</td>
<td width="95">
<p>Barbarian</p>
</td>
</tr>
<tr>
<td width="115">
<p>Stonehenge</p>
</td>
<td width="93">
<p>Kinky</p>
</td>
<td width="123">
<p>terrifymarzipan</p>
</td>
<td width="57">
<p>99</p>
</td>
<td width="76">
<p>4825.00</p>
</td>
<td width="95">
<p>Witch Doctor</p>
</td>
</tr>
<tr>
<td width="115">
<p>&hellip;</p>
</td>
<td width="93">
<p>&nbsp;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
<td width="57">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 24.&nbsp;&nbsp;&nbsp; Users in Games with Their Items</h2>
<p>Find all users in games with their items count and items price. Display the username, game name, items count and items price. Display only user in games with items count more or equal to 10. Sort the results by items count in descending order then by price in descending order and by username in ascending order. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="435">
<tbody>
<tr>
<td width="113">
<p><strong>Username</strong></p>
</td>
<td width="142">
<p><strong>Game</strong></p>
</td>
<td width="94">
<p><strong>Items Count</strong></p>
</td>
<td width="85">
<p><strong>Items Price</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>skippingside</p>
</td>
<td width="142">
<p>Rose Fire &amp; Ice</p>
</td>
<td width="94">
<p>23</p>
</td>
<td width="85">
<p>11065.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>countrydecay</p>
</td>
<td width="142">
<p>Star of Bethlehem</p>
</td>
<td width="94">
<p>18</p>
</td>
<td width="85">
<p>8039.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>obliquepoof</p>
</td>
<td width="142">
<p>Washington D.C.</p>
</td>
<td width="94">
<p>17</p>
</td>
<td width="85">
<p>5186.00</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 25.&nbsp;&nbsp;&nbsp; * User in Games with Their Statistics</h2>
<p>Find information about <strong>every game</strong> a user has played with their <strong>statistics</strong>. Each user may have participated in several games. Display the username, game name, character name, strength, defence, speed, mind and luck.<br /> Every statistic (strength, defence, speed, mind and luck) should be a sum of the <strong>character statistic, game type statistic</strong> and <strong>items</strong> for user <strong>in game</strong> statistic. One user may have multiple characters in a single game. What you should do in order to calculate the statistic properly is to sum the following:</p>
<ol>
<li>Get the sum of all items - of all characters that the user may have(SUM).</li>
<li>For all of his characters get the character stats which are the biggest (MAX).</li>
<li>For all of his game types stats select only these which are again the biggest (MAX).</li>
</ol>
<p>Order the results by <strong>Strength</strong>, <strong>Defence</strong>, <strong>Speed</strong>, <strong>Mind</strong>, <strong>Luck</strong> &ndash; all in descending order. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Example</h3>
<p>Let&rsquo;s say that we have user &ldquo;<strong>Ana</strong>&rdquo; and she is in the game &ldquo;<strong>Star of Bethlehem</strong>&rdquo; having two characters: Sorceress and Paladin. In tables below will be given their statistics:</p>
<p><strong>Paladin</strong>:</p>
<table width="444">
<tbody>
<tr>
<td width="155">
<p><strong>Type of Stats\Statistics</strong></p>
</td>
<td width="72">
<p><strong>Strength</strong></p>
</td>
<td width="66">
<p><strong>Defence</strong></p>
</td>
<td width="54">
<p><strong>Speed</strong></p>
</td>
<td width="48">
<p><strong>Mind</strong></p>
</td>
<td width="49">
<p><strong>Luck</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Item A Stats</p>
</td>
<td width="72">
<p>15</p>
</td>
<td width="66">
<p>10</p>
</td>
<td width="54">
<p>3</p>
</td>
<td width="48">
<p>14</p>
</td>
<td width="49">
<p>20</p>
</td>
</tr>
<tr>
<td width="155">
<p>Game Type Stats</p>
</td>
<td width="72">
<p>5</p>
</td>
<td width="66">
<p>5</p>
</td>
<td width="54">
<p>7</p>
</td>
<td width="48">
<p>4</p>
</td>
<td width="49">
<p>5</p>
</td>
</tr>
<tr>
<td width="155">
<p>Character Stats</p>
</td>
<td width="72">
<p>20</p>
</td>
<td width="66">
<p>17</p>
</td>
<td width="54">
<p>10</p>
</td>
<td width="48">
<p>8</p>
</td>
<td width="49">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Sorceress</strong>:</p>
<table width="444">
<tbody>
<tr>
<td width="155">
<p><strong>Type of Stats\Statistics</strong></p>
</td>
<td width="72">
<p><strong>Strength</strong></p>
</td>
<td width="66">
<p><strong>Defence</strong></p>
</td>
<td width="54">
<p><strong>Speed</strong></p>
</td>
<td width="48">
<p><strong>Mind</strong></p>
</td>
<td width="49">
<p><strong>Luck</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Item B Stats</p>
</td>
<td width="72">
<p>8</p>
</td>
<td width="66">
<p>4</p>
</td>
<td width="54">
<p>10</p>
</td>
<td width="48">
<p>22</p>
</td>
<td width="49">
<p>12</p>
</td>
</tr>
<tr>
<td width="155">
<p>Game Type Stats</p>
</td>
<td width="72">
<p>6</p>
</td>
<td width="66">
<p>6</p>
</td>
<td width="54">
<p>6</p>
</td>
<td width="48">
<p>4</p>
</td>
<td width="49">
<p>6</p>
</td>
</tr>
<tr>
<td width="155">
<p>Character Stats</p>
</td>
<td width="72">
<p>8</p>
</td>
<td width="66">
<p>6</p>
</td>
<td width="54">
<p>13</p>
</td>
<td width="48">
<p>23</p>
</td>
<td width="49">
<p>10</p>
</td>
</tr>
</tbody>
</table>
<p>What we should get as a result is:</p>
<table width="710">
<tbody>
<tr>
<td width="145">
<p><strong>Username</strong></p>
</td>
<td width="156">
<p><strong>Game</strong></p>
</td>
<td width="120">
<p><strong>Character</strong></p>
</td>
<td width="72">
<p><strong>Strength</strong></p>
</td>
<td width="66">
<p><strong>Defence</strong></p>
</td>
<td width="54">
<p><strong>Speed</strong></p>
</td>
<td width="48">
<p><strong>Mind</strong></p>
</td>
<td width="49">
<p><strong>Luck</strong></p>
</td>
</tr>
<tr>
<td width="145">
<p>Ana</p>
</td>
<td width="156">
<p>Star of Bethlehem</p>
</td>
<td width="120">
<p>Sorceress</p>
</td>
<td width="72">
<p>49</p>
</td>
<td width="66">
<p>37</p>
</td>
<td width="54">
<p>33</p>
</td>
<td width="48">
<p>63</p>
</td>
<td width="49">
<p>48</p>
</td>
</tr>
</tbody>
</table>
<p>Now let&rsquo;s see how the Strength is calculated:</p>
<p>Strength &ndash; (Item A&rsquo;s Strength + Item B&rsquo;s Strength) + MAX (Paladin Game Type&rsquo;s Strength, Sorceress GameType's Strength) + MAX (Paladin Character&rsquo;s Strength, Sorceress Character&rsquo;s Strength) = 15 + 8 + 6 + 20 = 49.</p>
<p>Here we sum up first the <strong>items</strong> <strong>stats</strong> (<strong>15 + 8</strong>) then we add the biggest one between the game type stats (6 &gt; 5 =&gt; <strong>6</strong>) then we add the biggest one between the character stats (20 &gt; 8 =&gt; <strong>20</strong>). So (15 + 8) + 6 + 20 = 49.</p>
<p>Same goes for the Luck:</p>
<p>Luck = (Item A&rsquo;s Luck + Item B&rsquo;s Luck) + MAX (Paladin Game Type&rsquo;s Luck, Sorceress GameType's Luck) + MAX (Paladin Character&rsquo;s Luck, Sorceress Character&rsquo;s Luck) = 20 + 12 + 6 + 10 = 49.</p>
<p>Here we sum up first the <strong>items</strong> <strong>stats</strong> (<strong>20 + 12</strong>) then we add the biggest one between the game type stats (6 &gt; 5 =&gt; <strong>6</strong>) then we add the biggest one between the character stats (10 &gt; 6 =&gt; <strong>10</strong>). So (20 + 12) + 6 + 10 = 48.</p>
<h3>Output</h3>
<table width="710">
<tbody>
<tr>
<td width="145">
<p><strong>Username</strong></p>
</td>
<td width="156">
<p><strong>Game</strong></p>
</td>
<td width="120">
<p><strong>Character</strong></p>
</td>
<td width="72">
<p><strong>Strength</strong></p>
</td>
<td width="66">
<p><strong>Defence</strong></p>
</td>
<td width="54">
<p><strong>Speed</strong></p>
</td>
<td width="48">
<p><strong>Mind</strong></p>
</td>
<td width="49">
<p><strong>Luck</strong></p>
</td>
</tr>
<tr>
<td width="145">
<p>skippingside</p>
</td>
<td width="156">
<p>Rose Fire &amp; Ice</p>
</td>
<td width="120">
<p>Sorceress</p>
</td>
<td width="72">
<p>258</p>
</td>
<td width="66">
<p>215</p>
</td>
<td width="54">
<p>246</p>
</td>
<td width="48">
<p>240</p>
</td>
<td width="49">
<p>263</p>
</td>
</tr>
<tr>
<td width="145">
<p>countrydecay</p>
</td>
<td width="156">
<p>Star of Bethlehem</p>
</td>
<td width="120">
<p>Sorceress</p>
</td>
<td width="72">
<p>221</p>
</td>
<td width="66">
<p>163</p>
</td>
<td width="54">
<p>216</p>
</td>
<td width="48">
<p>153</p>
</td>
<td width="49">
<p>196</p>
</td>
</tr>
<tr>
<td width="145">
<p>obliquepoof</p>
</td>
<td width="156">
<p>Washington D.C.</p>
</td>
<td width="120">
<p>Paladin</p>
</td>
<td width="72">
<p>204</p>
</td>
<td width="66">
<p>200</p>
</td>
<td width="54">
<p>183</p>
</td>
<td width="48">
<p>185</p>
</td>
<td width="49">
<p>185</p>
</td>
</tr>
</tbody>
</table>
<p>Note that for the <strong>Character</strong> column you should select the character name which is <strong>alphabetically</strong> &ldquo;bigger&rdquo; then others. In other word if you have two characters: &ldquo;A&rdquo; and &ldquo;Z&rdquo;, <strong>pick</strong> &ldquo;<strong>Z</strong>&rdquo; because alphabetically is after &ldquo;A&rdquo;.</p>
<h3>Hints</h3>
<p>You have to join <strong>GameType</strong> with <strong>Statistics</strong>, <strong>Characters</strong> with <strong>Statistics</strong> and <strong>Items</strong> with their <strong>Statistics</strong> in a single <strong>query</strong> (and that for every <strong>user </strong>in a game). After that use aggregate functions (like <strong>MAX</strong> and <strong>SUM</strong>) to calculate the above statistics.</p>
<p>For the character name use <strong>MAX</strong>(characterName).</p>
<h2>Problem 26.&nbsp;&nbsp;&nbsp; All Items with Greater than Average Statistics</h2>
<p>Find all items with statistics larger than average. Display only items that have <strong>Mind, Luck </strong>and<strong> Speed</strong> greater than average <strong>Items</strong> mind, luck and speed. Sort the results by item names in alphabetical order. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="710">
<tbody>
<tr>
<td width="185">
<p><strong>Name</strong></p>
</td>
<td width="128">
<p><strong>Price</strong></p>
</td>
<td width="90">
<p><strong>MinLevel</strong></p>
</td>
<td width="72">
<p><strong>Strength</strong></p>
</td>
<td width="66">
<p><strong>Defence</strong></p>
</td>
<td width="53">
<p><strong>Speed</strong></p>
</td>
<td width="67">
<p><strong>Luck</strong></p>
</td>
<td width="49">
<p><strong>Mind</strong></p>
</td>
</tr>
<tr>
<td width="185">
<p>Aether Walker</p>
</td>
<td width="128">
<p>473.00</p>
</td>
<td width="90">
<p>46</p>
</td>
<td width="72">
<p>2</p>
</td>
<td width="66">
<p>10</p>
</td>
<td width="53">
<p>15</p>
</td>
<td width="67">
<p>11</p>
</td>
<td width="49">
<p>13</p>
</td>
</tr>
<tr>
<td width="185">
<p>Ancient Parthan Defenders</p>
</td>
<td width="128">
<p>566.00</p>
</td>
<td width="90">
<p>38</p>
</td>
<td width="72">
<p>5</p>
</td>
<td width="66">
<p>7</p>
</td>
<td width="53">
<p>10</p>
</td>
<td width="67">
<p>19</p>
</td>
<td width="49">
<p>18</p>
</td>
</tr>
<tr>
<td width="185">
<p>Aquila Cuirass</p>
</td>
<td width="128">
<p>405.00</p>
</td>
<td width="90">
<p>76</p>
</td>
<td width="72">
<p>5</p>
</td>
<td width="66">
<p>7</p>
</td>
<td width="53">
<p>10</p>
</td>
<td width="67">
<p>19</p>
</td>
<td width="49">
<p>18</p>
</td>
</tr>
<tr>
<td width="185">
<p>Arcstone</p>
</td>
<td width="128">
<p>613.00</p>
</td>
<td width="90">
<p>50</p>
</td>
<td width="72">
<p>2</p>
</td>
<td width="66">
<p>10</p>
</td>
<td width="53">
<p>15</p>
</td>
<td width="67">
<p>11</p>
</td>
<td width="49">
<p>13</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 27.&nbsp;&nbsp;&nbsp; Display All Items with Information about Forbidden Game Type</h2>
<p>Find <strong>all</strong> <strong>items </strong>and information whether and what forbidden game types they have. Display item name, price, min level and forbidden game type. Display all items. Sort the results by game type in descending order, then by item name in ascending order. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="420">
<tbody>
<tr>
<td width="132">
<p><strong>Item</strong></p>
</td>
<td width="66">
<p><strong>Price</strong></p>
</td>
<td width="72">
<p><strong>MinLevel</strong></p>
</td>
<td width="150">
<p><strong>Forbidden Game Type</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Archfiend Arrows</p>
</td>
<td width="66">
<p>531.00</p>
</td>
<td width="72">
<p>8</p>
</td>
<td width="150">
<p>Kinky</p>
</td>
</tr>
<tr>
<td width="132">
<p>Behistun Rune</p>
</td>
<td width="66">
<p>611.00</p>
</td>
<td width="72">
<p>67</p>
</td>
<td width="150">
<p>Kinky</p>
</td>
</tr>
<tr>
<td width="132">
<p>Boots</p>
</td>
<td width="66">
<p>782.00</p>
</td>
<td width="72">
<p>44</p>
</td>
<td width="150">
<p>Kinky</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="72">
<p>&hellip;</p>
</td>
<td width="150">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 28.&nbsp;&nbsp;&nbsp; Buy Items for User in Game</h2>
<ol>
<li>User <strong>Alex </strong>is in the shop in the game &ldquo;<strong>Edinburgh</strong>&rdquo; and she wants to buy some items. She likes <strong>Blackguard</strong>, <strong>Bottomless Potion of Amplification</strong>, <strong>Eye of Etlich (Diablo III)</strong>, <strong>Gem of Efficacious Toxin</strong>, <strong>Golden Gorget of Leoric</strong> and <strong>Hellfire Amulet</strong>. Buy the items. You should add the data in the right tables. Get the money for the items from user in game <strong>Cash</strong>.</li>
<li>Select all users in the current game with their items. Display username, game name, cash and item name. Sort the result by item name.</li>
</ol>
<p>Submit your query statements as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table width="529">
<tbody>
<tr>
<td width="124">
<p><strong>Username</strong></p>
</td>
<td width="84">
<p><strong>Name</strong></p>
</td>
<td width="76">
<p><strong>Cash</strong></p>
</td>
<td width="246">
<p><strong>Item Name</strong></p>
</td>
</tr>
<tr>
<td width="124">
<p>Alex</p>
</td>
<td width="84">
<p>Edinburgh</p>
</td>
<td width="76">
<p>****.**</p>
</td>
<td width="246">
<p>Akanesh, the Herald of Righteousness</p>
</td>
</tr>
<tr>
<td width="124">
<p>&hellip;</p>
</td>
<td width="84">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="246">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="124">
<p>corruptpizz</p>
</td>
<td width="84">
<p>Edinburgh</p>
</td>
<td width="76">
<p>****.**</p>
</td>
<td width="246">
<p>Broken Crown</p>
</td>
</tr>
<tr>
<td width="124">
<p>&hellip;</p>
</td>
<td width="84">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="246">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="124">
<p>printerstencils</p>
</td>
<td width="84">
<p>Edinburgh</p>
</td>
<td width="76">
<p>****.**</p>
</td>
<td width="246">
<p>Envious Blade</p>
</td>
</tr>
</tbody>
</table>
<h1>PART IV &ndash; Queries for Geography Database</h1>
<h2>Problem 29.&nbsp;&nbsp;&nbsp; Peaks and Mountains</h2>
<p>Find all <strong>peaks along with their mountain</strong> sorted by elevation (from the highest to the lowest), then by peak name alphabetically. Display the peak name, mountain range name and elevation. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="123">
<p><strong>PeakName</strong></p>
</td>
<td width="85">
<p><strong>Mountain</strong></p>
</td>
<td width="78">
<p><strong>Elevation</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>Everest</p>
</td>
<td width="85">
<p>Himalayas</p>
</td>
<td width="78">
<p>8848</p>
</td>
</tr>
<tr>
<td width="123">
<p>K2</p>
</td>
<td width="85">
<p>Karakoram</p>
</td>
<td width="78">
<p>8611</p>
</td>
</tr>
<tr>
<td width="123">
<p>Kangchenjunga</p>
</td>
<td width="85">
<p>Himalayas</p>
</td>
<td width="78">
<p>8586</p>
</td>
</tr>
<tr>
<td width="123">
<p>&hellip;</p>
</td>
<td width="85">
<p>&nbsp;</p>
</td>
<td width="78">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 30.&nbsp;&nbsp;&nbsp; Peaks with Their Mountain, Country and Continent</h2>
<p>Find all peaks along with their mountain, country and continent. When a mountain belongs to multiple countries, display them all. Sort the results by peak name alphabetically, then by country name alphabetically. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="112">
<p><strong>PeakName</strong></p>
</td>
<td width="82">
<p><strong>Mountain</strong></p>
</td>
<td width="107">
<p><strong>CountryName</strong></p>
</td>
<td width="118">
<p><strong>ContinentName</strong></p>
</td>
</tr>
<tr>
<td width="112">
<p>Aconcagua</p>
</td>
<td width="82">
<p>Andes</p>
</td>
<td width="107">
<p>Argentina</p>
</td>
<td width="118">
<p>South America</p>
</td>
</tr>
<tr>
<td width="112">
<p>Aconcagua</p>
</td>
<td width="82">
<p>Andes</p>
</td>
<td width="107">
<p>Chile</p>
</td>
<td width="118">
<p>South America</p>
</td>
</tr>
<tr>
<td width="112">
<p>Banski Suhodol</p>
</td>
<td width="82">
<p>Pirin</p>
</td>
<td width="107">
<p>Bulgaria</p>
</td>
<td width="118">
<p>Europe</p>
</td>
</tr>
<tr>
<td width="112">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
<td width="118">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 31.&nbsp;&nbsp;&nbsp; Rivers by Country</h2>
<p>For each country in the database, display the number of rivers passing through that country and the total length of these rivers. When a country does not have any river, display <strong>0</strong> as rivers count and as total length. Sort the results by rivers count (from largest to smallest), then by total length (from largest to smallest), then by country alphabetically. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="107">
<p><strong>CountryName</strong></p>
</td>
<td width="118">
<p><strong>ContinentName</strong></p>
</td>
<td width="95">
<p><strong>RiversCount</strong></p>
</td>
<td width="94">
<p><strong>TotalLength</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>China</p>
</td>
<td width="118">
<p>Asia</p>
</td>
<td width="95">
<p>8</p>
</td>
<td width="94">
<p>35156</p>
</td>
</tr>
<tr>
<td width="107">
<p>Russia</p>
</td>
<td width="118">
<p>Europe</p>
</td>
<td width="95">
<p>6</p>
</td>
<td width="94">
<p>26427</p>
</td>
</tr>
<tr>
<td width="107">
<p>&hellip;</p>
</td>
<td width="118">
<p>&nbsp;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="94">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 32.&nbsp;&nbsp;&nbsp; Count of Countries by Currency</h2>
<p>Find the <strong>number of countries for each currency</strong>. Display three columns: currency code, currency description and number of countries. Sort the results by number of countries (from highest to lowest), then by currency description alphabetically. Name the columns exactly like in the table below. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="107">
<p><strong>CurrencyCode</strong></p>
</td>
<td width="314">
<p><strong>Currency</strong></p>
</td>
<td width="145">
<p><strong>NumberOfCountries</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>EUR</p>
</td>
<td width="314">
<p>Euro Member Countries</p>
</td>
<td width="145">
<p>35</p>
</td>
</tr>
<tr>
<td width="107">
<p>USD</p>
</td>
<td width="314">
<p>United States Dollar</p>
</td>
<td width="145">
<p>17</p>
</td>
</tr>
<tr>
<td width="107">
<p>AUD</p>
</td>
<td width="314">
<p>Australia Dollar</p>
</td>
<td width="145">
<p>8</p>
</td>
</tr>
<tr>
<td width="107">
<p>XOF</p>
</td>
<td width="314">
<p>Communaut&eacute; Financi&egrave;re Africaine (BCEAO) Franc</p>
</td>
<td width="145">
<p>8</p>
</td>
</tr>
<tr>
<td width="107">
<p>&hellip;</p>
</td>
<td width="314">
<p>&hellip;</p>
</td>
<td width="145">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 33.&nbsp;&nbsp;&nbsp; Population and Area by Continent</h2>
<p>For each continent, display the total area and total population of all its countries. Sort the results by population from highest to lowest. Submit your query statement as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="118">
<p><strong>ContinentName</strong></p>
</td>
<td width="109">
<p><strong>CountriesArea</strong></p>
</td>
<td width="147">
<p><strong>CountriesPopulation</strong></p>
</td>
</tr>
<tr>
<td width="118">
<p>Asia</p>
</td>
<td width="109">
<p>31603228</p>
</td>
<td width="147">
<p>4130318467</p>
</td>
</tr>
<tr>
<td width="118">
<p>Africa</p>
</td>
<td width="109">
<p>30360296</p>
</td>
<td width="147">
<p>1015470588</p>
</td>
</tr>
<tr>
<td width="118">
<p>&hellip;</p>
</td>
<td width="109">
<p>&hellip;</p>
</td>
<td width="147">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 34.&nbsp;&nbsp;&nbsp; Monasteries by Country</h2>
<ol>
<li>Create a <strong>table Monasteries(Id, Name, CountryCode)</strong>. Use auto-increment for the primary key. Create a <strong>foreign key</strong> between the tables Monasteries and Countries.</li>
<li>Execute the following SQL script (it should pass without any errors):</li>
</ol>
<table>
<tbody>
<tr>
<td width="672">
<p>INSERT INTO Monasteries(Name, CountryCode) VALUES</p>
<p>('Rila Monastery &ldquo;St. Ivan of Rila&rdquo;', 'BG'),</p>
<p>('Bachkovo Monastery &ldquo;Virgin Mary&rdquo;', 'BG'),</p>
<p>('Troyan Monastery &ldquo;Holy Mother''s Assumption&rdquo;', 'BG'),</p>
<p>('Kopan Monastery', 'NP'),</p>
<p>('Thrangu Tashi Yangtse Monastery', 'NP'),</p>
<p>('Shechen Tennyi Dargyeling Monastery', 'NP'),</p>
<p>('Benchen Monastery', 'NP'),</p>
<p>('Southern Shaolin Monastery', 'CN'),</p>
<p>('Dabei Monastery', 'CN'),</p>
<p>('Wa Sau Toi', 'CN'),</p>
<p>('Lhunshigyia Monastery', 'CN'),</p>
<p>('Rakya Monastery', 'CN'),</p>
<p>('Monasteries of Meteora', 'GR'),</p>
<p>('The Holy Monastery of Stavronikita', 'GR'),</p>
<p>('Taung Kalat Monastery', 'MM'),</p>
<p>('Pa-Auk Forest Monastery', 'MM'),</p>
<p>('Taktsang Palphug Monastery', 'BT'),</p>
<p>('S&uuml;mela Monastery', 'TR')</p>
</td>
</tr>
</tbody>
</table>
<ol start="3">
<li>Write a SQL command to add a new Boolean column IsDeleted in the Countries table (defaults to false). Note that there is no "Boolean" type in SQL server, so you should use an alternative and make sure you set the <strong>default</strong> value properly.</li>
<li>Write and execute a SQL command to <strong>mark as deleted all countries that have more than 3 rivers</strong>.</li>
<li>Write a query to display all <strong>monasteries</strong> along with their <strong>countries</strong> sorted by monastery name. Skip all deleted countries and their monasteries.</li>
</ol>
<p>Submit your query statements <strong>only for subtasks 1, 2, 4 and 5</strong> <strong>at once </strong>as Prepare DB &amp; run queries in Judge.</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="232">
<p><strong>Monastery</strong></p>
</td>
<td width="70">
<p><strong>Country</strong></p>
</td>
</tr>
<tr>
<td width="232">
<p>Bachkovo Monastery &ldquo;Virgin Mary&rdquo;</p>
</td>
<td width="70">
<p>Bulgaria</p>
</td>
</tr>
<tr>
<td width="232">
<p>Benchen Monastery</p>
</td>
<td width="70">
<p>Nepal</p>
</td>
</tr>
<tr>
<td width="232">
<p>Kopan Monastery</p>
</td>
<td width="70">
<p>Nepal</p>
</td>
</tr>
<tr>
<td width="232">
<p>&hellip;</p>
</td>
<td width="70">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 35.&nbsp;&nbsp;&nbsp; Monasteries by Continents and Countries</h2>
<p>This problem assumes that <strong>the previous problem is completed successfully without errors</strong>.</p>
<ol>
<li>Write and execute a SQL command that <strong>changes the country named "Myanmar" to its other name "Burma"</strong>.</li>
<li>Add a <strong>new monastery</strong> holding the following information: Name="Hanga Abbey", Country="Tanzania".</li>
<li>Add a <strong>new monastery</strong> holding the following information: Name="Myin-Tin-Daik", Country="Myanmar".</li>
<li>Find the <strong>count of monasteries for each continent and not deleted country</strong>. Display the <strong>continent name</strong>, the <strong>country name</strong> and the <strong>count of monasteries</strong>. Include also the countries with 0 Sort the results by monasteries count (from largest to lowest), then by country name alphabetically. Name the columns exactly like in the table below.</li>
</ol>
<p>Submit all your query statements at once as Prepare DB &amp; run queries in Judge.</p>
<p>* Note when you <strong>insert</strong> the <strong>monasteries</strong> make sure to specify the country code by &nbsp;the country name (aka use &nbsp;&nbsp;<br /> &nbsp;&nbsp; <strong>subquery</strong>).</p>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>ContinentName</strong></p>
</td>
<td width="76">
<p><strong>CountryName</strong></p>
</td>
<td width="81">
<p><strong>MonasteriesCount</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Asia</p>
</td>
<td width="76">
<p>Nepal</p>
</td>
<td width="81">
<p>4</p>
</td>
</tr>
<tr>
<td width="95">
<p>Europe</p>
</td>
<td width="76">
<p>Bulgaria</p>
</td>
<td width="81">
<p>3</p>
</td>
</tr>
<tr>
<td width="95">
<p>Asia</p>
</td>
<td width="76">
<p>Burma</p>
</td>
<td width="81">
<p>2</p>
</td>
</tr>
<tr>
<td width="95">
<p>Europe</p>
</td>
<td width="76">
<p>Greece</p>
</td>
<td width="81">
<p>2</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="81">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>