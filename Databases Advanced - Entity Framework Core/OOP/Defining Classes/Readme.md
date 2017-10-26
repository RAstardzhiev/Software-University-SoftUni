<h1>Exercises: Defining Classes</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"CSharp DB Advanced" course @ Software University</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Define a class Person</h2>
<p>Define a class<strong> Person</strong> with <strong>public</strong> properties for <strong>Name</strong> and <strong>Age</strong>.</p>
<h3>Note</h3>
<p>Add the following code to your main method and submit it to Judge.</p>
<table width="408">
<tbody>
<tr>
<td width="408">
<p>static void Main(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Type personType = typeof(Person);</p>
<p>&nbsp;&nbsp;&nbsp; PropertyInfo[] properties = personType.GetProperties</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (BindingFlags.Public | BindingFlags.Instance);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(properties.Length);</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>If you defined the class correctly, the test should pass.</p>
<h3>Bonus*</h3>
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
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Creating Constructors</h2>
<p>Add 3 constructors to the <strong>Person</strong> class from the last task, use constructor chaining to reuse code:</p>
<ol>
<li>The first should take <strong>no arguments</strong> and produce a person with <strong>name</strong> &ldquo;<strong>No name</strong>&rdquo; and <strong>age</strong> = <strong>1</strong>.</li>
<li>The second should accept only <strong>an</strong> <strong>integer</strong> <strong>number</strong> for the <strong>age</strong> and produce a person with <strong>name</strong> &ldquo;<strong>No name</strong>&rdquo; and <strong>age</strong> equal to the passed parameter.</li>
<li>The third one should accept a <strong>string</strong> for the name and an <strong>integer</strong> for the age and should produce a person with the given <strong>name</strong> and <strong>age</strong>.</li>
</ol>
<p>Add the following code to your main method and submit it to Judge.</p>
<table width="721">
<tbody>
<tr>
<td width="721">
<p>Type personType = typeof(Person);</p>
<p>ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });</p>
<p>ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });</p>
<p>ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });</p>
<p>bool swapped = false;</p>
<p>if (nameAgeCtor == null)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });</p>
<p>&nbsp;&nbsp;&nbsp; swapped = true;</p>
<p>}</p>
<p>&nbsp;</p>
<p>string name = Console.ReadLine();</p>
<p>int age = int.Parse(Console.ReadLine());</p>
<p>&nbsp;</p>
<p>Person basePerson = (Person)emptyCtor.Invoke(new object[] { });</p>
<p>Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });</p>
<p>Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) :(Person)nameAgeCtor.Invoke(new object[] { name, age });</p>
<p>&nbsp;</p>
<p>Console.WriteLine("{0} {1}", basePerson.Name, basePerson.Age);</p>
<p>Console.WriteLine("{0} {1}", personWithAge.Name, personWithAge.Age);</p>
<p>Console.WriteLine("{0} {1}", personWithAgeAndName.Name, personWithAgeAndName.Age);</p>
</td>
</tr>
</tbody>
</table>
<p>If you defined the constructors correctly, the test should pass.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>Pesho</p>
<p>20</p>
</td>
<td width="100">
<p>No name 1</p>
<p>No name 20</p>
<p>Pesho 20</p>
</td>
</tr>
<tr>
<td width="74">
<p>Gosho</p>
<p>18</p>
</td>
<td width="100">
<p>No name 1</p>
<p>No name 18</p>
<p>Gosho 18</p>
</td>
</tr>
<tr>
<td width="74">
<p>Stamat</p>
<p>43</p>
</td>
<td width="100">
<p>No name 1</p>
<p>No name 43</p>
<p>Stamat 43</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Opinion Poll</h2>
<p>Using the Person class, write a program that reads from the console <strong>N</strong> lines of personal information and then prints all people whose <strong>age</strong> is<strong> more than 30</strong> years,<strong> sorted</strong><strong> in alphabetical order</strong>.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="196">
<p><strong>Input</strong></p>
</td>
<td width="210">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="196">
<p>3</p>
<p>Pesho 12</p>
<p>Stamat 31</p>
<p>Ivan 48</p>
</td>
<td width="210">
<p>Ivan - 48</p>
<p>Stamat - 31</p>
</td>
</tr>
<tr>
<td width="196">
<p>5</p>
<p>Nikolai 33</p>
<p>Yordan 88</p>
<p>Tosho 22</p>
<p>Lyubo 44</p>
<p>Stanislav 11</p>
</td>
<td width="210">
<p>Lyubo - 44</p>
<p>Nikolai - 33</p>
<p>Yordan - 88</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Speed Racing</h2>
<p>Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class <strong>Car</strong> that keeps track of a car&rsquo;s <strong>Model, fuel amount, fuel consumption for 1 kilometer </strong>and <strong>distance traveled</strong>. A Car&rsquo;s Model is <strong>unique</strong> - there will never be 2 cars with the same model.</p>
<p>&nbsp;On the first line of the input you will receive a number <strong>N</strong> &ndash; the number of cars you need to track, on each of the next <strong>N</strong> lines you will receive information for a car in the following format &ldquo;&lt;<strong>Model&gt; &lt;FuelAmount&gt; &lt;FuelConsumptionFor1km&gt;</strong>&rdquo;, all <strong>cars start at 0 kilometers traveled</strong>.</p>
<p>After the <strong>N</strong> lines, until the command &ldquo;<strong>End</strong>&rdquo; is received, you will receive a command in the following format &ldquo;<strong>Drive &lt;CarModel&gt;&nbsp; &lt;amountOfKm&gt;</strong>&rdquo;. Implement a method in the <strong>Car</strong> class to calculate whether a car can move that distance. If it can the car&rsquo;s <strong>fuel</strong><strong> amount</strong> should be <strong>reduced</strong> by the amount of used fuel and its <strong>distance traveled</strong> should be increased by the amount of kilometers traveled, otherwise the car should not move (Its fuel amount and distance traveled should stay the same) and you should print on the console &ldquo;<strong>Insufficient fuel for the </strong><strong>drive</strong>&rdquo;. After the &ldquo;<strong>End</strong>&rdquo; command is received, print <strong>each car</strong> and its <strong>current fuel amount</strong> and <strong>distance traveled</strong> in the format &ldquo;<strong>&lt;Model&gt; &lt;fuelAmount&gt;&nbsp; &lt;distanceTraveled&gt;</strong>&rdquo;, where the fuel amount should be printed to <strong>two decimal places</strong> after the separator.</p>
<h3>Examples</h3>
<table width="720">
<tbody>
<tr>
<td width="426">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="426">
<p>2</p>
<p>AudiA4 23 0.3</p>
<p>BMW-M2 45 0.42</p>
<p>Drive BMW-M2 56</p>
<p>Drive AudiA4 5</p>
<p>Drive AudiA4 13</p>
<p>End</p>
</td>
<td width="294">
<p>AudiA4 17.60 18</p>
<p>BMW-M2 21.48 56</p>
</td>
</tr>
<tr>
<td width="426">
<p>3</p>
<p>AudiA4 18 0.34</p>
<p>BMW-M2 33 0.41</p>
<p>Ferrari-488Spider 50 0.47</p>
<p>Drive Ferrari-488Spider 97</p>
<p>Drive Ferrari-488Spider 35</p>
<p>Drive AudiA4 85</p>
<p>Drive AudiA4 50</p>
<p>End</p>
</td>
<td width="294">
<p>Insufficient fuel for the drive</p>
<p>Insufficient fuel for the ride</p>
<p>AudiA4 1.00 50</p>
<p>BMW-M2 33.00 0</p>
<p>Ferrari-488Spider 4.41 97</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Company Roster</h2>
<p>Define a class <strong>Employee</strong> that holds the following information: <strong>name, salary, position, department, email</strong> and <strong>age</strong>. The <strong>name, salary</strong>, <strong>position</strong> and <strong>department</strong> are <strong>mandatory</strong> while the rest are <strong>optional</strong>.</p>
<p>Your task is to write a program which takes <strong>N</strong> lines of employees from the console and calculates the department with the highest average salary and prints for each employee in that department his <strong>name, salary, email and age</strong> &ndash; <strong>sorted by salary in descending order</strong>. If an employee <strong>doesn&rsquo;t have</strong> an <strong>email</strong> &ndash; in place of that field you should print &ldquo;<strong>n/a</strong>&rdquo; instead, if he doesn&rsquo;t have an <strong>age</strong> &ndash; print &ldquo;<strong>-1</strong>&rdquo; instead. The <strong>salary</strong> should be printed to <strong>two decimal places</strong> after the seperator.</p>
<h3>Examples</h3>
<table width="720">
<tbody>
<tr>
<td width="426">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="426">
<p>4</p>
<p>Pesho 120.00 Dev Development pesho@abv.bg 28</p>
<p>Toncho 333.33 Manager Marketing 33</p>
<p>Ivan 840.20 ProjectLeader Development ivan@ivan.com</p>
<p>Gosho 0.20 Freeloader Nowhere 18</p>
</td>
<td width="294">
<p>Highest Average Salary: Development</p>
<p>Ivan 840.20 ivan@ivan.com -1</p>
<p>Pesho 120.00 pesho@abv.bg 28</p>
</td>
</tr>
<tr>
<td width="426">
<p>6</p>
<p>Stanimir 496.37 Temp Coding stancho@yahoo.com</p>
<p>Yovcho 610.13 Manager Sales</p>
<p>Toshko 609.99 Manager Sales toshko@abv.bg 44</p>
<p>Venci 0.02 Director BeerDrinking beer@beer.br 23</p>
<p>Andrei 700.00 Director Coding</p>
<p>Popeye 13.3333 Sailor SpinachGroup popeye@pop.ey</p>
</td>
<td width="294">
<p>Highest Average Salary: Sales</p>
<p>Yovcho 610.13 n/a -1</p>
<p>Toshko 609.99 toshko@abv.bg 44</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>