<h1>Lab: Multidimensional Arrays</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1633/csharp-advanced-may-2017">"C# Advanced" course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/599/Matrices-Lab">https://judge.softuni.bg/Contests/599/Matrices-Lab</a></p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Sum Matrix Elements</h2>
<p>Write program that <strong>read a matrix</strong> from console and print:</p>
<ul>
<li>Count of <strong>rows</strong></li>
<li>Count of <strong>columns</strong></li>
<li>Sum of all <strong>matrix&rsquo;s elements</strong></li>
</ul>
<p>On first line you will get matrix sizes in format <strong>[rows, columns]</strong></p>
<h3>Examples</h3>
<table width="485">
<tbody>
<tr>
<td width="211">
<p><strong>Input</strong></p>
</td>
<td width="274">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="211">
<p>3, 6</p>
<p>7, 1, 3, 3, 2, 1<br /> 1, 3, 9, 8, 5, 6<br /> 4, 6, 7, 9, 1, 0</p>
<p>&nbsp;</p>
</td>
<td width="274">
<p>3</p>
<p>6</p>
<p>76</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>On next <strong>[rows]</strong> lines you will get elements for each column separated with coma and whitespace</li>
<li>Try to use only <strong>foreach </strong>for printing</li>
</ul>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Maximum sum of 2x2 submatrix</h2>
<p>Write a program that <strong>read a matrix</strong> from console. Then find biggest sum of <strong>2x2 submatrix</strong> and print it to console.</p>
<p>On first line you will get matrix sizes in format <strong>rows, columns.</strong></p>
<p>One next <strong>rows</strong> lines you will get elements for each <strong>column</strong> separated with coma.</p>
<p>Print <strong>biggest top-left</strong> square, which you find and sum of it's elements.</p>
<h3>Examples</h3>
<table width="580">
<tbody>
<tr>
<td width="249">
<p><strong>Input</strong></p>
</td>
<td width="331">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="249">
<p>3, 6</p>
<p>7, 1, 3, 3, 2, 1<br /> 1, 3, 9, 8, 5, 6<br /> 4, 6, 7, 9, 1, 0</p>
</td>
<td width="331">
<p>9 8</p>
<p>7 9</p>
<p>33</p>
</td>
</tr>
<tr>
<td width="249">
<p>2, 4</p>
<p>10, 11, 12, 13</p>
<p>14, 15, 16, 17</p>
</td>
<td width="331">
<p>12 13</p>
<p>16 17</p>
<p>58</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Think about <strong>IndexOutOfRangeException()</strong></li>
<li>If you find some max squares, print top-left one</li>
</ul>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Group Numbers</h2>
<p>Read a set of numbers and <strong>group</strong> them by their remainder when <strong>dividing to 3</strong> (0, 1 and 2).</p>
<p>One first line, you will get numbers separated with coma and whitespace.</p>
<h3>Examples</h3>
<table width="611">
<tbody>
<tr>
<td width="365">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="365">
<p>1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2</p>
<p><strong>&nbsp;</strong></p>
</td>
<td width="246">
<p>3 66</p>
<p>1 4 55 1 124</p>
<p>113 2 557 2</p>
</td>
</tr>
<tr>
<td width="365">
<p>1, 4, -113, 55, -3, 1, -2, 66, 557, -124, 2</p>
</td>
<td width="246">
<p>-3 66</p>
<p>1 4 55 1 -124</p>
<p>-113 -2 557 2</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Think about how to get <strong>all rows lengths</strong></li>
<li>First element in each array will be <strong>easy</strong>, but what will happen with <strong>next numbers we need to add</strong> to each row. Probably you will need one more <strong>array</strong> to save next <strong>index</strong> for each row</li>
</ul>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Pascal Triangle</h2>
<p>The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other) row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.</p>
<p>If you want more info about it: <a href="https://en.wikipedia.org/wiki/Pascal's_triangle">https://en.wikipedia.org/wiki/Pascal's_triangle</a></p>
<p>Print each row elements separated with whitespace.</p>
<h3>Examples</h3>
<table width="693">
<tbody>
<tr>
<td width="104">
<p><strong>Input</strong></p>
</td>
<td width="589">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>4</p>
</td>
<td width="589">
<p>1</p>
<p>1 1</p>
<p>1 2 1</p>
<p>1 3 3 1</p>
</td>
</tr>
<tr>
<td width="104">
<p>13</p>
</td>
<td width="589">
<p>1</p>
<p>1 1</p>
<p>1 2 1</p>
<p>1 3 3 1</p>
<p>1 4 6 4 1</p>
<p>1 5 10 10 5 1</p>
<p>1 6 15 20 15 6 1</p>
<p>1 7 21 35 35 21 7 1</p>
<p>1 8 28 56 70 56 28 8 1</p>
<p>1 9 36 84 126 126 84 36 9 1</p>
<p>1 10 45 120 210 252 210 120 45 10 1</p>
<p>1 11 55 165 330 462 462 330 165 55 11 1</p>
<p>1 12 66 220 495 792 924 792 495 220 66 12 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Input number <strong>n</strong> will be <strong>1 &lt;= n &lt;= 100</strong></li>
<li>Think about proper <strong>type</strong> for elements in array</li>
<li>Don&rsquo;t be scary to use <strong>more and more Arrays</strong></li>
</ul>