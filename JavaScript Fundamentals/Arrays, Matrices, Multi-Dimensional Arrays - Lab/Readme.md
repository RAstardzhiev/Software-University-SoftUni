<h1>Lab: Arrays, Matrices, Multi-Dimensional Arrays</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/311">https://judge.softuni.bg/Contests/311</a>.</p>
<h2>1.&nbsp;&nbsp; Sum First Last</h2>
<p>Write a JS function that calculates and prints the sum of the first and the last elements in an array.</p>
<p>The <strong>input</strong> comes as array of string elements holding numbers.</p>
<p>The <strong>output</strong> is the return value of your function.</p>
<h3>Examples</h3>
<table width="630">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>['20', '30', '40']</p>
</td>
<td width="113">
<p>60</p>
</td>
<td width="189">
<p>['5', '10']</p>
</td>
<td width="113">
<p>15</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Even Position Element</h2>
<p>Write a JS function that finds the elements at even positions in an array.</p>
<p>The <strong>input</strong> comes as array of string elements.</p>
<p>The <strong>output</strong> is the return value of your function. Collect all elements in a string, separated by space.</p>
<h3>Examples</h3>
<table width="630">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>['20', '30', '40']</p>
</td>
<td width="113">
<p>20 40</p>
</td>
<td width="189">
<p>['5', '10']</p>
</td>
<td width="113">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Negative / Positive Numbers</h2>
<p>Write a JS function that processes the elements in an array one by one and produces a new array. Prepend each negative element at the front of the result and append each positive (or 0) element at the end of the result.</p>
<p>The <strong>input</strong> comes as array of number elements.</p>
<p>The <strong>output</strong> is printed on the console, each element on a new line.</p>
<h3>Examples</h3>
<table width="555">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[7, -2, 8, 9]</p>
</td>
<td width="76">
<p>-2</p>
<p>7</p>
<p>8</p>
<p>9</p>
</td>
<td width="189">
<p>[3, -2, 0, -1]</p>
</td>
<td width="76">
<p>-1</p>
<p>-2</p>
<p>3</p>
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; First and Last K Numbers</h2>
<p>Write a JS function that prints the first <strong>k</strong> and the last <strong>k</strong> elements from an array of numbers.</p>
<p>The <strong>input</strong> comes as array of number elements. The first element represents the number <strong>k</strong>, all other elements are from the array that needs to be processed.</p>
<p>The <strong>output</strong> is printed on the console on two lines. On the first line print the <strong>first</strong> <strong>k</strong> elements, separated by space. On the second line print the <strong>last</strong> <strong>k</strong> elements, separated by space.</p>
<h3>Examples</h3>
<table width="555">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[<strong>2</strong>,</p>
<p>&nbsp;7, 8, 9]</p>
</td>
<td width="76">
<p>7 8</p>
<p>8 9</p>
</td>
<td width="189">
<p>[<strong>3</strong>,</p>
<p>&nbsp;6, 7, 8, 9]</p>
</td>
<td width="76">
<p>6 7 8</p>
<p>7 8 9</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Last K Numbers Sequence</h2>
<p>You are given two integers <strong>n</strong> and <strong>k</strong>. Write a JS function that generates and prints the following sequence:</p>
<ul>
<li>The first element is 1</li>
<li>Every following element equals the sum of the previous <strong>k</strong> elements</li>
<li>The length of the sequence is <strong>n</strong> elements</li>
</ul>
<p>The <strong>input</strong> comes as two number arguments. The first element represents the number <strong>n</strong>, and the second &ndash; the number <strong>k</strong>.</p>
<p>The <strong>output</strong> is printed on the console on a single line, separated by space.</p>
<h3>Examples</h3>
<table width="630">
<tbody>
<tr>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>6, 3</p>
</td>
<td width="189">
<p>1 1 2 4 7 13</p>
</td>
<td width="113">
<p>8, 2</p>
</td>
<td width="189">
<p>1 1 2 3 5 8 13 21</p>
</td>
</tr>
</tbody>
</table>
<h4>Explanation</h4>
<p>The 2<sup>nd</sup> element (1) is the sum of the 3 elements before it, but there is only 1, so we take that. The third element, is the sum of the first 2 (1 and 1) and the 4<sup>th</sup> &ndash; the sum of 1, 1 and 2. The 5<sup>th</sup> element is the sum of the 2<sup>nd</sup>, 3<sup>rd</sup> and 4<sup>th</sup> (1, 2 and 4) and so on.</p>
<h2>6.&nbsp;&nbsp; Process Odd Numbers</h2>
<p>You are given an array of numbers. Write a JS function that prints the elements at odd positions from the array, doubled and in reverse order.</p>
<p>The <strong>input</strong> comes as array of number elements.</p>
<p>The <strong>output</strong> is printed on the console on a single line, separated by space.</p>
<h3>Examples</h3>
<table width="668">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="265">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[10, 15, 20, 25]</p>
</td>
<td width="76">
<p>50 30</p>
</td>
<td width="265">
<p>[3, 0, 10, 4, 7, 3]</p>
</td>
<td width="76">
<p>6 8 0</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Smallest Two Numbers</h2>
<p>Write a JS function that prints the two smallest elements from an array of numbers.</p>
<p>The <strong>input</strong> comes as array of number elements.</p>
<p>The <strong>output</strong> is printed on the console on a single line, separated by space.</p>
<h3>Examples</h3>
<table width="668">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="265">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[30, 15, 50, 5]</p>
</td>
<td width="76">
<p>5 15</p>
</td>
<td width="265">
<p>[3, 0, 10, 4, 7, 3]</p>
</td>
<td width="76">
<p>0 3</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Biggest Element</h2>
<p>Write a JS function that finds the biggest element inside a matrix.</p>
<p>The <strong>input</strong> comes as array of arrays, containing number elements (2D matrix of numbers).</p>
<p>The <strong>output</strong> is the return value of your function. Find the biggest element and return it.</p>
<h3>Examples</h3>
<table width="555">
<tbody>
<tr>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>[[20, 50, 10],</p>
<p>&nbsp;[8, 33,&nbsp;145]]</p>
</td>
<td width="113">
<p>145</p>
</td>
<td width="151">
<p>[[3, 5, 7, 12],</p>
<p>&nbsp;[-1, 4, 33, 2],</p>
<p>&nbsp;[8, 3, 0, 4]]</p>
</td>
<td width="113">
<p>33</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Diagonal Sums</h2>
<p>A square matrix of numbers comes as an array of strings, each string holding numbers (space separated). Write a JS function that finds the sum at the main and at the secondary diagonals.</p>
<p>The <strong>input</strong> comes as array of arrays, containing number elements (2D matrix of numbers).</p>
<p>The <strong>output</strong> is printed on the console, on a single line separated by space. First print the sum at the main diagonal, then the sum at the secondary diagonal.</p>
<h3>Examples</h3>
<table width="555">
<tbody>
<tr>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>[[20, 40],</p>
<p>&nbsp;[10, 60]]</p>
</td>
<td width="113">
<p>80 50</p>
</td>
<td width="151">
<p>[[3, 5, 17],</p>
<p>&nbsp;[-1, 7, 14],</p>
<p>&nbsp;[1, -8, 89]]</p>
</td>
<td width="113">
<p>99 25</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Equal Neighbors</h2>
<p>Write a JS function that finds the number of equal neighbor pairs inside a matrix of variable size and type (numbers or strings).</p>
<p>The <strong>input</strong> comes as array of arrays, containing string elements (2D matrix of strings).</p>
<p>The <strong>output</strong> is return value of you function. Save the number of equal pairs you find and return it.</p>
<h3>Examples</h3>
<table width="668">
<tbody>
<tr>
<td width="246">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="246">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="246">
<p>[['2', '3', '4', '7', '0'],</p>
<p>&nbsp;['4', '0', '5', '3', '4'],</p>
<p>&nbsp;['2', '3', '5', '4', '2'],</p>
<p>&nbsp;['9', '8', '7', '5', '4']]</p>
</td>
<td width="76">
<p>1</p>
</td>
<td width="246">
<p>[['test', 'yes', 'yo', 'ho'],</p>
<p>&nbsp;['well', 'done', 'yo', '6'],</p>
<p>&nbsp;['not', 'done', 'yet', '5']]</p>
</td>
<td width="76">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>