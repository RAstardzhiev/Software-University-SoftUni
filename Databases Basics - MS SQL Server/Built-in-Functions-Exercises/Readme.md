<h1>Exercises: Built-in Functions</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016">"Databases Basics - MSSQL" course @ Software University.</a></p>
<h1>Part I &ndash; Queries for SoftUni Database</h1>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Names of All Employees by First Name</h2>
<p>Write a SQL query to find <strong>first</strong> and <strong>last names</strong> of all employees whose <strong>first name starts with</strong> <strong>&ldquo;SA&rdquo;. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="142">
<p><strong>LastName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Sariya</p>
</td>
<td width="142">
<p>Harnpadoungsataya</p>
</td>
</tr>
<tr>
<td width="95">
<p>Sandra</p>
</td>
<td width="142">
<p>Reategui Alayo</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;Find Names of All employees by Last Name</h2>
<p>Write a SQL query to find <strong>first</strong> and <strong>last names</strong> of all employees whose <strong>last name contains &ldquo;ei&rdquo;. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="142">
<p><strong>LastName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Kendall</p>
</td>
<td width="142">
<p>Keil</p>
</td>
</tr>
<tr>
<td width="95">
<p>Christian</p>
</td>
<td width="142">
<p>Kleinerman</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find First Names of All Employees</h2>
<p>Write a SQL query to find the <strong>first names</strong> of all employees in the <strong>departments</strong> with <strong>ID 3 or 10</strong> and whose <strong>hire year</strong> is <strong>between 1995 and 2005 inclusive</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>FirstName</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Deborah</p>
</td>
</tr>
<tr>
<td width="85">
<p>Wendy</p>
</td>
</tr>
<tr>
<td width="85">
<p>Candy</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find All Employees Except Engineers</h2>
<p>Write a SQL query to find the <strong>first </strong>and<strong> last names</strong> of all employees whose <strong>job titles does not contain</strong> &ldquo;<strong>engineer</strong>&rdquo;. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>FirstName</strong></p>
</td>
<td width="76">
<p><strong>LastName</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Guy</p>
</td>
<td width="76">
<p>Gilbert</p>
</td>
</tr>
<tr>
<td width="85">
<p>Kevin</p>
</td>
<td width="76">
<p>Brown</p>
</td>
</tr>
<tr>
<td width="85">
<p>Rob</p>
</td>
<td width="76">
<p>Walters</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Towns with Name Length</h2>
<p>Write a SQL query to find town names that are <strong>5</strong> or <strong>6 symbols long</strong> and <strong>order</strong> them <strong>alphabetically by town name</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="66">
<p><strong>Name</strong></p>
</td>
</tr>
<tr>
<td width="66">
<p>Berlin</p>
</td>
</tr>
<tr>
<td width="66">
<p>Duluth</p>
</td>
</tr>
<tr>
<td width="66">
<p>Duvall</p>
</td>
</tr>
<tr>
<td width="66">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find Towns Starting With</h2>
<p>Write a SQL query to find all towns that <strong>start with</strong> letters <strong>M</strong>, <strong>K</strong>, <strong>B</strong> or <strong>E</strong>. Order them <strong>alphabetically</strong> by town name. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="66">
<p><strong>TownID</strong></p>
</td>
<td width="95">
<p><strong>Name</strong></p>
</td>
</tr>
<tr>
<td width="66">
<p>5</p>
</td>
<td width="95">
<p>Bellevue</p>
</td>
</tr>
<tr>
<td width="66">
<p>31</p>
</td>
<td width="95">
<p>Berlin</p>
</td>
</tr>
<tr>
<td width="66">
<p>30</p>
</td>
<td width="95">
<p>Bordeaux</p>
</td>
</tr>
<tr>
<td width="66">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find Towns Not Starting With</h2>
<p>Write a SQL query to find all towns that <strong>does not start with</strong> letters <strong>R</strong>, <strong>B</strong> or <strong>D</strong>. Order them <strong>alphabetically</strong> by name. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="66">
<p><strong>TownID</strong></p>
</td>
<td width="95">
<p><strong>Name</strong></p>
</td>
</tr>
<tr>
<td width="66">
<p>2</p>
</td>
<td width="95">
<p>Calgary</p>
</td>
</tr>
<tr>
<td width="66">
<p>23</p>
</td>
<td width="95">
<p>Cambridge</p>
</td>
</tr>
<tr>
<td width="66">
<p>15</p>
</td>
<td width="95">
<p>Carnation</p>
</td>
</tr>
<tr>
<td width="66">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create View Employees Hired After 2000 Year</h2>
<p>Write a SQL query to create view <strong>V_EmployeesHiredAfter2000</strong> with <strong>first and last name</strong> to all employees <strong>hired after 2000 year. </strong>Submit your query statements as Run skeleton, run queries &amp; check DB.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>FirstName</strong></p>
</td>
<td width="76">
<p><strong>LastName</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Steven</p>
</td>
<td width="76">
<p>Selikoff</p>
</td>
</tr>
<tr>
<td width="85">
<p>Peter</p>
</td>
<td width="76">
<p>Krebs</p>
</td>
</tr>
<tr>
<td width="85">
<p>Stuart</p>
</td>
<td width="76">
<p>Munson</p>
</td>
</tr>
<tr>
<td width="85">
<p>...</p>
</td>
<td width="76">
<p>...</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Length of Last Name</h2>
<p>Write a SQL query to find the names of all employees whose last name is <strong>exactly</strong> <strong>5 characters long.</strong></p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>FirstName</strong></p>
</td>
<td width="85">
<p><strong>LastName</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Kevin</p>
</td>
<td width="85">
<p>Brown</p>
</td>
</tr>
<tr>
<td width="85">
<p>Terri</p>
</td>
<td width="85">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="85">
<p>Jo</p>
</td>
<td width="85">
<p>Brown</p>
</td>
</tr>
<tr>
<td width="85">
<p>Diane</p>
</td>
<td width="85">
<p>Glimp</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>Part II &ndash; Queries for Geography Database</h1>
<h2>Problem 10. Countries Holding &lsquo;A&rsquo; 3 or More Times</h2>
<p>Find all countries that holds the letter 'A' in their name at least 3 times (case insensitively), sorted by ISO code. Display the country name and ISO code. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>CountryName</strong></p>
</td>
<td width="85">
<p><strong>ISO Code</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Afghanistan</p>
</td>
<td width="85">
<p>AFG</p>
</td>
</tr>
<tr>
<td width="104">
<p>Albania</p>
</td>
<td width="85">
<p>ALB</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11. &nbsp;Mix of Peak and River Names</h2>
<p>Combine all peak names with all river names, so that the last letter of each peak name is the same like the first letter of its corresponding river name. Display the peak names, river names, and the obtained mix (mix should be in lowercase). Sort the results by the obtained mix. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>PeakName</strong></p>
</td>
<td width="85">
<p><strong>RiverName</strong></p>
</td>
<td width="132">
<p><strong>Mix</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Aconcagua</p>
</td>
<td width="85">
<p>Amazon</p>
</td>
<td width="132">
<p>aconcaguamazon</p>
</td>
</tr>
<tr>
<td width="113">
<p>Aconcagua</p>
</td>
<td width="85">
<p>Amur</p>
</td>
<td width="132">
<p>aconcaguamur</p>
</td>
</tr>
<tr>
<td width="113">
<p>Banski Suhodol</p>
</td>
<td width="85">
<p>Lena</p>
</td>
<td width="132">
<p>banski suhodolena</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>Part III &ndash; Queries for Diablo Database</h1>
<h2>Problem 12. Games from 2011 and 2012 year</h2>
<p>Find the top 50 games ordered by start date, then by name of the game. Display only games from 2011 and 2012 year. Display start date in the format &ldquo;<strong>yyyy-MM-dd</strong>&rdquo;. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>Name</strong></p>
</td>
<td width="85">
<p><strong>Start</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Rose Royalty</p>
</td>
<td width="85">
<p>2011-01-05</p>
</td>
</tr>
<tr>
<td width="104">
<p>London</p>
</td>
<td width="85">
<p>2011-01-13</p>
</td>
</tr>
<tr>
<td width="104">
<p>Broadway</p>
</td>
<td width="85">
<p>2011-01-16</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13. &nbsp;User Email Providers</h2>
<p>Find all users along with information about their email providers. Display the username and email provider. Sort the results by email provider alphabetically, then by username. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>Username</strong></p>
</td>
<td width="132">
<p><strong>Email Provider</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Pesho</p>
</td>
<td width="132">
<p>abv.bg</p>
</td>
</tr>
<tr>
<td width="104">
<p>monoxidecos</p>
</td>
<td width="132">
<p>astonrasuna.com</p>
</td>
</tr>
<tr>
<td width="104">
<p>bashsassafras</p>
</td>
<td width="132">
<p>balibless</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14. &nbsp;Get Users with IPAdress Like Pattern</h2>
<p>Find all users along with their IP addresses sorted by username alphabetically. Display only rows that IP address matches the pattern: &ldquo;<strong>***.1^.^.***</strong>&rdquo;. Submit your query statements as Prepare DB &amp; run queries.</p>
<p>Legend: <strong>* </strong>- one symbol, <strong>^</strong> - one or more symbols</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>Username</strong></p>
</td>
<td width="123">
<p><strong>IP Address</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>bindbawdy</p>
</td>
<td width="123">
<p>192.157.20.222</p>
</td>
</tr>
<tr>
<td width="132">
<p>evolvingimportant</p>
</td>
<td width="123">
<p>223.175.227.173</p>
</td>
</tr>
<tr>
<td width="132">
<p>inguinalself</p>
</td>
<td width="123">
<p>255.111.250.207</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 15. &nbsp;Show All Games with Duration and Part of the Day</h2>
<p>Find all games with part of the day and duration sorted by game name alphabetically then by duration (alphabetically, not by the timespan) and part of the day (all ascending). <strong>Parts of the day</strong> should be <strong>Morning</strong> (time is &gt;= 0 and &lt; 12), <strong>Afternoon</strong> (time is &gt;= 12 and &lt; 18), <strong>Evening</strong> (time is &gt;= 18 and &lt; 24). <strong>Duration</strong> should be <strong>Extra</strong> <strong>Short </strong>(smaller or equal to 3), <strong>Short </strong>(between 4 and 6 including), <strong>Long</strong> (greater than 6) and <strong>Extra Long </strong>(without duration). Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>Game</strong></p>
</td>
<td width="123">
<p><strong>Part of the Day</strong></p>
</td>
<td width="113">
<p><strong>Duration</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Ablajeck</p>
</td>
<td width="123">
<p>Morning</p>
</td>
<td width="113">
<p>Long</p>
</td>
</tr>
<tr>
<td width="113">
<p>Ablajeck</p>
</td>
<td width="123">
<p>Afternoon</p>
</td>
<td width="113">
<p>Short</p>
</td>
</tr>
<tr>
<td width="113">
<p>Abregado Rae</p>
</td>
<td width="123">
<p>Afternoon</p>
</td>
<td width="113">
<p>Long</p>
</td>
</tr>
<tr>
<td width="113">
<p>Abrion</p>
</td>
<td width="123">
<p>Morning</p>
</td>
<td width="113">
<p>Extra Short</p>
</td>
</tr>
<tr>
<td width="113">
<p>Acaeria</p>
</td>
<td width="123">
<p>Evening</p>
</td>
<td width="113">
<p>Long</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>Part IV &ndash; Date Functions Queries</h1>
<h2>Problem 16. &nbsp;Orders Table</h2>
<p>You are given a table <strong>Orders(Id, ProductName, OrderDate)</strong> filled with data. Consider that the <strong>payment</strong> for that order must be accomplished <strong>within 3 days after the order date</strong>. Also the <strong>delivery date is up to 1 month</strong>. Write a query to show each product&rsquo;s <strong>name</strong>, <strong>order date</strong>, <strong>pay and deliver due dates</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Original Table</h3>
<table>
<tbody>
<tr>
<td width="38">
<p><strong>Id</strong></p>
</td>
<td width="104">
<p><strong>ProductName</strong></p>
</td>
<td width="170">
<p><strong>OrderDate</strong></p>
</td>
</tr>
<tr>
<td width="38">
<p>1</p>
</td>
<td width="104">
<p>Butter</p>
</td>
<td width="170">
<p>2016-09-19 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>2</p>
</td>
<td width="104">
<p>Milk</p>
</td>
<td width="170">
<p>2016-09-30 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>3</p>
</td>
<td width="104">
<p>Cheese</p>
</td>
<td width="170">
<p>2016-09-04 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>4</p>
</td>
<td width="104">
<p>Bread</p>
</td>
<td width="170">
<p>2015-12-20 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>5</p>
</td>
<td width="104">
<p>Tomatoes</p>
</td>
<td width="170">
<p>2015-12-30 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>&hellip;</p>
</td>
<td width="104">
<p>&hellip;</p>
</td>
<td width="170">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Output</h3>
<table>
<tbody>
<tr>
<td width="123">
<p><strong>ProductName</strong></p>
</td>
<td width="170">
<p><strong>OrderDate</strong></p>
</td>
<td width="170">
<p><strong>Pay Due</strong></p>
</td>
<td width="170">
<p><strong>Deliver Due</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>Butter</p>
</td>
<td width="170">
<p>2016-09-19 00:00:00.000</p>
</td>
<td width="170">
<p>2016-09-22 00:00:00.000</p>
</td>
<td width="170">
<p>2016-10-19 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="123">
<p>Milk</p>
</td>
<td width="170">
<p>2016-09-30 00:00:00.000</p>
</td>
<td width="170">
<p>2016-10-03 00:00:00.000</p>
</td>
<td width="170">
<p>2016-10-30 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="123">
<p>Cheese</p>
</td>
<td width="170">
<p>2016-09-04 00:00:00.000</p>
</td>
<td width="170">
<p>2016-09-07 00:00:00.000</p>
</td>
<td width="170">
<p>2016-10-04 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="123">
<p>Bread</p>
</td>
<td width="170">
<p>2015-12-20 00:00:00.000</p>
</td>
<td width="170">
<p>2015-12-23 00:00:00.000</p>
</td>
<td width="170">
<p>2016-01-20 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="123">
<p>Tomatoes</p>
</td>
<td width="170">
<p>2015-12-30 00:00:00.000</p>
</td>
<td width="170">
<p>2016-01-02 00:00:00.000</p>
</td>
<td width="170">
<p>2016-01-30 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="123">
<p>&hellip;</p>
</td>
<td width="170">
<p>&hellip;</p>
</td>
<td width="170">
<p>&hellip;</p>
</td>
<td width="170">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 17. &nbsp;People Table</h2>
<p>Create a table <strong>People(Id, Name</strong><strong>, Birthdate).</strong> Write a query to <strong>find</strong> <strong>age in years</strong>, <strong>months</strong>, <strong>days</strong> and <strong>minutes</strong> for each person for the <strong>current time</strong> of executing the query.</p>
<h3>Original Table</h3>
<table>
<tbody>
<tr>
<td width="38">
<p><strong>Id</strong></p>
</td>
<td width="66">
<p><strong>Name</strong></p>
</td>
<td width="170">
<p><strong>Birthdate</strong></p>
</td>
</tr>
<tr>
<td width="38">
<p>1</p>
</td>
<td width="66">
<p>Victor</p>
</td>
<td width="170">
<p>2000-12-07 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>2</p>
</td>
<td width="66">
<p>Steven</p>
</td>
<td width="170">
<p>1992-09-10 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>3</p>
</td>
<td width="66">
<p>Stephen</p>
</td>
<td width="170">
<p>1910-09-19 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>4</p>
</td>
<td width="66">
<p>John</p>
</td>
<td width="170">
<p>2010-01-06 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="38">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="170">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example Output</h3>
<table>
<tbody>
<tr>
<td width="76">
<p><strong>Name</strong></p>
</td>
<td width="95">
<p><strong>Age in Years</strong></p>
</td>
<td width="104">
<p><strong>Age in Months</strong></p>
</td>
<td width="85">
<p><strong>Age in Days</strong></p>
</td>
<td width="113">
<p><strong>Age in Minutes</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>Victor</p>
</td>
<td width="95">
<p>16</p>
</td>
<td width="104">
<p>189</p>
</td>
<td width="85">
<p>5754</p>
</td>
<td width="113">
<p>8286787</p>
</td>
</tr>
<tr>
<td width="76">
<p>Steven</p>
</td>
<td width="95">
<p>24</p>
</td>
<td width="104">
<p>288</p>
</td>
<td width="85">
<p>8764</p>
</td>
<td width="113">
<p>12621187</p>
</td>
</tr>
<tr>
<td width="76">
<p>Stephen</p>
</td>
<td width="95">
<p>106</p>
</td>
<td width="104">
<p>1272</p>
</td>
<td width="85">
<p>38706</p>
</td>
<td width="113">
<p>55737667</p>
</td>
</tr>
<tr>
<td width="76">
<p>John</p>
</td>
<td width="95">
<p>6</p>
</td>
<td width="104">
<p>80</p>
</td>
<td width="85">
<p>2437</p>
</td>
<td width="113">
<p>3510307</p>
</td>
</tr>
<tr>
<td width="76">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="104">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>