<h1>Exercises: Inheritance</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017">"C# DB Advanced" course @ Software University</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Person</h2>
<p>You are asked to model an application for storing data about people. You should be able to have a person and a child. The child is derived of the person. Your task is to model the application. The only constraints are:</p>
<ul>
<li>People&rsquo;s <strong>names</strong> should be at least <strong>3 symbols</strong> long</li>
<li>People should <strong>not</strong> be able to have <strong>negative age</strong></li>
<li>Children should <strong>not</strong> be able to have age <strong>more than 15</strong></li>
<li><strong>Person</strong> &ndash; represents the base class by which all others are implemented</li>
<li><strong>Child</strong> &ndash; represents a class, which is derived from the</li>
</ul>
<h3>Note</h3>
<p>Your class&rsquo;s names <strong>MUST</strong> be the same as the names shown above!!!</p>
<p>Use this Main() method to test your solution locally and in Judge:</p>
<table width="520">
<tbody>
<tr>
<td width="520">
<p><strong>Main()</strong></p>
</td>
</tr>
<tr>
<td width="520">
<p>static void Main()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; string name = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp; int age = int.Parse(Console.ReadLine());</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; try</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Child child = new Child(name, age);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(child);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; catch (ArgumentException ae)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(ae.Message);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
<p>Create a new empty class and name it <strong>Person</strong>. Set its access modifier to <strong>public </strong>so it can be instantiated from any project. Every person has a name, and age.</p>
<table width="528">
<tbody>
<tr>
<td width="528">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="528">
<p>public class Person</p>
<p>{</p>
<p>&nbsp;&nbsp; // 1. Add Fields</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp; // 2. Add Constructor</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp; // 3. Add Properties</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp; // 4. Add Methods</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 2 &ndash; Define the fields</h3>
<p>Define a <strong>field</strong> for each property the class should have (e.g. <strong>Name</strong>, <strong>Age</strong>)</p>
<h3>Step 3 - Define the Properties of a Person</h3>
<p>Define the <strong>Name</strong> and <strong>Age</strong> properties of a Person. Ensure that they can only be <strong>changed by the class itself</strong><strong> or its descendants</strong> (pick the most appropriate access modifier).</p>
<table width="331">
<tbody>
<tr>
<td width="331">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="331">
<p>public virtual string Name</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
<p>&nbsp;</p>
<p>public virtual int Age</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO</p>
&nbsp;&nbsp;&nbsp; }}</td>
</tr>
</tbody>
</table>
<h3>Step 4 - Define a Constructor</h3>
<p>Define a constructor that accepts <strong>name and age</strong>.</p>
<table width="341">
<tbody>
<tr>
<td width="341">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="341">
<p>public Person(string name, int age)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; this.Name = name;</p>
<p>&nbsp;&nbsp;&nbsp; this.Age = age;</p>
}</td>
</tr>
</tbody>
</table>
<h3>Step 5 - Perform Validations</h3>
<p>After you have created a <strong>field</strong> for each property (e.g. <strong>Name</strong> and <strong>Age</strong>). Next step is to <strong>perform validations</strong> for each one. The <strong>getter should return the corresponding field&rsquo;s value</strong> and the <strong>setter should validate</strong> the input data before setting it. Do this for each property.</p>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>public int Age</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return this.age;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; if (value &lt; 0)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; throw new ArgumentException("Age must be positive!");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO set field age with value</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
<h3>Constraints</h3>
<ul>
<li>If the age of a person is negative &ndash; exception&rsquo;s message is: <strong>"Age must be positive!"</strong></li>
<li>If the age of a child is bigger than 15 &ndash; exception&rsquo;s message is: <strong>"Child</strong><strong>'</strong><strong>s age must be less than 15!</strong><strong>"</strong></li>
<li>If the name of a child or a person is no longer than 3 symbols &ndash; exception&rsquo;s message is: <strong>"Name's length should not be less than 3 symbols!"</strong></li>
</ul>
<h3>Step 6 - Override ToString()</h3>
<p>As you probably already know, all classes in C# inherit the <strong>Object</strong> class and therefore have all its <strong>public</strong> members (<strong>T</strong><strong>oString()</strong>, <strong>E</strong><strong>quals()</strong> and <strong>G</strong><strong>etHashCode()</strong> methods). <strong>T</strong><strong>oString()</strong> serves to return information about an instance as string. Let's <strong>override</strong> (change) its behavior for our <strong>Person</strong> class.</p>
<table width="501">
<tbody>
<tr>
<td width="501">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="501">
<p>public override string ToString()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; return $"Name: {this.Name}, Age: {this.Age}";</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>And voila! If everything is correct, we can now create <strong>Person objects</strong> and display information about them.</p>
<h3>Step 7 &ndash; Create a Child</h3>
<p>Create a <strong>Child </strong>class that inherits <strong>Person</strong> and has the same constructor definition. However, do not copy the code from the Person class - <strong>reuse the Person class&rsquo;s constructor</strong>.</p>
<table width="330">
<tbody>
<tr>
<td width="330">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="330">
<p>public Child(string name, int age)</p>
<p>&nbsp;&nbsp;&nbsp; : base(name, age)</p>
<p>{</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>There is <strong>no need</strong> to rewrite the Name and Age properties since <strong>Child</strong> inherits <strong>Person </strong>and by default has them.</p>
<h3>Step 8 &ndash; Validate the Child&rsquo;s setter</h3>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>public new int Age</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return base.Age;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO validate childs age</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; base.Age = value;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Book Shop</h2>
<p>You are working in a library and you don&rsquo;t want to write descriptions for books by hand, so you wish to use a computer to speed up the process. The task is simple - your program should have two classes &ndash; one for the ordinary books &ndash; <strong>Book</strong>, and another for the special ones &ndash; <strong>GoldenEditionBook</strong>. So let&rsquo;s get started! We need two classes:</p>
<ul>
<li><strong>Book</strong> - represents a book that holds <strong>title</strong>, <strong>author </strong>and <strong>price</strong>. A book should offer <strong>information</strong> about itself in the format shown in the output below.</li>
<li><strong>GoldenEditionBook</strong> - represents a special book holds the same properties as any <strong>Book</strong>, but its <strong>price</strong> is always <strong>30% higher</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>If the author&rsquo;s second name is starting with a digit &ndash; the exception message is <strong>"Author not valid!"</strong></li>
<li>If the title&rsquo;s length is less than 3 symbols &ndash; the exception message is <strong>"Title not valid!"</strong></li>
<li>If the price is zero or it is negative &ndash; the exception message is <strong>"Price not valid!"</strong></li>
<li>Price must be formatted to <strong>two</strong> symbols after the decimal separator</li>
</ul>
<p>Use this Main() method to test your solution locally and in Judge:</p>
<table width="678">
<tbody>
<tr>
<td width="678">
<p><strong>Main()</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>static void Main()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; try</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; string author = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; string title = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; decimal price = decimal.Parse(Console.ReadLine());</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Book book = new Book(author, title, price);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(book + Environment.NewLine);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(goldenEditionBook);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; catch (ArgumentException ae)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(ae.Message);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<table width="382">
<tbody>
<tr>
<td width="175">
<p><strong>Input</strong></p>
</td>
<td width="207">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="175">
<p>Ivo 4ndonov</p>
<p>Under Cover</p>
<p>9999999999999999999</p>
</td>
<td width="207">
<p>Author not valid!</p>
</td>
</tr>
<tr>
<td width="175">
<p>Petur Ivanov</p>
<p>Life of Pesho</p>
<p>20</p>
</td>
<td width="207">
<p>Type: Book</p>
<p>Title: Life of Pesho</p>
<p>Author: Petur Ivanov</p>
<p>Price: 20.00</p>
<p>&nbsp;</p>
<p>Type: GoldenEditionBook</p>
<p>Title: Life of Pesho</p>
<p>Author: Petur Ivanov</p>
<p>Price: 26.00</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 1 - Create a Book Class</h3>
<p>Create a new empty class and name it <strong>Book</strong>. Set its access modifier to <strong>public </strong>so it can be instantiated from any project.</p>
<table width="256">
<tbody>
<tr>
<td width="256">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>public class Book</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //1. Add Fields</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; //2. Add Constructors</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; //3. Add Properties</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; //4. Add Methods</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 2 - Define the Properties of a Book</h3>
<p>Define the <strong>Title</strong>, <strong>Author</strong> and <strong>Price</strong> properties of a Book. Ensure that they can only be <strong>changed by the class itself or its descendants</strong> (pick the most appropriate access modifier).</p>
<h3>Step 3 - Define a Constructor</h3>
<p>Define a constructor that accepts <strong>author, title</strong> and <strong>price</strong> arguments.</p>
<table width="669">
<tbody>
<tr>
<td width="669">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="669">
<p>public Book(string author, string title, decimal price)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.Author = author;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.Title = title;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.Price = price;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
</td>
</tr>
</tbody>
</table>
<h3>Step 4 - Perform Validations</h3>
<p>Create a <strong>field</strong> for each property (<strong>Price</strong>, <strong>Title</strong> and <strong>Author</strong>) and <strong>perform validations</strong> for each one. The <strong>getter should return the corresponding field</strong> and the <strong>setter should validate</strong> the input data before setting it. Do this for every property.</p>
<table width="661">
<tbody>
<tr>
<td width="661">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="661">
<p>public string Author</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return this.author;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO validate value</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.author = value;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string Title</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return this.title;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO validate value</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.title = value;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>public virtual decimal Price</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; get</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return this.price;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; set</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //TODO validate value</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.price = value;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Step 5 - Override ToString()</h3>
<p>We already mentioned that all classes in C# inherit the <strong>System.Object</strong> class and therefore have all its <strong>public</strong> members. Let's <strong>override</strong> (change) &nbsp;the <strong>ToString()</strong> method&rsquo;s behavior again acordingly our <strong>Book</strong> class&rsquo;s data.</p>
<table width="675">
<tbody>
<tr>
<td width="675">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="675">
<p>public override string ToString()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; return $"Type: {this.GetType().Name}" + Environment.NewLine +</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $"Title: {this.Title}" + Environment.NewLine +</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $"Author: {this.Author}" + Environment.NewLine +</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $"Price: {this.Price:f2}";</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>And voila! If everything is correct, we can now create <strong>Book objects</strong> and display information about them.</p>
<h3>Step 6 &ndash; Create a GoldenEditionBook</h3>
<p>Create a <strong>GoldenEditionBook </strong>class that inherits <strong>Book</strong> and has the same constructor definition. However, do not copy the code from the Book class - <strong>reuse the Book class constructor</strong>. Inside your new constructor set the price to a <strong>30% higher</strong> value.</p>
<table width="675">
<tbody>
<tr>
<td width="675">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="675">
<p>public GoldenEditionBook(string title, string author, decimal price)</p>
<p>&nbsp;&nbsp;&nbsp; :base(title, author, price)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; this.Price *= 1.3m;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>There is <strong>no need</strong> to rewrite the Price, Title and Author properties since <strong>GoldenEditionBook</strong> inherits <strong>Book </strong>and by default has them.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mankind</h2>
<p>Your task is to model an application. It is very simple. The mandatory models of our application are 3:&nbsp; Human, Worker and Student.</p>
<p>The parent class &ndash; Human should have <strong>first name</strong> and <strong>last name</strong>. Every student has a <strong>faculty number</strong>. Every worker has a <strong>week salary</strong> and <strong>work hours per day</strong>. It should be able to calculate the money he earns by hour. You can see the constraints below.</p>
<h3>Input</h3>
<p>On the first input line you will be given info about a single student - a name and faculty number.</p>
<p>On the second input line you will be given info about a single worker - first name, last name, salary and working hours.</p>
<h3>Output</h3>
<p>You should first print the info about the student following a single blank line and the info about the worker in the given formats:</p>
<ul>
<li>Print the student info in the following format:</li>
</ul>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>First Name: {student's first name}</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last Name: {student's last name}</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Faculty number: {student's faculty number}</strong></p>
<p><strong>&nbsp;</strong></p>
<ul>
<li>Print the worker info in the following format:</li>
</ul>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; First Name: {worker's first name}</strong></p>
<p><strong>Last Name: {worker's second name}</strong></p>
<p><strong>Week Salary: {worker's salary}</strong></p>
<p><strong>Hours per day: {worker's working hours}</strong></p>
<p><strong>Salary per hour: {worker's salary per hour}</strong></p>
<p>All numeric values will be <strong>real numbers</strong>, even the working hours. Use the most appropriate data type for each of them.</p>
<p>Print exactly<strong> two digits</strong> after every numeric value's decimal separator (e.g. 10.00). Consider the workweek from Monday to Friday. A faculty number should be consisted only of digits and letters.</p>
<h3>Constraints</h3>
<table width="737">
<tbody>
<tr>
<td width="132">
<p><strong>Parameter</strong></p>
</td>
<td width="208">
<p><strong>Constraint</strong></p>
</td>
<td width="397">
<p><strong>Exception Message</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Human first name</p>
</td>
<td width="208">
<p>Should start with a capital letter</p>
</td>
<td width="397">
<p>"Expected upper case letter! Argument: firstName"</p>
</td>
</tr>
<tr>
<td width="132">
<p>Human first name</p>
</td>
<td width="208">
<p>Should be more than 3 symbols</p>
</td>
<td width="397">
<p>"Expected length at least 4 symbols! Argument: firstName"</p>
</td>
</tr>
<tr>
<td width="132">
<p>Human last name</p>
</td>
<td width="208">
<p>Should start with a capital letter</p>
</td>
<td width="397">
<p>"Expected upper case letter! Argument: lastName"</p>
</td>
</tr>
<tr>
<td width="132">
<p>Human last name</p>
</td>
<td width="208">
<p>Should be more than 2 symbols</p>
</td>
<td width="397">
<p>"Expected length at least 3 symbols! Argument: lastName "</p>
</td>
</tr>
<tr>
<td width="132">
<p>Faculty number</p>
</td>
<td width="208">
<p>Should be in range [5..10] symbols</p>
</td>
<td width="397">
<p>"Invalid faculty number!"</p>
</td>
</tr>
<tr>
<td width="132">
<p>Week salary</p>
</td>
<td width="208">
<p>Should be more than 10</p>
</td>
<td width="397">
<p>"Expected value mismatch! Argument: weekSalary"</p>
</td>
</tr>
<tr>
<td width="132">
<p>Working hours</p>
</td>
<td width="208">
<p>Should be in the range [1..12]</p>
</td>
<td width="397">
<p>"Expected value mismatch! Argument: workHoursPerDay"</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<table width="624">
<tbody>
<tr>
<td width="191">
<p><strong>Input</strong></p>
</td>
<td width="433">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="191">
<p>Ivan Ivanov 08</p>
<p>Pesho Kirov 1590 10</p>
</td>
<td width="433">
<p>Invalid faculty number!</p>
</td>
</tr>
<tr>
<td width="191">
<p>Stefo Mk321 0812111</p>
<p>Ivcho Ivanov 1590 10</p>
</td>
<td width="433">
<p>First Name: Stefo</p>
<p>Last Name: Mk321</p>
<p>Faculty number: 0812111</p>
<p>&nbsp;</p>
<p>First Name: Ivcho</p>
<p>Last Name: Ivanov</p>
<p>Week Salary: 1590.00</p>
<p>Hours per day: 10.00</p>
<p>Salary per hour: 31.80</p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>