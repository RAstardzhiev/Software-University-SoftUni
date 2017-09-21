<h1>Exercises: Basic CRUD</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">"Databases Basics - MSSQL" course @ Software University.</a></p>
<h2>1.&nbsp;&nbsp; Examine the Databases</h2>
<p>Download and get familiar with the <strong>SoftUni</strong>, <strong>Diablo</strong> and <strong>Geography </strong>database schemas and tables. You will use them in this and the following exercises to write queries.</p>
<h1>Part I &ndash; Queries for SoftUni Database</h1>
<h2>2.&nbsp;&nbsp; Find All Information About Departments</h2>
<p>Write a SQL query to find <strong>all available information about the Departments. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepartmentID</strong></p>
</td>
<td width="95">
<p><strong>Name</strong></p>
</td>
<td width="85">
<p><strong>ManagerID</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>1</p>
</td>
<td width="95">
<p>Engineering</p>
</td>
<td width="85">
<p>12</p>
</td>
</tr>
<tr>
<td width="104">
<p>2</p>
</td>
<td width="95">
<p>Tool Design</p>
</td>
<td width="85">
<p>4</p>
</td>
</tr>
<tr>
<td width="104">
<p>3</p>
</td>
<td width="95">
<p>Sales</p>
</td>
<td width="85">
<p>273</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Find all Department Names</h2>
<p>Write SQL query to find <strong>all Department names</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>Name</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Engineering</p>
</td>
</tr>
<tr>
<td width="95">
<p>Tool Design</p>
</td>
</tr>
<tr>
<td width="95">
<p>Sales</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Find Salary of Each Employee</h2>
<p>Write SQL query to find the <strong>first name</strong>, <strong>last name</strong> and <strong>salary</strong> of each employee. Submit your query statements as Prepare DB &amp; run queries.</p>
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
<td width="76">
<p><strong>Salary</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Guy</p>
</td>
<td width="85">
<p>Gilbert</p>
</td>
<td width="76">
<p>12500.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>Kevin</p>
</td>
<td width="85">
<p>Brown</p>
</td>
<td width="76">
<p>13500.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>Roberto</p>
</td>
<td width="85">
<p>Tamburello</p>
</td>
<td width="76">
<p>43300.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Find Full Name of Each Employee</h2>
<p>Write SQL query to find the <strong>first</strong>, <strong>middle</strong> and <strong>last name</strong> of each employee. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="94">
<p><strong>MiddleName</strong></p>
</td>
<td width="132">
<p><strong>LastName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Guy</p>
</td>
<td width="94">
<p>R</p>
</td>
<td width="132">
<p>Gilbert</p>
</td>
</tr>
<tr>
<td width="95">
<p>Kevin</p>
</td>
<td width="94">
<p>F</p>
</td>
<td width="132">
<p>Brown</p>
</td>
</tr>
<tr>
<td width="95">
<p>Roberto</p>
</td>
<td width="94">
<p>NULL</p>
</td>
<td width="132">
<p>Tamburello</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="94">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Find Email Address of Each Employee</h2>
<p>Write a SQL query to find the <strong>email address</strong> of each employee. (by his <strong>first and last name</strong>). Consider that the email domain is <strong>softuni.bg</strong>. Emails should look like &ldquo;John.Doe@softuni.bg". The <strong>produced column</strong> should be named <strong>"Full Email Address"</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="217">
<p><strong>Full Email Address</strong></p>
</td>
</tr>
<tr>
<td width="217">
<p>Guy.Gilbert@softuni.bg</p>
</td>
</tr>
<tr>
<td width="217">
<p>Kevin.Brown@softuni.bg</p>
</td>
</tr>
<tr>
<td width="217">
<p>Roberto.Tamburello@softuni.bg</p>
</td>
</tr>
<tr>
<td width="217">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Find All Different Employee&rsquo;s Salaries</h2>
<p>Write a SQL query to find <strong>all different employee&rsquo;s salaries</strong>. Show only the salaries. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="76">
<p><strong>Salary</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>9000.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>9300.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>9500.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Find all Information About Employees</h2>
<p>Write a SQL query to find <strong>all information</strong> about the employees whose <strong>job title</strong> is <strong>&ldquo;Sales Representative&rdquo;. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table width="662">
<tbody>
<tr>
<td width="38">
<p><strong>ID</strong></p>
</td>
<td width="66">
<p><strong>First</strong></p>
<p><strong>Name</strong></p>
</td>
<td width="66">
<p><strong>Last</strong></p>
<p><strong>Name</strong></p>
</td>
<td width="66">
<p><strong>Middle</strong></p>
<p><strong>Name</strong></p>
</td>
<td width="113">
<p><strong>Job Title</strong></p>
</td>
<td width="47">
<p><strong>DeptID</strong></p>
</td>
<td width="57">
<p><strong>Mngr</strong></p>
<p><strong>ID</strong></p>
</td>
<td width="47">
<p><strong>HireDate</strong></p>
</td>
<td width="76">
<p><strong>Salary</strong></p>
</td>
<td width="85">
<p><strong>AddressID</strong></p>
</td>
</tr>
<tr>
<td width="38">
<p>275</p>
</td>
<td width="66">
<p>Michael</p>
</td>
<td width="66">
<p>Blythe</p>
</td>
<td width="66">
<p>G</p>
</td>
<td width="113">
<p>Sales Representative</p>
</td>
<td width="47">
<p>3</p>
</td>
<td width="57">
<p>268</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="76">
<p>23100.00</p>
</td>
<td width="85">
<p>60</p>
</td>
</tr>
<tr>
<td width="38">
<p>276</p>
</td>
<td width="66">
<p>Linda</p>
</td>
<td width="66">
<p>Mitchell</p>
</td>
<td width="66">
<p>C</p>
</td>
<td width="113">
<p>Sales Representative</p>
</td>
<td width="47">
<p>3</p>
</td>
<td width="57">
<p>268</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="76">
<p>23100.00</p>
</td>
<td width="85">
<p>170</p>
</td>
</tr>
<tr>
<td width="38">
<p>277</p>
</td>
<td width="66">
<p>Jillian</p>
</td>
<td width="66">
<p>Carson</p>
</td>
<td width="66">
<p>NULL</p>
</td>
<td width="113">
<p>Sales Representative</p>
</td>
<td width="47">
<p>3</p>
</td>
<td width="57">
<p>268</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="76">
<p>23100.00</p>
</td>
<td width="85">
<p>61</p>
</td>
</tr>
<tr>
<td width="38">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="57">
<p>&hellip;</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Find Names of All Employees by Salary in Range</h2>
<p>Write a SQL query to find the <strong>first name</strong>, <strong>last name</strong> and <strong>job title</strong> of all employees whose <strong>salary is in the</strong> <strong>range [20000, 30000]. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
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
<td width="151">
<p><strong>JobTitle</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Rob</p>
</td>
<td width="76">
<p>Walters</p>
</td>
<td width="151">
<p>Senior Tool Designer</p>
</td>
</tr>
<tr>
<td width="85">
<p>Thierry</p>
</td>
<td width="76">
<p>D'Hers</p>
</td>
<td width="151">
<p>Tool Designer</p>
</td>
</tr>
<tr>
<td width="85">
<p>JoLynn</p>
</td>
<td width="76">
<p>Dobney</p>
</td>
<td width="151">
<p>Production Supervisor</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find Names of All Employees</h2>
<p>Write a SQL query to find the <strong>full name</strong> of all employees whose <strong>salary</strong> is <strong>25000, 14000, 12500 or 23600</strong>. Full Name is combination of <strong>first</strong>, <strong>middle</strong> and <strong>last</strong> name (separated with <strong>single space</strong>) and they should be <strong>in one column</strong> called <strong>&ldquo;Full Name&rdquo;. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
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
<p>Guy R Gilbert</p>
</td>
</tr>
<tr>
<td width="132">
<p>Thierry B D'Hers</p>
</td>
</tr>
<tr>
<td width="132">
<p>JoLynn M Dobney</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find All Employees Without Manager</h2>
<p>Write a SQL query to find <strong>first and last names</strong> about those employees that <strong>does not have a manager</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
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
<p>Ken</p>
</td>
<td width="76">
<p>Sanchez</p>
</td>
</tr>
<tr>
<td width="85">
<p>Svetlin</p>
</td>
<td width="76">
<p>Nakov</p>
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
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find All Employees with Salary More Than 50000</h2>
<p>Write a SQL query to find <strong>first name</strong>, <strong>last name</strong> and <strong>salary</strong> of those employees who has salary more than 50000. Order them in decreasing order by salary. Submit your query statements as Prepare DB &amp; run queries.</p>
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
<td width="85">
<p><strong>Salary</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Ken</p>
</td>
<td width="76">
<p>Sanchez</p>
</td>
<td width="85">
<p>125500.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>James</p>
</td>
<td width="76">
<p>Hamilton</p>
</td>
<td width="85">
<p>84100.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Find 5 Best Paid Employees.</h2>
<p>Write SQL query to find <strong>first and last names </strong>about <strong>5 best paid Employees</strong> ordered <strong>descending by their salary. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
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
<p>Ken</p>
</td>
<td width="76">
<p>Sanchez</p>
</td>
</tr>
<tr>
<td width="85">
<p>James</p>
</td>
<td width="76">
<p>Hamilton</p>
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
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find All Employees Except Marketing</h2>
<p>Write a SQL query to find the <strong>first </strong>and<strong> last names</strong> of all employees whose <strong>department ID is different from 4. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
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
<p>Guy</p>
</td>
<td width="85">
<p>Gilbert</p>
</td>
</tr>
<tr>
<td width="85">
<p>Roberto</p>
</td>
<td width="85">
<p>Tamburello</p>
</td>
</tr>
<tr>
<td width="85">
<p>Rob</p>
</td>
<td width="85">
<p>Walters</p>
</td>
</tr>
</tbody>
</table>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sort Employees Table</h2>
<p>Write a SQL query to sort all records in the Employees table by the following criteria:</p>
<ul>
<li>First by <strong>salary</strong> in <strong>decreasing</strong> order</li>
<li>Then by <strong>first name</strong> <strong>alphabetically</strong></li>
<li>Then by <strong>last name descending</strong></li>
<li>Then by <strong>middle name alphabetically</strong></li>
</ul>
<p>Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table width="671">
<tbody>
<tr>
<td width="38">
<p><strong>ID</strong></p>
</td>
<td width="66">
<p><strong>First</strong></p>
<p><strong>Name</strong></p>
</td>
<td width="76">
<p><strong>Last</strong></p>
<p><strong>Name</strong></p>
</td>
<td width="66">
<p><strong>Middle</strong></p>
<p><strong>Name</strong></p>
</td>
<td width="113">
<p><strong>Job Title</strong></p>
</td>
<td width="47">
<p><strong>DeptID</strong></p>
</td>
<td width="47">
<p><strong>Mngr</strong></p>
<p><strong>ID</strong></p>
</td>
<td width="47">
<p><strong>HireDate</strong></p>
</td>
<td width="85">
<p><strong>Salary</strong></p>
</td>
<td width="85">
<p><strong>AddressID</strong></p>
</td>
</tr>
<tr>
<td width="38">
<p>109</p>
</td>
<td width="66">
<p>Ken</p>
</td>
<td width="76">
<p>Sanchez</p>
</td>
<td width="66">
<p>J</p>
</td>
<td width="113">
<p>Chief Executive Officer</p>
</td>
<td width="47">
<p>16</p>
</td>
<td width="47">
<p>NULL</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="85">
<p>125500.00</p>
</td>
<td width="85">
<p>177</p>
</td>
</tr>
<tr>
<td width="38">
<p>148</p>
</td>
<td width="66">
<p>James</p>
</td>
<td width="76">
<p>Hamilton</p>
</td>
<td width="66">
<p>R</p>
</td>
<td width="113">
<p>Vice President of Production</p>
</td>
<td width="47">
<p>7</p>
</td>
<td width="47">
<p>109</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="85">
<p>84100.00</p>
</td>
<td width="85">
<p>158</p>
</td>
</tr>
<tr>
<td width="38">
<p>273</p>
</td>
<td width="66">
<p>Brian</p>
</td>
<td width="76">
<p>Welcker</p>
</td>
<td width="66">
<p>S</p>
</td>
<td width="113">
<p>Vice President of Sales</p>
</td>
<td width="47">
<p>3</p>
</td>
<td width="47">
<p>109</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="85">
<p>72100.00</p>
</td>
<td width="85">
<p>134</p>
</td>
</tr>
<tr>
<td width="38">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="47">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Create View Employees with Salaries</h2>
<p>Write a SQL query to create a view <strong>V_EmployeesSalaries</strong> with <strong>first name</strong>, <strong>last name</strong> and <strong>salary</strong> for each employee. Submit your query statements as Run skeleton, run queries &amp; check DB.</p>
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
<td width="76">
<p><strong>Salary</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>Guy</p>
</td>
<td width="76">
<p>Gilbert</p>
</td>
<td width="76">
<p>12500.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>Kevin</p>
</td>
<td width="76">
<p>Brown</p>
</td>
<td width="76">
<p>13500.00</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create View Employees with Job Titles</h2>
<p>Write a SQL query to create view <strong>V_EmployeeNameJobTitle </strong>with <strong>full employee name</strong> and <strong>job title</strong>. When middle name is <strong>NULL</strong> replace it with <strong>empty string (&lsquo;&rsquo;)</strong>. Submit your query statements as Run skeleton, run queries &amp; check DB.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>Full Name</strong></p>
</td>
<td width="151">
<p><strong>Job Title</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Guy R Gilbert</p>
</td>
<td width="151">
<p>Production Technician</p>
</td>
</tr>
<tr>
<td width="151">
<p>Kevin F Brown</p>
</td>
<td width="151">
<p>Marketing Assistant</p>
</td>
</tr>
<tr>
<td width="151">
<p>Roberto&nbsp; Tamburello</p>
</td>
<td width="151">
<p>Engineering Manager</p>
</td>
</tr>
<tr>
<td width="151">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Distinct Job Titles</h2>
<p>Write a SQL query to find <strong>all distinct job titles</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="180">
<p><strong>JobTitle</strong></p>
</td>
</tr>
<tr>
<td width="180">
<p>Accountant</p>
</td>
</tr>
<tr>
<td width="180">
<p>Accounts Manager</p>
</td>
</tr>
<tr>
<td width="180">
<p>Accounts Payable Specialist</p>
</td>
</tr>
<tr>
<td width="180">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find First 10 Started Projects</h2>
<p>Write a SQL query to find <strong>first 10 started projects</strong>. Select <strong>all information about them</strong> and <strong>sort</strong> them <strong>by start date</strong>, <strong>then by name</strong>. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="38">
<p><strong>ID</strong></p>
</td>
<td width="113">
<p><strong>Name</strong></p>
</td>
<td width="321">
<p><strong>Description</strong></p>
</td>
<td width="104">
<p><strong>StartDate</strong></p>
</td>
<td width="104">
<p><strong>EndDate</strong></p>
</td>
</tr>
<tr>
<td width="38">
<p>6</p>
</td>
<td width="113">
<p>HL Road Frame</p>
</td>
<td width="321">
<p>Research, design and development of HL Road &hellip;</p>
</td>
<td width="104">
<p>1998-05-02 00:00:00</p>
</td>
<td width="104">
<p>2003-06-01 00:00:00</p>
</td>
</tr>
<tr>
<td width="38">
<p>2</p>
</td>
<td width="113">
<p>Cycling Cap</p>
</td>
<td width="321">
<p>Research, design and development of C&hellip;</p>
</td>
<td width="104">
<p>2001-06-01 00:00:00</p>
</td>
<td width="104">
<p>2003-06-01 00:00:00</p>
</td>
</tr>
<tr>
<td width="38">
<p>5</p>
</td>
<td width="113">
<p>HL Mountain Frame</p>
</td>
<td width="321">
<p>Research, design and development of HL M&hellip;</p>
</td>
<td width="104">
<p>2001-06-01 00:00:00</p>
</td>
<td width="104">
<p>2003-06-01 00:00:00</p>
</td>
</tr>
<tr>
<td width="38">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
<td width="321">
<p>&hellip;</p>
</td>
<td width="104">
<p>&hellip;</p>
</td>
<td width="104">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Last 7 Hired Employees</h2>
<p>Write a SQL query to find <strong>last 7 hired employees</strong>. Select <strong>their first, last name and their hire date. </strong>Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>FirstName</strong></p>
</td>
<td width="85">
<p><strong>LastName</strong></p>
</td>
<td width="189">
<p><strong>HireDate</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Rachel</p>
</td>
<td width="85">
<p>Valdez</p>
</td>
<td width="189">
<p>2005-07-01 00:00:00</p>
</td>
</tr>
<tr>
<td width="113">
<p>Lynn</p>
</td>
<td width="85">
<p>Tsoflias</p>
</td>
<td width="189">
<p>2005-07-01 00:00:00</p>
</td>
</tr>
<tr>
<td width="113">
<p>Syed</p>
</td>
<td width="85">
<p>Abbas</p>
</td>
<td width="189">
<p>2005-04-15 00:00:00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="189">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>21.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Increase Salaries</h2>
<p>Write a SQL query to increase salaries of all employees that are in the <strong>Engineering</strong>, <strong>Tool Design</strong>, <strong>Marketing</strong> or <strong>Information Services</strong> department by <strong>12%</strong>. Then <strong>select Salaries column</strong> from the <strong>Employees</strong> table. After that exercise restore your database to revert those changes. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="76">
<p><strong>Salary</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>12500.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>15120.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>48496.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>33376.00</p>
</td>
</tr>
<tr>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h1>Part II &ndash; Queries for Geography Database</h1>
<h2>22.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;All Mountain Peaks</h2>
<p>Display all <strong>mountain peaks </strong>in alphabetical order. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="123">
<p><strong>PeakName</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>Aconcagua</p>
</td>
</tr>
<tr>
<td width="123">
<p>Banski Suhodol</p>
</td>
</tr>
<tr>
<td width="123">
<p>Batashki Snezhnik</p>
</td>
</tr>
<tr>
<td width="123">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>23.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Biggest Countries by Population</h2>
<p>Find the 30 biggest countries by population <strong>from Europe</strong>. Display the country name and population. Sort the results by population (from biggest to smallest), then by country alphabetically. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>CountryName</strong></p>
</td>
<td width="85">
<p><strong>Population</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Russia</p>
</td>
<td width="85">
<p>140702000</p>
</td>
</tr>
<tr>
<td width="104">
<p>Germany</p>
</td>
<td width="85">
<p>81802257</p>
</td>
</tr>
<tr>
<td width="104">
<p>France</p>
</td>
<td width="85">
<p>64768389</p>
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
<h2>24.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;*Countries and Currency (Euro / Not Euro)</h2>
<p>Find all countries along with information about their currency. Display the country code, country name and information about its currency: either "<strong>Euro</strong>" or "<strong>Not Euro</strong>". Sort the results by country name alphabetically. Submit your query statements as Prepare DB &amp; run queries.</p>
<p>*Hint: Use <strong>CASE</strong> &hellip; <strong>WHEN</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>CountryName</strong></p>
</td>
<td width="95">
<p><strong>CountryCode</strong></p>
</td>
<td width="95">
<p><strong>Currency</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Afghanistan</p>
</td>
<td width="95">
<p>AF</p>
</td>
<td width="95">
<p>Not Euro</p>
</td>
</tr>
<tr>
<td width="104">
<p>&Aring;land</p>
</td>
<td width="95">
<p>AX</p>
</td>
<td width="95">
<p>Euro</p>
</td>
</tr>
<tr>
<td width="104">
<p>Albania</p>
</td>
<td width="95">
<p>AL</p>
</td>
<td width="95">
<p>Not Euro</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h1>Part III &ndash; Queries for Diablo Database</h1>
<h2>25.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;All Diablo Characters</h2>
<p>Display all <strong>characters </strong>in alphabetical order. Submit for evaluation the result text comma separated with headers. Submit your query statements as Prepare DB &amp; run queries.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="123">
<p><strong>Name</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>Amazon</p>
</td>
</tr>
<tr>
<td width="123">
<p>Assassin</p>
</td>
</tr>
<tr>
<td width="123">
<p>Barbarian</p>
</td>
</tr>
<tr>
<td width="123">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>