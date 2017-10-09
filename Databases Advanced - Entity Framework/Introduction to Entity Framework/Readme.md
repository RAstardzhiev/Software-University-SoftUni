<h1>Exercises: Introduction to Entity Framework</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/databases-advanced-entity-framework">"Databases Advanced &ndash; Entity Framework" course @ Software University.</a> Please submit your solutions in <a href="https://judge.softuni.bg/Contests/351/Introduction-to-Entity-Framework">Judge.</a></p>
<h2>1.&nbsp;&nbsp; Import the SoftUni Database</h2>
<p>Import the SoftUni database into SQL Management Studio by <strong>executing</strong> the provided <strong>.sql</strong> script.</p>
<h2>2.&nbsp;&nbsp; Database First</h2>
<p>Model the existing database by using Database First.</p>
<p>First create a new empty <strong>ConsoleApplication</strong> and after it is created right click on the project and add a new item. In the newly appeared window select <strong>ADO.NET Entity Data Model </strong>and call it <strong>SoftuniContext</strong> as shown below:</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>Choose your <strong>server name</strong> (SQL management studio connection) and the <strong>database</strong> you wish to model.</p>
<p>Select the latest stable Entitiy Framework version.</p>
<p>Select the tables the desired tables from the target database. Exclude any views and stored procedures.</p>
<p>Click finish. The result should be all the tables that are in your table, generated as classes:</p>
<p>&nbsp;</p>
<p>Entity Framework has successfully <strong>mapped the database schema to C# classes</strong>. However, it isn't quite good with names (See the <strong>Employee</strong> class) - e.g. <strong>Employees1</strong>, <strong>Employee1</strong>. Edit the properties and give them more <strong>proper names</strong>.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Finally, before we begin working with the data, please create a new folder in the project called Models and insert your models in it. (Don&rsquo;t forget to change the namespace, once the models are moved).</p>
<h2>3.&nbsp;&nbsp; Employees Full Information</h2>
<p>Let's start writing C# queries! Your task is to extract <strong>all employees </strong>print their <strong>first</strong>, <strong>last</strong> and <strong>middle</strong> name, their <strong>job</strong> <strong>title</strong> and <strong>salary</strong> separated with a space. Order them by employee id.</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Guy Gilbert R Production Technician 12500.0000</p>
</td>
</tr>
<tr>
<td width="540">
<p>Kevin Brown F Marketing Assistant 13500.0000</p>
</td>
</tr>
<tr>
<td width="540">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Employees with Salary Over 50 000</h2>
<p>Your task is to extract <strong>all employees</strong> with <strong>salary</strong> over <strong>50000</strong>. Create a new context and use lambdas to build your query. Make sure the query returns <strong>only the</strong> <strong>first names </strong>of those employees.</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Terri</p>
</td>
</tr>
<tr>
<td width="540">
<p>Jean</p>
</td>
</tr>
<tr>
<td width="540">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use Express Profiler and check if the made query by Entity Framework is correct (there is only one query, but there may be more that are performed by EF for checks).</p>
<h2>5.&nbsp;&nbsp; Employees from Research and Development</h2>
<p>Extract all employees from the <strong>Research and Development</strong> department. Order them by <strong>salary</strong> (in ascending order), then by <strong>first name</strong> (in descending order). Print only their <strong>first name</strong>, <strong>last name</strong>, <strong>department name</strong> and <strong>salary</strong> in the format shown below:</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>Gigi Matthew from Research and Development - $40900.00</p>
</td>
</tr>
<tr>
<td width="624">
<p>Diane Margheim from Research and Development - $40900.00</p>
</td>
</tr>
<tr>
<td width="624">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>&nbsp;</p>
<p>Use Express Profiler and check if the made query by Entity Framework is correct (there is only one query).</p>
<h2>6.&nbsp;&nbsp; Adding a New Address and Updating Employee</h2>
<p>Create a new address with <strong>text</strong> "<strong>Vitoshka 15</strong>" and <strong>TownId</strong> <strong>4</strong>. Set that address to the employee with last name &ldquo;Nakov&rdquo;.</p>
<p>Then order by descending all the employees by their Address&rsquo; Id, take 10 rows and from them, take the AddressText. Print the results each on a new line:</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>Vitoshka 15</p>
</td>
</tr>
<tr>
<td width="624">
<p>163 Nishava Str, ent A, apt. 1</p>
</td>
</tr>
<tr>
<td width="624">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Create the address and find the employee with last name equal to &ldquo;Nakov&rdquo; in order to assign the address to him.</p>
<h2>7.&nbsp;&nbsp; Find Employees in Period</h2>
<p>Find the first <strong>30</strong> employees who have <strong>projects</strong> started in the time period <strong>2001 - 2003 </strong>(inclusive). Print each employee's <strong>first name</strong>, <strong>last name </strong>and <strong>manager&rsquo;s first name </strong>and each of their projects'<strong> name</strong>, <strong>start date</strong>, <strong>end date</strong>. Here is the format:</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>Guy Gilbert Jo</p>
</td>
</tr>
<tr>
<td width="624">
<p>--Half-Finger Gloves 6/1/2002 12:00:00 AM 6/1/2003 12:00:00 AM</p>
</td>
</tr>
<tr>
<td width="624">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Constraints</h3>
<p>Use date format: &ldquo;M/d/yyyy h:mm:ss tt&rdquo;.</p>
<h2>8.&nbsp;&nbsp; Addresses by Town Name</h2>
<p>Find all addresses, <strong>ordered</strong> by the <strong>number of employees</strong> who live there (descending), then by <strong>town name</strong> (ascending). Take only the <strong>first 10 addresses</strong>. For each address print it in the format:</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>7726 Driftwood Drive, Monroe - 2 employees</p>
</td>
</tr>
<tr>
<td width="624">
<p>163 Nishava Str, ent A, apt. 1, Sofia - 2 employees</p>
</td>
</tr>
<tr>
<td width="624">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Employee with id 147</h2>
<p>Get an <strong>employee with id 147.</strong> Print only his/her <strong>first name</strong>, <strong>last name</strong>, <strong>job title</strong> and <strong>projects</strong> (print only their names). The projects should be <strong>ordered</strong> <strong>by</strong> <strong>name</strong> (ascending). Format of the output:</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Linda Randall Production Technician</p>
</td>
</tr>
<tr>
<td width="540">
<p>HL Touring Handlebars</p>
</td>
</tr>
<tr>
<td width="540">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Departments with more than 5 employees</h2>
<p>Find <strong>all departments</strong> with more than <strong>5 employees</strong>. Order them by <strong>employee count</strong> (ascending).Print the <strong>department name</strong>, <strong>manager&rsquo;s first name</strong> and first name, last name and job title of every <strong>employee</strong>. Format of the output:</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Engineering Terri</p>
</td>
</tr>
<tr>
<td width="540">
<p>Terri Duffy Vice President of Engineering</p>
</td>
</tr>
<tr>
<td width="540">
<p>Roberto Tamburello Engineering Manager</p>
</td>
</tr>
<tr>
<td width="540">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Latest 10 Projects</h2>
<p>Write a program that prints information about <strong>last 10 started projects</strong>. Print <strong>their name, description, start and end date</strong> and <strong>sort</strong> <strong>them by name </strong>lexicographically. Format of the output:</p>
<table width="678">
<tbody>
<tr>
<td width="678">
<p>Output</p>
</td>
</tr>
<tr>
<td width="678">
<p>All-Purpose Bike Stand Research, design and development of All-Purpose Bike Stand. Perfect all-purpose bike stand for working on your bike at home. Quick-adjusting clamps and steel construction. 9/1/2005 12:00:00 AM</p>
</td>
</tr>
<tr>
<td width="678">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Constraints</h3>
<p>Use date format: &ldquo;M/d/yyyy h:mm:ss tt&rdquo;.</p>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Increase Salaries</h2>
<p>Write a program that increase salaries of all employees that are in the <strong>Engineering</strong>, <strong>Tool Design</strong>, <strong>Marketing</strong> or <strong>Information Services</strong> department by <strong>12%</strong>. Then <strong>print first name, last name and salary </strong>for those employees whose salary was increased. Format of the output:</p>
<table width="534">
<tbody>
<tr>
<td width="534">
<p>Output</p>
</td>
</tr>
<tr>
<td width="534">
<p>Kevin Brown ($15120.000000)</p>
</td>
</tr>
<tr>
<td width="534">
<p>Roberto Tamburello ($48496.000000)</p>
</td>
</tr>
<tr>
<td width="534">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Employees by First Name Starting with &lsquo;SA&rsquo;</h2>
<p>Write a program that finds all employees whose first name starts with &lsquo;<strong>SA</strong>&rsquo;. Print their first, last name, their job title and salary in the format given in the example below.</p>
<p>*Note: You have to solve <strong>previous</strong> task in order to display proper results.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="534">
<tbody>
<tr>
<td width="534">
<p>Output</p>
</td>
</tr>
<tr>
<td width="534">
<p>Sariya Harnpadoungsataya - Marketing Specialist - ($16128.0000)</p>
</td>
</tr>
<tr>
<td width="534">
<p>Sandra Reategui Alayo - Production Technician - ($9500.0000)</p>
</td>
</tr>
<tr>
<td width="534">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; First Letter</h2>
<p>Use the <strong>Gringotts database</strong>. Write a program that prints all unique wizard first letters of their <strong>first names</strong> only if they have deposit of type Troll Chest. Order them alphabetically. Use DISTINCT for uniqueness.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="85">
<p>Output</p>
</td>
</tr>
<tr>
<td width="85">
<p>A</p>
</td>
</tr>
<tr>
<td width="85">
<p>B</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Delete Project by Id</h2>
<p>Use again &ldquo;SoftUni&rdquo; database. Let's delete a project by id <strong>2</strong>. Then take 10 projects, select their names and print them on the console each on a new line. Remember to restore your database after this task.</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>Classic Vest</p>
</td>
</tr>
<tr>
<td width="624">
<p>Full-Finger Gloves</p>
</td>
</tr>
<tr>
<td width="624">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>If we try to delete the project directly:</p>
<p>This happens:</p>
<p>The project is <strong>referenced</strong> by the junction (many-to-many) table <strong>EmployeesProjects</strong>. Therefore we cannot safely delete it. First, we need to remove any references to that row in the <strong>Projects</strong> table.</p>
<p>This is done by removing the project from all employees who reference it. <strong>Tip</strong>: Get those employees from the <strong>Employee </strong>navigation property.</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Remove Towns</h2>
<p>Write a program that <strong>deletes </strong><strong>town </strong>which name is given as an input. Also, <strong>delete all addresses</strong> that are in those towns. Print on the console the number addresses that were deleted. You may also note that there are some Employees in that have addresses which may be a problem for deleting the addresses. So first off start by setting the AddressID of each employee in for the given address to null. After all of them are set to null, you may safely remove all the addresses from the context.Addresses and finally remove the given town. You may test this task <strong>locally</strong>, so that you can see what happens for more than 1 case of deletion.</p>
<h3>Example</h3>
<table width="397">
<tbody>
<tr>
<td width="85">
<p>Input</p>
</td>
<td width="312">
<p>Output</p>
</td>
</tr>
<tr>
<td width="85">
<p>Sofia</p>
</td>
<td width="312">
<p>1 address in Sofia was deleted</p>
</td>
</tr>
<tr>
<td width="85">
<p>Seattle</p>
</td>
<td width="312">
<p>44 addresses in Seattle were deleted</p>
</td>
</tr>
</tbody>
</table>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Native SQL Query</h2>
<p>Find all <strong>employees</strong> who have projects with <strong>start date</strong> in the year <strong>2002</strong>. Select only their <strong>first name</strong>. Solve this task by using both <strong>LINQ query</strong> and <strong>native SQL query </strong>through the context.</p>
<p>Measure the difference in performance in both cases with a <strong>Stopwatch</strong>.</p>
<p><strong>Tip</strong>: Use the method for executing native SQL queries.</p>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Explore the Full Source Code of Entity Framework</h2>
<p>Your task is to download (clone the repository) and explore the full source code of Entity Framework. You can find it on <a href="http://entityframework.codeplex.com">http://entityframework.codeplex.com</a>. Do not submit anything for this problem.</p>