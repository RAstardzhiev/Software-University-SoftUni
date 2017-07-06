<h1>Lab: Polymorphism</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/csharp-oop-basics">"C# OOP Basics" course @ SoftUni</a>".</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Compete/Index/680%230">https://judge.softuni.bg/Contests/Compete/Index/680#0</a>.</p>
<h2>1.&nbsp;&nbsp; MathOperation</h2>
<p>Create a class <strong>MathOperations</strong>, which should have 3 times method Add(). Method Add() have to be invoked with:</p>
<ul>
<li>Add(int, int): <strong>int</strong></li>
<li>Add(double, double, double): <strong>double</strong></li>
<li>Add(decimal, decimal, decimal): <strong>decimal</strong></li>
</ul>
<p>You should be able to use the class like this:</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>public static void Main()</p>
<p>{</p>
<p>&nbsp;&nbsp; MathOperations mo = new MathOperations();</p>
<p>&nbsp;&nbsp; Console.WriteLine(mo.Add(2, 3));</p>
<p>&nbsp;&nbsp; Console.WriteLine(mo.Add(2.2, 3.3, 5.5));</p>
<p>&nbsp;&nbsp; Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m))</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="482">
<tbody>
<tr>
<td width="181">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="181">
<p>&nbsp;</p>
</td>
<td width="302">
<p>5</p>
<p>11</p>
<p>9.9</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;&nbsp;</p>
<h2>2.&nbsp;&nbsp; Animals</h2>
<p>Create a class Animal, which hold two fields:</p>
<ul>
<li>name: string</li>
<li>favouriteFood: string</li>
</ul>
<p>Animal have one virtual method <strong>ExplainMyself(): string<br /> </strong>You should add two new classes <strong>Cat </strong>and <strong>Dog. </strong>There override ExplainMyself() method by adding concrete animal sound on new line. (Look at examples below)</p>
<p>You should be able to use the class like this:</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>Animal cat = new Cat("Pesho", "Whiskas");</p>
<p>Animal dog = new Dog("Gosho", "Meat");</p>
<p>&nbsp;</p>
<p>Console.WriteLine(cat.ExplainMyself());</p>
Console.WriteLine(dog.ExplainMyself());</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="426">
<tbody>
<tr>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="366">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="366">
<p>I am Pesho and my fovourite food is Whiskas</p>
<p>MEEOW</p>
<p>I am Gosho and my fovourite food is Meat</p>
<p>DJAAF</p>
</td>
</tr>
</tbody>
</table>
<h2><br />3.&nbsp;&nbsp; Shapes</h2>
<p>Create class hierarchy, starting with <strong>abstract</strong> class Shape:</p>
<ul>
<li><strong>Abstract methods:</strong>
<ul>
<li>calculatePerimeter(): doulbe</li>
<li>calculateArea(): double</li>
</ul>
</li>
<li><strong>Virtual methods</strong>:
<ul>
<li>Draw(): string</li>
</ul>
</li>
</ul>
<p>Extend Shape class with two children:</p>
<ul>
<li><strong>Rectangle</strong></li>
<li><strong>Circle</strong></li>
</ul>
<p>Each of them need to have:</p>
<ul>
<li><strong>Fields: </strong>
<ul>
<li><strong>height and width for Rectangle</strong></li>
<li><strong>radius for Circle</strong></li>
</ul>
</li>
<li><strong>Encapsulation for this fields</strong></li>
<li><strong>Public constructor </strong></li>
<li><strong>Concrete methods for calculations (perimeter and area)</strong></li>
<li><strong>Override methods for drawing</strong></li>
</ul>