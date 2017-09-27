<h1>Exercises: Joins, Subqueries, CTE and Indices</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016">"Databases Basics - MSSQL" course @ Software University.</a> For problems from 1 to 11 (inclusively) use "<strong>SoftUni</strong>" database and for the other problems &ndash; "<strong>Geography</strong>".</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee Address</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeId</li>
<li>JobTitle</li>
<li>AddressId</li>
<li>AddressText</li>
</ul>
<p>Return the first 5 rows sorted by AddressId in ascending order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="94">
<p><strong>EmployeeId</strong></p>
</td>
<td width="186">
<p><strong>JobTitle</strong></p>
</td>
<td width="76">
<p><strong>AddressId</strong></p>
</td>
<td width="132">
<p><strong>AddressText</strong></p>
</td>
</tr>
<tr>
<td width="94">
<p>142</p>
</td>
<td width="186">
<p>Production Technician</p>
</td>
<td width="76">
<p>1</p>
</td>
<td width="132">
<p>108 Lakeside Court</p>
</td>
</tr>
<tr>
<td width="94">
<p>30</p>
</td>
<td width="186">
<p>Human Resources Manager</p>
</td>
<td width="76">
<p>2</p>
</td>
<td width="132">
<p>1341 Prospect St</p>
</td>
</tr>
<tr>
<td width="94">
<p>&hellip;</p>
</td>
<td width="186">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Addresses with Towns</h2>
<p>Write a query that selects:</p>
<ul>
<li>FirstName</li>
<li>LastName</li>
<li>Town</li>
<li>AddressText</li>
</ul>
<p>Sorted by FirstName in ascending order then by LastName. Select first 50 employees.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>FirstName</strong></p>
</td>
<td width="82">
<p><strong>LastName</strong></p>
</td>
<td width="103">
<p><strong>Town</strong></p>
</td>
<td width="134">
<p><strong>AddressText</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>A.Scott</p>
</td>
<td width="82">
<p>Wright</p>
</td>
<td width="103">
<p>Newport Hills</p>
</td>
<td width="134">
<p>1400 Gate Drive</p>
</td>
</tr>
<tr>
<td width="84">
<p>Alan</p>
</td>
<td width="82">
<p>Brewer</p>
</td>
<td width="103">
<p>Kenmore</p>
</td>
<td width="134">
<p>8192 Seagull Court</p>
</td>
</tr>
<tr>
<td width="84">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="103">
<p>&hellip;</p>
</td>
<td width="134">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sales Employee</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>FirstName</li>
<li>LastName</li>
<li>DepartmentName</li>
</ul>
<p>Sorted by EmployeeID in ascending order. Select only employees from &ldquo;<strong>Sales</strong>&rdquo; department.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="82">
<p><strong>FirstName</strong></p>
</td>
<td width="103">
<p><strong>LastName</strong></p>
</td>
<td width="132">
<p><strong>DepartmentName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>268</p>
</td>
<td width="82">
<p>Stephen</p>
</td>
<td width="103">
<p>Jiang</p>
</td>
<td width="132">
<p>Sales</p>
</td>
</tr>
<tr>
<td width="95">
<p>273</p>
</td>
<td width="82">
<p>Brian</p>
</td>
<td width="103">
<p>Welcker</p>
</td>
<td width="132">
<p>Sales</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="103">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee Departments</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>FirstName</li>
<li>Salary</li>
<li>DepartmentName</li>
</ul>
<p>Filter only employees with salary higher than 15000. Return the first 5 rows sorted by DepartmentID in ascending order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="95">
<p><strong>Salary</strong></p>
</td>
<td width="151">
<p><strong>DepartmentName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>3&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="95">
<p>Roberto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="95">
<p>43300.00</p>
</td>
<td width="151">
<p>Engineering</p>
</td>
</tr>
<tr>
<td width="95">
<p>9</p>
</td>
<td width="95">
<p>Gail</p>
</td>
<td width="95">
<p>32700.00</p>
</td>
<td width="151">
<p>Engineering</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees Without Project</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>FirstName</li>
</ul>
<p>Filter only employees without a project. Return the first 3 rows sorted by EmployeeID in ascending order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>2</p>
</td>
<td width="95">
<p>Kevin</p>
</td>
</tr>
<tr>
<td width="95">
<p>6</p>
</td>
<td width="95">
<p>David</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees Hired After</h2>
<p>Write a query that selects:</p>
<ul>
<li>FirstName</li>
<li>LastName</li>
<li>HireDate</li>
<li>DeptName</li>
</ul>
<p>Filter only employees with hired after 1/1/1999 and are from either "Sales" or "Finance" departments. Sorted by HireDate (ascending).</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>FirstName</strong></p>
</td>
<td width="82">
<p><strong>LastName</strong></p>
</td>
<td width="146">
<p><strong>HireDate</strong></p>
</td>
<td width="92">
<p><strong>DeptName</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>Debora&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="82">
<p>Poe</p>
</td>
<td width="146">
<p>2001-01-19 00:00:00</p>
</td>
<td width="92">
<p>Finance</p>
</td>
</tr>
<tr>
<td width="101">
<p>Wendy</p>
</td>
<td width="82">
<p>Kahn</p>
</td>
<td width="146">
<p>2001-01-26 00:00:00</p>
</td>
<td width="92">
<p>Finance</p>
</td>
</tr>
<tr>
<td width="101">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="146">
<p>&hellip;</p>
</td>
<td width="92">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees with Project</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>FirstName</li>
<li>ProjectName</li>
</ul>
<p>Filter only employees with a project which has started after 13.08.2002 and it is still ongoing (no end date). Return the first 5 rows sorted by EmployeeID in ascending order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="124">
<p><strong>ProjectName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>1</p>
</td>
<td width="95">
<p>Guy</p>
</td>
<td width="124">
<p>Racing Socks</p>
</td>
</tr>
<tr>
<td width="95">
<p>1</p>
</td>
<td width="95">
<p>Guy</p>
</td>
<td width="124">
<p>Road Bottle Cage</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="124">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee 24</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>FirstName</li>
<li>ProjectName</li>
</ul>
<p>Filter all the projects of employee with Id 24. If the project has started after 2005 the return value should be NULL.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="95">
<p><strong>ProjectName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>24</p>
</td>
<td width="95">
<p>David</p>
</td>
<td width="95">
<p>NULL</p>
</td>
</tr>
<tr>
<td width="95">
<p>24</p>
</td>
<td width="95">
<p>David</p>
</td>
<td width="95">
<p>Road-650</p>
</td>
</tr>
<tr>
<td width="95">
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
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee Manager</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>FirstName</li>
<li>MangerID</li>
<li>ManagerName</li>
</ul>
<p>Filter all employees with a manager who has ID equals to 3 or 7. Return the all rows sorted by EmployeeID in ascending order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="95">
<p><strong>ManagerID</strong></p>
</td>
<td width="113">
<p><strong>ManagerName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>4</p>
</td>
<td width="95">
<p>Rob</p>
</td>
<td width="95">
<p>3</p>
</td>
<td width="113">
<p>Roberto</p>
</td>
</tr>
<tr>
<td width="95">
<p>37</p>
</td>
<td width="95">
<p>Simon</p>
</td>
<td width="95">
<p>7</p>
</td>
<td width="113">
<p>JoLynn</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10.&nbsp;&nbsp;&nbsp; Employee Summary</h2>
<p>Write a query that selects:</p>
<ul>
<li>EmployeeID</li>
<li>EmployeeName</li>
<li>ManagerName</li>
<li>DepartmentName</li>
</ul>
<p>Show first 50 employees with their managers and the departments which they are in (show the departments of the employees). Order by EmployeeID.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="118">
<p><strong>EmployeeName</strong></p>
</td>
<td width="113">
<p><strong>ManagerName</strong></p>
</td>
<td width="132">
<p><strong>DepartmentName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>1</p>
</td>
<td width="118">
<p>Guy Gilbert</p>
</td>
<td width="113">
<p>Jo Brown</p>
</td>
<td width="132">
<p>Production</p>
</td>
</tr>
<tr>
<td width="95">
<p>2</p>
</td>
<td width="118">
<p>Kevin Brown</p>
</td>
<td width="113">
<p>David Bradley</p>
</td>
<td width="132">
<p>Marketing</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="118">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11.&nbsp;&nbsp;&nbsp; Min Average Salary</h2>
<p>Write a query that return the value of the lowest average salary of all departments.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="133">
<p><strong>MinAverageSalary</strong></p>
</td>
</tr>
<tr>
<td width="133">
<p>10866.6666</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12.&nbsp;&nbsp;&nbsp; Highest Peaks in Bulgaria</h2>
<p>Write a query that selects:</p>
<ul>
<li>CountryCode</li>
<li>MountainRange</li>
<li>PeakName</li>
<li>Elevation</li>
</ul>
<p>Filter all peaks in Bulgaria with elevation over 2835. Return the all rows sorted by elevation in descending order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>CountryCode</strong></p>
</td>
<td width="123">
<p><strong>MountainRange</strong></p>
</td>
<td width="95">
<p><strong>PeakName</strong></p>
</td>
<td width="76">
<p><strong>Elevation</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>BG</p>
</td>
<td width="123">
<p>Rila</p>
</td>
<td width="95">
<p>Musala</p>
</td>
<td width="76">
<p>2925</p>
</td>
</tr>
<tr>
<td width="101">
<p>BG</p>
</td>
<td width="123">
<p>Pirin</p>
</td>
<td width="95">
<p>Vihren</p>
</td>
<td width="76">
<p>2914</p>
</td>
</tr>
<tr>
<td width="101">
<p>&hellip;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13.&nbsp;&nbsp;&nbsp; Count Mountain Ranges</h2>
<p>Write a query that selects:</p>
<ul>
<li>CountryCode</li>
<li>MountainRanges</li>
</ul>
<p>Filter the count of the mountain ranges in the United States, Russia and Bulgaria.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>CountryCode</strong></p>
</td>
<td width="126">
<p><strong>MountainRanges</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>BG</p>
</td>
<td width="126">
<p>6</p>
</td>
</tr>
<tr>
<td width="101">
<p>RU</p>
</td>
<td width="126">
<p>1</p>
</td>
</tr>
<tr>
<td width="101">
<p>&hellip;</p>
</td>
<td width="126">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14.&nbsp;&nbsp;&nbsp; Countries with Rivers</h2>
<p>Write a query that selects:</p>
<ul>
<li>CountryName</li>
<li>RiverName</li>
</ul>
<p>Find the first 5 countries with or without rivers in Africa. Sort them by CountryName in ascending order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="107">
<p><strong>CountryName</strong></p>
</td>
<td width="89">
<p><strong>RiverName</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>Algeria</p>
</td>
<td width="89">
<p>Niger</p>
</td>
</tr>
<tr>
<td width="107">
<p>Angola</p>
</td>
<td width="89">
<p>Congo</p>
</td>
</tr>
<tr>
<td width="107">
<p>Benin</p>
</td>
<td width="89">
<p>Niger</p>
</td>
</tr>
<tr>
<td width="107">
<p>Botswana</p>
</td>
<td width="89">
<p>NULL</p>
</td>
</tr>
<tr>
<td width="107">
<p>Burkina Faso</p>
</td>
<td width="89">
<p>Niger</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 15.&nbsp;&nbsp;&nbsp; *Continents and Currencies</h2>
<p>Write a query that selects:</p>
<ul>
<li>ContinentCode</li>
<li>CurrencyCode</li>
<li>CurrencyUsage</li>
</ul>
<p>Find all continents and their most used currency. Filter any currency that is used in only one country. Sort your results by ContinentCode.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>ContinentCode</strong></p>
</td>
<td width="104">
<p><strong>CurrencyCode</strong></p>
</td>
<td width="113">
<p><strong>CurrencyUsage</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>AF</p>
</td>
<td width="104">
<p>XOF</p>
</td>
<td width="113">
<p>8</p>
</td>
</tr>
<tr>
<td width="113">
<p>AS</p>
</td>
<td width="104">
<p>AUD</p>
</td>
<td width="113">
<p>2</p>
</td>
</tr>
<tr>
<td width="113">
<p>AS</p>
</td>
<td width="104">
<p>ILS</p>
</td>
<td width="113">
<p>2</p>
</td>
</tr>
<tr>
<td width="113">
<p>EU</p>
</td>
<td width="104">
<p>EUR</p>
</td>
<td width="113">
<p>26</p>
</td>
</tr>
<tr>
<td width="113">
<p>NA</p>
</td>
<td width="104">
<p>XCD</p>
</td>
<td width="113">
<p>8</p>
</td>
</tr>
<tr>
<td width="113">
<p>OC</p>
</td>
<td width="104">
<p>USD</p>
</td>
<td width="113">
<p>8</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 16.&nbsp;&nbsp;&nbsp; Countries without any Mountains</h2>
<p>Write a query that selects <strong>CountryCode</strong><strong>.</strong> Find all the count of all countries which don&rsquo;t have a mountain.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>CountryCode</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>231</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 17.&nbsp;&nbsp;&nbsp; Highest Peak and Longest River by Country</h2>
<p>For each country, find the elevation of <strong>the highest peak</strong> and <strong>the length of the longest river</strong>, sorted by the highest peak elevation (from highest to lowest), then by the longest river length (from longest to smallest), then by country name (alphabetically). Display <strong>NULL</strong> when no data is available in some of the columns. Limit only the first 5 rows.</p>
<table>
<tbody>
<tr>
<td width="107">
<p><strong>CountryName</strong></p>
</td>
<td width="147">
<p><strong>HighestPeakElevation</strong></p>
</td>
<td width="134">
<p><strong>LongestRiverLength</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>China</p>
</td>
<td width="147">
<p>8848</p>
</td>
<td width="134">
<p>6300</p>
</td>
</tr>
<tr>
<td width="107">
<p>India</p>
</td>
<td width="147">
<p>8848</p>
</td>
<td width="134">
<p>3180</p>
</td>
</tr>
<tr>
<td width="107">
<p>Nepal</p>
</td>
<td width="147">
<p>8848</p>
</td>
<td width="134">
<p>2948</p>
</td>
</tr>
<tr>
<td width="107">
<p>Pakistan</p>
</td>
<td width="147">
<p>8611</p>
</td>
<td width="134">
<p>3180</p>
</td>
</tr>
<tr>
<td width="107">
<p>Argentina</p>
</td>
<td width="147">
<p>6962</p>
</td>
<td width="134">
<p>4880</p>
</td>
</tr>
<tr>
<td width="107">
<p>Chile</p>
</td>
<td width="147">
<p>6962</p>
</td>
<td width="134">
<p>NULL</p>
</td>
</tr>
<tr>
<td width="107">
<p>&hellip;</p>
</td>
<td width="147">
<p>&hellip;</p>
</td>
<td width="134">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 18.&nbsp;&nbsp;&nbsp; * Highest Peak Name and Elevation by Country</h2>
<p>For each country, find the name and elevation of <strong>the highest peak</strong>, along with its mountain. When no peaks are available in some country, display elevation<strong> 0</strong>, "<strong>(no highest peak)</strong>" as peak name and "<strong>(no mountain)</strong>" as mountain name. When multiple peaks in some country have the same elevation, display all of them. Sort the results by country name alphabetically, then by highest peak name alphabetically. Limit only the first 5 rows.</p>
<table>
<tbody>
<tr>
<td width="102">
<p><strong>Country</strong></p>
</td>
<td width="138">
<p><strong>HighestPeakName</strong></p>
</td>
<td width="157">
<p><strong>HighestPeakElevation</strong></p>
</td>
<td width="107">
<p><strong>Mountain</strong></p>
</td>
</tr>
<tr>
<td width="102">
<p>Afghanistan</p>
</td>
<td width="138">
<p>(no highest peak)</p>
</td>
<td width="157">
<p>0</p>
</td>
<td width="107">
<p>(no mountain)</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>Argentina</p>
</td>
<td width="138">
<p>Aconcagua</p>
</td>
<td width="157">
<p>6962</p>
</td>
<td width="107">
<p>Andes</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>Bulgaria</p>
</td>
<td width="138">
<p>Musala</p>
</td>
<td width="157">
<p>2925</p>
</td>
<td width="107">
<p>Rila</p>
</td>
</tr>
<tr>
<td width="102">
<p>Burkina Faso</p>
</td>
<td width="138">
<p>(no highest peak)</p>
</td>
<td width="157">
<p>0</p>
</td>
<td width="107">
<p>(no mountain)</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>United States</p>
</td>
<td width="138">
<p>Mount McKinley</p>
</td>
<td width="157">
<p>6194</p>
</td>
<td width="107">
<p>Alaska Range</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>Zambia</p>
</td>
<td width="138">
<p>(no highest peak)</p>
</td>
<td width="157">
<p>0</p>
</td>
<td width="107">
<p>(no mountain)</p>
</td>
</tr>
<tr>
<td width="102">
<p>Zimbabwe</p>
</td>
<td width="138">
<p>(no highest peak)</p>
</td>
<td width="157">
<p>0</p>
</td>
<td width="107">
<p>(no mountain)</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>