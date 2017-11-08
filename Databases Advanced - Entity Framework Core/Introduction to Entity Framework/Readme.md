<h1>Exercises: Introduction to Entity Framework</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp; Import the SoftUni Database</h2>
<p>Import the SoftUni database into SQL Management Studio by <strong>executing</strong> the provided <strong>.sql</strong> script.</p>
<h2>2.&nbsp;&nbsp; Database First</h2>
<p>Model the existing database by using Database First.</p>
<p>First create a new empty <strong>.Net Core</strong> <strong>ConsoleApplication</strong> and after it is created open the <strong>Package Manager Console</strong>:</p>
<p>It will look something like this:</p>
<p>Use it to run the following commands <strong>one by one</strong>:</p>
<table>
<tbody>
<tr>
<td width="522">
<p>Install-Package Microsoft.EntityFrameworkCore.Tools</p>
<p>Install-Package Microsoft.EntityFrameworkCore.SqlServer</p>
<p>Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design</p>
</td>
</tr>
</tbody>
</table>
<p>These are the <strong>packages</strong> you will need, in order to <strong>scaffold</strong> our <strong>SoftUniContext</strong> from the <strong>SoftUni</strong> <strong>database</strong>.</p>
<p>Next, we must <strong>execute</strong> the <strong>command</strong> to <strong>scaffold</strong> our <strong>context</strong> <strong>class</strong>. It will consist of 4 things:</p>
<ul>
<li>First, the name of the command:</li>
</ul>
<table>
<tbody>
<tr>
<td width="168">
<p>Scaffold-DbContext</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Second, the connection we will be using (our connection string):</li>
</ul>
<table>
<tbody>
<tr>
<td width="558">
<p>-Connection "Server=&lt;ServerName&gt;;Database=&lt;DatabaseName&gt;;Integrated Security=True;"</p>
</td>
</tr>
</tbody>
</table>
<p>For <strong>ServerName</strong>, use the name of your local MS SQL Server instance or ".".</p>
<p>For <strong>DatabaseName</strong>, use the name of the database you want to use, in this case &ndash; <strong>SoftUni</strong>.</p>
<ul>
<li>Third, we need to declare our service provider, we&rsquo;ll be using <strong>EntityFrameworkCore.SqlServer</strong>:</li>
</ul>
<table>
<tbody>
<tr>
<td width="418">
<p>-Provider Microsoft.EntityFrameworkCore.SqlServer</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>And the fourth thing we&rsquo;ll do, is to give it a directory where all of our models will go (e.g. <strong>Models</strong>):</li>
</ul>
<table>
<tbody>
<tr>
<td width="192">
<p>-OutputDir Data/Models</p>
</td>
</tr>
</tbody>
</table>
<p>Our final command will look like this:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>Scaffold-DbContext -Connection "Server=.;Database=SoftUni;Integrated Security=True;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models</p>
</td>
</tr>
</tbody>
</table>
<p>Execute the <strong>whole command</strong> on a <strong>single line</strong></p>
<p>Entity Framework Core has successfully <strong>mapped the database schema to C# classes</strong>. However, it isn't good enough with names &ndash; all classes have been pluralized. Use the <strong>Solution Explorer</strong> in Visual Studio to move the <strong>SoftUniContext</strong> class out of <strong>Models </strong>into the<strong> Data </strong>folder and rename all of our classes properly. Use <strong>right click </strong><strong>&rarr; Rename</strong> or the <strong>F2</strong> shortcut and press <strong>OK</strong> on this <strong>pop</strong> <strong>up</strong> <strong>window </strong>after each class:</p>
<p>This way Visual Studio will also <strong>rename</strong> the <strong>classes</strong> <strong>everywhere</strong> they&rsquo;re used.</p>
<p>The final result should look like this:</p>
<p>Don&rsquo;t forget to fix the <strong>SoftUniContext&rsquo;s</strong> namespace after moving it and add a reference to the <strong>Models</strong> namespace:</p>
<p><strong>Make</strong> <strong>sure</strong> that your namespaces are <strong>exactly</strong> the same as these:</p>
<table>
<tbody>
<tr>
<td width="256">
<p>P02_DatabaseFirst</p>
<p>P02_DatabaseFirst.Data</p>
<p>P02_DatabaseFirst.Data.Models</p>
</td>
</tr>
</tbody>
</table>
<p>To be able to test our models, we need to add this <strong>constructor</strong> to our <strong>SoftUniContext</strong> class:</p>
<table>
<tbody>
<tr>
<td width="350">
<p>public SoftUniContext(DbContextOptions options)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :base(options) { }</p>
</td>
</tr>
</tbody>
</table>
<p>Finally, we want to clean up the packages we won&rsquo;t be using anymore from the package manager GUI or by running these commands:</p>
<table>
<tbody>
<tr>
<td width="710">
<p>Uninstall-Package Microsoft.EntityFrameworkCore.Tools -RemoveDependencies</p>
<p>Uninstall-Package Microsoft.EntityFrameworkCore.SqlServer.Design -RemoveDependencies</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Employees Full Information</h2>
<p>Now we can use the <strong>SoftUniContext</strong> to extract data from our database. Your first task is to extract <strong>all employees </strong>and print their <strong>first</strong>, <strong>last</strong> and <strong>middle</strong> name, their <strong>job</strong> <strong>title</strong> and <strong>salary</strong>, rounded to <strong>2</strong> <strong>symbols</strong> after the decimal separator, all of those separated with a space. Order them by <strong>employee</strong> <strong>id</strong>.</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Guy Gilbert R Production Technician 12500.00</p>
</td>
</tr>
<tr>
<td width="540">
<p>Kevin Brown F Marketing Assistant 13500.00</p>
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
<p>Your task is to extract <strong>all employees</strong> with <strong>salary</strong> over <strong>50000</strong>. Return <strong>only the</strong> <strong>first names </strong>of those employees, ordered <strong>alphabetically</strong>.</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Brian</p>
</td>
</tr>
<tr>
<td width="540">
<p>Dylan</p>
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
<p>Use <strong>Express</strong> <strong>Profiler</strong> and check if the query Entity Framework Core sent is correct (there is only one query, but there may be more that are performed by EF for checks).</p>
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
<p>Create a new address with <strong>text</strong> "<strong>Vitoshka 15</strong>" and <strong>TownId</strong> <strong>4</strong>. Set that address to the employee with last name "<strong>Nakov</strong>".</p>
<p>Then order by <strong>descending</strong> all the employees by their <strong>Address&rsquo;</strong> <strong>Id</strong>, take <strong>10</strong> rows and from them, take the <strong>AddressText</strong>. Print the results each on a new line:</p>
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
<p>After this <strong>restore</strong> your <strong>database</strong> for the tasks ahead!</p>
<h3>Hints</h3>
<p>Create the address and find the employee with last name equal to "Nakov" in order to assign the address to him.</p>
<h2>7.&nbsp;&nbsp; Employees and Projects</h2>
<p>Find the first <strong>30</strong> employees who have <strong>projects</strong> started in the period <strong>2001 - 2003 </strong>(inclusive). Print each employee's <strong>first name</strong>, <strong>last name, manager&rsquo;s first name </strong>and<strong> last name</strong><strong>. </strong>Then print <strong>all</strong> of their <strong>projects</strong> in the format "--&lt;<strong>ProjectName</strong>&gt; - &lt;<strong>StartDate</strong>&gt; - &lt;<strong>EndDate</strong>&gt;", each on a <strong>new</strong> <strong>row</strong>. If a project has no end date, print "<strong>not finished</strong>" instead.</p>
<p>Here is the format:</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>Guy Gilbert &ndash; Manager: Jo</p>
</td>
</tr>
<tr>
<td width="624">
<p>--Half-Finger Gloves - 6/1/2002 12:00:00 AM - 6/1/2003 12:00:00 AM</p>
</td>
</tr>
<tr>
<td width="624">
<p>--Racing Socks - 11/22/2005 12:00:00 AM - not finished</p>
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
<p>Use date format: "M/d/yyyy h:mm:ss tt".</p>
<h2>8.&nbsp;&nbsp; Addresses by Town</h2>
<p>Find all addresses, <strong>ordered</strong> by the <strong>number of employees</strong> who live there (<strong>descending</strong>), then by <strong>town name</strong> (<strong>ascending</strong>), and finally by <strong>address</strong> <strong>text</strong> (<strong>ascending</strong>). Take only the <strong>first 10 addresses</strong>. For each address print it in the format "&lt;<strong>AddressText</strong>&gt;, &lt;<strong>TownName</strong>&gt; - &lt;<strong>EmployeeCount</strong>&gt; employees":</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p>Output</p>
</td>
</tr>
<tr>
<td width="624">
<p>163 Nishava Str, ent A, apt. 1, Sofia - 3 employees</p>
</td>
</tr>
<tr>
<td width="624">
<p>7726 Driftwood Drive, Monroe - 2 employees</p>
</td>
</tr>
<tr>
<td width="624">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Employee 147</h2>
<p>Get the <strong>employee with id 147.</strong> Print only his/her <strong>first name</strong>, <strong>last name</strong>, <strong>job title</strong> and <strong>projects</strong> (print only their names). The projects should be <strong>ordered</strong> <strong>by</strong> <strong>name</strong> (<strong>ascending</strong>). Format of the output:</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Linda Randall - Production Technician</p>
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
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Departments with More Than 5 Employees</h2>
<p>Find <strong>all departments</strong> with more than <strong>5</strong><strong> employees</strong>. Order them by <strong>employee count</strong> (<strong>ascending</strong>), then by <strong>department</strong> <strong>name</strong> (<strong>alphabetically</strong>). <br /> For each department, print the <strong>department name</strong> and the <strong>manager&rsquo;s first </strong>and<strong> last name </strong>on the<strong> first row</strong>. Then print the <strong>first</strong> <strong>name</strong>, the <strong>last</strong> <strong>name</strong> and the <strong>job</strong> <strong>title</strong> of every <strong>employee</strong> on a new row. Then, print <strong>10 dashes</strong> before the next department ("<strong>----------</strong>"). <br /> Order the employees by <strong>first</strong> <strong>name</strong> (<strong>ascending</strong>), then by <strong>last</strong> <strong>name</strong> (<strong>ascending</strong>). Format of the output:</p>
<table width="540">
<tbody>
<tr>
<td width="540">
<p>Output</p>
</td>
</tr>
<tr>
<td width="540">
<p>Engineering &ndash; Terri Duffy</p>
</td>
</tr>
<tr>
<td width="540">
<p>Gail Erickson - Design Engineer</p>
</td>
</tr>
<tr>
<td width="540">
<p>Jossef Goldberg - Design Engineer</p>
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
<p>Write a program that prints information about the <strong>last 10 started projects</strong>.<strong> Sort</strong> <strong>them by name </strong>lexicographically and print <strong>their name, description and start date</strong>, each on a new row. Format of the output:</p>
<table width="678">
<tbody>
<tr>
<td width="678">
<p>Output</p>
</td>
</tr>
<tr>
<td width="678">
<p>All-Purpose Bike Stand</p>
<p>Research, design and development of All-Purpose Bike Stand. Perfect all-purpose bike stand for working on your bike at home. Quick-adjusting clamps and steel construction.</p>
<p>9/1/2005 12:00:00 AM</p>
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
<p>Use date format: "M/d/yyyy h:mm:ss tt".</p>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Increase Salaries</h2>
<p>Write a program that increase salaries of all employees that are in the <strong>Engineering</strong>, <strong>Tool Design</strong>, <strong>Marketing</strong> or <strong>Information Services</strong> department by <strong>12%</strong>. Then <strong>print first name, last name and salary </strong>(2 symbols after the decimal separator) for those employees whose salary was increased. Order them by <strong>first</strong> <strong>name</strong> (<strong>ascending</strong>), then by <strong>last</strong> <strong>name</strong> (<strong>ascending</strong>). Format of the output:</p>
<table width="534">
<tbody>
<tr>
<td width="534">
<p>Output</p>
</td>
</tr>
<tr>
<td width="534">
<p>Ashvini Sharma ($36400.00)</p>
</td>
</tr>
<tr>
<td width="534">
<p>Dan Bacon ($30688.00)</p>
</td>
</tr>
<tr>
<td width="534">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Employees by First Name Starting With "Sa"</h2>
<p>Write a program that finds all employees whose first name starts with "<strong>Sa</strong>". Print their <strong>first</strong>, <strong>last</strong> <strong>name</strong>, their <strong>job</strong> <strong>title</strong> and <strong>salary</strong> in the format given in the example below. Order them by <strong>first</strong> <strong>name</strong>, then by <strong>last</strong> <strong>name</strong> (<strong>ascending</strong>).</p>
<p>*Note: You have to solve <strong>previous</strong> task in order to display proper results.</p>
<table width="534">
<tbody>
<tr>
<td width="534">
<p>Output</p>
</td>
</tr>
<tr>
<td width="534">
<p>Sairaj Uddin - Scheduling Assistant - ($16000.00)</p>
</td>
</tr>
<tr>
<td width="534">
<p>Samantha Smith - Production Technician - ($14000.00)</p>
</td>
</tr>
<tr>
<td width="534">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Delete Project by Id</h2>
<p>Let's <strong>delete</strong> the project with id <strong>2</strong>. Then, take 10 projects and print their names on the console, each on a new line. Remember to restore your database after this task.</p>
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
<p>This is done by removing the project from all employees who reference it.</p>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Remove Towns</h2>
<p>Write a program that <strong>deletes a </strong><strong>town </strong>by its name, given as an input. Also, <strong>delete all addresses</strong> that are in those towns. Print on the console the <strong>number</strong> of <strong>addresses</strong> that were <strong>deleted</strong>. There will be <strong>employees</strong> living at those addresses, which will be a problem when trying to delete the addresses. So, start by setting the AddressID of each employee for the given address to <strong>null</strong>. After all of them are set to null, you may safely remove all the addresses from the context.Addresses and finally remove the <strong>given</strong> <strong>town</strong>. You should test this task <strong>locally</strong>, so you can see what happens for more than 1 case of deletion.</p>
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
<p>&nbsp;</p>