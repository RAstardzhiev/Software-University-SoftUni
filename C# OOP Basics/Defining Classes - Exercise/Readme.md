<h1>Exercises: Defining Classes</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017">"CSharp OOP Basics" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/228/Defining-Classes">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Define a class Person</h2>
<p>Define a class<strong> Person</strong> with <strong>public</strong> fields for <strong>name</strong> and <strong>age</strong>. In order to submit the source code in Judge don&rsquo;t add the class as a separate file.</p>
<h3>Note</h3>
<p>Add the following code to your main method and submit it to Judge.</p>
<table width="720">
<tbody>
<tr>
<td width="720">
<p>static void Main(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Type personType = typeof (Person);</p>
<p>&nbsp;&nbsp;&nbsp; FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(fields.Length);</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
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
<p>&nbsp;</p>
<p>Use both the inline initialization and the default constructor. Your fields should be <strong>public</strong>, otherwise you won&rsquo;t see them.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Creating Constructors</h2>
<p>Add 3 constructors to the <strong>Person</strong> class from the last task, use constructor chaining to reuse code:</p>
<ol>
<li>The first should take no arguments and produce a person with name &ldquo;<strong>No name</strong>&rdquo; and age = <strong>1</strong>.</li>
<li>The second should accept only an integer number for the age and produce a person with name &ldquo;<strong>No name</strong>&rdquo; and age equal to the passed parameter.</li>
<li>The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.</li>
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
<p>Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);</p>
<p>Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);</p>
<p>Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
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
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Oldest Family Member</h2>
<p>Create class <strong>Person</strong> with fields <strong>name</strong> and <strong>age</strong>. Create a class <strong>Family</strong>. The class should have <strong>list of people</strong>, method for adding members (<strong>void AddMember(Person member)</strong>) and a method returning the oldest family member (<strong>Person GetOldestMember())</strong>. Write a program that reads name and age for <strong>N</strong> people and <strong>add them to the family</strong>. Then <strong>print</strong> the <strong>name</strong> and <strong>age</strong> of the oldest member.</p>
<h3>Note</h3>
<p>Add the following code to your main method before your code and submit it to Judge.</p>
<table width="720">
<tbody>
<tr>
<td width="720">
<p>MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");</p>
<p>MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");</p>
<p>if(oldestMemberMethod == null || addMemberMethod == null)</p>
<p>{</p>
<p>&nbsp;&nbsp; throw new Exception();</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>If you defined the class correctly, the test should pass.</p>
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
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Opinion Poll</h2>
<p>Using the Person class, write a program that reads from the console <strong>N</strong> lines of personal information and then prints all people whose <strong>age</strong> is<strong> more than 30</strong> years,<strong> sorted in alphabetical order</strong>.</p>
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
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date Modifier</h2>
<p>Create a class <strong>DateModifier</strong> which stores the difference of the days between two Dates. It should have a method which takes <strong>two string parameters</strong> <strong>representing a date</strong> as strings and <strong>calculates the </strong>difference in the days between them.</p>
<h3>Examples</h3>
<table width="193">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="85">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>1992 05 31</p>
<p>2016 06 17</p>
</td>
<td width="85">
<p>8782</p>
</td>
</tr>
<tr>
<td width="108">
<p>2016 05 31</p>
<p>2016 04 19</p>
</td>
<td width="85">
<p>42</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Company Roster</h2>
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
<p>Popeye 13.3333 Sailor SpinachGroup <a href="mailto:popeye@pop.ey">popeye@pop.ey</a></p>
</td>
<td width="294">
<p>Highest Average Salary: Sales</p>
<p>Yovcho 610.13 n/a -1</p>
<p>Toshko 609.99 toshko@abv.bg 44</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Speed Racing</h2>
<p>Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class <strong>Car</strong> that keeps track of a car&rsquo;s <strong>Model, fuel amount, fuel consumption for 1 kilometer </strong>and <strong>distance traveled</strong>. A Car&rsquo;s Model is <strong>unique</strong> - there will never be 2 cars with the same model.</p>
<p>&nbsp;On the first line of the input you will receive a number <strong>N</strong> &ndash; the number of cars you need to track, on each of the next <strong>N</strong> lines you will receive information for a car in the following format &ldquo;&lt;<strong>Model&gt; &lt;FuelAmount&gt; &lt;FuelConsumptionFor1km&gt;</strong>&rdquo;, all <strong>cars start at 0 kilometers traveled</strong>.</p>
<p><br /> After the <strong>N</strong> lines, until the command &ldquo;<strong>End</strong>&rdquo; is received, you will receive a commands in the following format &ldquo;<strong>Drive &lt;CarModel&gt;&nbsp; &lt;amountOfKm&gt;</strong>&rdquo;. Implement a method in the <strong>Car</strong> class to calculate whether or not a car can move that distance, if it can the car&rsquo;s <strong>fuel amount</strong> should be <strong>reduced</strong> by the amount of used fuel and its <strong>distance traveled</strong> should be increased by the amount of kilometers traveled, otherwise the car should not move (Its fuel amount and distance traveled should stay the same) and you should print on the console &ldquo;<strong>Insufficient fuel for the drive</strong>&rdquo;. After the &ldquo;<strong>End</strong>&rdquo; command is received, print each car and its current fuel amount and distance traveled in the format &ldquo;<strong>&lt;Model&gt; &lt;fuelAmount&gt;&nbsp; &lt;distanceTraveled&gt;</strong>&rdquo;, where the fuel amount should be printed to <strong>two decimal places</strong> after the separator.</p>
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
<p>Insufficient fuel for the drive</p>
<p>AudiA4 1.00 50</p>
<p>BMW-M2 33.00 0</p>
<p>Ferrari-488Spider 4.41 97</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Raw Data</h2>
<p>You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a class <strong>Car</strong> that holds information about <strong>model, engine, cargo</strong> and a <strong>collection of exactly 4 tires</strong>. The engine, cargo and tire <strong>should be separate classes</strong>, create a constructor that receives all information about the Car and creates and initializes its inner components (engine, cargo and tires).</p>
<p>On the first line of input you will receive a number <strong>N</strong> - the amount of cars you have, on each of the next <strong>N</strong> lines you will receive information about a car in the format &ldquo;<strong>&lt;Model&gt; &lt;EngineSpeed&gt; &lt;EnginePower&gt; &lt;CargoWeight&gt; &lt;CargoType&gt; &lt;Tire1Pressure&gt; &lt;Tire1Age&gt; &lt;Tire2Pressure&gt; &lt;Tire2Age&gt; &lt;Tire3Pressure&gt; &lt;Tire3Age&gt; &lt;Tire4Pressure&gt; &lt;Tire4Age&gt;&rdquo;</strong> where the speed, power, weight and tire age are<strong> integers</strong>, tire pressure is a <strong>double. </strong></p>
<p>After the <strong>N</strong> lines you will receive a single line with one of 2 commands &ldquo;<strong>fragile</strong>&rdquo; or &ldquo;<strong>flamable</strong>&rdquo; , if the command is &ldquo;<strong>fragile</strong>&rdquo; print all cars whose <strong>Cargo Type is &ldquo;fragile&rdquo;</strong> with a tire whose <strong>pressure is</strong>&nbsp; <strong>&lt; 1</strong>, if the command is &ldquo;<strong>flamable</strong>&rdquo; print all cars whose <strong>Cargo Type is &ldquo;flamable&rdquo;</strong> and have <strong>Engine Power &gt; 250</strong>. The cars should be printed in order of appearing in the input.</p>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="520">
<p><strong>Input</strong></p>
</td>
<td width="186">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="520">
<p>2</p>
<p>ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4</p>
<p>Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1</p>
<p>fragile</p>
</td>
<td width="186">
<p>Citroen2CV</p>
</td>
</tr>
<tr>
<td width="520">
<p>4</p>
<p>ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1</p>
<p>ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1</p>
<p>DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1</p>
<p>Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2</p>
<p>flamable</p>
</td>
<td width="186">
<p>ChevroletExpress</p>
<p>DaciaDokker</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Rectangle Intersection</h2>
<p>Create a class <strong>Rectangle</strong>. It should consist of an <strong>ID, width, height</strong> and the <strong>coordinates of its top left corner</strong> (<strong>horizontal and vertical</strong>). Create a <strong>method </strong>which <strong>receives as a parameter</strong> <strong>another Rectangle</strong>, checks if the two rectangles <strong>intersect</strong> and <strong>returns true or false</strong>.</p>
<p>On the first line you will receive the <strong>number of rectangles</strong> &ndash; <strong>N</strong> and the number of <strong>intersection checks</strong> &ndash; <strong>M</strong>. On the next <strong>N</strong> lines, you will get the rectangles with their <strong>ID, width, height and coordinates</strong>. On the last <strong>M</strong> lines, you will get <strong>pairs of IDs</strong> which represent rectangles. Print if each of the pairs <strong>intersect.</strong></p>
<p>You will always receive valid data. There is no need to check if a rectangle exists.</p>
<h3>Examples</h3>
<table width="595">
<tbody>
<tr>
<td width="274">
<p><strong>Input</strong></p>
</td>
<td width="321">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="274">
<p>2 1</p>
<p>Pesho 2 2 0 0</p>
<p>Gosho 2 2 0 0</p>
<p>Pesho Gosho</p>
</td>
<td width="321">
<p>true</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 10. Car Salesman</h2>
<p>Define two classes <strong>Car</strong> and <strong>Engine. </strong>A<strong> Car </strong>has a <strong>model, engine, weight</strong> and <strong>color</strong>. An Engine has <strong>model</strong>, <strong>power, displacement</strong> and <strong>efficiency</strong>. A Car&rsquo;s <strong>weight</strong> and <strong>color</strong> and its Engine&rsquo;s <strong>displacements</strong> and <strong>efficiency</strong> are <strong>optional</strong>.</p>
<p>On the first line you will read a number <strong>N</strong> which will specify how many lines of engines you will receive, on each of the next <strong>N</strong> lines you will receive information about an <strong>Engine</strong> in the following format &ldquo;&lt;<strong>Model&gt; &lt;Power&gt; &lt;Displacement&gt; &lt;Efficiency&gt;</strong>&rdquo;. After the lines with engines, on the next line you will receive a number <strong>M</strong> &ndash; specifying the number of Cars that will follow, on each of the next <strong>M</strong> lines information about a <strong>Car</strong> will follow in the following format &ldquo;&lt;<strong>Model&gt; &lt;Engine&gt; &lt;Weight&gt; &lt;Color&gt;</strong>&rdquo;, where the engine in the format will be the <strong>model of an existing</strong> <strong>Engine</strong>. When creating the object for a <strong>Car</strong>, you should keep a <strong>reference to the real engine</strong> in it, instead of just the engine&rsquo;s model, note that the optional properties <strong>might be missing</strong> from the formats.</p>
<p>Your task is to print each car (in the order you received them) and its information in the format defined bellow, if any of the optional fields has not been given print &ldquo;<strong>n/a</strong>&rdquo; in its place instead:</p>
<p><strong>&lt;CarModel&gt;:<br /> &nbsp; &lt;EngineModel&gt;:<br /> &nbsp;&nbsp;&nbsp; Power: &lt;EnginePower&gt;<br /> &nbsp;&nbsp;&nbsp; Displacement: &lt;EngineDisplacement&gt;<br /> &nbsp;&nbsp;&nbsp; Efficiency: &lt;EngineEfficiency&gt;<br /> &nbsp; Weight: &lt;CarWeight&gt;<br /> &nbsp; Color: &lt;CarColor&gt;</strong></p>
<h3>Bonus*</h3>
<p>Override the classes&rsquo;s ToString() methods to have a reusable way of displaying the objects.</p>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="334">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="334">
<p>2</p>
<p>V8-101 220 50</p>
<p>V4-33 140 28 B</p>
<p>3</p>
<p>FordFocus V4-33 1300 Silver</p>
<p>FordMustang V8-101</p>
<p>VolkswagenGolf V4-33 Orange</p>
</td>
<td width="372">
<p>FordFocus:</p>
<p>&nbsp; V4-33:</p>
<p>&nbsp;&nbsp;&nbsp; Power: 140</p>
<p>&nbsp;&nbsp;&nbsp; Displacement: 28</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: B</p>
<p>&nbsp; Weight: 1300</p>
<p>&nbsp; Color: Silver</p>
<p>FordMustang:</p>
<p>&nbsp; V8-101:<br /> &nbsp;&nbsp;&nbsp; Power: 220<br /> &nbsp;&nbsp;&nbsp; Displacement: 50</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: n/a</p>
<p>&nbsp; Weight: n/a</p>
<p>&nbsp; Color: n/a</p>
<p>VolkswagenGolf:</p>
<p>&nbsp; V4-33:</p>
<p>&nbsp;&nbsp;&nbsp; Power: 140</p>
<p>&nbsp;&nbsp;&nbsp; Displacement: 28</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: B</p>
<p>&nbsp; Weight: n/a</p>
<p>&nbsp; Color: Orange</p>
</td>
</tr>
<tr>
<td width="334">
<p>4</p>
<p>DSL-10 280 B</p>
<p>V7-55 200 35</p>
<p>DSL-13 305 55 A+</p>
<p>V7-54 190 30 D</p>
<p>4</p>
<p>FordMondeo DSL-13 Purple</p>
<p>VolkswagenPolo V7-54 1200 Yellow</p>
<p>VolkswagenPassat DSL-10 1375 Blue</p>
<p>FordFusion DSL-13</p>
</td>
<td width="372">
<p>FordMondeo:</p>
<p>&nbsp; DSL-13:</p>
<p>&nbsp;&nbsp;&nbsp; Power: 305</p>
<p>&nbsp;&nbsp;&nbsp; Displacement: 55</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: A+</p>
<p>&nbsp; Weight: n/a</p>
<p>&nbsp; Color: Purple</p>
<p>VolkswagenPolo:</p>
<p>&nbsp; V7-54:</p>
<p>&nbsp;&nbsp;&nbsp; Power: 190</p>
<p>&nbsp;&nbsp;&nbsp; Displacement: 30</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: D</p>
<p>&nbsp; Weight: 1200</p>
<p>&nbsp; Color: Yellow</p>
<p>VolkswagenPassat:</p>
<p>&nbsp; DSL-10:</p>
<p>&nbsp;&nbsp;&nbsp; Power: 280</p>
<p>&nbsp;&nbsp;&nbsp; Displacement: n/a</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: B</p>
<p>&nbsp; Weight: 1375</p>
<p>&nbsp; Color: Blue</p>
<p>FordFusion:</p>
<p>&nbsp; DSL-13:</p>
<p>&nbsp;&nbsp;&nbsp; Power: 305</p>
<p>&nbsp;&nbsp;&nbsp; Displacement: 55</p>
<p>&nbsp;&nbsp;&nbsp; Efficiency: A+</p>
<p>&nbsp; Weight: n/a</p>
<p>&nbsp; Color: n/a</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11. Pokemon Trainer</h2>
<p>You wanna be the very best pokemon trainer, like no one ever was, so you set out to catch pokemon. Define a class <strong>Trainer</strong> and a class <strong>Pokemon</strong>. Trainers have a <strong>name</strong>, <strong>number of badges</strong> and a <strong>collection of pokemon</strong>, <strong>Pokemon</strong> have a <strong>name</strong>, an <strong>element</strong> and <strong>health</strong>, all values are <strong>mandatory</strong>. Every Trainer <strong>starts with 0 badges</strong>.</p>
<p>From the console you will receive an unknown number of lines until you receive the command &ldquo;<strong>Tournament</strong>&rdquo;, each line will carry information about a pokemon and the trainer who caught it in the format &ldquo;&lt;<strong>TrainerName&gt; &lt;PokemonName&gt; &lt;PokemonElement&gt; &lt;PokemonHealth&gt;&rdquo; </strong>where <strong>TrainerName</strong> is the name of the Trainer who caught the pokemon, names are <strong>unique </strong>there cannot be 2 trainers with the same name. After receiving the command &ldquo;<strong>Tournament</strong>&rdquo; an unknown number of lines containing one of three elements &ldquo;<strong>Fire</strong>&rdquo;, &ldquo;<strong>Water</strong>&rdquo;, &ldquo;<strong>Electricity</strong>&rdquo; will follow until the command &ldquo;<strong>End</strong>&rdquo; is received. For every command you must check if a trainer has atleast 1 pokemon with the given element, if he does he receives 1 badge, otherwise all his pokemon <strong>lose 10 health</strong>, if a pokemon falls <strong>to 0 or less health he dies</strong> and must be deleted from the trainer&rsquo;s collection. After the command &ldquo;<strong>End</strong>&rdquo; is received you should print all trainers <strong>sorted by the amount of badges they have in descending order</strong> (if two trainers have the same amount of badges they should be sorted by order of appearance in the input) in the format &ldquo;&lt;<strong>TrainerName&gt; &lt;Badges&gt; &lt;NumberOfPokemon&gt;</strong>&rdquo;.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="352">
<p><strong>Input</strong></p>
</td>
<td width="335">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="352">
<p>Pesho Charizard Fire 100</p>
<p>Gosho Squirtle Water 38</p>
<p>Pesho Pikachu Electricity 10</p>
<p>Tournament</p>
<p>Fire</p>
<p>Electricity</p>
<p>End</p>
</td>
<td width="335">
<p>Pesho 2 2</p>
<p>Gosho 0 1</p>
</td>
</tr>
<tr>
<td width="352">
<p>Stamat Blastoise Water 18</p>
<p>Nasko Pikachu Electricity 22</p>
<p>Jicata Kadabra Psychic 90</p>
<p>Tournament</p>
<p>Fire</p>
<p>Electricity</p>
<p>Fire</p>
<p>End</p>
</td>
<td width="335">
<p>Nasko 1 1</p>
<p>Stamat 0 0</p>
<p>Jicata 0 1</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12. Google</h2>
<p>Google is always watching you, so it should come as no surprise that they know everything about you (even your pokemon collection), since you&rsquo;re really good at writing classes Google asked you to design a Class that can hold all the information they need for people.</p>
<p>From the console you will receive an unkown amount of lines until the command &ldquo;<strong>End</strong>&rdquo; is read, on each of those lines there will be information about a person in one of the following formats:</p>
<ul>
<li>&ldquo;<strong>&lt;Name&gt; company &lt;companyName&gt; &lt;department&gt; &lt;salary&gt;</strong>&rdquo;</li>
<li>&ldquo;<strong>&lt;Name&gt; pokemon &lt;pokemonName&gt; &lt;pokemonType&gt;&rdquo;</strong></li>
<li>&ldquo;<strong>&lt;Name&gt; parents &lt;parentName&gt; &lt;parentBirthday&gt;</strong>&rdquo;</li>
<li>&ldquo;<strong>&lt;Name&gt; children &lt;childName&gt; &lt;childBirthday&gt;</strong>&rdquo;</li>
<li>&ldquo;<strong>&lt;Name&gt; car &lt;carModel&gt; &lt;carSpeed&gt;</strong>&rdquo;</li>
</ul>
<p>You should structure all information about a person in a class with nested subclasses. People&rsquo;s names are <strong>unique </strong>- there won&rsquo;t be 2 people with the same name, a person can also have <strong>only 1</strong> <strong>company</strong> and <strong>car</strong>, but can have <strong>multiple</strong> <strong>parents, chidlren</strong> and <strong>pokemon</strong>. After the command &ldquo;<strong>End</strong>&rdquo; is received on the next line you will receive a single name, you should print all information about that person. Note that information can change during the input, for instance if we receive multiple lines which specify a person&rsquo;s company, only the <strong>last one</strong> should be the one remembered. The salary must be formated to <strong>two decimal places</strong> after the seperator.</p>
<h3>Examples</h3>
<table width="720">
<tbody>
<tr>
<td width="408">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="408">
<p>PeshoPeshev company PeshInc Management 1000.00</p>
<p>TonchoTonchev car Trabant 30</p>
<p>PeshoPeshev pokemon Pikachu Electricity</p>
<p>PeshoPeshev parents PoshoPeshev 22/02/1920</p>
<p>TonchoTonchev pokemon Electrode Electricity</p>
<p>End</p>
<p>TonchoTonchev</p>
</td>
<td width="312">
<p>TonchoTonchev</p>
<p>Company:</p>
<p>Car:</p>
<p>Trabant 30</p>
<p>Pokemon:</p>
<p>Electrode Electricity</p>
<p>Parents:</p>
<p>Children:</p>
</td>
</tr>
<tr>
<td width="408">
<p>JelioJelev pokemon Onyx Rock</p>
<p>JelioJelev parents JeleJelev 13/03/1933</p>
<p>GoshoGoshev pokemon Moltres Fire</p>
<p>JelioJelev company JeleInc Jelior 777.77</p>
<p>JelioJelev children PudingJelev 01/01/2001</p>
<p>StamatStamatov pokemon Blastoise Water</p>
<p>JelioJelev car AudiA4 180</p>
<p>JelioJelev pokemon Charizard Fire</p>
<p>End</p>
<p>JelioJelev</p>
</td>
<td width="312">
<p>JelioJelev</p>
<p>Company:</p>
<p>JeleInc Jelior 777.77</p>
<p>Car:</p>
<p>AudiA4 180</p>
<p>Pokemon:</p>
<p>Onyx Rock</p>
<p>Charizard Fire</p>
<p>Parents:</p>
<p>JeleJelev 13/03/1933</p>
<p>Children:</p>
<p>PudingJelev 01/01/2001</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h3>Bonus*</h3>
<p>Override the ToString() method in the classes to standardize the displaying of objects.</p>
<h2>Problem 13. Family Tree</h2>
<p>You want to build your family tree, so you went to ask your grandmother, sadly your grandmother keeps remembering information about your predecessors in pieces, so it falls to you to group the information and build the family tree.</p>
<p>On the first line of the input you will receive either a name or a birthdate in the format &ldquo;&lt;<strong>FirstName&gt; &lt;LastName&gt;&rdquo; </strong>or <strong>&ldquo;day/month/year</strong>&rdquo; &ndash; your task is to find the person&rsquo;s information in the family tree. On the next lines until the command &ldquo;<strong>End</strong>&rdquo; is received you will receive information about your predecessors that you will use to build the family tree.</p>
<p>The information will be in one of the following formats:</p>
<ul>
<li>&ldquo;<strong>FirstName LastName - FirstName LastName</strong>&rdquo;</li>
<li>&ldquo;<strong>FirstName LastName - day/month/year</strong>&rdquo;</li>
<li>&ldquo;<strong>day/month/year - FirstName LastName</strong>&rdquo;</li>
<li>&ldquo;<strong>day/month/year - day/month/year</strong>&rdquo;</li>
<li>&ldquo;<strong>FirstName LastName day/month/year</strong>&rdquo;</li>
</ul>
<p>The first 4 formats reveal a family tie &ndash; <strong>the person on the left is parent to the person on the right</strong> (as you can see the format does not need to contain names, for example the 4<sup>th</sup> format means the person born on the left date is parent to the person born on the right date). The last format ties different information together &ndash; i.e. <strong>the person with that name was born on that date</strong>. <strong>Names</strong> and <strong>birthdates</strong> are <strong>unique</strong> &ndash; there won&rsquo;t be 2 people with the same name or birthdate, there will <strong>always</strong> be enough entries to construct the family tree (all people&rsquo;s names and birthdates are known and they have atleast one connection to another person in the tree).</p>
<p>After the command &ldquo;<strong>End</strong>&rdquo; is received you should print all information about the person whose name or birthdate you received on the first line &ndash; his <strong>name, birthday, parents and children</strong> (check the examples for the format). The people in the parents and childrens lists should be ordered by their first appearance in the input (regardless if they appeared as a birthdate or a name, for example in the first input Stamat is before Penka because he has appeared first on the second line, while she appears on the third one).</p>
<h3>Examples</h3>
<table width="720">
<tbody>
<tr>
<td width="408">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="408">
<p>Pesho Peshev</p>
<p>11/11/1951 - 23/5/1980</p>
<p>Penka Pesheva - 23/5/1980</p>
<p>Penka Pesheva 9/2/1953</p>
<p>Pesho Peshev - Gancho Peshev</p>
<p>Gancho Peshev 1/1/2005</p>
<p>Stamat Peshev 11/11/1951</p>
<p>Pesho Peshev 23/5/1980</p>
<p>End</p>
</td>
<td width="312">
<p>Pesho Peshev 23/5/1980</p>
<p>Parents:</p>
<p>Stamat Peshev 11/11/1951</p>
<p>Penka Pesheva 9/2/1953</p>
<p>Children:</p>
<p>Gancho Peshev 1/1/2005</p>
</td>
</tr>
<tr>
<td width="408">
<p>13/12/1993</p>
<p>25/3/1934 - 4/4/1961</p>
<p>Poncho Tonchev 25/3/1934</p>
<p>4/4/1961 - Moncho Tonchev</p>
<p>Toncho Tonchev - Lomcho Tonchev</p>
<p>Moncho Tonchev 13/12/1993</p>
<p>Lomcho Tonchev 7/7/1995</p>
<p>Toncho Tonchev 4/4/1961</p>
<p>End</p>
</td>
<td width="312">
<p>Moncho Tonchev 13/12/1993</p>
<p>Parents:</p>
<p>Toncho Tonchev 4/4/1961</p>
<p>Children:</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 14. *Cat Lady</h2>
<p>Ginka has many cats in her house of various breeds, since some breeds have specific characteristics, Ginka needs some way to catalogue the cats, help her by creating a class hierarchy with all her breeds of cats so that she can easily check on their characteristics. Ginka has 3 specific breeds of cats &ldquo;Siamese&rdquo;, &ldquo;Cymric&rdquo; and the very famous bulgarian breed &ldquo;Street Extraordinaire&rdquo;,&nbsp; each breed has a specific characteristic about which information should be kept. For the Siamese cats their ear size should be kept, for Cymric cats - the length of their fur in centimeters and for the Street Extraordinaire the decibels of their meowing during the night.</p>
<p>From the console you will receive lines of information with cats. Until the command &ldquo;<strong>End</strong>&rdquo; is received, the information will come in one of the following formats:</p>
<ul>
<li>&ldquo;<strong>Siamese &lt;name&gt; &lt;earSize&gt;&rdquo;</strong></li>
<li>&ldquo;<strong>Cymric &lt;name&gt; &lt;furLength&gt;&rdquo;</strong></li>
<li>&ldquo;<strong>StreetExtraordinaire &lt;name&gt; &lt;decibelsOfMeows&gt;&rdquo;</strong></li>
</ul>
<p>On the last line after the &ldquo;<strong>End</strong>&rdquo; command you will receive the name of a cat, you should print that cat&rsquo;s information in the same format in which you received it (with <strong>fur size</strong> being formated to <strong>two decimal places</strong> after the separator). Ear size and decibels will always be <strong>positive integer</strong> numbers, cat names are <strong>unique</strong>.</p>
<h3>Example</h3>
<table width="720">
<tbody>
<tr>
<td width="408">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="408">
<p>StreetExtraordinaire Maca 85</p>
<p>Siamese Sim 4</p>
<p>Cymric Tom 2.80</p>
<p>End</p>
<p>Tom</p>
</td>
<td width="312">
<p>Cymric Top 2.80</p>
</td>
</tr>
<tr>
<td width="408">
<p>StreetExtraordinaire Koti 80</p>
<p>StreetExtraordinaire Maca 100</p>
<p>Cymric Tim 3.10</p>
<p>End</p>
<p>Maca</p>
</td>
<td width="312">
<p>StreetExtraordinaire Maca 100</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Hint</h3>
<p>Use class inheritance to represent the cat hierarchy and override the ToString() methods of concrete breeds to allow for easy printing of the cat, regardless the breed.</p>
<h2>Problem 15. *Drawing tool</h2>
<p>You are a young programmer and your Boss is giving you a task to create a tool which is drawing figures on the console. He knows you are not so good at OOP tasks so he told you to create only a single class - CorDraw. Its task is to draw rectangular figures on the screen.</p>
<p>CorDraw&rsquo;s constructor should take as parameter a Square instance or a Rectangle instance, extract its characteristics and draw the figure. Like we said your Boss is a good guy and he has some more info for you:</p>
<p>One of the extra classes you will need should be a class named <strong>Square</strong> that should have only one method &ndash; <strong>Draw()</strong> which uses the length of the square&rsquo;s sides and draws them on the console. For horizontal lines, use dashes ("-") and spaces (" "). For vertical lines &ndash; pipes ("|"). If the size of the figure is 6, dashes should also be 6.</p>
<h3>Hint</h3>
<p>Search in the internet for abstract classes and try implementing one. This will help you to reduce the input parameters in the CorDraw&rsquo;s constructor to a single one.</p>
<h3>Examples</h3>
<table width="428">
<tbody>
<tr>
<td width="125">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
<td width="151">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Square</p>
<p>3</p>
</td>
<td width="151">
<p>|- - -|</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>|- - -|</p>
</td>
<td width="151">
<p>Square&rsquo;s size is 3 so we draw 3 pipes down and 3 dashes across</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="428">
<tbody>
<tr>
<td width="125">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
<td width="151">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Rectangle</p>
<p>7</p>
<p>3</p>
</td>
<td width="151">
<p>|- - - - - - -|</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>|- - - - - - -|</p>
</td>
<td width="151">
<p>The Rectangle&rsquo;s width is 7 and the length is 3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>