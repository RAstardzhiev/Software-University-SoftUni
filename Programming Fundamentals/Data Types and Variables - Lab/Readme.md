<h1>Lab: Data Types and Variables</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/171/Data-Types-and-Variables-Lab">https://judge.softuni.bg/Contests/171/Data-Types-and-Variables-Lab</a>.</p>
<h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Integer and Real Numbers</h1>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Centuries to Minutes</h2>
<p>Write program to enter an integer number of <strong>centuries</strong> and convert it to <strong>years</strong>, <strong>days</strong>, <strong>hours</strong> and <strong>minutes</strong>.</p>
<h3>Examples</h3>
<table width="659">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="608">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>1</p>
</td>
<td width="608">
<p>1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes</p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
</td>
<td width="608">
<p>5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use appropriate data type to fit the result after each data conversion.</li>
<li>Assume that a year has 2422 days at average (<a href="https://en.wikipedia.org/wiki/Tropical_year">the Tropical year</a>).</li>
</ul>
<h3>Solution</h3>
<p>You might help yourself with the code below:</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Circle Area (12 Digits Precision)</h2>
<p>Write program to enter a radius r (real number) and <strong>print the area</strong> of the circle with exactly <strong>12 digits</strong> after the decimal point. Use data type of <strong>enough precision</strong> to hold the results.</p>
<h3>Examples</h3>
<table width="406">
<tbody>
<tr>
<td width="47">
<p><strong>Input</strong></p>
</td>
<td width="140">
<p><strong>Output</strong></p>
</td>
<td width="35">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="47">
<p>2.5</p>
</td>
<td width="140">
<p>19.634954084936</p>
</td>
<td width="35">
<p>&nbsp;</p>
</td>
<td width="51">
<p>1.2</p>
</td>
<td width="132">
<p>4.523893421169</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>You might use the data type double. It has precision of 15-16 digits.</li>
<li>To print the output with exactly 12 digits after the decimal point, you might use the following code:</li>
</ul>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Exact Sum of Real Numbers</h2>
<p>Write program to enter n numbers and calculate and print their <strong>exact sum</strong> (without rounding).</p>
<h3>Examples</h3>
<table width="646">
<tbody>
<tr>
<td width="153">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
<td width="12">
<p><strong>&nbsp;</strong></p>
</td>
<td width="112">
<p><strong>Input</strong></p>
</td>
<td width="205">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="153">
<p>3</p>
<p>1000000000000000000</p>
<p>5</p>
<p>10</p>
</td>
<td width="165">
<p>1000000000000000015</p>
</td>
<td width="12">
<p>&nbsp;</p>
</td>
<td width="112">
<p>2</p>
<p>0.00000000003</p>
<p>333333333333.3</p>
</td>
<td width="205">
<p>333333333333.30000000003</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>If you use types like float or double, the result will lose some of its precision. Also it might be printed in scientific notation.</li>
<li>You might use the decimal data type which holds real numbers with high precision with less loss.</li>
<li>Note that decimal numbers sometimes hold the unneeded zeroes after the decimal point, so 0m is different than 0m and 0.00000m.</li>
</ul>
<h1>&nbsp;&nbsp; II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Data Types and Type Conversion</h1>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Elevator</h2>
<p>Calculate how many courses will be needed to <strong>elevate n persons</strong> by using an elevator of <strong>capacity of p persons</strong>. The input holds two lines: the <strong>number of people n</strong> and the <strong>capacity p</strong> of the elevator.</p>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="576">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>17</p>
<p>3</p>
</td>
<td width="62">
<p>6</p>
</td>
<td width="576">
<p>5 courses * 3 people<br /> + 1 course * 2 persons</p>
</td>
</tr>
<tr>
<td width="51">
<p>4</p>
<p>5</p>
</td>
<td width="62">
<p>1</p>
</td>
<td width="576">
<p>All the persons fit inside in the elevator.</p>
<p>Only one course is needed.</p>
</td>
</tr>
<tr>
<td width="51">
<p>10</p>
<p>5</p>
</td>
<td width="62">
<p>2</p>
</td>
<td width="576">
<p>2 courses * 5 people</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>You should <strong>divide </strong>n<strong> by </strong>p. This gives you the number of full courses (e.g. 17 / 3 = 5).</li>
<li>If n does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).</li>
<li>Another approach is to round up n / p to the nearest integer (ceiling), e.g. 17/3 = 67 &agrave; rounds up to 6.</li>
<li>Sample code for the round-up calculation:</li>
</ul>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp; Special Numbers</h2>
<p>A <strong>number</strong> is <strong>special</strong> when its <strong>sum of digits is 5, 7 or 11</strong>.</p>
<p>Write a program to read an integer n and for all numbers in the range <strong>1&hellip;n</strong> to print the number and if it is special or not (True / False).</p>
<h3>Examples</h3>
<table width="159">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>15</p>
</td>
<td width="108">
<p>1 -&gt; False</p>
<p>2 -&gt; False</p>
<p>3 -&gt; False</p>
<p>4 -&gt; False</p>
<p>5 -&gt; True</p>
<p>6 -&gt; False</p>
<p>7 -&gt; True</p>
<p>8 -&gt; False</p>
<p>9 -&gt; False</p>
<p>10 -&gt; False</p>
<p>11 -&gt; False</p>
<p>12 -&gt; False</p>
<p>13 -&gt; False</p>
<p>14 -&gt; True</p>
<p>15 -&gt; False</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>To calculate the sum of digits of given number num, you might repeat the following: sum the last digit (num % 10) and remove it (sum = sum / 10) until num reaches 0.</p>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp; Triples of Latin Letters</h2>
<p>Write a program to read an integer <strong>n</strong> and print all <strong>triples</strong> of the first <strong>n small Latin letters</strong>, ordered alphabetically:</p>
<h3>Examples</h3>
<table width="106">
<tbody>
<tr>
<td width="44">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="44">
<p>3</p>
</td>
<td width="62">
<p>aaa</p>
<p>aab</p>
<p>aac</p>
<p>aba</p>
<p>abb</p>
<p>abc</p>
<p>aca</p>
<p>acb</p>
<p>acc</p>
<p>baa</p>
<p>bab</p>
<p>bac</p>
<p>bba</p>
<p>bbb</p>
<p>bbc</p>
<p>bca</p>
<p>bcb</p>
<p>bcc</p>
<p>caa</p>
<p>cab</p>
<p>cac</p>
<p>cba</p>
<p>cbb</p>
<p>cbc</p>
<p>cca</p>
<p>ccb</p>
<p>ccc</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Perform 3 nested loops from 0 to n-1. For each number num print its corresponding Latin letter as follows:</p>
<h2>7.&nbsp;&nbsp;&nbsp;&nbsp; Greeting</h2>
<p>Write a program that enters <strong>first name</strong>, <strong>last name</strong> and <strong>age</strong> and prints "<strong><em>Hello, &lt;first name&gt; &lt;last name&gt;. You are &lt;age&gt; years old.</em></strong>". Use interpolated strings.</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="118">
<p><strong>Input</strong></p>
</td>
<td width="362">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="118">
<p>Svetlin</p>
<p>Nakov</p>
<p>25</p>
</td>
<td width="362">
<p>Hello, Svetlin Nakov. You are 25 years old.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You might use the following code:</p>
<h1>III.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Variables</h1>
<h2>8.&nbsp;&nbsp;&nbsp;&nbsp; Refactor Volume of Pyramid</h2>
<p>You are given a <strong>working code</strong> that finds the <strong>volume of a pyramid</strong>. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that <strong>have multiple purpose</strong>.</p>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<h3>Code</h3>
<table width="437">
<tbody>
<tr>
<td width="437">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="437">
<p>double dul, sh, V = 0;</p>
<p>Console.Write("Length: ");</p>
<p>dul = double.Parse(Console.ReadLine());</p>
<p>Console.Write("Width: ");</p>
<p>sh = double.Parse(Console.ReadLine());</p>
<p>Console.Write("Heigth: ");</p>
<p>V = double.Parse(Console.ReadLine());</p>
<p>V = (dul + sh + V) / 3;</p>
<p>Console.WriteLine("Pyramid Volume: {0:F2}", V);</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Reduce the span</strong> of the variables by declaring them in the moment they receive a value, not before</li>
<li>Rename your variables to <strong>represent their </strong>real <strong>purpose</strong> (example: "dul" should become length, etc.)</li>
<li>Search for variables that have multiple purpose. If you find any,<strong> introduce a new variable</strong>.</li>
</ul>
<h2>9.&nbsp;&nbsp;&nbsp;&nbsp; Refactor Special Numbers</h2>
<p>You are given a <strong>working code</strong> that is a solution to <strong>Problem 5. Special Numbers</strong>. However, the variables are <strong>improperly named, declared before</strong> they are needed and some of them are used for multiple things. Without using your previous solution, <strong>modify the code</strong> so that it is <strong>easy to read and understand</strong>.</p>
<h3>Code</h3>
<table width="685">
<tbody>
<tr>
<td width="685">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="685">
<p>int kolkko = int.Parse(Console.ReadLine());</p>
<p>int obshto = 0; int takova = 0; bool toe = false;</p>
<p>for (int ch = 1; ch &lt;= kolkko; ch++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; takova = ch;</p>
<p>&nbsp;&nbsp;&nbsp; while (ch &gt; 0)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;obshto += ch % 10;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ch = ch / 10;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; toe = (obshto == 5) || (obshto == 7) || (obshto == 11);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine($"{takova} -&gt; {toe}");</p>
<p>&nbsp;&nbsp;&nbsp; obshto = 0;</p>
<p>&nbsp;&nbsp;&nbsp; ch = takova;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Reduce the span of the variables by declaring them in the moment they receive a value, not before</li>
<li>Rename your variables to represent their real purpose (example: "dul" should become length, etc.)</li>
<li>Search for variables that have multiple purpose. If you find any, introduce a new variable</li>
</ul>