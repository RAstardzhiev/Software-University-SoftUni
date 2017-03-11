<h1>Exercises: PHP Syntax, Basic Web</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/software-technologies">&ldquo;Software Technologies&rdquo; course @ SoftUni</a>.</p>
<p>You can submit your solutions here <a href="https://judge.softuni.bg/Contests/236/PHP-First-Steps-Exercises">https://judge.softuni.bg/Contests/236/PHP-First-Steps-Exercises</a>.</p>
<h1>Part I: Simple operations with PHP</h1>
<h2>1.&nbsp;&nbsp; Multiply a Number by 2</h2>
<p>You are given a number num. Write a PHP script that <strong>multiplies</strong> the <strong>number by 2</strong> and prints the result. The input comes as a parameter named num.</p>
<h3>Examples</h3>
<table width="379">
<tbody>
<tr>
<td width="123">
<p><strong>Parameter name</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>num</p>
</td>
<td width="51">
<p>2</p>
</td>
<td width="62">
<p>4</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>3</p>
</td>
<td width="62">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<p>You will be given a HTML form that submits the input data:</p>
<p>The name of the input parameter will be exactly as shown above &ndash; num.</p>
<p>Print the output in the HTML document, just after the HTML form.</p>
<h3>Hints</h3>
<ul>
<li>In case the form was submitted and the input parameter num exists, take its value as integer using the function intval(string).</li>
<li>Then, just print the results: echo $n * 2.</li>
<li>Test whether your code workd as expected:</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; Multiply Two Numbers</h2>
<p>You are given a number num1 and a number num2. Write a PHP script that multiplies num1 * num2 and prints the result. The input comes as parameters named num1 and num2. Print the output in the HTML page.</p>
<h3>Examples</h3>
<table width="406">
<tbody>
<tr>
<td width="128">
<p><strong>Parameters names</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="3" width="22">
<p><strong>&nbsp;</strong></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
<td width="66">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="128">
<p>num1</p>
</td>
<td width="61">
<p>2</p>
</td>
<td rowspan="2" width="62">
<p>6</p>
</td>
<td width="66">
<p>13</p>
</td>
<td rowspan="2" width="66">
<p>169</p>
</td>
</tr>
<tr>
<td width="128">
<p>num2</p>
</td>
<td width="61">
<p>3</p>
</td>
<td width="66">
<p>13&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>This time the form which will be given to use will have 2 input elements, with names num1 and num2</li>
<li>We must check both elements, if they have values before we perform any action</li>
<li>When we have checked both elements we get them both and extract their values into variables and we perform the specified action:</li>
<li>The result is as follows:</li>
</ul>
<h2>3.&nbsp;&nbsp; Multiply / Divide Numbers</h2>
<p>You are given a number num1 and a number num2. Write a PHP script that:</p>
<ul>
<li>Multiplies num1 * num2 if num2 is greater than or equal to num1.</li>
<li>Divides num1/num2 if num1 is greater than num2.</li>
</ul>
<p>The input comes as parameters named num1 and num2. Print the output in the HTML page.</p>
<h3>Examples</h3>
<table width="536">
<tbody>
<tr>
<td width="128">
<p><strong>Parameters names</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="3" width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="128">
<p>num1</p>
</td>
<td width="61">
<p>2</p>
</td>
<td rowspan="2" width="62">
<p>6</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>13</p>
</td>
<td rowspan="2" width="62">
<p>169</p>
</td>
<td width="60">
<p>3</p>
</td>
<td rowspan="2" width="62">
<p>1.5</p>
</td>
</tr>
<tr>
<td width="128">
<p>num2</p>
</td>
<td width="61">
<p>3</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>13</p>
</td>
<td width="60">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Product of 3 Numbers</h2>
<p>You are given a number num1, num2 and num3. Write a PHP script that finds if num1 * num2 * num3 (the product) is <strong>negative</strong> or <strong>positive</strong>. Try to do this <strong>WITHOUT</strong> multiplying the 3 numbers.</p>
<p>The input comes as parameters named num1, num2 and num3.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="123">
<p><strong>Parameters name</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="84">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="84">
<p><strong>Output</strong></p>
</td>
<td rowspan="4" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="84">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>num1</p>
</td>
<td width="51">
<p>2</p>
</td>
<td rowspan="3" width="84">
<p>Negative</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>5</p>
</td>
<td rowspan="3" width="84">
<p>Positive</p>
</td>
<td width="51">
<p>-3</p>
</td>
<td rowspan="3" width="84">
<p>Positive</p>
</td>
</tr>
<tr>
<td width="123">
<p>num2</p>
</td>
<td width="51">
<p>3</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>4</p>
</td>
<td width="51">
<p>-4</p>
</td>
</tr>
<tr>
<td width="123">
<p>num3</p>
</td>
<td width="51">
<p>-1</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>3</p>
</td>
<td width="51">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Count the <strong>negative numbers</strong>. If they are odd number, the result will be negative, otherwise &agrave;</li>
<li>Special case: one of the numbers is 0 &agrave; the product is positive.</li>
</ul>
<h2>5.&nbsp;&nbsp; Numbers from 1 to N</h2>
<p>You are given a number num. Write a PHP script that loops through all of the numbers from 1 to num and prints them. The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="412">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="92">
<p>1 2 3 4 5</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>2</p>
</td>
<td width="62">
<p>1 2</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Numbers from N to 1</h2>
<p>You are given a number num. Write a PHP script that loops through all of the numbers from num to 1 and prints them. The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="412">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="92">
<p>5 4 3 2 1</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>2</p>
</td>
<td width="62">
<p>2 1</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Even Numbers from 1 to N</h2>
<p>You are given a number num. Write a PHP script that loops through all of the numbers from 1 to num and prints only the even ones. The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="383">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="62">
<p>2 4</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>2</p>
</td>
<td width="62">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Odd Numbers from N to 1</h2>
<p>You are given a number num. Write a PHP script that loops through all of the numbers from num to 1 and prints only the odd ones. The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="383">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="62">
<p>5 3 1</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>2</p>
</td>
<td width="62">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; N Factorial</h2>
<p>You are given a number num. Write a PHP script that prints <strong>factorial</strong> of num. Factorial is calculated by multiplying all numbers to the given number. Factorial (N) = 1 * 2 * 3&hellip; * num. The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="383">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="62">
<p>120</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>3</p>
</td>
<td width="62">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not Divisor Numbers</h2>
<p>You are given a number num. Write a PHP script that prints all the numbers from num to 1<strong>, </strong>which are not divisors of num<strong>.</strong> The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="490">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>10</p>
</td>
<td width="108">
<p>9 8 7 6 4 3</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>12</p>
</td>
<td width="124">
<p>11 10 9 8 7 5</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fibonacci Sequence</h2>
<p>You are given a number num. Write a PHP script that prints num numbers from The Fibonacci sequence, each on a new line, starting from 1. In the Fibonacci sequence, every number is formed from the sum of the previous 2. The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="549">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
<td width="15">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="205">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="92">
<p>1 1 2 3 5</p>
</td>
<td width="15">
<p>&nbsp;</p>
</td>
<td width="60">
<p>10</p>
</td>
<td width="205">
<p>1 1 2 3 5 8 13 21 34 55</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tribonacci Sequence</h2>
<p>In the <strong>&ldquo;Tribonacci&rdquo; sequence</strong>, every number is formed by the <strong>sum of the previous 3</strong>.</p>
<p>You are given a number num. Write a PHP script that prints num numbers from the Tribonacci sequence, each on a new line, starting from 1. The input comes as a parameter named num. The value num will always be positive integer.</p>
<h3>Examples</h3>
<table width="488">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="51">
<p>4</p>
</td>
<td width="76">
<p>1 1 2 4</p>
<p>&nbsp;</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>8</p>
</td>
<td width="165">
<p>1 1 2 4 7 13 24 44</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prime Numbers from N to 1</h2>
<p>You are given a number num. Write a PHP script that prints only the <strong>prime</strong> numbers from num to 1. A prime number is a number that can be divided only by 1 and itself. <strong>1 is not a prime number.</strong> The input comes as a parameter named num. The parameter num will hold a positive integer.</p>
<h3>Examples</h3>
<table width="477">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="157">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>10</p>
</td>
<td width="62">
<p>7 5 3</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>20</p>
</td>
<td width="157">
<p>19 17 13 11 7 5 3</p>
</td>
</tr>
</tbody>
</table>
<h1>Part 2: Manipulating HTML with PHP</h1>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HTML Buttons</h2>
<p>You are given a number num. Write a PHP script that <strong>generates HTML &lt;button&gt; elements.</strong> The buttons must hold a number from 1 to num as their caption. The input comes as a parameter named num, holding a positive integer.</p>
<p>There is no indentation on the elements.</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="117">
<p><strong>Parameter name</strong></p>
</td>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="219">
<p><strong>Output</strong></p>
</td>
<td width="291">
<p><strong>Picture</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>3</p>
</td>
<td width="219">
<p>&lt;button&gt;1&lt;/button&gt;</p>
<p>&lt;button&gt;2&lt;/button&gt;</p>
<p>&lt;button&gt;3&lt;/button&gt;</p>
</td>
<td rowspan="3" width="291">&nbsp;</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="219">
<p>&lt;button&gt;1&lt;/button&gt;</p>
<p>&lt;button&gt;2&lt;/button&gt;</p>
<p>&lt;button&gt;3&lt;/button&gt;</p>
<p>&lt;button&gt;4&lt;/button&gt;</p>
<p>&lt;button&gt;5&lt;/button&gt;</p>
</td>
</tr>
<tr>
<td width="117">
<p>num</p>
</td>
<td width="61">
<p>1</p>
</td>
<td width="219">
<p>&lt;button&gt;1&lt;/button&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sub-Lists</h2>
<p>You are given a number num1 and a number num2. Write a PHP script that generates a list with <strong>num1</strong> elements, and each of those elements has a sub-list with <strong>num2 </strong>elements. Each of the Lists has a caption &ldquo;<strong>List #</strong>&rdquo; where # is the current number from 1 to num1<strong>. </strong>And each of the elements of those lists has a caption &ldquo;<strong>Element #.#</strong>&rdquo; where the first # is the current list number and the second <strong>#</strong> is the current element from 1 to num2. The input comes as a parameters named num1 and num2, holding positive integers.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="128">
<p><strong>Parameters names</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
<td width="208">
<p><strong>Picture</strong></p>
</td>
</tr>
<tr>
<td width="128">
<p>num1</p>
</td>
<td width="51">
<p>1</p>
</td>
<td rowspan="2" width="302">
<p>&lt;ul&gt;</p>
<p>&lt;li&gt;List 1</p>
<p>&lt;ul&gt;</p>
<p>&lt;li&gt;</p>
<p>Element 1.1</p>
<p>&lt;/li&gt;</p>
<p>&lt;li&gt;</p>
<p>Element 1.2</p>
<p>&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
<p>&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
</td>
<td rowspan="2" width="208">&nbsp;</td>
</tr>
<tr>
<td width="128">
<p>num2</p>
</td>
<td width="51">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p>There is <strong>indentation</strong> on the elements. Each nested element is <strong>tabbed</strong> <strong>once right</strong> from its parent.</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Draw an &ldquo;S&rdquo; with Buttons</h2>
<p>Write a PHP script that draws 5 x 9 &lt;button&gt; elements with <strong>0 </strong>and <strong>1</strong> in them. The <strong>1</strong>s should form a figure <strong>&ldquo;S&rdquo;</strong>. Make the <strong>1</strong>s&rsquo; background color &ndash; <strong>blue</strong>. There is no indentation on the elements.</p>
<h3>Example</h3>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RGB Table</h2>
<p>Write a PHP script that draws a table with 3 columns, with captions &ndash; <strong>Red</strong>, <strong>Green</strong> and <strong>Blue</strong>, and 5 rows, each having as <strong>background</strong> <strong>1</strong> of <strong>5</strong> shades of those colors. Increase the color index by <strong>51</strong> for each row. For example, for the Red Column it will be:</p>
<ul>
<li>RGB(51, 0, 0)</li>
<li>RGB(102, 0, 0)</li>
<li>RGB(153, 0, 0)</li>
<li>. . .</li>
</ul>
<p>The caption columns should<strong> NOT </strong>be colored. There indentation on the elements. Make the table cells in the table row <strong>tabbed 1 times to the right</strong>.</p>
<h3>Picture:</h3>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 50 Shades of Grey</h2>
<p>Write a PHP script that generates 5 rows of 10 &lt;div&gt;<strong> elements</strong>, each having as background a different shade of grey &ndash; resulting in 50 shades of grey. Every row starts with a color index &ndash; a <strong>multiple of 51</strong>.</p>
<ul>
<li>First row &ndash; 0,</li>
<li>Second row &ndash; 51,</li>
<li>Third row &ndash; 102 &hellip;</li>
</ul>
<p>Then you need to print <strong>10 divs</strong>, each increasing that index with <strong>5.</strong></p>
<ul>
<li>First row &ndash; 0, 5, 10&hellip;</li>
<li>Second row &ndash; 51, 56, 61&hellip;</li>
</ul>
<p>The color index needs to be applied to <strong>all</strong> <strong>parameters</strong> of the <strong>RGB function</strong>. Example: rgb(51, 51, 51);</p>
<h3>Picture:</h3>
<p>There is no indentation on the elements.</p>