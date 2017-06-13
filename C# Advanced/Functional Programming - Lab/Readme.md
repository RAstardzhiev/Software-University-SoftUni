<h1>Lab: Functional Programming</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/csharp-advanced">&ldquo;C# Advanced&rdquo; course @ SoftUni".</a></p>
<p>Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/597/Functional-Programming-Lab">https://judge.softuni.bg/Contests/597/Functional-Programming-Lab.</a></p>
<h2>1.&nbsp;&nbsp; Sort Even Numbers</h2>
<p>Write a program that reads one line of <strong>Integers</strong> separated by <strong>", "</strong>. Then print exactly 2 lines of output. On the first line print <strong>only the even numbers</strong> of that sequence. On the second line print those <strong>even numbers sorted </strong>in<strong> increasing</strong> order.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="125">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="57">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="15">
<p><strong>&nbsp;</strong></p>
</td>
<td width="117">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>4, 2, 1, 3, 5, 7, 1, 4, 2, 12</p>
</td>
<td width="132">
<p>2, 2, 4, 4, 12</p>
</td>
<td width="76">
<p>1, 3, 5</p>
</td>
<td width="57">
<p>&nbsp;</p>
</td>
<td width="117">
<p>2, 4, 6</p>
</td>
<td width="76">
<p>2, 4, 6</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>It is up to you what type of data structures you will use to solve this problem</p>
<p>Using functional programming filter and sort the collection of numbers.</p>
<h2>2.&nbsp;&nbsp; Sum Numbers</h2>
<p>Write a program that reads one line of <strong>Integers</strong> separated by <strong>", "</strong>. Print <strong>count</strong> of numbers and their <strong>sum.</strong></p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="342">
<p><strong>Input</strong></p>
</td>
<td width="346">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="342">
<p>4, 2, 1, 3, 5, 7, 1, 4, 2, 12</p>
</td>
<td width="346">
<p>10</p>
<p>41</p>
</td>
</tr>
<tr>
<td width="342">
<p>2, 4, 6</p>
</td>
<td width="346">
<p>3</p>
<p>12</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Count Uppercase Words</h2>
<p>Write a program that reads one line of <strong>text</strong> from console. Print <strong>all</strong> words that start with <strong>Uppercase</strong> in the <strong>same order</strong> like you find them in text.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="295">
<p><strong>Input</strong></p>
</td>
<td width="393">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="295">
<p>The following example shows how to use Predicate</p>
</td>
<td width="393">
<p>The</p>
<p>Predicate</p>
</td>
</tr>
<tr>
<td width="295">
<p>Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in the same order like you find them in text.</p>
</td>
<td width="393">
<p>Write</p>
<p>Print</p>
<p>Uppercase,</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use <strong>Func&lt;string, bool&gt; </strong>like or in if condition</p>
<p>Use <strong>" "</strong> for splitting words.</p>
<h2>4.&nbsp;&nbsp; Add VAT</h2>
<p>Write a program that reads one line of <strong>double </strong>prices separated by <strong>", "</strong>. Print prices with added VATs for all of them.</p>
<p>Format them to 2 sign after decimal point. Order of prices must be the same. VAT is equal to 20% of the price.</p>
<h3>Examples</h3>
<table width="593">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="148">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="15">
<p><strong>&nbsp;</strong></p>
</td>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="148">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>1.38, 2.56, 4.4</p>
</td>
<td width="148">
<p>1.66</p>
<p>3.07</p>
<p>5.28</p>
</td>
<td width="140">
<p>1, 3, 5, 7</p>
</td>
<td width="148">
<p>1.20</p>
<p>3.60</p>
<p>6.00</p>
<p>8.40</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Filter by Age</h2>
<p>Write a program that read integer <strong>N</strong> on first line. And on next <strong>N</strong> lines read pairs of <strong>"[name], [age]". </strong>Then read three lines with:</p>
<ul>
<li><strong>Condition</strong> - "younger" or "older"</li>
<li><strong>Age</strong> - Integer</li>
<li><strong>Format</strong> - "name", "age" or "name age"</li>
</ul>
<p>Depend on <strong>condition</strong> print right <strong>pairs</strong> in right <strong>format</strong>.</p>
<p><strong>Don&rsquo;t use built-in functionality from .NET. Write your own methods.</strong></p>
<h3>Examples</h3>
<table width="615">
<tbody>
<tr>
<td width="96">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="14">
<p><strong>&nbsp;</strong></p>
</td>
<td width="96">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
<td width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="96">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="96">
<p>5</p>
<p>Pesho, 20<br /> Gosho, 18<br /> Mimi, 29<br /> Ico, 31<br /> Simo, 16</p>
<p>older</p>
<p>20</p>
<p>name age</p>
</td>
<td width="100">
<p>Pesho - 20</p>
<p>Mimi - 29</p>
<p>Ico - 31</p>
</td>
<td width="96">
<p>5</p>
<p>Pesho, 20<br /> Gosho, 18<br /> Mimi, 29<br /> Ico, 31<br /> Simo, 16</p>
<p>younger</p>
<p>20</p>
<p>name</p>
</td>
<td width="100">
<p>Gosho</p>
<p>Simo</p>
</td>
<td width="13">
<p>&nbsp;</p>
</td>
<td width="96">
<p>5</p>
<p>Pesho, 20<br /> Gosho, 18<br /> Mimi, 29<br /> Ico, 31<br /> Simo, 16</p>
<p>younger</p>
<p>50</p>
<p>age</p>
</td>
<td width="100">
<p>20</p>
<p>18</p>
<p>29</p>
<p>31</p>
<p>16</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>