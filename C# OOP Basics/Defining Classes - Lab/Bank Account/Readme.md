<h1>Lab: Defining Classes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017">"C# OOP Basics" course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/674/Defining-Classes-Lab">https://judge.softuni.bg/Contests/674/Defining-Classes-Lab</a></p>
<h1>Part I: Defining Classes</h1>
<h2>1.&nbsp;&nbsp; Define Bank Account Class</h2>
<p>Create a class named BankAccount.</p>
<p>The class should have private fields for:</p>
<ul>
<li>id: int</li>
<li>balance: double</li>
</ul>
<p>The class should also have public properties for:</p>
<ul>
<li>ID:int</li>
<li>Balance:double</li>
</ul>
<h3>Solution</h3>
<p>Create a <strong>new class</strong> and ensure <strong>proper naming</strong></p>
<h2>2.&nbsp;&nbsp; Methods</h2>
<p>Create a class BankAccount (you can use class from previous task)</p>
<p>The class should have private fields for:</p>
<ul>
<li>id: int</li>
<li>balance: double</li>
</ul>
<p>The class should also have properties for:</p>
<ul>
<li>ID:int</li>
<li>Balance:double</li>
<li>Deposit(Double amount):void</li>
<li>Withdraw(Double amount):void</li>
</ul>
<p>Override the method ToString().</p>
<h3>Solution</h3>
<p>Create a method Deposit(double amount)</p>
<p>Create a method Withdraw(double amount)</p>
<p>Override the method toString()</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Test Client</h2>
<p>Create a test client that tests your BankAccount class.</p>
<p>Support the <strong>following commands</strong>:</p>
<ul>
<li><strong>Create {Id}</strong></li>
<li><strong>Deposit {Id} {Amount}</strong></li>
<li><strong>Withdraw {Id} {Amount}</strong></li>
<li><strong>Print {Id}</strong></li>
<li><strong>End</strong></li>
</ul>
<p>If you try to create an account with existing Id, print <strong>"Account already exists"</strong>.</p>
<p>If you try to perform an operation on <strong>non-existing account</strong> with existing Id, print <strong>"Account does not exist"</strong>.</p>
<p>If you try to withdraw an amount larger than the balance, print <strong>"Insufficient balance"</strong>.</p>
<p>The Print command should print <strong>"Account ID{id}, balance {balance}"</strong>. Round the balance to the second digit after the decimal separator.</p>
<h3>Examples</h3>
<table width="353">
<tbody>
<tr>
<td width="124">
<p><strong>Input</strong></p>
</td>
<td width="229">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="124">
<p>Create 1</p>
<p>Create 1</p>
<p>Deposit 1 20</p>
<p>Withdraw 1 30</p>
<p>Withdraw 1 10</p>
<p>Print 1</p>
<p>End</p>
</td>
<td width="229">
<p>Account already exists</p>
<p>Insufficient balance</p>
<p>Account ID1, balance 10.00</p>
</td>
</tr>
<tr>
<td width="124">
<p>Create 1</p>
<p>Deposit 2 20</p>
<p>Withdraw 2 30</p>
<p>Print 2</p>
<p>End</p>
</td>
<td width="229">
<p>Account does not exist</p>
<p>Account does not exist</p>
<p>Account does not exist</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>Create a Dictionary&lt;int, BankAccount&gt; to store existing accounts</p>
<p>&nbsp;</p>
<p>Create the input loop</p>
<p>Check the <strong>type of command</strong> and <strong>execute</strong> accordingly (<strong><em>optional:</em></strong><em> you can create a separate method for each command</em>)</p>
<p>Implement the Create command</p>
<p>Implement the rest of the commands following the same logic</p>
<h2>4.&nbsp;&nbsp; Define Person Class</h2>
<p>Create a <strong>Person</strong> class.</p>
<p>The class should have <strong>private fields</strong> for:</p>
<ul>
<li>Name: <strong>string</strong></li>
<li>Age: <strong>int</strong></li>
<li>Accounts: List&lt;BankAccount&gt;</li>
</ul>
<p>The class should have <strong>constructors</strong>:</p>
<ul>
<li>Person(string name, int age)</li>
<li>Person(string name, int age, List&lt;BankAccount&gt; accounts)</li>
</ul>
<p>The class should also have <strong>public methods</strong> for:</p>
<ul>
<li>GetBalance():double</li>
</ul>
<h3>Solution</h3>
<p>Create the class as usual</p>
<p>Create a constructor with two parameters</p>
<p>Create a constructor with three parameters</p>
<p>Create method GetBalance()</p>
<p><strong><em>Optional:</em></strong> You can take advantage of <strong>constructor chaining</strong></p>
<p>&nbsp;</p>