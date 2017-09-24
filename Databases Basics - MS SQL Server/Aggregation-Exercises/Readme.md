<h1>Exercises: Data Aggregation</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016">"Databases Basics - MSSQL" course @ Software University.</a></p>
<p>Mr. Bodrog is a greedy small goblin who is in charge of <strong>Gringotts</strong> &ndash; the biggest wizard bank. His most precious possession is a small database of the deposits in the wizard&rsquo;s world. Taking money is his hobby. He wants your money as well but unfortunately you are not a wizard. The only magic you know is how to work with <strong>databases</strong>. That&rsquo;s how you got access to the precious data. Mr. Bodrog wants you to send him some reports otherwise he will send a pack of hungry werewolves after you. You don&rsquo;t want to confront pack of hungry werewolves, do you?</p>
<p>Before going on the next task make sure to download the <strong>Gringotts</strong> database.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Records&rsquo; Count</h2>
<p>Import the database and send the total count of records to Mr. Bodrog. Make sure nothing got lost.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="58">
<p><strong>Count</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>162</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Longest Magic Wand</h2>
<p>Select the size of the longest magic wand. Rename the new column appropriately.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="142">
<p><strong>LongestMagicWand</strong></p>
</td>
</tr>
<tr>
<td width="142">
<p>31</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Longest Magic Wand per Deposit Groups</h2>
<p>For wizards in each deposit group show the longest magic wand. Rename the new column appropriately.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="142">
<p><strong>LongestMagicWand</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Human Pride</p>
</td>
<td width="142">
<p>30</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Smallest Deposit Group per Magic Wand Size</h2>
<p>Select the deposit group with the lowest average wand size.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>DepositGroup</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Troll Chest</p>
</td>
</tr>
<tr>
<td width="132">
<p>Venomous Tongue</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deposits Sum</h2>
<p>Select all deposit groups and its total deposit sum.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepositGroup</strong></p>
</td>
<td width="95">
<p><strong>TotalSum</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Human Pride</p>
</td>
<td width="95">
<p>1041291.52</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deposits Sum for Ollivander Family</h2>
<p>Select all deposit groups and its total deposit sum but only for the wizards who has their magic wand crafted by Ollivander family.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="85">
<p><strong>TotalSum</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Human Pride</p>
</td>
<td width="85">
<p>188366.86</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deposits Filter</h2>
<p>Select all deposit groups and its total deposit sum but only for the wizards who has their magic wand crafted by Ollivander family. After this filter total deposit amounts lower than 150000. Order by total deposit amount in descending order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="85">
<p><strong>TotalSum</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Troll Chest</p>
</td>
<td width="85">
<p>126585.18</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Deposit Charge</h2>
<p>Create a query that selects:</p>
<ul>
<li><strong>Deposit group </strong></li>
<li><strong>Magic wand creator</strong></li>
<li>Minimum <strong>deposit charge</strong> for each group</li>
</ul>
<p>Select the data in ascending order by <strong>MagicWandCreator</strong> and <strong>DepositGroup</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="142">
<p><strong>MagicWandCreator</strong></p>
</td>
<td width="132">
<p><strong>MinDepositCharge</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Blue Phoenix</p>
</td>
<td width="142">
<p>Antioch Peverell</p>
</td>
<td width="132">
<p>30.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
<td width="132">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Age Groups</h2>
<p>Write down a query that creates 7 different groups based on their <strong>age</strong>.</p>
<p><strong>Age groups</strong> should be as follows:</p>
<ul>
<li>[0-10]</li>
<li>[11-20]</li>
<li>[21-30]</li>
<li>[31-40]</li>
<li>[41-50]</li>
<li>[51-60]</li>
<li>[61+]</li>
</ul>
<p>The query should return</p>
<ul>
<li><strong>Age groups</strong></li>
<li><strong>Count </strong>of wizards in it</li>
</ul>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>AgeGroup</strong></p>
</td>
<td width="104">
<p><strong>WizardCount</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>[11-20]</p>
</td>
<td width="104">
<p>21</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="104">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10.&nbsp;&nbsp;&nbsp; First Letter</h2>
<p>Write a query that returns all unique wizard first letters of their <strong>first names</strong> only if they have deposit of type Troll Chest. Order them alphabetically. Use GROUP BY for uniqueness.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>FirstLetter</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>A</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11.&nbsp;&nbsp;&nbsp; Average Interest</h2>
<p>Mr. Bodrog is highly interested in profitability. He wants to know the average interest of all <strong>deposits groups</strong> split by whether the deposit has <strong>expired or not</strong>. But that&rsquo;s not all. He wants you to select deposits with <strong>start date</strong> after 01/01/1985. Order the data descending by Deposit Group and ascending by Expiration Flag.</p>
<p>The output should consist of the following columns:</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>DepositGroup</strong></p>
</td>
<td width="123">
<p><strong>IsDepositExpired</strong></p>
</td>
<td width="123">
<p><strong>AverageInterest</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Venomous Tongue</p>
</td>
<td width="123">
<p>0</p>
</td>
<td width="123">
<p>16.698947</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
<td width="123">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12.&nbsp;&nbsp;&nbsp; * Rich Wizard, Poor Wizard</h2>
<p>Mr. Bodrog definitely likes his werewolves more than you. This is your last chance to survive! Give him some data to play his favorite game Rich Wizard, Poor Wizard. The rules are simple: You compare the deposits of every wizard with the wizard after him. If a wizard is the last one in the database, simply <strong>ignore it</strong>. In the end you have to sum the difference between the deposits.</p>
<table>
<tbody>
<tr>
<td width="141">
<p><strong>Host Wizard</strong></p>
</td>
<td width="141">
<p><strong>Host Wizard Deposit</strong></p>
</td>
<td width="141">
<p><strong>Guest Wizard</strong></p>
</td>
<td width="161">
<p><strong>Guest Wizard Deposit</strong></p>
</td>
<td width="121">
<p><strong>Difference</strong></p>
</td>
</tr>
<tr>
<td width="141">
<p>Harry</p>
</td>
<td width="141">
<p>10 000</p>
</td>
<td width="141">
<p>Tom</p>
</td>
<td width="161">
<p>12&nbsp;000</p>
</td>
<td width="121">
<p>-2000</p>
</td>
</tr>
<tr>
<td width="141">
<p>Tom</p>
</td>
<td width="141">
<p>12 000</p>
</td>
<td width="141">
<p>&hellip;</p>
</td>
<td width="161">
<p>&hellip;</p>
</td>
<td width="121">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>At the end your query should return a single value: the SUM of all differences.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>SumDifference</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>44393.97</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13.&nbsp;&nbsp;&nbsp; Departments Total Salaries</h2>
<p>That&rsquo;s it! You no longer work for Mr. Bodrog. You have decided to find a proper job as an analyst in SoftUni. <br /> It&rsquo;s not a surprise that you will use the <strong>SoftUni</strong> database. Things get more exciting here!</p>
<p>Create a query which shows the total sum of salaries for each department. <strong>Order</strong> by DepartmentID.<br /> Your query should return:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<ul>
<li><strong>DepartmentID</strong></li>
</ul>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepartmentID</strong></p>
</td>
<td width="113">
<p><strong>TotalSalary</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>1</p>
</td>
<td width="113">
<p>241000.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14.&nbsp;&nbsp;&nbsp; Employees Minimum Salaries</h2>
<p>Select the minimum salary from the employees for departments with ID (2,5,7) but only for those who are hired after 01/01/2000.<br /> Your query should return:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<ul>
<li><strong>DepartmentID</strong></li>
</ul>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepartmentID</strong></p>
</td>
<td width="113">
<p><strong>MinimumSalary</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>2</p>
</td>
<td width="113">
<p>2500.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 15.&nbsp;&nbsp;&nbsp; Employees Average Salaries</h2>
<p>Select all employees who earn more than 30000 <strong>into a new table. </strong>Then delete all employees who has <strong>ManagerID = 42 </strong>(in the new table); Then increase the salaries of all employees with <strong>DepartmentID=1</strong> with 5000. Finally, select the average salaries in each department.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepartmentID</strong></p>
</td>
<td width="113">
<p><strong>AverageSalary</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>1</p>
</td>
<td width="113">
<p>45166.6666</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 16.&nbsp;&nbsp;&nbsp; Employees Maximum Salaries</h2>
<p>Find the max salary for each department. Filter those which have max salaries not in the range 30000 and 70000;</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepartmentID</strong></p>
</td>
<td width="85">
<p><strong>MaxSalary</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>2</p>
</td>
<td width="85">
<p>29800.00</p>
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
<h2>Problem 17.&nbsp;&nbsp;&nbsp; Employees Count Salaries</h2>
<p>Count the salaries of all employees who don&rsquo;t have a manager.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="66">
<p><strong>Count</strong></p>
</td>
</tr>
<tr>
<td width="66">
<p>4</p>
</td>
</tr>
<tr>
<td width="66">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 18.&nbsp;&nbsp;&nbsp; *3rd Highest Salary</h2>
<p>Find the third highest salary in each department if there is such.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="109">
<p><strong>DepartmentID</strong></p>
</td>
<td width="132">
<p><strong>ThirdHighestSalary</strong></p>
</td>
</tr>
<tr>
<td width="109">
<p>2</p>
</td>
<td width="132">
<p>25000.00</p>
</td>
</tr>
<tr>
<td width="109">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 19.&nbsp;&nbsp;&nbsp; **Salary Challenge</h2>
<p>Write a query that returns:</p>
<ul>
<li><strong>FirstName</strong></li>
<li><strong>LastName</strong></li>
<li><strong>DepartmentID</strong></li>
</ul>
<p>Select all employees who have salary higher than the average salary of their respective departments. Select only the first 10 rows. Order by DepartmentID.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>FirstName</strong></p>
</td>
<td width="90">
<p><strong>LastName</strong></p>
</td>
<td width="113">
<p><strong>DepartmentID</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>Roberto</p>
</td>
<td width="90">
<p>Tamburello</p>
</td>
<td width="113">
<p>1</p>
</td>
</tr>
<tr>
<td width="84">
<p>&hellip;</p>
</td>
<td width="90">
<p>&hellip;</p>
</td>
<td width="113">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>