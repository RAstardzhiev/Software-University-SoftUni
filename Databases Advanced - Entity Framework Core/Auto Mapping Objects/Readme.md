<h1>Exercises: C# Auto Mapping Objects</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Employees Mapping</h2>
<p>Create a simple database with one table &ndash; Employees. Each employee should have properties: <strong>first name</strong>, <strong>last name</strong>, <strong>salary</strong>, <strong>birthday</strong> and <strong>address</strong>. Only <strong>first</strong> <strong>name</strong>, <strong>last</strong> <strong>name</strong> and <strong>salary</strong> are <strong>required</strong>.</p>
<p>Create <strong>EmployeeDto</strong> class that will keep synthesized information about instances of Employee class (only <strong>id</strong>, <strong>first name</strong>, <strong>last name</strong> and <strong>salary</strong>).</p>
<p>Create a console app for your database, which uses the <strong>Automapper</strong> package and the <strong>EmployeeDto</strong> class to <strong>transfer</strong> <strong>data</strong> from and back to the database. You should have the following commands:</p>
<ul>
<li><strong>AddEmployee</strong> &lt;<strong>firstName</strong>&gt; &lt;<strong>lastName</strong>&gt; &lt;<strong>salary</strong>&gt; &ndash; adds a new Employee to the database</li>
<li><strong>SetBirthday &lt;employeeId&gt; &lt;date:</strong> "dd-MM-yyyy"<strong>&gt; </strong>&ndash; sets the birthday of the employee to the given date</li>
<li><strong>SetAddress</strong> &lt;<strong>employeeId</strong>&gt; &lt;<strong>address</strong>&gt; &ndash; sets the address of the employee to the given string</li>
<li><strong>EmployeeInfo</strong> &lt;<strong>employeeId</strong>&gt; &ndash; prints on the console the information for an employee in the format "ID: {employeeId} - {firstName} {lastName} - ${salary:f2}"</li>
<li><strong>EmployeePersonalInfo &lt;employeeId&gt; </strong>&ndash; prints all the information for an employee in the following format:</li>
</ul>
<table width="272">
<tbody>
<tr>
<td width="272">
<p>ID: 1 - Pesho Ivanov - $1000:00</p>
<p>Birthday: 15-04-1976</p>
<p>Address: Sofia, ul. Vitosha 15</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Exit</strong> &ndash; closes the application</li>
</ul>
<h4>Bonus</h4>
<p>Only use <strong>DTOs</strong> in your application. Use a <strong>service</strong> to connect to the <strong>database</strong>.</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Manager Mapping</h2>
<p>Add to the <strong>Employee</strong> model information about their <strong>manager</strong> and a list of <strong>employees</strong> that they <strong>manage</strong>. It is <strong>possible</strong> for an employee to have <strong>no</strong> <strong>manager</strong>. Create another data transfer object, which treats employees as managers:</p>
<ul>
<li><strong>ManagerDto</strong> &ndash; first name, last name, list of EmployeeDtos that he/she is in charge of and their count</li>
</ul>
<p>Add the following commands to your console application:</p>
<ul>
<li><strong>SetManager</strong> &lt;<strong>employeeId</strong>&gt; &lt;<strong>managerId</strong>&gt; &ndash; sets the second employee to be a manager of the first employee</li>
<li><strong>ManagerInfo</strong> &lt;<strong>employeeId</strong>&gt; &ndash; prints on the console information about a manager in the following format:</li>
</ul>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="262">
<p><strong>Sample output</strong></p>
</td>
</tr>
<tr>
<td width="262">
<p>Steve Jobbsen | Employees: 2</p>
<p>&nbsp;&nbsp;&nbsp; - Stephen Bjorn - $4300.00</p>
<p>&nbsp;&nbsp;&nbsp; - Kirilyc Lefi - $4400.00</p>
</td>
</tr>
<tr>
<td width="262">
<p>Carl Kormac | Employees: 14</p>
<p>&nbsp;&nbsp;&nbsp; - Jurgen Straus - $1000.45</p>
<p>&nbsp;&nbsp;&nbsp; - Moni Kozinac - $2030.99</p>
<p>&nbsp;&nbsp;&nbsp; - Kopp Spidok - $2000.21</p>
<p>&nbsp;&nbsp;&nbsp; - &hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Projection</h2>
<p>Add a few employees to your database with their birthdays. Create a command "<strong>ListEmployeesOlderThan</strong> &lt;<strong>age</strong>&gt;" which lists all employees older than given age and their managers. Order them <strong>by salary descending. </strong>Add the necessary DTOs and commands to your application.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="410">
<p><strong>Sample output</strong></p>
</td>
</tr>
<tr>
<td width="410">
<p>Steve Jobbsen - $6000.20 - Manager: [no manager]</p>
<p>Kirilyc Lefi - $4400.00 - Manager: Jobbsen</p>
<p>Stephen Bjorn - $4300.00 - Manager: Jobbsen</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>