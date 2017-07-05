<h1>Exercises: Encapsulation</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017">"CSharp OOP Basics" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/232/Encapsulation-Exercise">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class Box</h2>
<p>You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: <a href="http://www.mathwords.com/r/rectangular_parallelepiped.htm">http://www.mathwords.com/r/rectangular_parallelepiped.htm</a>).</p>
<p>On the first three lines you will get the length, width and height. On the next three lines print the surface area, lateral surface area and the volume of the box:</p>
<h3>Note</h3>
<p>Add the following code <strong>at the start</strong> of your main method and submit it to Judge.</p>
<table width="720">
<tbody>
<tr>
<td width="720">
<p>static void Main(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Type boxType = typeof(Box);</p>
<p>&nbsp;&nbsp;&nbsp; FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(fields.Count());</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>If you defined the class correctly, the test should pass.</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="314">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="314">
<p>2</p>
<p>3</p>
<p>4</p>
</td>
<td width="384">
<p>3</p>
<p>Surface Area &ndash; 52.00</p>
<p>Lateral Surface Area &ndash; 40.00</p>
<p>Volume &ndash; 24.00</p>
</td>
</tr>
<tr>
<td width="314">
<p>1.3</p>
<p>1</p>
<p>6</p>
</td>
<td width="384">
<p>3</p>
<p>Surface Area - 30.20</p>
<p>Lateral Surface Area - 27.60</p>
<p>Volume - 7.80</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class Box Data Validation</h2>
<p>A box&rsquo;s side should not be zero or a negative number. Expand your class from the previous problem by adding data validation for each parameter given to the constructor. Make a private setter that performs data validation internally.</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="314">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="314">
<p>2</p>
<p>-3</p>
<p>4</p>
</td>
<td width="384">
<p>3</p>
<p>Width cannot be zero or negative.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Animal Farm</h2>
<p>You should be familiar with encapsulation already. For this problem, you&rsquo;ll be working with the <strong>Animal Farm project</strong>. It contains a class Chicken. Chicken contains several fields, a constructor, several properties and several methods. Your task is to encapsulate or hide anything that is not intended to be viewed or modified from outside the class.</p>
<h3>Step 1. Encapsulate Fields</h3>
<p>Fields should be <strong>private</strong>. Leaving fields open for modification from outside the class is potentially dangerous. Make all fields in the Chicken class private.</p>
<p>In case the value inside a field is needed elsewhere, use <strong>getters</strong> to reveal it.</p>
<h3>Step 2. Ensure Classes Have a Correct State</h3>
<p>Having <strong>getters and setters</strong> is useless if you don&rsquo;t actually use them. The Chicken constructor modifies the fields directly which is wrong when there are suitable setters available. Modify the constructor to fix this issue.</p>
<h3>Step 3. Validate Data Properly</h3>
<p>Validate the chicken&rsquo;s <strong>name</strong> (it cannot be null, empty or whitespace). In case of <strong>invalid name</strong>, print exception message "Name cannot be empty."</p>
<p>Validate the <strong>age</strong> properly, minimum and maximum age are provided, make use of them. In case of <strong>invalid age</strong>, print exception message "Age should be between 0 and 15."</p>
<p>Don&rsquo;t forget to handle properly the possibly thrown exceptions.</p>
<h3>Step 4. Hide Internal Logic</h3>
<p>If a method is intended to be used only by descendant classes or internally to perform some action, there is no point in keeping them <strong>public</strong>. The <strong>CalculateProductPerDay()</strong> method is used by the <strong>productPerDay()</strong> public getter. This means the method can safely be hidden inside the Chicken class by declaring it <strong>private</strong>.</p>
<h3>Step 5. Submit Code to Judge</h3>
<p>Submit your code as a zip file in Judge. Zip everything except the bin and obj folders within the project and submit the single zip file in judge.</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="314">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="314">
<p>Mara</p>
<p>10</p>
</td>
<td width="384">
<p>Chicken Mara (age 10) can produce 1 eggs per day.</p>
</td>
</tr>
<tr>
<td width="314">
<p>Mara</p>
<p>17</p>
</td>
<td width="384">
<p>Age should be between 0 and 15.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Shopping Spree</h2>
<p>Create two classes: <strong>class</strong> <strong>Person</strong> and <strong>class</strong> <strong>Product</strong>. Each person should have a <strong>name</strong>, <strong>money</strong> and a <strong>bag</strong> <strong>of products</strong>. Each product should have <strong>name</strong> and <strong>cost</strong>. Name cannot be an <strong>empty string</strong>. Money cannot be a <strong>negative number</strong>.</p>
<p>Create a program in which <strong>each command</strong> corresponds to a <strong>person buying a product</strong>. If the person can <strong>afford</strong> a product <strong>add</strong> it to his bag. If a person <strong>doesn&rsquo;t have enough</strong> money, print an <strong>appropriate</strong> <strong>message</strong> ("[Person name] can't afford [Product name]").</p>
<p>On the <strong>first two lines</strong> you are given <strong>all people</strong> and <strong>all products</strong>. After all purchases print <strong>every person</strong> in the order of <strong>appearance</strong> and <strong>all products</strong> that he has <strong>bought</strong> also in order of <strong>appearance</strong>. If <strong>nothing is bought</strong>, print the name of the person followed by "<strong>Nothing bought</strong>".</p>
<p>In case of <strong>invalid input</strong> (negative money exception message: "<strong>Money cannot be negative</strong>") or empty name (empty name exception message: "<strong>Name cannot be empty</strong>") <strong>break</strong> the program with an appropriate message. See the examples below:</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="314">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="314">
<p>Pesho=11;Gosho=4</p>
<p>Bread=10;Milk=2;</p>
<p>Pesho Bread</p>
<p>Gosho Milk</p>
<p>Gosho Milk</p>
<p>Pesho Milk</p>
<p>END</p>
</td>
<td width="384">
<p>Pesho bought Bread</p>
<p>Gosho bought Milk</p>
<p>Gosho bought Milk</p>
<p>Pesho can't afford Milk</p>
<p>Pesho - Bread</p>
<p>Gosho - Milk, Milk</p>
</td>
</tr>
<tr>
<td width="314">
<p>Mimi=0</p>
<p>Kafence=2</p>
<p>Mimi Kafence</p>
<p>END</p>
</td>
<td width="384">
<p>Mimi can't afford Kafence</p>
<p>Mimi &ndash; Nothing bought</p>
</td>
</tr>
<tr>
<td width="314">
<p>Jeko=-3</p>
<p>Chushki=1;</p>
<p>Jeko Chushki</p>
<p>END</p>
</td>
<td width="384">
<p>Money cannot be negative</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza Calories</h2>
<p>A Pizza is made of dough and different toppings. You should model a <strong>class Pizza</strong> which should have a <strong>name</strong>, <strong>dough</strong> and <strong>toppings</strong> as fields. Every type of <strong>ingredient</strong> should have its <strong>own class</strong>. Every ingredient has different properties: the <strong>dough</strong> can be white or wholegrain and in addition it can be crispy, chewy or homemade. The <strong>toppings</strong> can be of type meat, veggies, cheese or sauce. <strong>Every ingredient</strong> should have a <strong>weight</strong> in grams and a method for <strong>calculating</strong> its calories according its type. Calories per gram are calculated through <strong>modifiers</strong>. Every ingredient has 2 calories per gram as a <strong>base</strong> and a <strong>modifier</strong> that <strong>gives</strong> the <strong>exact</strong> calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough weighting 100 grams will have 100 * 1.5 * 1.1 = 330.00 total calories.</p>
<p><strong>Your job</strong> is to model the classes in such a way that they are <strong>properly encapsulated</strong> and to provide a public method for every pizza that <strong>calculates its calories according to the ingredients it has</strong>.</p>
<h3>Step 1. Create a Dough Class</h3>
<p>The base ingredient of a Pizza is the dough. First you need to create a class for it. It has a <strong>flour type</strong> which can be <strong>white</strong> or <strong>wholegrain</strong>. In addition, it has a <strong>baking technique</strong> which can be <strong>crispy</strong>, <strong>chewy</strong> or <strong>homemade</strong>. A dough should have a <strong>weight</strong> in grams. The calories per gram of a dough are calculated depending on the flour type and the baking technique. Every dough has 2 calories per gram as a base and a modifier that gives the exact calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough weighting 100 grams will have (2 * 100) * 1.5 * 1.1 = 330.00 total calories. You are given the modifiers below:</p>
<p>Modifiers:</p>
<ul>
<li>White &ndash; 1.5;</li>
<li>Wholegrain &ndash; 1.0;</li>
<li>Crispy &ndash; 0.9;</li>
<li>Chewy &ndash; 1.1;</li>
<li>Homemade &ndash; 1.0;</li>
</ul>
<p>Everything that the class should expose is a getter for the calories per gram. Your task is to create the class with a proper constructor, fields, getters and setters. Make sure you use the proper access modifiers.</p>
<h3>Step 2. Validate Data for the Dough Class</h3>
<p>Change the internal logic of the Dough class by adding a data validation in the setters.</p>
<p>Make sure that if invalid flour type or an invalid baking technique is given a proper exception is thrown with the message "Invalid type of dough.".</p>
<p>The allowed weight of a dough is in the range [1..200] grams. If it is outside of this range throw an exception with the message "Dough weight should be in the range [1..200].".</p>
<h3>Exception Messages</h3>
<ul>
<li>"Invalid type of dough."</li>
<li>"Dough weight should be in the range [.200]."</li>
</ul>
<p>Make a test in your main method that reads Doughs and prints their calories until an "END" command is read.</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="314">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="314">
<p>Dough White Chewy 100</p>
<p>END</p>
</td>
<td width="384">
<p>330.00</p>
</td>
</tr>
<tr>
<td width="314">
<p>Dough Tip500 Chewy 100</p>
<p>END</p>
</td>
<td width="384">
<p>Invalid type of dough.</p>
</td>
</tr>
<tr>
<td width="314">
<p>Dough White Chewy 240</p>
<p>END</p>
</td>
<td width="384">
<p>Dough weight should be in the range [1..200].</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Step 3. Create a Topping Class</h3>
<p>Next you need to create a <strong>Topping class</strong>. It can be of four different types &ndash; <strong>meat</strong>, <strong>veggies</strong>, <strong>cheese</strong> or a <strong>sauce</strong>. A topping has a <strong>weight</strong> in grams. The calories per gram of a topping are calculated depending on its type. The <strong>base calories</strong> per gram are <strong>2</strong>. Every different type of topping has a modifier. For example, meat has a modifier of 1.5, so a meat topping will have 1.5 calories per gram (1 * 1.5). Everything that the class should expose is a getter for calories per gram. You are given the modifiers below:</p>
<p>Modifiers:</p>
<ul>
<li>Meat &ndash; 1.2;</li>
<li>Veggies &ndash; 0.8;</li>
<li>Cheese &ndash; 1.1;</li>
<li>Sauce &ndash; 0.9;</li>
</ul>
<p>Your task is to create the class with a proper constructor, fields, getters and setters. Make sure you use the proper access modifiers.</p>
<h3>Step 4. Validate Data for the Topping Class</h3>
<p>Change the internal logic of the Topping class by adding a data validation in the setter.</p>
<p>Make sure the topping is one of the provided types, otherwise throw a proper exception with the message "Cannot place [name of invalid argument] on top of your pizza.".</p>
<p>The allowed weight of a topping is in the range [1..50] grams. If it is outside of this range throw an exception with the message "[Topping type name] weight should be in the range [1..50].".</p>
<h3>Exception Messages</h3>
<ul>
<li>"Cannot place [name of invalid argument] on top of your pizza."</li>
<li>"[Topping type name] weight should be in the range [1..50]."</li>
</ul>
<p>Make a test in your main method that reads a single dough and a topping after that and prints their calories.</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="314">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="314">
<p>Dough White Chewy 100</p>
<p>Topping meat 30</p>
<p>END</p>
</td>
<td width="384">
<p>330.00</p>
<p>72.00</p>
</td>
</tr>
<tr>
<td width="314">
<p>Dough White chewy 100</p>
<p>Topping Krenvirshi 500</p>
<p>END</p>
</td>
<td width="384">
<p>330.00</p>
<p>Cannot place Krenvirshi on top of your pizza.</p>
</td>
</tr>
<tr>
<td width="314">
<p>Dough White Chewy 100</p>
<p>Topping Meat 500</p>
<p>END</p>
</td>
<td width="384">
<p>330.00</p>
<p>Meat weight should be in the range [1..50].</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Step 5. Create a Pizza Class!</h3>
<p>A Pizza should have a <strong>name</strong>, some <strong>toppings</strong> and a <strong>dough</strong>. Make use of the two classes you&rsquo;ve made earlier. Also a pizza should have <strong>public getters</strong> for its <strong>name</strong>, <strong>number of toppings</strong> and the <strong>total calories</strong>. The <strong>total calories</strong> are <strong>calculated by summing the calories of all the ingredients a pizza has</strong>. Create the class using a proper constructor, expose a method for adding a topping, a public setter for the dough and a getter method for the total calories.</p>
<p>The input for a pizza consists of several lines. On the first line is the <strong>pizza name</strong> and the <strong>number of toppings it has</strong>. On the second line you will get input for the <strong>dough</strong>. On the next lines, you will receive every topping the pizza has. <strong>The number of lines for the toppings</strong> will correspond to the number of toppings declared on the first line.</p>
<p>If creation of the pizza was <strong>successful</strong> print on a single line the name of the pizza and the <strong>total calories</strong> it has.</p>
<h3>Step 6. Validate Data for the Pizza Class</h3>
<p>The <strong>name</strong> of the pizza should <strong>not</strong> be an <strong>empty string</strong>. Also it should <strong>not be longer than 15 symbols</strong>. If it doesn&rsquo;t fit this throw and <strong>exception</strong> with the message "Pizza name should be between 1 and 15 symbols."</p>
<p>The <strong>number of toppings</strong> should be in range [0...10]. If not, throw an <strong>exception</strong> with the message "Number of toppings should be in range [0..10]."</p>
<p>Your task is to print the name of the pizza and the total calories it has according to the examples below.</p>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="333">
<p><strong>Input</strong></p>
</td>
<td width="365">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Meatless 2</p>
<p>Dough Wholegrain Crispy 100</p>
<p>Topping Veggies 50</p>
<p>Topping Cheese 50</p>
<p>END</p>
</td>
<td width="365">
<p>Meatless &ndash; 370.00 Calories.</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Meatfull 5</p>
<p>Dough White cheWy 200</p>
<p>Topping Meat 50</p>
<p>Topping Cheese 50</p>
<p>Topping meat 20</p>
<p>Topping sauce 10</p>
<p>Topping Meat 30</p>
<p>END</p>
</td>
<td width="365">
<p>Meatfull &ndash; 1028.00 Calories.</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Bulgarian 20</p>
<p>Dough Tip500 Balgarsko 100</p>
<p>Topping Sirene 50</p>
<p>Topping Cheese 50</p>
<p>Topping Krenvirsh 20</p>
<p>Topping Meat 10</p>
<p>END</p>
</td>
<td width="365">
<p>Number of toppings should be in range [0..10].</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Bulgarian 2</p>
<p>Dough Tip500 Balgarsko 100</p>
<p>Topping Sirene 50</p>
<p>Topping Cheese 50</p>
<p>Topping Krenvirsh 20</p>
<p>Topping Meat 10</p>
<p>END</p>
</td>
<td width="365">
<p>Invalid type of dough.</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Bulgarian 2</p>
<p>Dough White Chewy 100</p>
<p>Topping Sirene 50</p>
<p>Topping Cheese 50</p>
<p>Topping Krenvirsh 20</p>
<p>Topping Meat 10</p>
<p>END</p>
</td>
<td width="365">
<p>Cannot place Sirene on top of your pizza.</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; **Football Team Generator</h2>
<p>A football team has variable <strong>number of players</strong>, a <strong>name</strong> and a <strong>rating</strong>. A player has a <strong>name</strong> and <strong>stats</strong> which are the basis for his skill level. The stats a player has are <strong>endurance</strong>, <strong>sprint</strong>, <strong>dribble</strong>, <strong>passing</strong> and <strong>shooting</strong>. Each stat can be in the range [0..100]. The overall skill level of a player is calculated as the average of his stats. Only the name of a player and his stats should be visible to all of the outside world. Everything else should be hidden.</p>
<p>A team should expose a name, a rating (calculated by the average skill level of all players in the team and rounded to the integer part only) and methods for adding and removing players.</p>
<p>Your task is to model the team and the players following the proper principles of Encapsulation. Expose only the properties that needs to be visible and validate data appropriately.</p>
<h3>Data Validation</h3>
<ul>
<li>A name cannot be null, empty or white space. If not, print "A name should not be empty. "</li>
<li>Stats should be in the range 0.. If not, print "[Stat name] should be between 0 and 100. "</li>
<li>If you receive a command to remove a missing player, print "Player [Player name] is not in [Team name] team. "</li>
<li>If you receive a command to add a player to a missing team, print "Team [team name] does not exist."</li>
<li>If you receive a command to show stats for a missing team, print "Team [team name] does not exist."</li>
</ul>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="342">
<p><strong>Input</strong></p>
</td>
<td width="355">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="342">
<p>Team;Arsenal</p>
<p>Add;Arsenal;Kieran_Gibbs;75;85;84;92;67</p>
<p>Add;Arsenal;Aaron_Ramsey;95;82;82;89;68</p>
<p>Remove;Arsenal;Aaron_Ramsey</p>
<p>Rating;Arsenal</p>
<p>END</p>
</td>
<td width="355">
<p>Arsenal &ndash; 81</p>
</td>
</tr>
<tr>
<td width="342">
<p>Team;Arsenal</p>
<p>Add;Arsenal;Kieran_Gibbs;75;85;84;92;67</p>
<p>Add;Arsenal;Aaron_Ramsey;195;82;82;89;68</p>
<p>Remove;Arsenal;Aaron_Ramsey</p>
<p>Rating;Arsenal</p>
<p>END</p>
</td>
<td width="355">
<p>Endurance should be between 0 and 100.</p>
<p>Player Aaron_Ramsey is not in Arsenal team.</p>
<p>Arsenal - 81</p>
</td>
</tr>
<tr>
<td width="342">
<p>Team;Arsenal</p>
<p>Rating;Arsenal</p>
<p>END</p>
</td>
<td width="355">
<p>Arsenal &ndash; 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>