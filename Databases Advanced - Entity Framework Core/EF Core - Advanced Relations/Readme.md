<h1>Exercises: Advanced Relations</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Bills Payment System</h2>
<p>Your task is to create a database for <strong>Bills Payment System</strong>, using the <strong>Code First </strong>approach. In the database, we should keep information about the <strong>users</strong> (<strong>first name, last name, email, password, payment methods</strong>). Every <strong>payment method</strong> should have an <strong>id</strong>, an <strong>owner</strong>, a <strong>type</strong> and a <strong>credit</strong> <strong>card</strong> or a <strong>bank</strong> <strong>account</strong> connected to it. There are <strong>two types</strong> of billing details &ndash; <strong>credit card</strong> and <strong>bank account</strong>. The credit card has <strong>expiration date</strong>, a<strong> limit </strong>and an amount of<strong> money owed</strong>. The <strong>bank</strong> <strong>account</strong> has a <strong>balance</strong>, a <strong>bank name</strong> and a <strong>SWIFT</strong> <strong>code</strong>.</p>
<p>Create the configuration of each model in a new class, implementing the IEntityTypeConfiguration interface. Your solution should look similar to this:</p>
<h3>Constraints</h3>
<p>Your <strong>namespaces</strong> should be:</p>
<ul>
<li>P01_BillsPaymentSystem &ndash; for your Startup class, if you have one</li>
<li>Data &ndash; for your DbContext</li>
<li>Data.Models &ndash; for your models</li>
</ul>
<p>Your <strong>models</strong> should be:</p>
<ul>
<li>BillsPaymentSystemContext &ndash; your DbContext</li>
<li>User:
<ul>
<li>UserId</li>
<li>FirstName (up to 50 characters, unicode)</li>
<li>LastName (up to 50 characters, unicode)</li>
<li>Email (up to 80 characters, non-unicode)</li>
<li>Password (up to 25 characters, non-unicode)</li>
</ul>
</li>
<li>CreditCard:
<ul>
<li>CreditCardId</li>
<li>Limit</li>
<li>MoneyOwed</li>
<li>LimitLeft (calculated property, not included in the database)</li>
<li>ExpirationDate</li>
</ul>
</li>
<li>BankAccount:
<ul>
<li>BankAccountId</li>
<li>Balance</li>
<li>BankName (up to 50 characters, unicode)</li>
<li>SWIFT Code (up to 20 characters, non-unicode)</li>
</ul>
</li>
<li>PaymentMethod:
<ul>
<li>Id - PK</li>
<li>Type &ndash; enum (BankAccount, CreditCard)</li>
<li>UserId</li>
<li>BankAccountId</li>
<li>CreditCardId</li>
</ul>
</li>
</ul>
<p><strong>Everything</strong> is required! Only <strong>PaymentMethod</strong>&rsquo;s <strong>BankAccountId</strong> and <strong>CreditCardId </strong>should be <strong>nullable</strong>, and you should make sure that always <strong>one</strong> of them <strong>is</strong> <strong>null</strong> and the <strong>other</strong> <strong>one</strong> is <strong>not </strong>(add a <strong>CHECK</strong> constraint).</p>
<p>Make sure that <strong>every</strong> <strong>record</strong> in the <strong>PaymentMethods</strong> table has a unique combination of <strong>UserId</strong>, <strong>BankAccountId</strong> and <strong>CreditCardId</strong>!</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Seed Some Data</h2>
<p>Make a <strong>Seed</strong>() method to seed some data into the <strong>BillsPaymentSystem</strong> database.</p>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; User Details</h2>
<p>Create a <strong>console</strong> <strong>app</strong> that retrieves from the database a <strong>user</strong> and all of his <strong>payment</strong> <strong>methods </strong>by a given<strong> user id</strong>, and prints them on the console in the format:</p>
<table>
<tbody>
<tr>
<td width="710">
<p>User: Guy Gilbert</p>
<p>Bank Accounts:</p>
<p>-- ID: 1</p>
<p>--- Balance: 2000.00</p>
<p>--- Bank: Unicredit Bulbank</p>
<p>--- SWIFT: UNCRBGSF</p>
<p>-- ID: 2</p>
<p>--- Balance: 1000.00</p>
<p>--- Bank: First Investment Bank</p>
<p>--- SWIFT: FINVBGSF</p>
<p>Credit Cards:</p>
<p>-- ID: 1</p>
<p>--- Limit: 800.00</p>
<p>--- Money Owed: 100.00</p>
<p>--- Limit Left:: 700.00</p>
<p>--- Expiration Date: 2020/03</p>
</td>
</tr>
</tbody>
</table>
<p>First, list the user&rsquo;s <strong>bank</strong> <strong>accounts</strong> and then &ndash; his <strong>credit</strong> <strong>cards</strong>. If <strong>no</strong> such <strong>user</strong> exist, print "User with id {<strong>userId</strong>} not found!" instead.</p>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Pay Bills</h2>
<p>Add <strong>Withdraw</strong>() and <strong>Deposit</strong>() methods to the <strong>BankAccount</strong> and <strong>CreditCard</strong> classes, and make sure they are the only way you can change the <strong>Balance</strong>, <strong>MoneyOwed</strong> and <strong>Limit</strong> properties. Then create a <strong>PayBills</strong>(int userId, decimal amount) method that uses all of a user&rsquo;s payment methods to pay his bills. Start with his <strong>bank</strong> <strong>accounts</strong>, ordered by id, and then his <strong>credit</strong> <strong>cards</strong>, ordered by<strong> id</strong>. If the user doesn&rsquo;t have enough money available, don&rsquo;t withdraw anything and print "Insufficient funds!" to the console.</p>