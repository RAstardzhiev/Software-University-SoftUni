<h1>Exercises: Generics</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/trainings/1637/c-sharp-oop-advanced-july-2017">"C# OOP Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/248/Generics-Exercise">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Box</h2>
<p>Create a generic class Box that can be initialized with any type and store the value. <strong>Override</strong> the <strong>ToString()</strong> method to print the type and the value of the data stored in the format <strong>{class full name: value}.</strong></p>
<h3>Note</h3>
<p>This problem does not have tests in Judge but instead, the class is used in the next problems.</p>
<p>In order to get a class' full name, use <a href="https://msdn.microsoft.com/en-us/library/system.type.fullname(v=vs.110).aspx">.GetType().FullName</a> property.</p>
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
<p>123123</p>
</td>
<td width="378">
<p>System.Int32: 12313</p>
</td>
</tr>
<tr>
<td width="198">
<p>life in a box</p>
</td>
<td width="378">
<p>System.String: life in a box</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Box of String</h2>
<p>Use the class that you've created for the previous problem and test it with the class <strong>System.String</strong><strong>.</strong> On the first line you will get <strong>n</strong> - the number of strings to read from the console. On the next <strong>n </strong>lines, you will get the actual strings. For each of them create a box and call its <strong>ToString()</strong> method to print its data on the console.</p>
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
<p>2</p>
<p>life in a box</p>
<p>box in a life</p>
</td>
<td width="378">
<p>System.String: life in a box</p>
<p>System.String: box in a life</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Box of Integer</h2>
<p>Use the description of the previous problem but now, test your generic box with Integers.</p>
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
<p>3</p>
<p>7</p>
<p>123</p>
<p>42</p>
</td>
<td width="378">
<p>System.Int32: 7</p>
<p>System.Int32: 123</p>
<p>System.Int32: 42</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Swap Method Strings</h2>
<p>Create a generic method that receives a list containing any type of data and swaps the elements at two given indexes.</p>
<p>As in the previous problems read <strong>n</strong> number of boxes of type String and add them to the list. On the next line, however you will receive a swap command consisting of two indexes. Use the method you've created to swap the elements that correspond to the given indexes and print each element in the list.</p>
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
<p>3</p>
<p>Pesho</p>
<p>Gosho</p>
<p>Swap me with Pesho</p>
<p>0 2</p>
</td>
<td width="378">
<p>System.String: Swap me with Pesho</p>
<p>System.String: Gosho</p>
<p>System.String: Pesho</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Swap Method Integers</h2>
<p>Use the description of the previous problem but now, test your list of generic boxes with Integers.</p>
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
<p>3</p>
<p>7</p>
<p>123</p>
<p>42</p>
<p>0 2</p>
</td>
<td width="378">
<p>System.Int32: 42</p>
<p>System.Int32: 123</p>
<p>System.Int32: 7</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Count Method Strings</h2>
<p>Create a <strong>method</strong> that receives as argument a <strong>list of any type that can be compared</strong> and an <strong>element of the given type</strong>. The method should <strong>return the count of elements that are greater than the value of the given element</strong>. <strong>Modify your Box class</strong> to support <strong>comparing by value</strong> of the data stored.</p>
<p>On the first line you will receive <strong>n </strong>- the number of elements to add to the list. On the next <strong>n</strong> lines, you will receive the actual elements. On the last line you will get the value of the element to which you need to compare every element in the list.</p>
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
<p>3</p>
<p>aa</p>
<p>aaa</p>
<p>bb</p>
<p>aa</p>
</td>
<td width="378">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generic Count Method Doubles</h2>
<p>Use the description of the previous problem but now, test your list of generic boxes with <strong>doubles</strong>.</p>
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
<p>3</p>
<p>7.13</p>
<p>123.22</p>
<p>42.78</p>
<p>7.55</p>
</td>
<td width="378">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Custom List</h2>
<p>Create a generic data structure that can store <strong>any</strong> type that <strong>can</strong> be compared. Implement functions:</p>
<ul>
<li><strong>void Add(T element)</strong></li>
<li><strong>T Remove(int index)</strong></li>
<li><strong>bool Contains(T element)</strong></li>
<li><strong>void Swap(int index1, int index2)</strong></li>
<li><strong>int CountGreaterThan(T element)</strong></li>
<li><strong>T Max()</strong></li>
<li><strong>T Min()</strong></li>
</ul>
<p>Create a command interpreter that reads commands and modifies the custom list that you have created. Set the custom list&rsquo;s type to string. Implement the commands:</p>
<ul>
<li><strong>Add &lt;element&gt;</strong> - Adds the given element to the end of the list</li>
<li><strong>Remove &lt;index&gt;</strong> - Removes the element at the given index</li>
<li><strong>Contains &lt;element&gt;</strong> - Prints if the list contains the given element <strong>(True or False)</strong></li>
<li><strong>Swap &lt;index&gt; &lt;index&gt; </strong>- Swaps the elements at the given indexes</li>
<li><strong>Greater &lt;element&gt;</strong> - Counts the elements that are greater than the given element and prints their count</li>
<li><strong>Max</strong> - Prints the maximum element in the list</li>
<li><strong>Min</strong> - Prints the minimum element in the list</li>
<li><strong>Print</strong> - Prints all elements in the list, each on a separate line</li>
<li><strong>END</strong> - stops the reading of commands</li>
</ul>
<p>There will <strong>not</strong> be any <strong>invalid</strong> input commands.</p>
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
<p>Add aa</p>
<p>Add bb</p>
<p>Add cc</p>
<p>Max</p>
<p>Min</p>
<p>Greater aa</p>
<p>Swap 0 2</p>
<p>Contains aa</p>
<p>Print</p>
<p>END</p>
</td>
<td width="378">
<p>cc</p>
<p>aa</p>
<p>2</p>
<p>true</p>
<p>cc</p>
<p>bb</p>
<p>aa</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Custom List Sorter</h2>
<p>Extend the previous problem by creating an additional <strong>Sorter class</strong>. It should have a single static <strong>method</strong> <strong>Sort()</strong> which can sort objects of type <strong>CustomList</strong> containing any type that can be compared. <strong>Extend the command list</strong> to support one additional command Sort:</p>
<ul>
<li><strong>Sort</strong> - Sort the elements in the list in ascending order.</li>
</ul>
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
<p>Add cc</p>
<p>Add bb</p>
<p>Add aa</p>
<p>Sort</p>
<p>Print</p>
<p>END</p>
</td>
<td width="378">
<p>aa</p>
<p>bb</p>
<p>cc</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 10. *Custom List Iterator</h2>
<p>For the print command you have probably used a <strong>for</strong> loop. Extend your custom list class by making it to implement<strong> IEnumerable&lt;T&gt;.</strong> This should allow you to iterate your list in a foreach statement.</p>
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
<p>Add aa</p>
<p>Add bb</p>
<p>Add cc</p>
<p>Max</p>
<p>Min</p>
<p>Greater aa</p>
<p>Swap 0 2</p>
<p>Print</p>
<p>END</p>
</td>
<td width="378">
<p>cc</p>
<p>aa</p>
<p>2</p>
<p>cc</p>
<p>bb</p>
<p>aa</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11. &nbsp;Tuple</h2>
<p>There is something, really annoying in C#. It is called a <a href="https://msdn.microsoft.com/en-us/library/system.tuple(v=vs.110).aspx"><strong>Tuple</strong></a>. It is a class, which may store a few objects but let&rsquo;s focus on the type of Tuple which contains two objects. The first one is &ldquo;<strong>item1</strong>&rdquo; and the second one is &ldquo;<strong>item2</strong>&rdquo;. It is kind of like a <strong>KeyValuePair</strong> except &ndash; it <strong>simply has items, </strong>which are <strong>neither key nor value</strong>. The annoyance is coming from the fact, that you have no idea what these objects are holding. The class name is telling you nothing, the methods which it has &ndash; also. So let&rsquo;s say for some reason we would like to try to implement it by ourselves and provide it in Java, just for practicing generics.</p>
<p>The task: Create a class &ldquo;<strong>Tuple</strong>&rdquo;, which is holding two objects. Like we said, the first one, will be &ldquo;<strong>item1</strong>&rdquo; and the second one - &ldquo;<strong>item2</strong>&rdquo;. The tricky part here is to make the class hold generics. This means, that when you create a new object of class - &ldquo;<strong>Tuple</strong>&rdquo;, there should be a way to explicitly, specify both the items type separately.</p>
<h3>Input</h3>
<p>The input consists of three lines:</p>
<ul>
<li>The first one is holding a person name and an address. They are separated by space(s). Your task is to collect them in the tuple and print them on the console. Format of the input:</li>
</ul>
<p><strong>&lt;&lt;first name&gt; &lt;last name&gt;&gt;</strong> <strong>&lt;address&gt;</strong></p>
<ul>
<li>The second line holds a <strong>name </strong>of a person and the <strong>amount of beer</strong> (int) he can drink. Format:</li>
</ul>
<p><strong>&lt;name&gt; &lt;liters of beer&gt;</strong></p>
<ul>
<li>The last line will hold an <strong>Integer</strong> and a <strong>Double</strong>. Format:</li>
</ul>
<p><strong>&lt;Integer&gt; &lt;Double&gt;</strong></p>
<h3>Output</h3>
<ul>
<li>Print the tuples&rsquo; items in format: {<strong>item1</strong>} -&gt; {<strong>item2</strong>}</li>
</ul>
<h3>Constraints</h3>
<p>Use the good practices we have learned. Create the class and make it have getters and setters for its class variables. The input will be valid, no need to check it explicitly!</p>
<h3>Example</h3>
<table width="624">
<tbody>
<tr>
<td width="264">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="264">
<p>Sofka Tripova Stolipinovo</p>
<p>Az 2</p>
<p>23 21.23212321</p>
</td>
<td width="360">
<p>Sofka Tripova -&gt; Stolipinovo</p>
<p>Az -&gt; 2</p>
<p>23 -&gt; 21.23212321</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12. &nbsp;Threeuple</h2>
<p>Create a Class <strong>Threeuple</strong>. Its name is telling us, that it will hold no longer, just a pair of objects. The task is simple, our <strong>Threeuple</strong> should <strong>hold three obj</strong><strong>ects</strong>. Make it have getters and setters. You can even extend the previous class</p>
<h3>Input</h3>
<p>The input consists of three lines:</p>
<ul>
<li>The first one is holding a name, an address and a town. Format of the input:</li>
</ul>
<p><strong>&lt;&lt;first name&gt; &lt;last name&gt;&gt; &lt;address&gt; &lt;town&gt;</strong></p>
<ul>
<li>The second line is holding a name, beer liters, and a Boolean variable with value - <strong>drunk</strong> or <strong>not</strong>. Format:</li>
</ul>
<p><strong>&lt;name&gt; &lt;liters of beer&gt; &lt;drunk or not&gt;</strong></p>
<ul>
<li>The last line will hold a name, a bank balance (double) and a bank name. Format:</li>
</ul>
<p><strong>&lt;name&gt; &lt;account balance&gt; &lt;bank name&gt;</strong></p>
<h3>Output</h3>
<ul>
<li>Print the Threeuples&rsquo; objects in format: {<strong>firstElement</strong>} -&gt; {<strong>secondElement</strong>} -&gt; {<strong>thirdElement</strong>}</li>
</ul>
<h3>Examples</h3>
<table width="642">
<tbody>
<tr>
<td width="294">
<p><strong>Input</strong></p>
</td>
<td width="348">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="294">
<p>Sofka Tripova Stolipinovo Plovdiv</p>
<p>MitkoShtaigata 18 drunk</p>
<p>SashoKompota 0.10 NkqfaBanka</p>
</td>
<td width="348">
<p>Sofka Tripova -&gt; Stolipinovo -&gt; Plovdiv</p>
<p>MitkoShtaigata -&gt; 18 -&gt; True</p>
<p>SashoKompota -&gt; 0.1 -&gt; NkqfaBanka</p>
</td>
</tr>
<tr>
<td width="294">
<p>Ivan Ivanov Tepeto Plovdiv</p>
<p>Mitko 18 not</p>
<p>Sasho 0.10 NGB</p>
</td>
<td width="348">
<p>Ivan Ivanov -&gt; Tepeto -&gt; Plovdiv</p>
<p>Mitko -&gt; 18 -&gt; False</p>
<p>Sasho -&gt; 0.1 -&gt; NGB</p>
</td>
</tr>
</tbody>
</table>
<h3>Note</h3>
<p>You may extend your previous solution.</p>