<h1>Exercises: Reflection</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/trainings/1637/c-sharp-oop-advanced-july-2017">"C# OOP Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/263/Reflection-Exercise">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Harvesting Fields</h2>
<p>You are given a <strong>RichSoilLand</strong> class with lots of fields (look at the provided skeleton). Like a good farmer as what you are, you must harvest them. Harvesting means that you must print each field in a certain format (see output).</p>
<h3>Input</h3>
<p>You will receive a maximum of 100 lines with one of the following commands:</p>
<ul>
<li><strong>private -</strong> print all private fields</li>
<li><strong>protected</strong> - print all protected fields</li>
<li><strong>public</strong> - print all public fields</li>
<li><strong>all</strong> - print ALL declared fields</li>
<li><strong>HARVEST</strong> - end the input</li>
</ul>
<h3>Output</h3>
<p>For each command, you must print the fields that have the given access modifier as described in the input section. The format in which the fields should be printed is:</p>
<p><strong>"&lt;access modifier&gt; &lt;field type&gt; &lt;field name&gt;"</strong></p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>protected</p>
<p>HARVEST</p>
</td>
<td width="378">
<p>protected String testString</p>
<p>protected Double aDouble</p>
<p>protected Byte testByte</p>
<p>protected StringBuilder aBuffer</p>
<p>protected BigInteger testBigNumber</p>
<p>protected Single testFloat</p>
<p>protected Object testPredicate</p>
<p>protected Object fatherMotherObject</p>
<p>protected String moarString</p>
<p>protected Exception inheritableException</p>
<p>protected Stream moarStreamz</p>
</td>
</tr>
<tr>
<td width="198">
<p>private</p>
<p>public</p>
<p>private</p>
<p>HARVEST</p>
</td>
<td width="378">
<p>private Int32 testInt</p>
<p>private Int64 testLong</p>
<p>private Calendar aCalendar</p>
<p>private Char testChar</p>
<p>private BigInteger testBigInt</p>
<p>private Thread aThread</p>
<p>private Object aPredicate</p>
<p>private Object hiddenObject</p>
<p>private String anotherString</p>
<p>private Exception internalException</p>
<p>private Stream secretStream</p>
<p>public Double testDouble</p>
<p>public String aString</p>
<p>public StringBuilder aBuilder</p>
<p>public Int16 testShort</p>
<p>public Byte aByte</p>
<p>public Single aFloat</p>
<p>public Thread testThread</p>
<p>public Object anObject</p>
<p>public Int32 anotherIntBitesTheDust</p>
<p>public Exception justException</p>
<p>public Stream aStream</p>
<p>private Int32 testInt</p>
<p>private Int64 testLong</p>
<p>private Calendar aCalendar</p>
<p>private Char testChar</p>
<p>private BigInteger testBigInt</p>
<p>private Thread aThread</p>
<p>private Object aPredicate</p>
<p>private Object hiddenObject</p>
<p>private String anotherString</p>
<p>private Exception internalException</p>
<p>private Stream secretStream</p>
</td>
</tr>
<tr>
<td width="198">
<p>all</p>
<p>HARVEST</p>
</td>
<td width="378">
<p>private Int32 testInt</p>
<p>public Double testDouble</p>
<p>protected String testString</p>
<p>private Int64 testLong</p>
<p>protected Double aDouble</p>
<p>public String aString</p>
<p>private Calendar aCalendar</p>
<p>public StringBuilder aBuilder</p>
<p>private Char testChar</p>
<p>public Int16 testShort</p>
<p>protected Byte testByte</p>
<p>public Byte aByte</p>
<p>protected StringBuilder aBuffer</p>
<p>private BigInteger testBigInt</p>
<p>protected BigInteger testBigNumber</p>
<p>protected Single testFloat</p>
<p>public Single aFloat</p>
<p>private Thread aThread</p>
<p>public Thread testThread</p>
<p>private Object aPredicate</p>
<p>protected Object testPredicate</p>
<p>public Object anObject</p>
<p>private Object hiddenObject</p>
<p>protected Object fatherMotherObject</p>
<p>private String anotherString</p>
<p>protected String moarString</p>
<p>public Int32 anotherIntBitesTheDust</p>
<p>private Exception internalException</p>
<p>protected Exception inheritableException</p>
<p>public Exception justException</p>
<p>public Stream aStream</p>
<p>protected Stream moarStreamz</p>
<p>private Stream secretStream</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Black Box Integer</h2>
<p>You are helping a buddy of yours who is still in the OOP Basics course - his name is Peshoslav (not to be mistaken with real people or trainers). He is rather slow and made a class with all private members. Your tasks are to instantiate an object from his class (always with start value 0) and then invoke the different methods it has. Your restriction is to not change anything in the class itself (consider it a black box). You can look at his class but don't touch anything! The class itself is called <strong>BlackBoxInt</strong> it is a wrapper for the <strong>int</strong> primitive.</p>
<p>The methods this class has are:</p>
<ul>
<li>Add(int)</li>
<li>Subtract(int)</li>
<li>Multiply(int)</li>
<li>Divide(int)</li>
<li>LeftShift(int)</li>
<li>RightShift(int)</li>
</ul>
<h3>Input</h3>
<p>The input will consist of lines in the form:</p>
<p><strong>&lt;method name&gt;_&lt;value&gt;</strong></p>
<p>For instance: <strong>Add_115</strong></p>
<p>Input will always be valid and in the format described, so there is no need to check it explicitly. You stop receiving input when you encounter the command "<strong>END</strong>".</p>
<h3>Output</h3>
<p>Each command (except the <strong>END</strong> one) should print the current value of <strong>innerValue</strong> of the BlackBoxInt object you instantiated. Don't cheat by overriding ToString() in the class - you must get the value from the <strong>private</strong> field.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Add_999999</p>
<p>Subtract_19</p>
<p>Divide_4</p>
<p>Multiply_2</p>
<p>RightShift_1</p>
<p>LeftShift_3</p>
<p>END</p>
</td>
<td width="378">
<p>999999</p>
<p>999980</p>
<p>249995</p>
<p>499990</p>
<p>249995</p>
<p>1999960</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BarracksWars - A New Factory</h2>
<p>You are given a small console based project called Barracks (the code for it is included in the provided skeleton).</p>
<p>The general functionalities of the project are adding new units to its repository and printing a report with statistics about the units currently in the repository. First let's go over the original task before the project was created:</p>
<h3>Input</h3>
<p>The input consists of commands each on a separate line. Commands that execute the functionality are:</p>
<ul>
<li><strong>add </strong>&lt;<strong>Archer</strong>/<strong>Swordsman</strong>/<strong>Pikeman/{&hellip;}</strong>&gt; - adds a unit to the repository.</li>
<li><strong>report</strong> - prints a lexicological ordered statistic about the units in the repository.</li>
<li><strong>fight</strong> - ends the input.</li>
</ul>
<h3>Output</h3>
<p>Each command except <strong>fight</strong> should print output on the console.</p>
<ul>
<li><strong>add </strong>should print: "&lt;<strong>Archer</strong>/<strong>Swordsman</strong>/<strong>Pikeman</strong>/<strong>{&hellip;}&gt; added!</strong>"</li>
<li><strong>report</strong> should print all the info in the repository in the format: "&lt;<strong>UnitType</strong>&gt;<strong> -&gt; </strong>&lt;<strong>UnitQuantity</strong>&gt;", sorted by UnitType</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Input will consist of no more than <strong>1000</strong> lines</li>
<li><strong>report</strong> command will never be given before any valid add command was provided</li>
</ul>
<p>&nbsp;</p>
<h3>Your task</h3>
<p>1) You have to <strong>study the code of the project and figure out how it works</strong>. However, there are parts of it that are not implemented (left with TODOs). You must implement the functionality of the <strong>CreateUnit </strong>method in the <strong>UnitFactory </strong>class so that it creates a unit based on the unit type received as parameter. Implement it in such a way that whenever you add a new unit it will be creatable without the need to change anything in the <strong>UnitFactory </strong>class (<em>psst</em><em> - use reflection</em>). You can use the approach called <strong>Simple Factory</strong>.</p>
<p>2) Add two new unit classes (there will be tests that require them) - <strong>Horseman </strong>with 50 health and 10 attack and <strong>Gunner </strong>with 20 health and 20 attack.</p>
<p>If you complete everything correctly for this problem, you should add code only inside the <strong>Factories</strong> and <strong>Units</strong> folders.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>add Swordsman</p>
<p>add Archer</p>
<p>add Pikeman</p>
<p>report</p>
<p>add Pikeman</p>
<p>add Pikeman</p>
<p>report</p>
<p>fight</p>
</td>
<td width="378">
<p>Swordsman added!</p>
<p>Archer added!</p>
<p>Pikeman added!</p>
<p>Archer -&gt; 1</p>
<p>Pikeman -&gt; 1</p>
<p>Swordsman -&gt; 1</p>
<p>Pikeman added!</p>
<p>Pikeman added!</p>
<p>Archer -&gt; 1</p>
<p>Pikeman -&gt; 3</p>
<p>Swordsman -&gt; 1</p>
</td>
</tr>
<tr>
<td width="198">
<p>add Pikeman</p>
<p>add Pikeman</p>
<p>add Gunner</p>
<p>add Horseman</p>
<p>add Archer</p>
<p>add Gunner</p>
<p>add Gunner</p>
<p>add Horseman</p>
<p>report</p>
<p>fight</p>
</td>
<td width="378">
<p>Pikeman added!</p>
<p>Pikeman added!</p>
<p>Gunner added!</p>
<p>Horseman added!</p>
<p>Archer added!</p>
<p>Gunner added!</p>
<p>Gunner added!</p>
<p>Horseman added!</p>
<p>Archer -&gt; 1</p>
<p>Gunner -&gt; 3</p>
<p>Horseman -&gt; 2</p>
<p>Pikeman -&gt; 2</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BarracksWars - The Commands Strike Back</h2>
<p>As you might have noticed commands in the project from Problem 3 are implemented via a switch case with method calls in the <strong>Engine</strong> class. Although this approach works it is flawed when you add a new command because you have to add a new case for it. In some projects, you might not have access to the engine and this would not work. Imagine this project will be outsourced and the outsourcing firm will not have access to the engine. Make it so whenever they want to add a new command they won't have to change anything in the <strong>Engine.</strong></p>
<p>To do so employ the design pattern called <a href="https://en.wikipedia.org/wiki/Command_pattern"><strong>Command Pattern</strong></a>. We've done this in the <strong>BashSoft</strong> <strong>Lab</strong> and you can look there for tips too. Use the provided <strong>Executable </strong>interface as a frame for the command classes. Put the new command classes in the provided <strong>commands</strong> package inside <strong>core</strong>. You can also make a Command Interpreter to decouple that functionality from the Engine. Here is how the base (abstract) command should look like:</p>
<p>Notice how all commands that extend this one will have both a Repository and a <strong>UnitFactory</strong> although not all of them need these. Leave it like this for this problem, because for the reflection to work we need all constructors to accept the same parameters. We will see how to go around this issue in problem 5.</p>
<p>Once you've implemented the pattern add a new command. It will have the following syntax:</p>
<ul>
<li><strong>retire</strong> &lt;<strong>UnitType</strong>&gt; - All it has to do is remove a unit of the provided type from the repository.
<ul>
<li>If there are no such units currently in the repository print: "<strong>No such units in repository.</strong>"</li>
<li>If there is such a unit currently in the repository, print: "<strong>&lt;UnitType&gt; retired!</strong>"</li>
</ul>
</li>
</ul>
<p>To implement this command, you will also have to implement a corresponding method in the <strong>UnitRepository</strong>.</p>
<p>If you do everything correctly for this problem, you should write/refactor code only in the <strong>Core</strong> and <strong>Data</strong> packages.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>retire Archer</p>
<p>add Pikeman</p>
<p>add Pikeman</p>
<p>add Gunner</p>
<p>add Horseman</p>
<p>add Archer</p>
<p>add Gunner</p>
<p>add Gunner</p>
<p>add Horseman</p>
<p>report</p>
<p>retire Gunner</p>
<p>retire Archer</p>
<p>report</p>
<p>retire Swordsman</p>
<p>retire Archer</p>
<p>fight</p>
</td>
<td width="378">
<p>No such units in repository.</p>
<p>Pikeman added!</p>
<p>Pikeman added!</p>
<p>Gunner added!</p>
<p>Horseman added!</p>
<p>Archer added!</p>
<p>Gunner added!</p>
<p>Gunner added!</p>
<p>Horseman added!</p>
<p>Archer -&gt; 1</p>
<p>Gunner -&gt; 3</p>
<p>Horseman -&gt; 2</p>
<p>Pikeman -&gt; 2</p>
<p>Gunner retired!</p>
<p>Archer retired!</p>
<p>Archer -&gt; 0</p>
<p>Gunner -&gt; 2</p>
<p>Horseman -&gt; 2</p>
<p>Pikeman -&gt; 2</p>
<p>No such units in repository.</p>
<p>No such units in repository.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * BarracksWars - Return of the Dependencies</h2>
<p>In the final part of this epic problem trilogy we will resolve the issue where all Commands received all utility classes as parameters in their constructors. We can accomplish this by using an approach called <strong>dependency injection container</strong>. This approach is used in many frameworks.</p>
<p>We will do a little twist on that approach. Remove all fields from the abstract command except the <strong>data. </strong>Instead put whatever fields each command needs in the concrete class. Create an attribute called <strong>Inject</strong> and make it so it can be used only on fields. Put the attribute over the fields we need to set trough reflection. Once you've prepared all of this, write the necessary reflection code in the <strong>Command Interpreter </strong>(which you should have refactored out from the engine in problem 4).</p>
<p>You can use the same example as in Problem 4 to check if you completed the task correctly.</p>