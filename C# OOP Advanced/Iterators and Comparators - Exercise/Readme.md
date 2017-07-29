<h1>Exercises: Iterators And Comparators</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/csharp-advanced-oop">"C# OOP Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ListyIterator</h2>
<p>Create a generic class "ListyIterator", it should receive the collection which it will iterate, through its constructor. You should store the elements in a List. The class should have three main functions:</p>
<ul>
<li><strong>Move</strong> - should move an internal index position to the next index in the list, the method should return true if it successfully moved and false if there is no next index.</li>
<li><strong>HasNext</strong> - should return true if there is a next index and false if the index is already at the last element of the list.</li>
<li><strong>Print</strong> - should print the element at the current internal index, calling Print on a collection without elements should throw an appropriate exception with the message "<strong>Invalid Operation!</strong>".</li>
</ul>
<p>By default, the internal index should be pointing to the <strong>0<sup>th</sup> index</strong> of the List. Your program should support the following commands:</p>
<table width="691">
<tbody>
<tr>
<td width="166">
<p><strong>Command</strong></p>
</td>
<td width="217">
<p><strong>Return Type</strong></p>
</td>
<td width="308">
<p><strong>Description</strong></p>
</td>
</tr>
<tr>
<td width="166">
<p>Create {e1 e2 &hellip;}</p>
</td>
<td width="217">
<p>void</p>
</td>
<td width="308">
<p>Creates a ListyIterator from the specified collection. In case of a Create command without any elements, you should create a ListyIterator with an empty collection.</p>
</td>
</tr>
<tr>
<td width="166">
<p>Move</p>
</td>
<td width="217">
<p>boolean</p>
</td>
<td width="308">
<p>This command should move the internal index to the next index.</p>
</td>
</tr>
<tr>
<td width="166">
<p>Print</p>
</td>
<td width="217">
<p>void</p>
</td>
<td width="308">
<p>This command should print the element at the current internal index.</p>
</td>
</tr>
<tr>
<td width="166">
<p>HasNext</p>
</td>
<td width="217">
<p>boolean</p>
</td>
<td width="308">
<p>Returns whether the collection has a next element.</p>
</td>
</tr>
<tr>
<td width="166">
<p>END</p>
</td>
<td width="217">
<p>void</p>
</td>
<td width="308">
<p>Stops the input.</p>
</td>
</tr>
</tbody>
</table>
<h3>Input</h3>
<p>Input will come from the console as lines of commands. The first line will always be the <strong>only</strong> Create command in the input. The last command received will always be the only <strong>END</strong> command.</p>
<h3>Output</h3>
<p>For every command from the input (with the exception of the <strong>END</strong> and <strong>Create</strong> commands) print the result of that command on the console, each on a new line. In case of <strong>Move</strong> or <strong>HasNext</strong> commands print the return value of the method, in case of a <strong>Print</strong> command you don&rsquo;t have to do anything additional as the method itself should already print on the console. Your program should catch any exceptions thrown because of validations (calling Print on an empty collection) and print their messages instead.</p>
<h3>Constraints</h3>
<ul>
<li>There will always be only <strong>1</strong> <strong>Create</strong> command and it will always be the first command passed.</li>
<li>The number of commands received will be between <strong>[1&hellip;100]</strong>.</li>
<li>The last command will always be the only <strong>END</strong></li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>Create</p>
<p>Print</p>
<p>END</p>
</td>
<td width="435">
<p>Invalid Operation!</p>
</td>
</tr>
<tr>
<td width="260">
<p>Create Stefcho Goshky</p>
<p>HasNext</p>
<p>Print</p>
<p>Move</p>
<p>Print</p>
<p>END</p>
</td>
<td width="435">
<p>True</p>
<p>Stefcho</p>
<p>True</p>
<p>Goshky</p>
</td>
</tr>
<tr>
<td width="260">
<p>Create 1 2 3</p>
<p>HasNext</p>
<p>Move</p>
<p>HasNext</p>
<p>HasNext</p>
<p>Move</p>
<p>HasNext</p>
<p>END</p>
</td>
<td width="435">
<p>True</p>
<p>True</p>
<p>True</p>
<p>True</p>
<p>True</p>
<p>False</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Collection</h2>
<p>Using the ListyIterator from the last problem, extend it by implementing the <strong>IEnumerable&lt;T&gt;</strong> interface, implement all methods desired by the interface manually (use <strong>yield return</strong> for <strong>GetEnumerator()</strong> method). Add a new command <strong>PrintAll</strong> that should foreach the collection and <strong>print</strong><strong> all elements</strong> on a <strong>single line separated by a space</strong>.</p>
<h3>Input</h3>
<p>Input will come from the console as lines of commands. The first line will always be the <strong>only</strong> Create command in the input. The last command received will always be the only <strong>END</strong> command.</p>
<h3>Output</h3>
<p>For every command from the input (with the exception of the <strong>END</strong> and <strong>Create</strong> commands) print the result of that command on the console, each on a new line. In case of <strong>Move</strong> or <strong>HasNext</strong> commands print the return value of the method, in case of a <strong>Print</strong> command you don&rsquo;t have to do anything additional as the method itself should already print on the console. In case of a <strong>PrintAll</strong> command you should print all elements on a single line separated by spaces. Your program should catch any exceptions thrown because of validations and print their messages instead.</p>
<h3>Constraints</h3>
<ul>
<li><strong>Do NOTuse the GetEnumerator() method from the base class. Use your own implementation using &ldquo;yield return&rdquo;</strong></li>
<li>There will always be only <strong>1</strong> <strong>Create</strong> command and it will always be the first command passed.</li>
<li>The number of commands received will be between <strong>[1&hellip;100]</strong>.</li>
<li>The last command will always be the only <strong>END</strong></li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>Create 1 2 3 4 5</p>
<p>Move</p>
<p>PrintAll</p>
<p>END</p>
</td>
<td width="435">
<p>True</p>
<p>1 2 3 4 5</p>
</td>
</tr>
<tr>
<td width="260">
<p>Create Stefcho Goshky Peshu</p>
<p>PrintAll</p>
<p>Move</p>
<p>Move</p>
<p>Print</p>
<p>HasNext</p>
<p>END</p>
</td>
<td width="435">
<p>Stefcho Goshky Peshu</p>
<p>True</p>
<p>True</p>
<p>Peshu</p>
<p>False</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Stack</h2>
<p>Since you have passed the basics algorithms course, now you have a task to create your custom stack. You are aware of the Stack's structure. There is a collection to store the elements and two functions (not from the functional programming) - to push an element and to pop it. Keep in mind that the first element which is popped is the last in the collection. The push method adds an element to the top of the collection and the pop method returns the top element and removes it.</p>
<p>Write your custom implementation of <strong>Stack&lt;T&gt;</strong> and implement <strong>IEnumerable&lt;T&gt; </strong>interface. Your implementation of the <strong>GetEnumerator()</strong> method should follow the rules of the Abstract Data Type &ndash; <strong>Stack</strong> (return the elements in reverse order of adding them to the stack)</p>
<h3>Input</h3>
<p>The input will come from the console as lines of commands. Commands will only be <strong>push</strong> and<strong> pop</strong>, followed by integers for the <strong>push</strong> command and no another input for the<strong> pop</strong> command.</p>
<p>Format:</p>
<ul>
<li><strong>Push {element1}, {element2}, &hellip; {elementN} &ndash; </strong>add given elements to the stack</li>
<li><strong>Pop &ndash; </strong>removes the last pushed element from the stack</li>
</ul>
<h3>Output</h3>
<p>When you receive <strong>END</strong>, the input is over. Foreach the stack <strong>twice</strong> and print all elements each on new line.</p>
<h3>Constraints</h3>
<ul>
<li>The elements in the push command will be valid integers between <strong>[2<sup>-32</sup>&hellip;2<sup>32</sup>-1]</strong>.</li>
<li>The commands will always be valid (always be either <strong>Push</strong><strong>, Pop </strong>or<strong> END</strong>).</li>
<li>If Pop command could not be executed as expected (e.g. no elements in the stack), print on the console: "<strong>No elements</strong>".</li>
</ul>
<h3>Examples</h3>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>Push 1, 2, 3, 4</p>
<p>Pop</p>
<p>Pop</p>
<p>END</p>
</td>
<td width="435">
<p>2</p>
<p>1</p>
<p>2</p>
<p>1</p>
</td>
</tr>
<tr>
<td width="260">
<p>Push 1, 2, 3, 4</p>
<p>Pop</p>
<p>Push 1</p>
<p>END</p>
</td>
<td width="435">
<p>1</p>
<p>3</p>
<p>2</p>
<p>1</p>
<p>1</p>
<p>3</p>
<p>2</p>
<p>1</p>
</td>
</tr>
<tr>
<td width="260">
<p>Push 1, 2, 3, 4</p>
<p>Pop</p>
<p>Pop</p>
<p>Pop</p>
<p>Pop</p>
<p>Pop</p>
<p>END</p>
</td>
<td width="435">
<p>No elements</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Froggy</h2>
<p>Let's play a game. You have a tiny little <strong>Frog</strong>, and a <strong>Lake</strong> that has path of stones in it. Every <strong>stone has a number</strong>. Our frog must <strong>cross the lake</strong> along that path and <strong>then return</strong>. But there are some rules when jumping on the stones. Firstly, the frog must <strong>jump on all even positions</strong> of the stones <strong>then on all odd positions</strong> but in <strong>reversed order</strong>. The order of the stones and their numbers will be given on the first line of input. Then you must <strong>print the order of stones which our frog jumped.</strong></p>
<p>Try to achieve this functionality by creating <strong>class Lake</strong> (it will hold <strong>all stone numbers in order</strong>) that implements <strong>IEnumerable&lt;int&gt;</strong> interface and override its <strong>GetEnumerator()</strong> methods.</p>
<h3>Examples</h3>
<table width="406">
<tbody>
<tr>
<td width="208">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="208">
<p>1, 2, 3, 4, 5, 6, 7, 8</p>
</td>
<td width="198">
<p>1, 3, 5, 7, 8, 6, 4, 2</p>
</td>
</tr>
<tr>
<td width="208">
<p>1, 2, 3, 4, 5</p>
</td>
<td width="198">
<p>1, 3, 5, 4, 2</p>
</td>
</tr>
<tr>
<td width="208">
<p>13, 23, 1, -8, 4, 9</p>
</td>
<td width="198">
<p>13, 1, 4, 9, -8, 23</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Comparing Objects</h2>
<p>There is a Comparable interface but probably you already know. Your task is simple. Create a <strong>class Person</strong>. Each person should have a <strong>name</strong>, an <strong>age</strong> and a <strong>town</strong>. You should implement the interface &ndash; <strong>IComparable&lt;T&gt;</strong> and implement the <strong>CompareTo</strong> method. When you compare two people, first you should <strong>compare their names</strong>, after that - <strong>their age</strong> and last but not at least - <strong>their towns</strong>.</p>
<h3>Input</h3>
<p>On every line, you will be given people in format:</p>
<p><strong>{name} {age} {town}</strong></p>
<p>Collect them till you receive <strong>"END"</strong></p>
<p>After that, you will receive an integer <strong>N</strong> - the <strong>N<sup>th</sup></strong> person in your collection. <strong>Starting from 1.</strong></p>
<h3>Output</h3>
<p>On the single output line, you should bring statistics, how many people are equal to him, how many people are not equal to him and the total people in your collection.</p>
<p>Format: <strong>{number of equal people} {number of not equal people} {total number of people}</strong></p>
<h3>Constraints</h3>
<p>Input names, ages and addresses will be valid. Input number will be always а valid integer in range [2&hellip;100]</p>
<p>If there are no equal people print: <strong>"No matches"</strong></p>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>Pesho 22 Vraca</p>
<p>Gogo 14 Sofeto</p>
<p>END</p>
<p>2</p>
</td>
<td width="435">
<p>No matches</p>
</td>
</tr>
<tr>
<td width="260">
<p>Pesho 22 Vraca</p>
<p>Gogo 22 Vraca</p>
<p>Gogo 22 Vraca</p>
<p>END</p>
<p>2</p>
</td>
<td width="435">
<p>2 1 3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Strategy Pattern</h2>
<p>An interesting pattern you may have heard of is the <strong>Strategy Pattern</strong>, if we have multiple ways to do a task (say <strong>sort a collection</strong>) it allows the client to <strong>choose the way that most fits his needs</strong>. A famous implementation of the pattern in C# are the <a href="https://msdn.microsoft.com/en-us/library/234b841s(v=vs.110).aspx"><strong>List&lt;T&gt;.Sort()</strong></a> and <a href="https://msdn.microsoft.com/en-us/library/aw9s5t8f(v=vs.110).aspx"><strong>Array.Sort()</strong></a> methods that take a <strong>IComparer </strong>as an argument.</p>
<p>Create a class <strong>Person</strong> that holds a <strong>name</strong> and <strong>age</strong>. Create 2 Comparators for Person (classes which implement the<strong> IComparer&lt;Person&gt;</strong> interface). The first comparator should compare people based on the <strong>length of their name </strong>as a first parameter, if 2 people have a name with the same length, perform a <strong>case-insensitive</strong> compare based on the <strong>first letter of their name</strong> instead. The second comparator should compare them based on their <strong>age</strong>. Create 2 <strong>SortedSets</strong> of type <strong>Person</strong>, the first should implement the <strong>name comparator</strong> and the second should implement<strong> the age comparator</strong>.</p>
<h3>Input</h3>
<p>On the first line of input you will receive a number <strong>N</strong>. On each of the next <strong>N</strong> lines you will receive information about people in the format <strong>&ldquo;&lt;name&gt; &lt;age&gt;&rdquo;</strong>.&nbsp; Add the people from the input into both sets (both sets should hold all the people passed in from the input).</p>
<h3>Output</h3>
<p>Foreach the sets and print each person from the set on a new line in the same format that you received them. Start with the set that implements the name comparator.</p>
<h3>Constraints</h3>
<ul>
<li>A person&rsquo;s name will be a string that contains only alphanumerical characters with a length between <strong>[1&hellip;50] </strong></li>
<li>A person&rsquo;s age will be a positive integer between <strong>[1&hellip;100]</strong>.</li>
<li>The number of people <strong>N</strong> will be a positive integer between <strong>[0&hellip;100]</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>3</p>
<p>Pesho 20</p>
<p>Joro 100</p>
<p>Pencho 1</p>
</td>
<td width="435">
<p>Joro 100</p>
<p>Pesho 20</p>
<p>Pencho 1</p>
<p>Pencho 1</p>
<p>Pesho 20</p>
<p>Joro 100</p>
</td>
</tr>
<tr>
<td width="260">
<p>5</p>
<p>Ivan 17</p>
<p>asen 33</p>
<p>Stoqn 25</p>
<p>Nasko 99</p>
<p>Joro 3</p>
</td>
<td width="435">
<p>asen 33</p>
<p>Ivan 17</p>
<p>Joro 3</p>
<p>Nasko 99</p>
<p>Stoqn 25</p>
<p>Joro 3</p>
<p>Ivan 17</p>
<p>Stoqn 25</p>
<p>asen 33</p>
<p>Nasko 99</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Equality Logic</h2>
<p>Create a <strong>class Person</strong> holding <strong>name</strong> and <strong>age</strong>. A person with the same name and age should be considered the same, override any methods needed to enforce this logic. Your class should work with both standard and hashed collections. Create a <strong>SortedSet</strong> and a <strong>HashSet</strong> of type Person.</p>
<h3>Input</h3>
<p>On the first line of input you will receive a number <strong>N</strong>. On each of the next <strong>N</strong> lines you will receive information about people in the format <strong>&ldquo;&lt;name&gt; &lt;age&gt;&rdquo;</strong>.&nbsp; Add the people from the input into both sets (both sets should hold all the people passed in from the input).</p>
<h3>Output</h3>
<p>The output should consists of exactly 2 lines. On the first you should print the size of the tree set and on the second - the size of the hashset.</p>
<h3>Constraints</h3>
<ul>
<li>A person&rsquo;s name will be a string that contains only alphanumerical characters with a length between <strong>[1&hellip;50] </strong></li>
<li>A person&rsquo;s age will be a positive integer between <strong>[1&hellip;100]</strong>.</li>
<li>The number of people <strong>N</strong> will be a positive integer between <strong>[0&hellip;100]</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>4</p>
<p>Pesho 20</p>
<p>Peshp 20</p>
<p>Joro 15</p>
<p>Pesho 21</p>
</td>
<td width="435">
<p>4</p>
<p>4</p>
</td>
</tr>
<tr>
<td width="260">
<p>7</p>
<p>Ivan 17</p>
<p>ivan 17</p>
<p>Stoqn 25</p>
<p>Ivan 18</p>
<p>Ivan 17</p>
<p>Stopn 25</p>
<p>Stoqn 25</p>
</td>
<td width="435">
<p>5</p>
<p>5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hint</h3>
<p>You should override both the <strong>Equals</strong> and <strong>GetHashCode</strong> methods. You can check online for an implementation of <strong>GetHashCode</strong> - it doesn&rsquo;t have to be perfect, but it should be good enough to produce the same hash code for objects with the same name and age, and different enough hash codes for objects with different name and/or age.</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Pet Clinics</h2>
<p>You are a young and ambitious owner of a Pet Clinics Holding. You ask your employees to create a program which will store all information about the pets in the database. Each pet should have a name, an age and a kind.</p>
<p>Your application should support a few basic operations such as creating a pet, creating a clinic, adding a pet to a clinic, releasing a pet from a clinic, printing information about a specific room in a clinic or printing information about all rooms in a clinic.</p>
<p>Clinics should have an odd number of rooms, attempting to create a clinic with an even number of should fail and throw an appropriate exception.</p>
<h3>Accommodation Order</h3>
<p>For example let us take a look at a clinic with 5 rooms. The first room where a pet will be treated is the central one (room 3). So the order of which an animal is entering is: first animal is going to the centre (3) room and after that the next pets are entering first to the left (2) and then to the right (4) room. The last rooms in which pets can enter are room 1 and room 5. In case a room is already occupied, we skip it and go to the next room in the above order. Your task is to model the application and make it support some commands.</p>
<p>The first pet enters room 3. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1 2 <strong>3</strong> 4 5</p>
<p>After that, the next pet enters room 2. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1 <strong>2</strong> 3 4 5</p>
<p>The third pet would enter room 4. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1 2 3 <strong>4</strong> 5</p>
<p>And the last two pets would be going to rooms - 1 and 5. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>1</strong> 2 3 4 <strong>5</strong></p>
<p>Now when we have covered adding the pets, it is time to find a way to release them. The process of releasing them is not so simple, when the release method is called, we start from the centre room (3) and continue right (4, 5&hellip; and so on) until we find a pet or reach the last room. If we reach the last room, we start from the first (1) and again move right until we reach the centre room (3). If a pet is found, we remove it from the collection, stop further search and return true, if a pet is <strong>NOT</strong> found, the operation returns false.</p>
<p>When a print command for a room is called, if the room contains a pet we print the pet on a single line in the format <strong>&ldquo;&lt;pet name&gt; &lt;pet age&gt; &lt;pet kind&gt;&rdquo;</strong>. Alternatively if the room is empty print <strong>&ldquo;Room empty&rdquo;</strong> instead. When a print command for a clinic is called it should print all rooms in the clinic in order of their number.</p>
<h3>Commands</h3>
<table width="691">
<tbody>
<tr>
<td width="317">
<p><strong>Command</strong></p>
</td>
<td width="151">
<p><strong>Return Type</strong></p>
</td>
<td width="223">
<p><strong>Description</strong></p>
</td>
</tr>
<tr>
<td width="317">
<p>Create Pet {name} {age} {kind}</p>
</td>
<td width="151">
<p>void</p>
</td>
<td width="223">
<p>Creates a pet with the specified name and age.</p>
<p>(true if the operation is successful and false if it isn't)</p>
</td>
</tr>
<tr>
<td width="317">
<p>Create Clinic {name} {rooms}</p>
</td>
<td width="151">
<p>void</p>
</td>
<td width="223">
<p>Creates a Clinic with the specified name and number of rooms.</p>
<p>(if the rooms are not odd, throws an exception)</p>
</td>
</tr>
<tr>
<td width="317">
<p>Add {pet's name} {clinic's name}</p>
</td>
<td width="151">
<p>boolean</p>
</td>
<td width="223">
<p>This command should add the given pet in the specified clinic.</p>
<p>(true if the operation is successful and false if it isn't).</p>
</td>
</tr>
<tr>
<td width="317">
<p>Release {clinic's name}</p>
</td>
<td width="151">
<p>boolean</p>
</td>
<td width="223">
<p>This command should release an animal from the specified clinic.</p>
<p>(true if the operation is successful and false if it isn't).</p>
</td>
</tr>
<tr>
<td width="317">
<p>HasEmptyRooms {clinic&rsquo;s name}</p>
</td>
<td width="151">
<p>boolean</p>
</td>
<td width="223">
<p>Returns whether the clinic has any empty rooms.</p>
<p>(true if it has and false if it doesn&rsquo;t).</p>
</td>
</tr>
<tr>
<td width="317">
<p>Print {clinic's name}</p>
</td>
<td width="151">
<p>void</p>
</td>
<td width="223">
<p>This command should print each room in the specified clinic, ordered by room number.</p>
</td>
</tr>
<tr>
<td width="317">
<p>Print {clinic's name} {room}</p>
</td>
<td width="151">
<p>void</p>
</td>
<td width="223">
<p>Prints on a single line the content of the specified room.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Input</h3>
<p>On the first line, you will be given an integer <strong>N</strong> - the number of commands you will receive. On each of the next <strong>N</strong> lines you will receive a command. Commands and parameters will always be correct (<strong>Add, Release, HasEmptyRooms</strong> and <strong>Print</strong> commands will always be passed existing clinics/pets), with the exception of the number of rooms in the <strong>Create Clinic</strong> command which can be any valid integer between 1 and 101.</p>
<h3>Output</h3>
<p>For each command with a boolean return type received through the input, you should print its return value on a separate line. In case of a method throwing an exception (such as trying to create a clinic with even number of rooms, or trying to add a pet that doesn&rsquo;t exist) you should catch the exceptions and instead print <strong>&ldquo;Invalid Operation!&rdquo;</strong>. The Print command with a clinic and a room should print information for that room in the format specified above. The Print command with only a clinic should print information for each room in the clinic in order of their numbers.</p>
<h3>Constraints</h3>
<ul>
<li>The number of commands <strong>N</strong> - will be a valid integer between <strong>[1&hellip;1000]</strong>, no need to check it explicitly.</li>
<li><strong>Pet names</strong>, <strong>Clinic names</strong>, and <strong>kind</strong> will be strings consisting only of alphabetical characters with length between <strong>[1&hellip;50]</strong></li>
<li><strong>Pet</strong> <strong>age</strong> will be a positive integer between <strong>[1&hellip;100]</strong>.</li>
<li><strong>Clinic rooms</strong> will be a positive integer between <strong>[1&hellip;101]</strong>.</li>
<li><strong>Room number</strong> in a <strong>Print</strong> command will always be between <strong>1</strong> and the <strong>number of rooms</strong> in that Clinic.</li>
<li>Input will consist <strong>only</strong> of<strong> correct commands </strong>and they will<strong> always</strong> have the correct type of parameters.</li>
</ul>
<h3>Example</h3>
<table width="576">
<tbody>
<tr>
<td width="251">
<p><strong>Input</strong></p>
</td>
<td width="326">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="251">
<p>9</p>
<p>Create Pet Gosho 7 Cat</p>
<p>Create Clinic Rezovo 4</p>
<p>Create Clinic Rizovo 1</p>
<p>HasEmptyRooms Rizovo</p>
<p>Release Rizovo</p>
<p>Add Gosho Rizovo</p>
<p>HasEmptyRooms Rizovo</p>
<p>Create Pet Sharo 2 Dog</p>
<p>Add Sharo Rizovo</p>
</td>
<td width="326">
<p>Invalid Operation!</p>
<p>true</p>
<p>false</p>
<p>true</p>
<p>false</p>
<p>false</p>
</td>
</tr>
<tr>
<td width="251">
<p>8</p>
<p>Create Pet Gosho 7 Cat</p>
<p>Create Pet Sosho 1 Cata</p>
<p>Create Clinic Rezovo 5</p>
<p>Add Gosho Rezovo</p>
<p>Add Sosho Rezovo</p>
<p>Print Rezovo 3</p>
<p>Release Rezovo</p>
<p>Print Rezovo</p>
</td>
<td width="326">
<p>true</p>
<p>true</p>
<p>Gosho 7 Cat</p>
<p>true</p>
<p>Room empty</p>
<p>Sosho 1 Cata</p>
<p>Room empty</p>
<p>Room empty</p>
<p>Room empty</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ***Linked List Traversal</h2>
<p>You need to write your own simplified implementation of a generic Linked List which implement <strong>IEnumerable&lt;T&gt;</strong>. The list should support the Add and Remove operations, should reveal the amount of elements it has with a Count property. The <strong>Add</strong> method should add the new element at the end of the collection. The <strong>Remove</strong> method should remove the first occurrence of the item starting at the beginning of the collection, if the element is succesfully removed the method <strong>returns true</strong>, alternatively if the element passed is not in the collection the method should <strong>return false</strong>. The <strong>Count</strong> property should return the number of elements currently in the list.</p>
<h3>Input</h3>
<p>On the first line of input you will receive a number <strong>N</strong>. On each of the next <strong>N</strong> lines you will receive a command in one of the following formats:</p>
<ul>
<li><strong>Add &lt;number&gt;</strong> - adds a number to your linked list.</li>
<li><strong>Remove &lt;number&gt;</strong> - removes the first occurrence of the number from the linked list. If there is no such element this command leaves the collection unchanged.</li>
</ul>
<h3>Output</h3>
<p>The output should consists of exactly 2 lines. On the first you should print the result of calling the Count property on the Linked list. On the second you should print all elements of the collection on a single line seperated by spaces, by calling foreach on the collection.</p>
<h3>Constraints</h3>
<ul>
<li>All numbers in the input will be valid integers between <strong>[2<sup>-32</sup>&hellip;2<sup>32</sup>-1]</strong>.</li>
<li>All commands received through the input will be <strong>valid</strong> (will be only <strong>Add</strong> or <strong>Remove</strong>).</li>
<li>The number of people <strong>N</strong> will be a positive integer between <strong>[1&hellip;500]</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="260">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="260">
<p>5</p>
<p>Add 7</p>
<p>Add -50</p>
<p>Remove 3</p>
<p>Remove 7</p>
<p>Add 20</p>
</td>
<td width="435">
<p>2</p>
<p>-50 20</p>
</td>
</tr>
<tr>
<td width="260">
<p>6</p>
<p>Add 13</p>
<p>Add 4</p>
<p>Add 20</p>
<p>Add 4</p>
<p>Remove 4</p>
<p>Add 4</p>
</td>
<td width="435">
<p>4</p>
<p>13 20 4 4</p>
</td>
</tr>
</tbody>
</table>
<h3>Hint</h3>
<p>You can use the <a href="https://softuni.bg/trainings/1308/data-structures-february-2016"><strong>lab</strong></a> about Linear Data Structures to help you implement your linked list. The resources should be enough as a guide for you to implement it.</p>