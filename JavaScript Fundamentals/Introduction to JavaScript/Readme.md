<h1>Lab: Introduction to JavaScript</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/287/">https://judge.softuni.bg/Contests/287/.</a></p>
<h2>1.&nbsp;&nbsp; Sum 3 Numbers</h2>
<p>Write a JS function that takes three numbers as input and outputs their sum.</p>
<p>The <strong>input</strong> comes as three number arguments passed to your function.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>2, 3, 4</p>
</td>
<td width="76">
<p>9</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="227">
<p>1.5, 1.5, -1</p>
</td>
<td width="76">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Sum And VAT</h2>
<p>Write a JS function that sums a variable number of prices and calculates their VAT (Value Add Tax, 20%).</p>
<p>The <strong>input</strong> comes as an array of numbers. The number of elements will be different every time.</p>
<p>The <strong>output</strong> should be printed to the console on a new line for every entry.</p>
<table width="643">
<tbody>
<tr>
<td width="416">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="416">
<p>[1.20, 2.60, 3.50]</p>
</td>
<td width="227">
<p>sum = 7.3</p>
<p>VAT = 1.46</p>
<p>total = 8.76</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="643">
<tbody>
<tr>
<td width="416">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="416">
<p>[3.12, 5, 18, 19.24, 1953.2262, 0.001564, 1.1445]</p>
</td>
<td width="227">
<p>sum = 1999.732264</p>
<p>VAT = 399.94645280000003</p>
<p>total = 2399.6787168</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Letter Occurrences in String</h2>
<p>Write a JS function that counts how many times a specific letter occurs in a given string.</p>
<p>The <strong>input</strong> comes two string arguments. The first element is the string to check and the second element is the letter to count.</p>
<p>The <strong>output</strong> should be returned as a result of your function.</p>
<table width="629">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>'hello', 'l'</p>
</td>
<td width="76">
<p>2</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="227">
<p>'panther', 'n'</p>
</td>
<td width="76">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Filter By Age</h2>
<p>Write a JS function that stores the name and age of two persons in objects and then filters them by minimum age.</p>
<p>The <strong>input</strong> comes as five arguments. The first element is the minimum age. The second and third elements are the name and age of the first person and the fourth and fifth elements &ndash; the name and age of the second person. The three age parameters will be numbers, the names will be strings.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<table width="605">
<tbody>
<tr>
<td width="340">
<p><strong>Input</strong></p>
</td>
<td width="265">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="340">
<p>12, 'Ivan', 15, 'Asen', 9</p>
</td>
<td width="265">
<p>{ name: 'Ivan', age: 15 }</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; String of Numbers 1&hellip;N</h2>
<p>Write a JS function that read a number <strong>n</strong> as input and prints all numbers from 1 to <strong>n</strong>, concatenated as a single string.</p>
<p>The <strong>input</strong> comes as one string element that needs to be parsed as a number.</p>
<p>The <strong>output</strong> should be returned as a result of your function.</p>
<table width="605">
<tbody>
<tr>
<td width="340">
<p><strong>Input</strong></p>
</td>
<td width="265">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="340">
<p>'11'</p>
</td>
<td width="265">
<p>'1234567891011'</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Figure Area</h2>
<p>Write a JS function that calculates the area of the figure on the right by given values for <strong>w</strong>, <strong>h</strong>, <strong>W</strong> and <strong>H</strong>. The lower right corner is always common for the two rectangles.</p>
<p>The <strong>input</strong> comes as four number parameters <strong>w</strong>, <strong>h</strong>, <strong>W</strong> and <strong>H</strong>.</p>
<p>The <strong>output</strong> should be returned as a result of your function.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>2, 4, 5, 3</p>
</td>
<td width="76">
<p>17</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="227">
<p>13, 2, 5, 8</p>
</td>
<td width="76">
<p>56</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Next Day</h2>
<p>Write a JS function that calculates the date of the next day by given year, month and day.</p>
<p>The <strong>input</strong> comes as three number parameters. The first element is the year, the second is the month and the third is the day.</p>
<p>The <strong>output</strong> should be returned as a result of your function.</p>
<h3>Examples</h3>
<table width="340">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>2016, 9, 30</p>
</td>
<td width="113">
<p>2016-10-1</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Distance between Points</h2>
<p>Write a JS function that calculates the distance between two points by given x and y coordinates. Use objects to store the two points.</p>
<p>The <strong>input</strong> comes as four number elements in the format <strong>x1, y1, x2, y2</strong>. Each pair of elements are the coordinates of a point in 2D space.</p>
<p>The <strong>output</strong> should be returned as a result of your function.</p>
<h3>Examples</h3>
<table width="567">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>2, 4, 5, 0</p>
</td>
<td width="189">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="567">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>2.34, 15.66, -13.55, -2.9985</p>
</td>
<td width="189">
<p>24.50778901186315</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>