<h1>Exercises: Encapsulation and Validation</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"CSharp DB Advanced" course @ Software University</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class Box</h2>
<p>You have a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: <a href="http://www.mathwords.com/r/rectangular_parallelepiped.htm">http://www.mathwords.com/r/rectangular_parallelepiped.htm</a>).</p>
<p>On the first three lines, you will get the length, width and height. On the next three lines, print the surface area, lateral surface area and the volume of the box:</p>
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
<p>&nbsp;&nbsp;&nbsp; ...</p>
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
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Shopping Spree</h2>
<p>Create two classes: <strong>class</strong> <strong>Person</strong> and <strong>class</strong> <strong>Product</strong>. Each person should have a <strong>name</strong>, <strong>money</strong> and a <strong>bag</strong> <strong>of products</strong>. Each product should have <strong>name</strong> and <strong>price</strong>. The name cannot be an <strong>empty string</strong>. The price cannot be <strong>negative or zero</strong>.</p>
<p>Create a program in which <strong>each command</strong> corresponds to a <strong>person buying a product</strong>. If the person can <strong>afford</strong> a product, <strong>add</strong> it to his bag. If a person <strong>doesn&rsquo;t have enough</strong> money, print an <strong>appropriate</strong> <strong>message</strong> ("[Person name] can't afford [Product name]").</p>
<p>On the <strong>first two lines,</strong> you are given <strong>all people</strong> and <strong>all products</strong>. After all purchases print <strong>every person</strong> in the order of <strong>appearance</strong> and <strong>all products</strong> that he has <strong>bought</strong> also in order of <strong>appearance</strong>. If <strong>nothing is bought</strong>, print the name of the person followed by "<strong>Nothing bought</strong>".</p>
<p>In case of <strong>invalid input</strong> (negative money exception message: "<strong>Money cannot be negative</strong>"), empty name (empty name exception message: "<strong>Name cannot be empty</strong>") or an invalid price (invalid price exception message: "<strong>Price cannot be zero or negative</strong>") <strong>break</strong> the program with an appropriate message. See the examples below:</p>
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
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza Calories</h2>
<p>A Pizza is made of dough and different toppings. You should model a <strong>class Pizza,</strong> which should have a <strong>name</strong>, <strong>dough</strong> and <strong>toppings</strong> as fields. Every type of <strong>ingredient</strong> should have its <strong>own class</strong>. Every ingredient has different properties: the <strong>dough</strong> can be white or wholegrain and in addition, it can be crispy, chewy or homemade. The <strong>toppings</strong> can be of type meat, veggies, cheese or sauce. <strong>Every ingredient</strong> should have a <strong>weight</strong> in grams and a method for <strong>calculating</strong> its calories according to its type. Calories per gram are calculated through <strong>modifiers</strong>. Every ingredient has 2 calories per gram as a <strong>base</strong> and a <strong>modifier</strong> that <strong>gives</strong> the <strong>exact</strong> calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough weighting 100 grams will have 100 * 1.5 * 1.1 = 330.00 total calories.</p>
<p><strong>Your job</strong> is to model the classes in such a way that they are <strong>properly encapsulated</strong> and to provide a public method for every pizza that <strong>calculates its calories according to the ingredients it has</strong>.</p>
<h3>Step 1. Create a Dough Class</h3>
<p>The base ingredient of a Pizza is the dough. First, you need to create a <strong>class</strong> for it. It has a <strong>flour type,</strong> which can be <strong>white</strong> or <strong>wholegrain</strong>. In addition, it has a <strong>baking technique,</strong> which can be <strong>crispy</strong>, <strong>chewy</strong> or <strong>homemade</strong>. A dough should have a <strong>weight</strong> in grams. The calories per gram of a dough are calculated depending on the flour type and the baking technique. Every dough has 2 calories per gram as a base and a modifier that gives the exact calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough weighting 100 grams will have (2 * 100) * 1.5 * 1.1 = 330.00 total calories. You are given the modifiers below:</p>
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
<p>Make sure that if <strong>invalid flour type</strong> or an <strong>invalid baking technique</strong> is given a proper <strong>exception</strong> is thrown with the message "Invalid type of dough.".</p>
<p>The allowed weight of a dough is in the range [1..200] grams. If it is outside of this range throw an exception with the message "Dough weight should be in the range [1..200].".</p>
<h3>Exception Messages</h3>
<ul>
<li>"Invalid type of dough."</li>
<li>"Dough weight should be in the range [.200]."</li>
</ul>
<p>Make a test in your main method that reads Doughs and prints their calories until an "END" command is given.</p>
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
<h3>Step 3. Create a Topping Class</h3>
<p>Next, you need to create a <strong>Topping class</strong>. It can be of four different types &ndash; <strong>meat</strong>, <strong>veggies</strong>, <strong>cheese</strong> or a <strong>sauce</strong>. A topping has a <strong>weight</strong> in grams. The calories per gram of topping are calculated depending on its type. The <strong>base calories</strong> per gram are <strong>2</strong>. Every different type of topping has a modifier. For example, meat has a modifier of 1.2, so a meat topping will have 1.2 calories per gram (1 * 1.2). Everything that the class should expose is a getter for calories per gram. You are given the modifiers below:</p>
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
<h3>Step 5. Create a Pizza Class!</h3>
<p>A Pizza should have a <strong>name</strong>, some <strong>toppings</strong> and a <strong>dough</strong>. Make use of the two classes you made earlier. In addition, a pizza should have <strong>public getters</strong> for its <strong>name</strong>, <strong>number of toppings</strong> and the <strong>total calories</strong>. The <strong>total calories</strong> are <strong>calculated</strong><strong> by summing the calories of all the ingredients a pizza has</strong>. Create the class using a proper constructor, expose a method for adding a topping, a public setter for the dough and a getter method for the total calories.</p>
<p>The input for a pizza consists of <strong>several</strong> <strong>lines</strong>. On the first line is the <strong>pizza name</strong> and the <strong>number of toppings it has</strong>. On the second line, you will get input for the <strong>dough</strong>. On the next lines, you will receive every topping the pizza has. <strong>The number of lines for the toppings</strong> will correspond to the number of toppings declared on the first line.</p>
<p>If creation of the pizza was <strong>successful,</strong> print on a single line the name of the pizza and the <strong>total calories</strong> it has.</p>
<h3>Step 6. Validate Data for the Pizza Class</h3>
<p>The <strong>name</strong> of the pizza should <strong>not</strong> be an <strong>empty string</strong>. In addition, it should <strong>not be longer than 15 symbols</strong>. If it does not fit, throw an <strong>exception</strong> with the message "Pizza name should be between 1 and 15 symbols.".</p>
<p>The <strong>number of toppings</strong> should be in range [0..10]. If not, throw an <strong>exception</strong> with the message "Number of toppings should be in range [0..10]."</p>
<p>Your task is to print the <strong>name</strong> of the pizza and the <strong>total</strong> <strong>calories</strong> it has according to the examples below.</p>
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
<p>Pizza Meatless</p>
<p>Dough Wholegrain Crispy 100</p>
<p>Topping Veggies 50</p>
<p>Topping Cheese 50</p>
<p>END</p>
</td>
<td width="365">
<p>Meatless - 370.00 Calories.</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Burgas</p>
<p>Dough White Homemade 200</p>
<p>Topping Meat 123</p>
<p>END</p>
</td>
<td width="365">
<p>Meat weight should be in the range [1..50].</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Bulgarian</p>
<p>Dough Tip500 Balgarsko 100</p>
<p>Topping Sauce 20</p>
<p>Topping Cheese 50</p>
<p>Topping Cheese 40</p>
<p>Topping Meat 10</p>
<p>Topping Sauce 10</p>
<p>Topping Cheese 30</p>
<p>Topping Cheese 40</p>
<p>Topping Meat 20</p>
<p>Topping Sauce 30</p>
<p>Topping Cheese 25</p>
<p>Topping Cheese 40</p>
<p>Topping Meat 40</p>
<p>END</p>
</td>
<td width="365">
<p>Invalid type of dough.</p>
</td>
</tr>
<tr>
<td width="333">
<p>Pizza Bulgarian</p>
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
<p>&nbsp;</p>