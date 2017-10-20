<h1>Database Basics MS SQL Exam &ndash; 24 Apr 2017</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">&ldquo;Database Basics&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/543/">https://judge.softuni.bg/Contests/543/</a>.</p>
<p><strong>Database Fundamentals MSSQL &ndash; Washing Machine Service</strong></p>
<p><em>Your task is to implement Washing Machine Service database based on the specs given below. Database will include information about broken machines which will be distributed to mechanics through so called &ldquo;jobs&rdquo;. Each mechanic may have several jobs and for each job he/she can require some parts. To let the mechanic get whats needed he/she has to make order for a particular part also specifying how many of it will be needed (specifying quantity).</em></p>
<h1>Section 1. DDL (30 pts)</h1>
<p>You have been given the E/R Diagram of the washing machine service:</p>
<p>Crate a database called <strong>WMS</strong>. You need to create <strong>9 tables</strong>:</p>
<ul>
<li><strong>Clients</strong> &ndash; contains information about the customers that use the service</li>
<li><strong>Mechanics </strong>&ndash; contains information about employees</li>
<li><strong>Jobs </strong>&ndash; contains information about all machines that clients submitted for repairs</li>
<li><strong>Models </strong>&ndash; list of all washing machine models that the servie operates with</li>
<li><strong>Orders </strong>&ndash; contains information about orders for parts</li>
<li><strong>Parts </strong>&ndash; list of all parts the service operates with</li>
<li><strong>OrderParts </strong>&ndash; mapping table between Orders and Parts with additional Quantity field</li>
<li><strong>PartsNeeded </strong>&ndash; mapping table between Jobs and Parts with additional Quantity field</li>
<li><strong>Vendors </strong>&ndash; list of vendors that supply parts to the service</li>
</ul>
<p>Include the following fields in each table. Unless otherwise specified, <strong>all fields are required</strong>.</p>
<p><strong>Clients</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>ClientId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>FirstName</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>LastName</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Phone</p>
</td>
<td width="212">
<p>String containing 12 symbols</p>
</td>
<td>
<p>String length is <strong>exactly</strong> 12 chars long</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Mechanics</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>MechanicId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>FirstName</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>LastName</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Address</p>
</td>
<td width="212">
<p>String up to 255 symbols, ASCII</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Jobs</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>JobId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>ModelId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Models</p>
</td>
</tr>
<tr>
<td width="125">
<p>Status</p>
</td>
<td width="212">
<p>String up to 11 symbols, ASCII</p>
</td>
<td>
<p>Allowed values: 'Pending', 'In Progress' and 'Finished'; Default value is 'Pending'</p>
</td>
</tr>
<tr>
<td width="125">
<p>ClientId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Clients</p>
</td>
</tr>
<tr>
<td width="125">
<p>MechanicId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Mechanics; Can be NULL</p>
</td>
</tr>
<tr>
<td width="125">
<p>IssueDate</p>
</td>
<td width="212">
<p>Date</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>FinishDate</p>
</td>
<td width="212">
<p>Date</p>
</td>
<td>
<p>Can be NULL</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Models</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>ModelId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>Unique</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Orders</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>OrderId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>JobId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Jobs</p>
</td>
</tr>
<tr>
<td width="125">
<p>IssueDate</p>
</td>
<td width="212">
<p>Date</p>
</td>
<td>
<p>Can be NULL</p>
</td>
</tr>
<tr>
<td width="125">
<p>Delivered</p>
</td>
<td width="212">
<p>Boolean</p>
</td>
<td>
<p>Default value is False</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Parts</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>PartId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>SerialNumber</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>Unique</p>
</td>
</tr>
<tr>
<td width="125">
<p>Description</p>
</td>
<td width="212">
<p>String up to 255 symbols, ASCII</p>
</td>
<td>
<p>Can be NULL</p>
</td>
</tr>
<tr>
<td width="125">
<p>Price</p>
</td>
<td width="212">
<p>Monetary value up to 9999.99</p>
</td>
<td>
<p>Cannot be zero or negative</p>
</td>
</tr>
<tr>
<td width="125">
<p>VendorId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Vendors</p>
</td>
</tr>
<tr>
<td width="125">
<p>StockQty</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Cannot be negative; Default value is 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>OrderParts</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>OrderId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Orders;</p>
<p>Primary table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>PartId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Parts;</p>
<p>Primary table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Quantity</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Cannot be zero or negative; Default value is 1</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>PartsNeeded</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>JobId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Jobs;</p>
<p>Primary table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>PartId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Relationship with table Parts;</p>
<p>Primary table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Quantity</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Cannot be zero or negative; Default value is 1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Vendors</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>VendorId</p>
</td>
<td width="212">
<p>32-bit Integer</p>
</td>
<td>
<p>Primary table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="212">
<p>String up to 50 symbols, ASCII</p>
</td>
<td>
<p>Unique</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>1.&nbsp;&nbsp; Database design</h2>
<p>Submit all of your create statements to Judge. <strong>Do not include</strong> database creation statements.</p>
<p><strong><u>Look for hints in the details of your submission!</u></strong></p>
<h1>Section 2. DML (10 pts)</h1>
<p><strong><u>Before you start you have to import Data.sql. If you have created the structure correctly the data should be successfully inserted.</u></strong></p>
<p>In this section, you have to do some data manipulations:</p>
<h2>2.&nbsp;&nbsp; Insert</h2>
<p>Let&rsquo;s <strong>insert</strong> some sample data into the database. Write a query to add the following records into the corresponding tables. All Id&rsquo;s should be auto-generated. Replace names that relate to other tables with the appropriate ID (look them up manually, there is no need to perform table joins).</p>
<p><strong>Clients</strong></p>
<table width="695">
<tbody>
<tr>
<td width="189">
<p><strong>First Name</strong></p>
</td>
<td width="189">
<p><strong>Last Name</strong></p>
</td>
<td width="317">
<p><strong>Phone</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>Teri</p>
</td>
<td width="189">
<p>Ennaco</p>
</td>
<td width="317">
<p>570-889-5187</p>
</td>
</tr>
<tr>
<td width="189">
<p>Merlyn</p>
</td>
<td width="189">
<p>Lawler</p>
</td>
<td width="317">
<p>201-588-7810</p>
</td>
</tr>
<tr>
<td width="189">
<p>Georgene</p>
</td>
<td width="189">
<p>Montezuma</p>
</td>
<td width="317">
<p>925-615-5185</p>
</td>
</tr>
<tr>
<td width="189">
<p>Jettie</p>
</td>
<td width="189">
<p>Mconnell</p>
</td>
<td width="317">
<p>908-802-3564</p>
</td>
</tr>
<tr>
<td width="189">
<p>Lemuel</p>
</td>
<td width="189">
<p>Latzke</p>
</td>
<td width="317">
<p>631-748-6479</p>
</td>
</tr>
<tr>
<td width="189">
<p>Melodie</p>
</td>
<td width="189">
<p>Knipp</p>
</td>
<td width="317">
<p>805-690-1682</p>
</td>
</tr>
<tr>
<td width="189">
<p>Candida</p>
</td>
<td width="189">
<p>Corbley</p>
</td>
<td width="317">
<p>908-275-8357</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Parts</strong></p>
<table width="695">
<tbody>
<tr>
<td width="113">
<p><strong>Serial Number</strong></p>
</td>
<td width="189">
<p><strong>Description</strong></p>
</td>
<td width="113">
<p><strong>Price</strong></p>
</td>
<td width="280">
<p><strong>Vendor Name</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>WP8182119</p>
</td>
<td width="189">
<p>Door Boot Seal</p>
</td>
<td width="113">
<p>117.86</p>
</td>
<td width="280">
<p>Suzhou Precision Products</p>
</td>
</tr>
<tr>
<td width="113">
<p>W10780048</p>
</td>
<td width="189">
<p>Suspension Rod</p>
</td>
<td width="113">
<p>42.81</p>
</td>
<td width="280">
<p>Shenzhen Ltd.</p>
</td>
</tr>
<tr>
<td width="113">
<p>W10841140</p>
</td>
<td width="189">
<p>Silicone Adhesive</p>
</td>
<td width="113">
<p>6.77</p>
</td>
<td width="280">
<p>Fenghua Import Export</p>
</td>
</tr>
<tr>
<td width="113">
<p>WPY055980</p>
</td>
<td width="189">
<p>High Temperature Adhesive</p>
</td>
<td width="113">
<p>13.94</p>
</td>
<td width="280">
<p>Qingdao Technology</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h2>3.&nbsp;&nbsp; Update</h2>
<p>Assign all <strong>Pending</strong> jobs to the mechanic <strong>Ryan Harnos</strong> (look up his ID manually, there is no need to use table joins) and change their <strong>status</strong> to '<strong>In Progress</strong>'.</p>
<h2>4.&nbsp;&nbsp; Delete</h2>
<p>Cancel Order with ID 19 &ndash; delete the order from the database and all associated entries from the mapping table.</p>
<h1>Section 3. Querying (45 pts)</h1>
<p><strong><u>You need to start with a fresh dataset, so run the Data.sql script again. It includes a section that will delete all records and replace them with the starting set, so you don&rsquo;t need to drop your database.</u></strong></p>
<h2>5.&nbsp;&nbsp; Clients by Name</h2>
<p>Select all <strong>clients</strong> ordered by <strong>last name</strong> (ascending) then by <strong>client ID</strong> (ascending).</p>
<p>Required columns:</p>
<ul>
<li>First Name</li>
<li>Last Name</li>
<li>Phone</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>FirstName</strong></p>
</td>
<td width="113">
<p><strong>LastName</strong></p>
</td>
<td width="189">
<p><strong>Phone</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Tasia</p>
</td>
<td width="113">
<p>Andreason</p>
</td>
<td width="189">
<p>201-920-9002</p>
</td>
</tr>
<tr>
<td width="113">
<p>Thaddeus</p>
</td>
<td width="113">
<p>Ankeny</p>
</td>
<td width="189">
<p>916-920-3571</p>
</td>
</tr>
<tr>
<td width="113">
<p>Loren</p>
</td>
<td width="113">
<p>Asar</p>
</td>
<td width="189">
<p>570-648-3035</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
<td width="189">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>6.&nbsp;&nbsp; Job Status</h2>
<p>Find all active <strong>jobs</strong> (that aren&rsquo;t <strong>Finished</strong>) and display their <strong>status</strong> and <strong>issue date</strong>. Order by issue date and by job ID (both ascending).</p>
<p>Required columns:</p>
<ul>
<li>Status</li>
<li>Issue Date</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="189">
<p><strong>Status</strong></p>
</td>
<td width="265">
<p><strong>IssueDate</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>In Progress</p>
</td>
<td width="265">
<p>2017-04-06</p>
</td>
</tr>
<tr>
<td width="189">
<p>In Progress</p>
</td>
<td width="265">
<p>2017-04-10</p>
</td>
</tr>
<tr>
<td width="189">
<p>In Progress</p>
</td>
<td width="265">
<p>2017-04-12</p>
</td>
</tr>
<tr>
<td width="189">
<p>&hellip;</p>
</td>
<td width="265">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>7.&nbsp;&nbsp; Mechanic Assignments</h2>
<p>Select all <strong>mechanics</strong> with their <strong>jobs</strong>. Include job <strong>status</strong> and <strong>issue date</strong>. Order by mechanic Id, issue date, job Id (all ascending).</p>
<p>Required columns:</p>
<ul>
<li>Mechanic Full Name</li>
<li>Job Status</li>
<li>Job Issue Date</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>Mechanic</strong></p>
</td>
<td width="151">
<p><strong>Status</strong></p>
</td>
<td width="151">
<p><strong>IssueDate</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Joni Breland</p>
</td>
<td width="151">
<p>Finished</p>
</td>
<td width="151">
<p>2017-01-12</p>
</td>
</tr>
<tr>
<td width="151">
<p>Joni Breland</p>
</td>
<td width="151">
<p>Finished</p>
</td>
<td width="151">
<p>2017-01-17</p>
</td>
</tr>
<tr>
<td width="151">
<p>Joni Breland</p>
</td>
<td width="151">
<p>Finished</p>
</td>
<td width="151">
<p>2017-01-24</p>
</td>
</tr>
<tr>
<td width="151">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>8.&nbsp;&nbsp; Current Clients</h2>
<p>Select the names of all <strong>clients</strong> with active <strong>jobs</strong> (not <strong>Finished</strong>). Include the <strong>status</strong> of the job and <strong>how many days</strong> it&rsquo;s been since it was submitted. Assume the <strong>current date</strong> is 24 April 2017. Order results by time length (descending) and by client ID (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Client Full Name</li>
<li>Days going &ndash; how many days have passed since the issuing</li>
<li>Status</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="189">
<p><strong>Client</strong></p>
</td>
<td width="151">
<p><strong>Days going</strong></p>
</td>
<td width="151">
<p><strong>Status</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>Gertude Witten</p>
</td>
<td width="151">
<p>18</p>
</td>
<td width="151">
<p>In Progress</p>
</td>
</tr>
<tr>
<td width="189">
<p>Brittni Gillaspie</p>
</td>
<td width="151">
<p>14</p>
</td>
<td width="151">
<p>In Progress</p>
</td>
</tr>
<tr>
<td width="189">
<p>Levi Munis</p>
</td>
<td width="151">
<p>12</p>
</td>
<td width="151">
<p>In Progress</p>
</td>
</tr>
<tr>
<td width="189">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Mechanic Performance</h2>
<p>Select all <strong>mechanics</strong> and the <strong>average time</strong> they take to finish their assigned <strong>jobs</strong>. Calculate the average as an integer. Order results by mechanic ID (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Mechanic Full Name</li>
<li>Average Days &ndash; average number of days the machanic took to finish the job</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="227">
<p><strong>Mechanic</strong></p>
</td>
<td width="151">
<p><strong>Average Days</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>Joni Breland</p>
</td>
<td width="151">
<p>9</p>
</td>
</tr>
<tr>
<td width="227">
<p>Malcolm Tromblay</p>
</td>
<td width="151">
<p>10</p>
</td>
</tr>
<tr>
<td width="227">
<p>Ryan Harnos</p>
</td>
<td width="151">
<p>5</p>
</td>
</tr>
<tr>
<td width="227">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hard Earners</h2>
<p>Select the first 3 <strong>mechanics</strong> who have more than 1 active <strong>job</strong> (not <strong>Finished</strong>). Order them by number of jobs (descending) and by mechanic ID (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Mechanic Full Name</li>
<li>Number of Jobs</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="189">
<p><strong>Mechanic</strong></p>
</td>
<td width="151">
<p><strong>Jobs</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>Nickolas Juvera</p>
</td>
<td width="151">
<p>3</p>
</td>
</tr>
<tr>
<td width="189">
<p>Malcolm Tromblay</p>
</td>
<td width="151">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Available Mechanics</h2>
<p>Select all <strong>mechanics</strong> without active <strong>jobs</strong> (<strong>include mechanics which don&rsquo;t have any job assigned or all of their jobs are finished</strong>). Order by ID (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Mechanic Full Name</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="227">
<p><strong>Available</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>Joni Breland</p>
</td>
</tr>
<tr>
<td width="227">
<p>Ryan Harnos</p>
</td>
</tr>
<tr>
<td width="227">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parts Cost</h2>
<p>Display the <strong>total cost</strong> of all <strong>parts</strong> ordered during the last three weeks. Assume the <strong>current date</strong> is 24 April 2017.</p>
<p>Required columns:</p>
<ul>
<li>Parts Total Cost</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="227">
<p><strong>Parts Total</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>109.62</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Past Expenses</h2>
<p>Select all <strong>finished jobs</strong> and the total cost of all <strong>parts</strong> that were <strong>ordered</strong> for them. Sort by total cost of parts ordered (descending) and by job ID (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Job ID</li>
<li>Total Parts Cost</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>JobId</strong></p>
</td>
<td width="151">
<p><strong>Total</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>17</p>
</td>
<td width="151">
<p>173.60</p>
</td>
</tr>
<tr>
<td width="151">
<p>12</p>
</td>
<td width="151">
<p>140.50</p>
</td>
</tr>
<tr>
<td width="151">
<p>1</p>
</td>
<td width="151">
<p>91.86</p>
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
<p>&nbsp;</p>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Model Repair Time</h2>
<p>Select all <strong>models</strong> with the <strong>average time</strong> it took to service, out of all the times it was repaired. Calculate the average as an integer value. Order the results by average service time ascending.</p>
<p>Required columns:</p>
<ul>
<li>Model ID</li>
<li>Name</li>
<li>Average Service Time &ndash; average number of days it took to finish the job; <strong><u>note the word 'days' attached at the end!</u></strong></li>
</ul>
<p>Example:</p>
<table width="491">
<tbody>
<tr>
<td width="113">
<p><strong>ModelId</strong></p>
</td>
<td width="189">
<p><strong>Name</strong></p>
</td>
<td width="189">
<p><strong>Average Service Time</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>5</p>
</td>
<td width="189">
<p>Maelstrom L700</p>
</td>
<td width="189">
<p>6 days</p>
</td>
</tr>
<tr>
<td width="113">
<p>4</p>
</td>
<td width="189">
<p>LN 100F</p>
</td>
<td width="189">
<p>7 days</p>
</td>
</tr>
<tr>
<td width="113">
<p>1</p>
</td>
<td width="189">
<p>Maelstrom L300</p>
</td>
<td width="189">
<p>8 days</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="189">
<p>&hellip;</p>
</td>
<td width="189">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Faultiest Model</h2>
<p>Find the <strong>model</strong> that breaks the most (has the highest number of <strong>jobs</strong> associated with it). Include the cost of <strong>parts</strong> <strong>ordered</strong> for it. If there are more than one models that were serviced the same number of times, <strong>list them all</strong>.</p>
<p>Required columns:</p>
<ul>
<li>Name</li>
<li>Times Serviced &ndash; number of assiciated jobs</li>
<li>Parts Total &ndash; cost of all parts ordered for the jobs</li>
</ul>
<p>Example:</p>
<table width="491">
<tbody>
<tr>
<td width="189">
<p><strong>Model</strong></p>
</td>
<td width="151">
<p><strong>Times Serviced</strong></p>
</td>
<td width="151">
<p><strong>Parts Total</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>Neko GG</p>
</td>
<td width="151">
<p>14</p>
</td>
<td width="151">
<p>321.72</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Missing Parts</h2>
<p>List all <strong>parts</strong> that are <strong>needed</strong> for active <strong>jobs</strong> (not <strong>Finished</strong>) without sufficient quantity <strong>in stock</strong> and in pending <strong>orders</strong> (the sum of parts in stock and parts ordered is less than the required quantity). Order them by part ID (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Part ID</li>
<li>Description</li>
<li>Required &ndash; number of parts required for active jobs</li>
<li>In Stock &ndash; how many of the part are currently in stock</li>
<li>Ordered &ndash; how many of the parts are expected to be delivered (associated with order that is not Delivered)</li>
</ul>
<p>Example:</p>
<table width="643">
<tbody>
<tr>
<td width="113">
<p><strong>PartId</strong></p>
</td>
<td width="189">
<p><strong>Description</strong></p>
</td>
<td width="113">
<p><strong>Required</strong></p>
</td>
<td width="113">
<p><strong>In Stock</strong></p>
</td>
<td width="113">
<p><strong>Ordered</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>12</p>
</td>
<td width="189">
<p>Shock Dampener</p>
</td>
<td width="113">
<p>2</p>
</td>
<td width="113">
<p>1</p>
</td>
<td width="113">
<p>0</p>
</td>
</tr>
<tr>
<td width="113">
<p>14</p>
</td>
<td width="189">
<p>Door Handle</p>
</td>
<td width="113">
<p>1</p>
</td>
<td width="113">
<p>0</p>
</td>
<td width="113">
<p>0</p>
</td>
</tr>
<tr>
<td width="113">
<p>17</p>
</td>
<td width="189">
<p>Lid Switch Assembly</p>
</td>
<td width="113">
<p>1</p>
</td>
<td width="113">
<p>0</p>
</td>
<td width="113">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h1>Section 4. Programmability (15 pts)</h1>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cost of Order</h2>
<p>Create a <strong>user defined function</strong> (udf_GetCost) that receives a <strong>job&rsquo;s ID</strong> and returns the total <strong>cost</strong> of all <strong>parts</strong> that were <strong>ordered</strong> for it. Return 0 if there are <strong>no orders</strong>.</p>
<p>Parameters:</p>
<ul>
<li>JobId</li>
</ul>
<p>Example usage:</p>
<table width="234">
<tbody>
<tr>
<td colspan="2" width="234">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="234">
<p>SELECT dbo.udf_GetCost(1)</p>
</td>
</tr>
<tr>
<td width="66">
<p>Id</p>
</td>
<td width="168">
<p>Result</p>
</td>
</tr>
<tr>
<td width="66">
<p>1</p>
</td>
<td width="168">
<p>91.86</p>
</td>
</tr>
<tr>
<td width="66">
<p>3</p>
</td>
<td width="168">
<p>40.97</p>
</td>
</tr>
<tr>
<td width="66">
<p>&hellip;</p>
</td>
<td width="168">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Place Order</h2>
<p>Your task is to create a user defined procedure (<strong>usp_PlaceOrder</strong>) which accepts <strong>job ID</strong>, part <strong>serial number</strong> and &nbsp;&nbsp;<strong>quantity</strong> and creates an <strong>order</strong> with the specified <strong>parameters</strong>. If an order <strong>already exists</strong> for the given job <strong>that and the order is not issued</strong> (order&rsquo;s issue date is NULL), add the new product to it. If the part is already listed in the order, add the quantity to the existing one.</p>
<p>When a new order is created, set it&rsquo;s IssueDate to NULL.</p>
<p>Limitations:</p>
<ul>
<li>An order <strong>cannot</strong> be placed for a job that is <strong>Finished</strong>; error message ID 50011 "<strong>This job is not active!</strong>"</li>
<li>The quantity <strong>cannot</strong> be zero or negative; error message ID 50012 "<strong>Part quantity must be more than zero!</strong>"</li>
<li>The job with given ID <strong>must exist</strong> in the database; error message ID 50013 "<strong>Job not found!</strong>"</li>
<li>The part with given serial number <strong>must exist</strong> in the database ID 50014 "<strong>Part not found!</strong>"</li>
</ul>
<p>If any of the requirements aren&rsquo;t met, rollback any changes to the database you&rsquo;ve made and <strong>throw an</strong> <strong>exception</strong> with the <strong>appropriate message</strong> and <strong>state 1</strong>.</p>
<p>Parameters:</p>
<ul>
<li>JobId</li>
<li>Part Serial Number</li>
<li>Quantity</li>
</ul>
<p>Example usage:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>DECLARE @err_msg AS NVARCHAR(MAX);</p>
<p>BEGIN TRY</p>
<p>&nbsp; EXEC usp_PlaceOrder 1, 'ZeroQuantity', 0</p>
<p>END TRY</p>
<p>&nbsp;</p>
<p>BEGIN CATCH</p>
<p>&nbsp; SET @err_msg = ERROR_MESSAGE();</p>
<p>&nbsp; SELECT @err_msg</p>
<p>END CATCH</p>
</td>
</tr>
<tr>
<td width="696">
<p>Response</p>
</td>
</tr>
<tr>
<td width="696">
<p>Part quantity must be more than zero!</p>
</td>
</tr>
</tbody>
</table>
<h2>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Detect Delivery</h2>
<p>Create a <strong>trigger</strong> that detects when an order&rsquo;s <strong>delivery status is</strong> changed from False to True which adds the quantities of all ordered parts to their stock quantity value (Qty).</p>
<p>Example usage:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>UPDATE Orders</p>
<p>SET Delivered = 1</p>
<p>WHERE OrderId = 21</p>
</td>
</tr>
<tr>
<td width="696">
<p>Response</p>
</td>
</tr>
<tr>
<td width="696">
<p>(1 row(s) affected)</p>
</td>
</tr>
</tbody>
</table>
<h1>Section 5. Bonus (10 pts)</h1>
<h2>20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vendor Preference</h2>
<p>List all mechanics and their preference for each vendor as a percentage of parts&rsquo; quantities they ordered for their jobs. Express the percentage as an integer value. Order them by mechanic&rsquo;s full name (ascending), number of parts from each vendor (descending) and by vendor name (ascending).</p>
<p>Required columns:</p>
<ul>
<li>Mechanic Full Name</li>
<li>Vendor Name</li>
<li>Parts ordered from vendor</li>
<li>Preference for Vendor (percantage of parts out of all parts count ordered by the mechanic)</li>
</ul>
<p>Example:</p>
<table width="671">
<tbody>
<tr>
<td width="141">
<p><strong>Mechanic</strong></p>
</td>
<td width="227">
<p><strong>Vendor</strong></p>
</td>
<td width="151">
<p><strong>Parts</strong></p>
</td>
<td width="151">
<p><strong>Preference</strong></p>
</td>
</tr>
<tr>
<td width="141">
<p>Gary Nunlee</p>
</td>
<td width="227">
<p>Shenzhen Ltd.</p>
</td>
<td width="151">
<p>2</p>
</td>
<td width="151">
<p>100%</p>
</td>
</tr>
<tr>
<td width="141">
<p>Jess Chaffins</p>
</td>
<td width="227">
<p>Qingdao Technology</p>
</td>
<td width="151">
<p>4</p>
</td>
<td width="151">
<p>57%</p>
</td>
</tr>
<tr>
<td width="141">
<p>Jess Chaffins</p>
</td>
<td width="227">
<p>Suzhou Precision Products</p>
</td>
<td width="151">
<p>2</p>
</td>
<td width="151">
<p>28%</p>
</td>
</tr>
<tr>
<td width="141">
<p>Jess Chaffins</p>
</td>
<td width="227">
<p>Fenghua Import Export</p>
</td>
<td width="151">
<p>1</p>
</td>
<td width="151">
<p>14%</p>
</td>
</tr>
<tr>
<td width="141">
<p>&hellip;</p>
</td>
<td width="227">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>