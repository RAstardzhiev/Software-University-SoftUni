<h1>Lab: Stacks and Queues</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1633/csharp-advanced-may-2017">"C# Advanced" course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Practice/Index/572#5">https://judge.softuni.bg/Contests/Practice/Index/572#5</a>.</p>
<h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Working with Stacks</h1>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Reverse Strings</h2>
<p>Write program that reads:</p>
<ul>
<li><strong>Reads </strong>an<strong> input string</strong></li>
<li><strong>Reverses </strong>it<strong> using a Stack</strong></li>
<li><strong>Prints </strong>the result back at the terminal</li>
</ul>
<h3>Examples</h3>
<table width="659">
<tbody>
<tr>
<td width="192">
<p><strong>Input</strong></p>
</td>
<td width="467">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="192">
<p>Learning Java</p>
</td>
<td width="467">
<p>avaJ gninraeL</p>
</td>
</tr>
<tr>
<td width="192">
<p>Stacks and Queues</p>
</td>
<td width="467">
<p>seueuQ dna skcatS</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use the <strong>Stack&lt;string&gt;</strong></li>
<li>Use the methods <strong>Push()</strong>, <strong>Pop()</strong></li>
</ul>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Simple Calculator</h2>
<p><strong>Create a simple calculator</strong> that can <strong>evaluate simple expressions</strong> that will not hold any operator different from addition and subtraction. There will not be parentheses or operator precedence.</p>
<p>Solve the problem <strong>using a Stack</strong>.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="287">
<tbody>
<tr>
<td width="155">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>2 + 5 + 10 - 2 - 1</p>
</td>
<td width="132">
<p>14</p>
</td>
</tr>
<tr>
<td width="155">
<p>2 - 2 + 5</p>
</td>
<td width="132">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use an <strong>Stack&lt;string&gt;</strong></li>
<li>You can either
<ul>
<li>add the elements and then pop them out</li>
<li>or push them and reverse the stack</li>
</ul>
</li>
</ul>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Decimal to Binary Converter</h2>
<p>Create a simple program that <strong>can convert a decimal number to its binary representation</strong>. Implement an elegant solution <strong>using a Stack</strong>.</p>
<p><strong>Print the binary representation</strong> back at the terminal.</p>
<h3>Examples</h3>
<table width="419">
<tbody>
<tr>
<td width="153">
<p><strong>Input</strong></p>
</td>
<td width="267">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="153">
<p>10</p>
</td>
<td width="267">
<p>1010</p>
</td>
</tr>
<tr>
<td width="153">
<p>1024</p>
</td>
<td width="267">
<p>10000000000</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>If the given number is 0, just print 0</li>
<li>Else, while the number is greater than zero, divide it by 2 and push the reminder into the stack</li>
<li>When you are done dividing, pop all reminders from the stack, that is the binary representation</li>
</ul>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Matching Brackets</h2>
<p>We are given an arithmetical expression with brackets. Scan through the string and extract each sub-expression.</p>
<p>Print the result back at the terminal.</p>
<h3>Examples</h3>
<table width="485">
<tbody>
<tr>
<td width="240">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="240">
<p>1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5</p>
</td>
<td width="246">
<p>(2 + 3)</p>
<p>(3 + 1)</p>
<p>(2 - (2 + 3) * 4 / (3 + 1))</p>
</td>
</tr>
<tr>
<td width="240">
<p>(2 + 3) - (2 + 3)</p>
</td>
<td width="246">
<p>(2 + 3)</p>
<p>(2 + 3)</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Scan through the expression searching for brackets
<ul>
<li>If you find an opening bracket, push the index into the stack</li>
<li>If you find a closing bracket pop the topmost element from the stack. This is the index of the opening bracket.</li>
<li>Use the current and the popped index to extract the sub-expression</li>
</ul>
</li>
</ul>
<h1>&nbsp;&nbsp; II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Working with Queues</h1>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp; Hot Potato</h2>
<p>Hot potato is a game in which <strong>children form a circle and start passing a hot potato</strong>. The counting starts with the fist kid. <strong>Every n<sup>th</sup></strong><strong> toss the child left with the potato leaves the game</strong>. When a kid leaves the game, it passes the potato forward. This continues repeating <strong>until there is only one kid left</strong>.</p>
<p>Create a program that simulates the game of Hot Potato. &nbsp;<strong>Print every kid that is removed from the circle</strong>. In the end, <strong>print the kid that is left last</strong>.</p>
<h3>Examples</h3>
<table width="501">
<tbody>
<tr>
<td width="283">
<p><strong>Input</strong></p>
</td>
<td width="217">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="283">
<p>Mimi Pepi Toshko</p>
<p>2</p>
</td>
<td width="217">
<p>Removed Pepi</p>
<p>Removed Mimi</p>
<p>Last is Toshko</p>
</td>
</tr>
<tr>
<td width="283">
<p>Gosho Pesho Misho Stefan Krasi</p>
<p>10</p>
</td>
<td width="217">
<p>Removed Krasi</p>
<p>Removed Pesho</p>
<p>Removed Misho</p>
<p>Removed Gosho</p>
<p>Last is Stefan</p>
</td>
</tr>
<tr>
<td width="283">
<p>Gosho Pesho Misho Stefan Krasi</p>
<p>1</p>
</td>
<td width="217">
<p>Removed Gosho</p>
<p>Removed Pesho</p>
<p>Removed Misho</p>
<p>Removed Stefan</p>
<p>Last is Krasi</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp; Math Potato</h2>
<p>Rework the previous problem so that a <strong>child is removed only on a prime cycle</strong> (cycles start from 1)</p>
<p>If a <strong>cycle is not prime</strong>, just <strong>print the child's name.</strong></p>
<p>As before, print the name of the child that is left last.</p>
<h3>Examples</h3>
<table width="501">
<tbody>
<tr>
<td width="283">
<p><strong>Input</strong></p>
</td>
<td width="217">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="283">
<p>Mimi Pepi Toshko</p>
<p>2</p>
</td>
<td width="217">
<p>Removed Pepi</p>
<p>Prime Mimi</p>
<p>Prime Toshko</p>
<p>Removed Mimi</p>
<p>Last is Toshko</p>
</td>
</tr>
<tr>
<td width="283">
<p>Gosho Pesho Misho Stefan Krasi</p>
<p>10</p>
</td>
<td width="217">
<p>Removed Krasi</p>
<p>Prime Pesho</p>
<p>Prime Misho</p>
<p>Removed Stefan</p>
<p>Prime Gosho</p>
<p>Removed Gosho</p>
<p>Prime Misho</p>
<p>Removed Pesho</p>
<p>Last is Misho</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>