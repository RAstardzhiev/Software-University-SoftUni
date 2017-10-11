<h1>Exercises: Entity Framework Code First + OOP Intro</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1442/databases-advanced-entity-framework-october-2016">"Databases Advanced &ndash; Entity Framework" course @ Software University.</a></p>
<h1>&nbsp;&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OOP Intro</h1>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Define a class Person</h2>
<p>Define a class<strong> Person</strong> with <strong>public</strong> properties for <strong>name</strong> and <strong>age</strong>.</p>
<h3>Bonus</h3>
<p>Try to create a few objects of type Person:</p>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>Name</strong></p>
</td>
<td width="76">
<p><strong>Age</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>Pesho</p>
</td>
<td width="76">
<p>20</p>
</td>
</tr>
<tr>
<td width="74">
<p>Gosho</p>
</td>
<td width="76">
<p>18</p>
</td>
</tr>
<tr>
<td width="74">
<p>Stamat</p>
</td>
<td width="76">
<p>43</p>
</td>
</tr>
</tbody>
</table>
<p>Use both the inline initialization and the default constructor. Your fields should be <strong>public</strong>, otherwise you won&rsquo;t see them.</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create Person Constructors</h2>
<p>Add 4 constructors to the <strong>Person</strong> class from the last task, use constructor chaining to reuse code:</p>
<ol>
<li>The first should take no arguments and produce a person with name &ldquo;<strong>No name</strong>&rdquo; and age = <strong>1</strong>.</li>
<li>The second should accept only an integer number for the age and produce a person with name &ldquo;<strong>No name</strong>&rdquo; and age equal to the passed parameter.</li>
<li>The third one should accept a string for the and should produce a person with the given name and age = <strong>1</strong>.</li>
<li>The fourth one should take both parameters.</li>
</ol>
<p>Your task is to create a command which parses the input parameters (if any), split by &ldquo;,&rdquo; and based on them to instantiate new object of type Person.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="120">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>Pesho,20</p>
</td>
<td width="120">
<p>Pesho 20</p>
</td>
</tr>
<tr>
<td width="84">
<p>Gosho</p>
</td>
<td width="120">
<p>Gosho 1</p>
</td>
</tr>
<tr>
<td width="84">
<p>43</p>
</td>
<td width="120">
<p>No name 43</p>
</td>
</tr>
<tr>
<td width="84">
<p>&nbsp;</p>
</td>
<td width="120">
<p>No name 1</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Oldest Family Member</h2>
<p>Use the same class <strong>Person</strong> with fields <strong>name</strong> and <strong>age</strong>. Create a class <strong>Family</strong>. The class should have <strong>list of people</strong>, method for adding members (void AddMember(Person member)) and a method returning the oldest family member (Person GetOldestMember()). Write a program that reads name and age for <strong>N</strong> people and <strong>add them to the family</strong>. Then <strong>print</strong> the <strong>name</strong> and <strong>age</strong> of the oldest member.</p>
<h3>Examples</h3>
<table width="379">
<tbody>
<tr>
<td width="70">
<p><strong>Input</strong></p>
</td>
<td width="71">
<p><strong>Output</strong></p>
</td>
<td width="30">
<p><strong>&nbsp;</strong></p>
</td>
<td width="132">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="70">
<p>3</p>
<p>Pesho 3</p>
<p>Gosho 4</p>
<p>Annie 5</p>
</td>
<td width="71">
<p>Annie 5</p>
</td>
<td width="30">
<p>&nbsp;</p>
</td>
<td width="132">
<p>5</p>
<p>Steve 10</p>
<p>Christopher 15</p>
<p>Annie 4</p>
<p>Ivan 35</p>
<p>Maria 34</p>
</td>
<td width="76">
<p>Ivan 35</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Students</h2>
<p>Define class <strong>Student</strong>. Add <strong>string field</strong> for a student&rsquo;s <strong>name</strong> that you are going to receive as a console input. Then add a <strong>static Integer field</strong> to <strong>keep track of how many students&rsquo; instances are created</strong>. Initialize the static field with <strong>0 (zero)</strong> and <strong>increment in the constructor</strong>. When you receive command <strong>&ldquo;End&rdquo;</strong> stop reading more students names and print their total count on the console.</p>
<h3>Examples</h3>
<table width="236">
<tbody>
<tr>
<td width="58">
<p><strong>Input</strong></p>
</td>
<td width="54">
<p><strong>Output</strong></p>
</td>
<td width="11">
<p><strong>&nbsp;</strong></p>
</td>
<td width="56">
<p><strong>Input</strong></p>
</td>
<td width="57">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>Atanas</p>
<p>Martin</p>
<p>End</p>
</td>
<td width="54">
<p>2</p>
</td>
<td width="11">
<p>&nbsp;</p>
</td>
<td width="56">
<p>Minka</p>
<p>End</p>
</td>
<td width="57">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Planck Constant</h2>
<p>Create class <strong>Calculation</strong>. Define static constant with value <strong>6.62606896e-34</strong> (Planck constant) and <strong>3.14159</strong> (Pi). Add <strong>static method</strong> that returns reduced Planck constant by the formula:</p>
<p>{Planck constant} / (2 * {Pi constant})</p>
<p>Print the result of the method on a <strong>single line on the console</strong>. <strong>Do not format</strong> in any way the <strong>result.</strong></p>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Math Utilities</h2>
<p>Define <strong>MathUtil</strong> class that supports <strong>basic</strong> mathematical operations:</p>
<ul>
<li><strong>Sum &lt;first number&gt; &lt;second number&gt;</strong></li>
<li><strong>Subtract &lt;first number&gt; &lt;second number&gt;</strong></li>
<li><strong>Multiply &lt;first number&gt; &lt;second number&gt;</strong></li>
<li><strong>Divide &lt;dividend&gt; &lt;divisor&gt;</strong></li>
<li><strong>Percentage &lt;total number&gt; &lt;percent of that number&gt;</strong></li>
</ul>
<p>Use <strong>static methods</strong> and make sure that the application will work with <strong>floating point numbers</strong>.</p>
<p>Read from the console until you receive command <strong>&ldquo;End&rdquo;. </strong>Results must be formatted with <strong>2 digits after the floating point.</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<h3>Examples</h3>
<table width="330">
<tbody>
<tr>
<td width="160">
<p><strong>Input</strong></p>
</td>
<td width="170">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="160">
<p>Sum 5 5</p>
<p>Multiply 5.5 11</p>
<p>Percentage 1500 99</p>
<p>Divide 12.24 2</p>
<p>Subtract 10.6 0.6</p>
<p>End</p>
</td>
<td width="170">
<p>10.00</p>
<p>60.50</p>
<p>1485.00</p>
<p>6.12</p>
<p>10.00</p>
</td>
</tr>
</tbody>
</table>
<h1>&nbsp; II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Code First</h1>
<h2>7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gringotts Database</h2>
<p>Your task is to create table<strong> WizardDeposits</strong> using the Code First approach. The table should contain the following fields:</p>
<ul>
<li><strong>Id</strong> &ndash; Primary Key (number in range [1, 2<sup>31</sup>-1].</li>
<li><strong>FirstName</strong> &ndash; Text field with max length of 50 symbols.</li>
<li><strong>LastName </strong>- Text field with max length of 60 Required</li>
<li><strong>Notes</strong> &ndash; Text field with max length of 1000 symbols</li>
<li><strong>Age</strong> &ndash; Non-negative number. Required</li>
<li><strong>MagicWandCreator</strong> &ndash; Text field with max length of 100 symbols</li>
<li><strong>MagicWandSize </strong>&ndash; Number in range [1, 2<sup>15</sup>-1]</li>
<li><strong>DepositGroup</strong> - Text field with max length of 20 symbols</li>
<li><strong>DepositStartDate</strong> &ndash; Date and time field</li>
<li><strong>DepositAmount </strong>&ndash; Floating point number field</li>
<li><strong>DepositInterest </strong>- Floating point number field</li>
<li><strong>DepositCharge</strong> - Floating point number field</li>
<li><strong>DepositExpirationDate</strong> &ndash; Date and time field</li>
<li><strong>IsDepositExpired</strong> &ndash; Boolean field</li>
</ul>
<p><br /> Add several records to the database using Entity Framework. Use the following example of wizard deposit creation and addition to the database.</p>
<h2>8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create User</h2>
<p>Your task is to create table <strong>Users</strong> using the Code First approach. The table should contain the following fields:</p>
<ul>
<li><strong>Id</strong> &ndash; Primary Key (number in range [1, 2<sup>31</sup>-1])</li>
<li><strong>Username</strong> &ndash; Text with length between 4 and 30 symbols. Required.</li>
<li><strong>Password</strong> &ndash; Required field. Text with length between 6 and 50 symbols. Should contain at least:
<ul>
<li>1 lowercase letter</li>
<li>1 uppercase letter</li>
<li>1 digit</li>
<li>1 special symbol (!, @, #, $, %, ^, &amp;, *, (, ), _, +, &lt;, &gt;, ?)</li>
</ul>
</li>
<li><strong>E-mail</strong> &ndash; Required field. Text that is considered to be in format <strong>&lt;user&gt;@&lt;host&gt;</strong> where:
<ul>
<li><strong>&lt;user&gt; </strong>is a sequence of letters and digits, where '<strong>.</strong>', '<strong>-</strong>' and '<strong>_</strong>' can appear between them (they cannot appear at the beginning or at the end of the sequence).</li>
<li><strong>&lt;host&gt; </strong>is a sequence of at least two words, separated by dots '<strong>.</strong>' (dots cannot appear at the beginning or at the end of the sequence)</li>
</ul>
</li>
<li><strong>ProfilePicture</strong> &ndash; Image file with size maximum of 1MB</li>
<li><strong>RegisteredOn</strong> &ndash; Date and time of user registration</li>
<li><strong>LastTimeLoggedIn</strong> &ndash; Date and time of the last time the user logged in</li>
<li><strong>Age </strong>&ndash; number in range [1, 120]</li>
<li><strong>IsDeleted</strong> &ndash; Shows whether the user is deleted or not</li>
</ul>
<p>Seed some users in the database. Test if validation of the fields works as expected.</p>
<h2>9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hospital Database</h2>
<p>Congrats! You were hired as a Junior Database App Developer. But before starting to work you were required to provide some documents such as fit note from your GP. So, you go to him to get it. When you tell him, what do you need and what kind of job you are about to start. He told you that he was just looking for someone to make a software to help him managing and keeping data about his patients. He offered you to give you the fit note for free if you help him. You decided that&rsquo;s a great opportunity to save 20 leva and go out tonight with friends and also you would expand your portfolio with 1 project.</p>
<p>Your task is to design a database using the Code First approach. The GP needs to keep information about his patients. Each patient has first name, last name, address, email, date of birth, picture, information whether he has medical insurance or not and should keep history about all his visitations, diagnoses and prescribed medicaments. Each visitation has date and comments. Each diagnose has name and comments for it. Each medicament has <strong>name</strong>. Make sure all data is validated before inserting in the database.</p>
<h3>Bonus Task</h3>
<p>Make console based user interface so the doctor can use easily the database.</p>
<h3>**Bonus Task</h3>
<p>The console based user interface is a good start point but almost nobody use them nowadays (except BDZ Passenger Services). So, make a nice good looking graphical user interface for the program.</p>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hospital Database Modification</h2>
<p>Your GP bragged around in the hospital about the cool software you made for him. And now the hospital administration wants to modify your program so they can use it too. They want to store information about the <strong>doctors</strong> (<strong>name</strong> and <strong>specialty</strong>). Each doctor can perform <strong>many</strong> <strong>visitations</strong> and in each <strong>visitation</strong>, can be <strong>performed</strong> <strong>by</strong> only <strong>one</strong> <strong>doctor</strong>. Make the necessary changes in the database to satisfy the new needs of the hospital administration. When migrating to the new database schema make sure no data is lost. If you made some user interface (graphical or not), make changes in it be more adequate for the changes.</p>
<h3>**Bonus Task</h3>
<p>Make authentication system for doctors. Each doctor should be able to log in with his email and password. When the doctor is logged in he can see only information related about himself (his visitations, the patients he examined, etc.).</p>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Get Users by Email Provider</h2>
<p>Insert some sample <a href="https://softuni.bg/downloads/svn/DB-Fundamentals/DB-Advanced-EntityFramework/Feb-2017/03.%20DB-Advanced-EntityFramework-EntityFramework-Code-First+OOP-Intro/Users-Sample-Data.sql">data</a> in <strong>Users </strong>database then write program that print all usernames and emails of users by given email provider.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="121">
<p><strong>Input</strong></p>
</td>
<td width="389">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="121">
<p>d.edu</p>
</td>
<td width="389">
<p>Hu Sed@Sedid.edu</p>
<p>Roary Praesent.luctus@velfaucibusid.edu</p>
</td>
</tr>
<tr>
<td width="121">
<p>t.org</p>
</td>
<td width="389">
<p>Lee odio@lectusNullamsuscipit.org</p>
<p>Denton nonummy@sit.org</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Remove Inactive Users</h2>
<p>Write a program that set IsDeleted field to true for all users that has not been logged in after given date. Print the number of user that has been set as deleted. Then delete all users that have been marked for removal.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="123">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>01 May 2013</p>
</td>
<td width="246">
<p>3 users have been deleted</p>
</td>
</tr>
<tr>
<td width="123">
<p>10 Apr 2014</p>
</td>
<td width="246">
<p>21 user has been deleted</p>
</td>
</tr>
<tr>
<td width="123">
<p>12 Dec 2013</p>
</td>
<td width="246">
<p>No users have been deleted</p>
</td>
</tr>
</tbody>
</table>
<p>*Note that the example is valid only in this order.</p>