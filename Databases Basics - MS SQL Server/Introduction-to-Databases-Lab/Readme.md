<h1>Lab: Introduction to Databases</h1>
<p>In this lab, we will create a <strong>&ldquo;Bank&rdquo; database</strong> in <strong>SQL Server</strong>, using <strong>MS SQL Server Management Studio</strong>. We will create <strong>tables</strong> and <strong>fill them with data</strong>, create <strong>views</strong>, <strong>functions</strong>, <strong>procedures</strong> and <strong>triggers</strong>. This tutorial is a part of the &ldquo;<a href="https://softuni.bg/modules/22/csharp-db-fundamentals">Databases Basics - MS SQL Server</a>&rdquo; course @ SoftUni.</p>
<p>Before starting this tutorial, make sure you&rsquo;ve followed the <a href="https://softuni.bg/downloads/svn/DB-Fundamentals/DB-Basics-MSSQL/Sept-2017/02.%20DB-Basics-MSSQL-Introduction-to-Databases/01.%20DB-Basics-MSSQL-Introduction-to-Databases-Installation-Guide.docx">SQL Server installation guide</a>.</p>
<h2>1.&nbsp;&nbsp; Create a Database</h2>
<p>Create a new <strong>database </strong>named Bank using the <strong>MS SQL Server Management Studio GUI</strong>.</p>
<ul>
<li>Right click on <strong>Databases</strong> in the <strong>Object Explorer</strong>:</li>
<li>Choose <strong>New Database</strong> from the drop-down menu:</li>
<li>A popup window will open. Go to <strong>Options </strong>and change the <strong>Collation</strong> to Cyrillic_General_100_CI_AS:<br /> <br /> The reason we do this is so that <strong>Cyrillic characters </strong>show up properly.<br /> Then go back to <strong>General</strong>, type in &ldquo;Bank&rdquo; as the <strong>Database name</strong> and click [<strong>OK</strong>]:</li>
</ul>
<h2>2.&nbsp;&nbsp; Create Tables</h2>
<ul>
<li>Using an <strong>SQL query</strong>, create table Clients with the following properties:</li>
<li>Id &ndash; unique <strong>number</strong> for every client (<strong>auto-incremented</strong>, <strong>primary key</strong>)</li>
<li>FirstName &ndash; the <strong>name</strong> of the user, which will be no more than <strong>50 Unicode characters</strong> (<strong>Cannot</strong> be null).</li>
<li>LastName &ndash; has the <strong>same properties</strong> as FirstName</li>
</ul>
<table>
<tbody>
<tr>
<td width="299">
<p>CREATE TABLE Clients (</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id INT PRIMARY KEY IDENTITY,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FirstName NVARCHAR(50) NOT NULL,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LastName NVARCHAR(50) NOT NULL</p>
<p>)</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Create table AccountType with:</li>
<li>Id &ndash; unique number for every type. (Auto incremented, primary key)</li>
<li>Name &ndash; the name of the account type, no longer than <strong>50 Unicode characters </strong>(<strong>Cannot</strong> be null)</li>
</ul>
<p><strong><em>Important: Don&rsquo;t forget to select the query you want to run before clicking Execute (F5) if you have multiple queries!</em></strong></p>
<table>
<tbody>
<tr>
<td width="267">
<p>CREATE TABLE AccountTypes (</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id INT PRIMARY KEY IDENTITY,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [Name] NVARCHAR(50) NOT NULL</p>
<p>)</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>Create table <strong>Accounts</strong> with:</li>
<li>Id - <strong>unique number</strong> for every user. (<strong>Auto incremented</strong>, <strong>primary key</strong>)</li>
<li>AccountTypeId &ndash; references the <strong>AccountTypes</strong> table (<strong>foreign key</strong>)</li>
<li>Balance &ndash; decimal data type with up to 15 digits including 2 after the decimal point and a default value of 0 (Not null)</li>
<li>ClientId &ndash; references the Clients table (foreign key)</li>
</ul>
<table width="525">
<tbody>
<tr>
<td width="525">
<p>CREATE TABLE Accounts (</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id INT PRIMARY KEY IDENTITY,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AccountTypeId INT FOREIGN KEY REFERENCES AccountTypes(Id),</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ClientId INT FOREIGN KEY REFERENCES Clients(Id)</p>
<p>)</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Insert Sample Data into Database</h2>
<p>We need some data to work with, so let&rsquo;s use INSERT INTO (&hellip;) VALUES (&hellip;) queries to fill our tables:</p>
<table>
<tbody>
<tr>
<td width="462">
<p>INSERT INTO Clients (FirstName, LastName) VALUES</p>
<p>('Gosho', 'Ivanov'),</p>
<p>('Pesho', 'Petrov'),</p>
<p>('Ivan', 'Iliev'),</p>
<p>('Merry', 'Ivanova')</p>
<p>&nbsp;</p>
<p>INSERT INTO AccountTypes (Name) VALUES</p>
<p>('Checking'),</p>
<p>('Savings')</p>
<p>&nbsp;</p>
<p>INSERT INTO Accounts (ClientId, AccountTypeId, Balance) VALUES</p>
<p>(1, 1, 175),</p>
<p>(2, 1, 275.56),</p>
<p>(3, 1, 138.01),</p>
<p>(4, 1, 40.30),</p>
<p>(4, 2, 375.50)</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Create a View</h2>
<p>Next, we&rsquo;re going to create a <strong>view</strong>, which displays the <strong>owner</strong>, <strong>type</strong> and <strong>balance</strong> of <strong>each account</strong> in our database:</p>
<table>
<tbody>
<tr>
<td width="514">
<p>CREATE VIEW v_ClientBalances AS</p>
<p>SELECT (FirstName + ' ' + LastName) AS [Name],</p>
<p>&nbsp; (AccountTypes.Name) AS [Account Type], Balance</p>
<p>FROM Clients</p>
<p>JOIN Accounts ON Clients.Id = Accounts.ClientId</p>
<p>JOIN AccountTypes ON AccountTypes.Id = Accounts.AccountTypeId</p>
</td>
</tr>
</tbody>
</table>
<p>We concatenated FirstName and LastName into a <strong>new column</strong>, called <strong>Name</strong> and took the <strong>Account Type </strong>and</p>
<p><strong>Balance</strong> for <strong>every account</strong> by <strong>joining</strong> the tables Clients<strong>, </strong>Accounts and AccountTypes to access <strong>data from all of them</strong>. Joining tables will be explained in more detail later into our course.</p>
<p>Now, if we <strong>select </strong>everything (*) from this view we will receive this:</p>
<h2>5.&nbsp;&nbsp; Create a Function</h2>
<p>Now let&rsquo;s create a <strong>function</strong>, which <strong>calculates</strong> the <strong>total balance</strong> from <strong>all accounts</strong> of a single <strong>client</strong>. Functions in <strong>SQL </strong>receive <strong>parameters</strong>, complete certain actions with them and <strong>always</strong> return a <strong>result</strong>. Our <strong>function </strong>will receive an int, called @ClientID and return a DECIMAL. It could look like this:</p>
<table>
<tbody>
<tr>
<td width="466">
<p>CREATE FUNCTION f_CalculateTotalBalance (@ClientID INT)</p>
<p>RETURNS DECIMAL(15, 2)</p>
<p>BEGIN</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DECLARE @result AS DECIMAL(15, 2) = (</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; SELECT SUM(Balance)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; FROM Accounts WHERE ClientId = @ClientID</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; )&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp; RETURN @result</p>
<p>END</p>
</td>
</tr>
</tbody>
</table>
<p>Now try and <strong>select</strong> the <strong>function</strong>, giving it an existing <strong>client ID </strong>as the <strong>parameter</strong>, example for <strong>client ID </strong><strong>&egrave; 4</strong>:</p>
<table>
<tbody>
<tr>
<td width="409">
<p>SELECT dbo.f_CalculateTotalBalance(4) AS Balance</p>
</td>
</tr>
</tbody>
</table>
<p>Notice the dbo. before the function name &ndash; this is the name of the <strong>schema </strong>which we <strong>must</strong> type when calling <strong>functions</strong>.</p>
<h2>6.&nbsp;&nbsp; Create Procedures</h2>
<p>Next, we&rsquo;ll create a <strong>procedure</strong> that creates a <strong>new account</strong> for an <strong>existing client</strong>. Just like functions, <strong>procedures </strong>receive <strong>parameters</strong>, but <strong>do not return</strong> results. Our <strong>procedure</strong> will receive @ClientID and @AccountTypeID as <strong>parameters</strong> and will look like this:</p>
<table>
<tbody>
<tr>
<td width="514">
<p>CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS</p>
<p>INSERT INTO Accounts (ClientId, AccountTypeId)</p>
<p>VALUES (@ClientId, @AccountTypeId)</p>
</td>
</tr>
</tbody>
</table>
<p>Now we can <strong>create</strong> a new savings <strong>account</strong> for our <strong>client</strong> with <strong>ID = 2</strong> like this:</p>
<table>
<tbody>
<tr>
<td width="159">
<p>p_AddAccount 2, 2</p>
</td>
</tr>
</tbody>
</table>
<p>After you <strong>execute the procedure</strong> a couple of times, don&rsquo;t forget to <strong>check</strong> if an account is <strong>added correctly</strong>, using a SELECT statement:</p>
<table>
<tbody>
<tr>
<td width="199">
<p>SELECT * FROM Accounts</p>
</td>
</tr>
</tbody>
</table>
<p>Let&rsquo;s create <strong>two</strong> more <strong>procedures</strong> to <strong>deposit</strong> and <strong>withdraw </strong>money from the <strong>accounts</strong>.</p>
<h3>Deposit Procedure</h3>
<p>The <strong>deposit procedure</strong> will always <strong>add</strong> our <strong>input amount</strong> to the <strong>current balance</strong>:</p>
<table>
<tbody>
<tr>
<td width="695">
<p>CREATE PROC p_Deposit @AccountId INT, @Amount DECIMAL(15, 2) AS</p>
<p>UPDATE Accounts</p>
<p>SET Balance += @Amount</p>
<p>WHERE Id = @AccountId</p>
</td>
</tr>
</tbody>
</table>
<h3>Withdraw Procedure</h3>
<p>The <strong>withdraw procedure</strong> will <strong>subtract</strong> the given <strong>amount</strong> of money from the account <strong>if the balance is enough</strong> and <strong>return an error message if it isn&rsquo;t</strong>:</p>
<table>
<tbody>
<tr>
<td width="695">
<p>CREATE PROC p_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS</p>
<p>BEGIN</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DECLARE @OldBalance DECIMAL(15, 2)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; IF (@OldBalance - @Amount &gt;= 0)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BEGIN</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UPDATE Accounts</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SET Balance -= @Amount</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; WHERE Id = @AccountId</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; END</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ELSE</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BEGIN</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RAISERROR('Insufficient funds', 10, 1)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; END</p>
<p>END</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Create Transactions Table and a Trigger</h2>
<p>Our bank will need a way to <strong>record transactions</strong> done by its <strong>clients</strong>, so we are now going to create a <strong>new table</strong> and a <strong>trigger</strong>, which will <strong>automatically</strong> record the <strong>date</strong>, <strong>time</strong> and <strong>amount transferred</strong> into the table.</p>
<p>We will name the table Transactions and it will have:</p>
<ul>
<li>Id &ndash; unique <strong>number</strong> for every <strong>transaction</strong>. (<strong>auto-incremented</strong>, <strong>primary key</strong>)</li>
<li>AccountId &ndash; references the Accounts table (<strong>foreign key</strong>)</li>
<li>OldBalance &ndash; the balance <strong>before</strong> the transaction</li>
<li>NewBalance &ndash; the balance <strong>after</strong> the transaction</li>
<li>Amount &ndash; the amount transferred (<strong>calculated</strong> column)</li>
<li>DateTime &ndash; the date and time of the transaction (as datetime2 data type)</li>
</ul>
<p>Let&rsquo;s create the <strong>table</strong>:</p>
<table>
<tbody>
<tr>
<td width="445">
<p>CREATE TABLE Transactions (</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id INT PRIMARY KEY IDENTITY,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AccountId INT FOREIGN KEY REFERENCES Accounts(Id),</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OldBalance DECIMAL(15, 2) NOT NULL,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NewBalance DECIMAL(15, 2) NOT NULL,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Amount AS NewBalance - OldBalance,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [DateTime] DATETIME2</p>
<p>)</p>
</td>
</tr>
</tbody>
</table>
<p>Now we can create our <strong>trigger</strong>, which will run whenever the Accounts table is <strong>updated </strong>by the <strong>procedures </strong>(or regular UPDATE statements), like this:</p>
<table width="670">
<tbody>
<tr>
<td width="670">
<p>CREATE TRIGGER tr_Transaction ON Accounts</p>
<p>AFTER UPDATE</p>
<p>AS</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; INSERT INTO Transactions (AccountId, OldBalance, NewBalance, [DateTime])</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SELECT inserted.Id, deleted.Balance, inserted.Balance, GETDATE() FROM inserted</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; JOIN deleted ON inserted.Id = deleted.Id</p>
</td>
</tr>
</tbody>
</table>
<p>We used the <strong>built in </strong>deleted and inserted tables to get the OldBalance and NewBalance values.</p>
<p>Next, let&rsquo;s do some <strong>transactions</strong>, which should <strong>run</strong> our <strong>trigger</strong>:</p>
<table>
<tbody>
<tr>
<td width="184">
<p>p_Deposit 1, 25.00</p>
<p>GO</p>
<p>&nbsp;</p>
<p>p_Deposit 1, 40.00</p>
<p>GO</p>
<p>&nbsp;</p>
<p>p_Withdraw 2, 200.00</p>
<p>GO</p>
<p>&nbsp;</p>
<p>p_Deposit 4, 180.00</p>
<p>GO</p>
</td>
</tr>
</tbody>
</table>
<p>And finally, let&rsquo;s take a look at our Transactions<strong> table</strong> to make sure our <strong>trigger</strong> is working:</p>
<table>
<tbody>
<tr>
<td width="231">
<p>SELECT * FROM Transactions</p>
</td>
</tr>
</tbody>
</table>
<p>The result should be something like this:</p>