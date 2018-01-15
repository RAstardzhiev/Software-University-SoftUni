<h1>Exercises: Entity Framework Relations</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1442/databases-advanced-entity-framework-october-2016">"Databases Advanced &ndash; Entity Framework" course @ Software University.</a></p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Code First Student System</h2>
<p>Your task is to create a database for the <strong>Student System</strong>, using the <strong>Entity Framework Code First </strong>approach. Model the following tables:</p>
<ul>
<li><strong>Students</strong>: id, name, phone number, registration date, birthday &ndash; all but phone number and birthdate are required.</li>
<li><strong>Courses</strong>: id, name, description, start date, end date, price &ndash; only description is optional (nullable)</li>
<li><strong>Resources</strong>: id, name, type of resource (video / presentation / document / other), URL &ndash; all properties are required</li>
<li><strong>Homework</strong>: id, content, content-type (application/pdf/zip), submission date &ndash; all properties are required</li>
</ul>
<p>Table relations:</p>
<ul>
<li><strong>Students</strong> can be in <strong>many course</strong>s</li>
<li><strong>Courses</strong> can have <strong>many students</strong></li>
<li><strong>Courses</strong> can have <strong>many resources</strong></li>
<li><strong>One course</strong> can have <strong>many homework submissions</strong></li>
<li><strong>Homework submissions</strong> have a <strong>student</strong></li>
</ul>
<p>&nbsp;</p>
<p>Add <strong>navigational properties</strong> in all models to simplify navigation. Annotate the data models with the appropriate <strong>attributes</strong> and validations and <strong>enable code first migrations</strong>.</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Seed Some Data in the Database</h2>
<p>Write a <strong>seed method</strong> that fills the database with sample data.</p>
<p>Fill a few <strong>students</strong>, <strong>courses</strong>, <strong>resources</strong> and <strong>homework submissions</strong>. Configure Entity Framework to run the <strong>Seed()</strong> method after the database is created for the first time (i.e. only if it's empty). (Set the database initializer as MigrateDatabaseToLatestVersion, but use <strong>AddOrUpdate</strong> in the <strong>Seed</strong>).</p>
<p>Run the application several times to ensure that it seeds sample data <strong>only</strong> <strong>once</strong>.</p>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Working with the Database</h2>
<p>Write a console application that works with the EF data layer and performs the following CRUD operations:</p>
<ol>
<li>Lists <strong>all students</strong> and their <strong>homework submissions</strong>. Print only their <strong>names</strong> and for each homework - <strong>content</strong> and <strong>content-type</strong>.</li>
<li>List <strong>all courses</strong> with their corresponding <strong>resources</strong>. Print the <strong>course name</strong> and <strong>description</strong> and everything for each <strong>resource</strong>. Order the courses by start date (ascending), then by end date (descending).</li>
<li>List <strong>all courses</strong> with <strong>more than 5 resources</strong>. Order them by <strong>resources count</strong> (descending), then by <strong>start date</strong> (descending). Print only the <strong>course name</strong> and the <strong>resource count</strong>.</li>
<li>*List all <strong>courses</strong> which were active on a <strong>given date</strong> (choose the date depending on the data seeded to ensure there are results), and for each course count the <strong>number of students enrolled</strong>. <br /> Print the <strong>course name</strong>, <strong>start </strong>and <strong>end date</strong>, <strong>course duration</strong> (difference between end and start date in days) and <strong>number of students enrolled</strong>. Order the results by the <strong>number of students</strong> enrolled (in descending order), then by <strong>duration</strong> (descending).</li>
<li>For each student, get the <strong>number of courses</strong> he/she has enrolled in, the <strong>total price </strong>of these courses and the <strong>average price per course</strong> for the student.<br /> Print the <strong>student name</strong>, <strong>number of courses</strong>, <strong>total price</strong> and <strong>average price</strong>. Order the results by <strong>total price</strong> (descending), then by <strong>number of courses</strong> (descending) and then by the <strong>student's name</strong> (ascending).</li>
</ol>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Resource Licenses</h2>
<p>Resources should now have many <strong>licenses</strong>. A <strong>license</strong> should have an <strong>Id</strong> and <strong>Name</strong> and <strong>Resource</strong>.</p>
<p>Make these changes using Code First Migrations. Make sure no data is lost after the update.</p>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp; Photographers</h2>
<p>Create entity photographer with username, password, email, register date and birth date. Insert sample data in database.</p>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp; Albums</h2>
<p>Now make each photographer capable of creating <strong>personal albums</strong>. Each album has name, background color and information whether is public or not. One album may have many pictures. Each picture has title, caption (string) and path on the file system. A picture can be present in many albums. Each photographer can have many albums but an album can have only one owner.</p>
<p>Make the necessary changes using Code First Migrations. Make sure no data is lost after the update. Add some photographers, pictures and albums.</p>
<h2>7.&nbsp;&nbsp;&nbsp;&nbsp; Tags</h2>
<p>Imagine how much cooler would be if the photographer can put tags on each album so they can be easily organized (such as, #NewYear2016, #HolidaySummer, #NoMakeup etc&hellip;). A tag is just simply a string without any spaces (we can call it label or signature). Each album can have as many tags the photographer wants and each tag can be placed on unlimited number of albums. Tag names should be unique, do not create duplicate tags.</p>
<p>Make the necessary changes using Code First Migrations. Make sure no data is lost after the update.</p>
<h2>8.&nbsp;&nbsp;&nbsp;&nbsp; *Tag Attribute</h2>
<p>Make a [Tag] attribute that would validate if the given string is valid tag. A valid tag is a string starting with pound sign (#), do not contain any spaces in it and is no more than 20 symbols long.</p>
<p>Write a static class TagTransofrmer that would have a single public static method inside Transform(string tag). That method would convert given tag to a valid one (remove all spaces, put pound sign at first position if it is not present and reduce the length of the tag if it is more than 20 symbols with &lsquo;<strong>#</strong>&rsquo;included). See examples for more clarity.</p>
<p>Write a program that receives as an input tags and insert them into the database. Use the [Tag] attribute and TagTransformer class to make sure only valid attributes are inserted in the database.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="262">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="262">
<p>#summer</p>
</td>
<td width="359">
<p>#summer was added to database</p>
</td>
</tr>
<tr>
<td width="262">
<p>myCat</p>
</td>
<td width="359">
<p>#myCat was added to database</p>
</td>
</tr>
<tr>
<td width="262">
<p>#no make up</p>
</td>
<td width="359">
<p>#nomakeup was added to database</p>
</td>
</tr>
<tr>
<td width="262">
<p>#aaaaaaaaaaaaaaaaaaXCutThisEnd</p>
</td>
<td width="359">
<p>#aaaaaaaaaaaaaaaaaaX was added to database</p>
</td>
</tr>
<tr>
<td width="262">
<p>me and my bff doing selfie</p>
</td>
<td width="359">
<p>#meandmybffdoingself was added to database</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Create custom validation <a href="http://stackoverflow.com/questions/11959431/how-to-create-a-custom-validation-attribute">attribute</a> and put it over the Tag. Try to insert the raw tag value and if exception is thrown use Transfrom method to edit it.</p>
<h2>9.&nbsp;&nbsp;&nbsp;&nbsp; Shared Albums</h2>
<p>Currently an album can have just one owner lets modify it so the owner can share its albums with other photographers. To do that just change the type of the relationship between photographer and album from one <br /> to many to more appropriate one.</p>
<p>Make the necessary changes using Code First Migrations. Make sure no data is lost after the update.</p>
<h2>10.&nbsp;&nbsp;&nbsp; **Photographer Roles</h2>
<p>Right now, if some photographer share album with other photographer the newly added one has total control over the album. That means he can add or delete photos without the permission of the initial owner of the album. To restrict that we can set role for each photographer for given album. The roles should be:</p>
<ul>
<li><strong>Owner</strong> - can modify the album</li>
<li><strong>Viewer </strong>- can only see the pictures in that album but cannot add or delete any</li>
</ul>
<p>Make the necessary changes using Code First Migrations.</p>
<h3>Hints</h3>
<p>Map the relation between photographer and album as entity model. Note that current mapping table may have different column names.</p>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Bank System</h2>
<p>Your task is to create a database for <strong>Bank System,</strong> using the <strong>Entity Framework Code First </strong>approach. In the database, we should keep information about banking accounts. There are two types of bank accounts:</p>
<ul>
<li><strong>Saving account</strong> &ndash; account number, balance, interest rate</li>
<li><strong>Checking account</strong> &ndash; account number, balance, fee</li>
</ul>
<p>The <strong>operations</strong> that can be performed with those accounts are:</p>
<ul>
<li><strong>Savings account</strong> &ndash; deposit money, withdraw money, add interest (add to current deposit the interest multiplied by the deposit itself)</li>
<li><strong>Checking account</strong> &ndash; deposit money, withdraw money, deduct fee (substract from current deposit the fee tax)</li>
</ul>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Bank System Console Client</h2>
<p>Extend the database from the previous exercise to support keeping information about <strong>users</strong>. A user has <strong>username, password, email</strong> and can have <strong>many bank accounts</strong>. Design a console application that uses that database and support the following commands:</p>
<p>Commands that can be executed when there is <strong>no currently logged in user</strong>:</p>
<ul>
<li>Register &lt;username&gt; &lt;password&gt; &lt;email&gt; - That command add new user to the database in case username, password and email are valid. Otherwise print appropriate message informing why the user cannot be registered. The requirements for valid parameters are:
<ul>
<li><strong>Username</strong> &ndash; can contain only letters [a-Z] and numbers. Cannot start with number. Cannot be less than 3 symbols long</li>
<li><strong>Password </strong>&ndash; must contain at least 1 lowercase letter, 1 uppercase letter and 1 digit. Also, must be more than 6 symbols long</li>
<li><strong>Email </strong>&ndash; must be in format <strong>&lt;user&gt;@&lt;host&gt;</strong> where:
<ul>
<li><strong>&lt;user&gt; </strong>is a sequence of letters and digits, where '<strong>.</strong>', '<strong>-</strong>' and '<strong>_</strong>' can appear between them.</li>
<li><strong>&lt;host&gt; </strong>is a sequence of at least two words, separated by dots '<strong>.</strong>'. Each word is sequence of letters and can have hyphens '<strong>-</strong>' between the letters.</li>
</ul>
</li>
<li>Login &lt;username&gt; &lt;password&gt; - That command set the current logged in user if exists. Otherwise print appropriate message.</li>
</ul>
</li>
</ul>
<p>Commands that can be executed when there is <strong>currently logged in user</strong>:</p>
<ul>
<li>Logout &ndash; log out the user from the system. If there is no logged in user print appropriate message.</li>
<li>Add SavingAccount &lt;initial balance&gt; &lt;interest rate&gt; - add saving account to the currently logged in user. Also, set the account number to random combination of 10 uppercase letters and digits. For example: &ldquo;PX234ADG56&rdquo;, &ldquo;90M09JKE73&rdquo;, etc.</li>
<li>Add CheckingAccount &lt;initial balance&gt; &lt;fee&gt; - add checking account to the currently logged in user. Also, set the account number to random combination of 10 uppercase letters and digits.</li>
<li>ListAccounts &ndash; prints a list of overall information for all accounts of currently logged in user in format:<br /> <br /> <br /> </li>
</ul>
<p>Saving Accounts:</p>
<p>--{Account Number} {Current Balance}<br /> Checking Accounts:<br /> --{Account Number} {Current Balance}</p>
<p>Order them <strong>by account number ascending</strong>.</p>
<ul>
<li>Deposit &lt;Account number&gt; &lt;money&gt; - adds money to the account with given number</li>
<li>Withdraw &lt;Account number&gt; &lt;money&gt; - subtracts money from the account with given number</li>
<li>DeductFee &lt;Account number&gt; - deduct the fee from the balance of the account with given number</li>
<li>AddInterest &lt;Account number&gt; - add interest to the balance of the account with given number</li>
</ul>
<p>After each command <strong>print appropriate message</strong> telling whether the command was successfully executed or not. If it is not print appropriate message telling what was the error.</p>
<h3>Example</h3>
<table width="710">
<tbody>
<tr>
<td width="293">
<p><strong>Input</strong></p>
</td>
<td width="417">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="293">
<p>Register vl Tsepesh89 vlad@rom.ro</p>
<p>Register vlad123 tspesh vlad@rom.ro</p>
<p>Register vlad123 Tsepesh89 -v-@-rom.ro</p>
<p>Register vlad123 Tsepesh89 vlad@rom.ro</p>
<p>Logout</p>
<p>Login vlad321 Tsepesh89</p>
<p>Login vlad123 smallPussyCat</p>
<p>Login vlad123 Tsepesh89</p>
<p>Add SavingsAccount 1000 0.2</p>
<p>Add CheckingAccount 100 4.20</p>
<p>Deposit A8234JDG9M 10.42</p>
<p>Withdraw A8234JDG9M 5</p>
<p>Deposit PO8FHH34GM 200</p>
<p>Withdraw PO8FHH34GM 45.2</p>
<p>AddInterest A8234JDG9M</p>
<p>DeductFee PO8FHH34GM</p>
<p>ListAccounts</p>
<p>Logout</p>
</td>
<td width="417">
<p>Incorrect username</p>
<p>Incorrect password</p>
<p>Incorrect email</p>
<p>vlad123 was registered in the system</p>
<p>Cannot log out. No user was logged in.</p>
<p>Incorrect username / password</p>
<p>Incorrect username / password</p>
<p>Succesfully logged in vlad123</p>
<p>Succesfully added account with number A8234JDG9M</p>
<p>Succesfully added account with number PO8FHH34GM</p>
<p>Account A8234JDG9M has balance of 1010.42</p>
<p>Account A8234JDG9M has balance of 1005.42</p>
<p>Account PO8FHH34GM has balance of 300.00</p>
<p>Account PO8FHH34GM has balance of 254.80</p>
<p>Added interest to A8234JDG9M. Current balance: 1206.50</p>
<p>Deducted fee of PO8FHH34GM. Current balance: 250.60</p>
<p>Accounts for user vlad123</p>
<p>Saving Accounts:</p>
<p>--A8234JDG9M 1206.50</p>
<p>Checking Accounts:</p>
<p>--PO8FHH34GM 250.60</p>
<p>User vlad123 successfully logged out</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp; **Football Betting Database</h2>
<p>Your task is to create a database for the <strong>Football Bookmaker System</strong>, using the <strong>Entity Framework Code First </strong>approach. Model the following tables:</p>
<ul>
<li><strong>Teams</strong> &ndash; Id, Name, Logo, 3 letter Initials (JUV, LIV, ARS&hellip;), Primary Kit Color, Secondary Kit Color, Town, Budget</li>
<li><strong>Colors</strong> &ndash; Id, Name</li>
<li><strong>Towns</strong> &ndash; Id, Name, Country</li>
<li><strong>Countries</strong> &ndash; Id (3 letters &ndash; for example BUL, USA, GER, FRA, ITA&hellip;), Name, Continent</li>
<li><strong>Continents</strong> &ndash; Id, Name</li>
<li><strong>Players</strong> &ndash; Id, Name, Squad Number, Team, Position, Is Currently Injured</li>
<li><strong>Position</strong> &ndash; Id (2 letters &ndash; GK, DF, MF, FW&hellip;), position description (for example &ndash; goal keeper, defender&hellip;)</li>
<li><strong>PlayerStatistics</strong> &ndash; Game, Player, Scored Goals, Player Assists, Played Minutes During Game, (PK = Game + Player)</li>
<li><strong>Games</strong> &ndash; Id, Home Team, Away Team, Home Goals, Away Goals, Date and Time of Game, Home team Win bet rate, Away Team Win Bet Rate, Draw Game Bet Rate, Round, Competition)</li>
<li><strong>Rounds</strong> &ndash; Id, Name (for example Groups, League, 1/8 Final, 1/4 Final, Semi-Final, Final&hellip;)</li>
<li><strong>Competitions</strong> &ndash; Id, Name, Type (local, national, international)</li>
<li><strong>CompetitionTypes </strong>&ndash; Id, Name</li>
<li><strong>BetGame</strong> &ndash; Game, Bet, Result Prediction (PK = Game + Bet)</li>
<li><strong>Bets</strong> &ndash; Id, Bet Money, Date and Time of Bet, User</li>
<li><strong>ResultPrediction</strong> &ndash; Id, Prediction (possible values - Home Team Win, Draw Game, Away Team Win)</li>
<li><strong>Users</strong> &ndash; Id, Username, Password, Email, Full Name, Balance</li>
</ul>
<p>Table relationships:</p>
<ul>
<li>Team has one primary kit color and one secondary kit color</li>
<li>Team resident in one town</li>
<li>Each town can host several teams</li>
<li>Town can be placed in one country and a country can have many towns</li>
<li>Country can be placed in several continents and a continent can have many countries</li>
<li>Player can play for one team and one team can have many players that play for it</li>
<li>Player can play at one position and one position can be played by many players</li>
<li>Player can play in many games and in each game, many players take part</li>
<li>Additionally, for each player for given game is kept statistics such as scored goals, goal assists and minutes played during given game</li>
<li>A game can be played in one round and in one round many games can be played</li>
<li>A game can be played in one competition and in one competition many games can be played</li>
<li>On a game, many bets can be placed and one bet can be on several games</li>
<li>Each bet for given game must have prediction result</li>
<li>A bet can be placed by only one user and one user can place many bets</li>
</ul>
<p>Add <strong>navigational properties</strong> in all models to simplify navigation. Annotate the data models with the appropriate <strong>attributes</strong> and validations and <strong>enable code first migrations</strong>.</p>
<p>Separate the <strong>models</strong>, <strong>data</strong> and <strong>client</strong> into <strong>different layers</strong> (projects).</p>
<h5>Hint - Database Schema</h5>
<p>&nbsp;</p>