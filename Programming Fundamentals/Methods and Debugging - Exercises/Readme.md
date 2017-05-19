<h1>Exercises: Methods and Debugging</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/305/Methods-and-Debugging-Excercises">https://judge.softuni.bg/Contests/305/Methods-and-Debugging-Excercises</a>.</p>
<h2>1.&nbsp;&nbsp; Hello, Name!</h2>
<p>Write a <strong>method</strong> that receives a name as <strong>parameter</strong> and prints on the console. &ldquo;Hello, &lt;name&gt;!&rdquo;</p>
<h3>Examples</h3>
<table width="176">
<tbody>
<tr>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="52">
<p>Peter</p>
</td>
<td width="124">
<p>Hello, Peter!</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Min Method</h2>
<p>Create a method GetMin(int a, int b), that returns maximal of two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax(&hellip;) method you just created.</p>
<h3>Examples</h3>
<table width="262">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="35">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>1</p>
<p>2</p>
<p>3</p>
</td>
<td width="62">
<p>3</p>
</td>
<td width="35">
<p>&nbsp;</p>
</td>
<td width="51">
<p>-100</p>
<p>-101</p>
<p>-102</p>
</td>
<td width="62">
<p>-100</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; English Name оf The Last Digit</h2>
<p>Write a <strong>method</strong> that returns the <strong>English name</strong> of the last digit of a given number. Write a program that reads an integer and prints the returned value from this method.</p>
<h3>Examples</h3>
<table width="258">
<tbody>
<tr>
<td width="47">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="35">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="47">
<p>1024</p>
</td>
<td width="62">
<p>four</p>
</td>
<td width="35">
<p>&nbsp;</p>
</td>
<td width="51">
<p>512</p>
</td>
<td width="62">
<p>two</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Numbers in Reversed Order</h2>
<p>Write a method that <strong>prints the digits</strong> of a given decimal number in a <strong>reversed order</strong>.</p>
<h3>Examples</h3>
<table width="262">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="35">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>256</p>
</td>
<td width="62">
<p>652</p>
</td>
<td width="35">
<p>&nbsp;</p>
</td>
<td width="51">
<p>1.12</p>
</td>
<td width="62">
<p>21.1</p>
</td>
</tr>
</tbody>
</table>
<ol start="5">
<li><strong>Fibonacci Numbers</strong></li>
</ol>
<p>Define a method <strong>Fib(n)</strong> that calculates the n<sup>th</sup> <a href="https://en.wikipedia.org/wiki/Fibonacci_number">Fibonacci number</a>. Examples:</p>
<table>
<tbody>
<tr>
<td width="44">
<p><strong>n</strong></p>
</td>
<td width="68">
<p><strong>Fib(n)</strong></p>
</td>
</tr>
<tr>
<td width="44">
<p>0</p>
</td>
<td width="68">
<p>1</p>
</td>
</tr>
<tr>
<td width="44">
<p>1</p>
</td>
<td width="68">
<p>1</p>
</td>
</tr>
<tr>
<td width="44">
<p>2</p>
</td>
<td width="68">
<p>2</p>
</td>
</tr>
<tr>
<td width="44">
<p>3</p>
</td>
<td width="68">
<p>3</p>
</td>
</tr>
<tr>
<td width="44">
<p>4</p>
</td>
<td width="68">
<p>5</p>
</td>
</tr>
<tr>
<td width="44">
<p>5</p>
</td>
<td width="68">
<p>8</p>
</td>
</tr>
<tr>
<td width="44">
<p>6</p>
</td>
<td width="68">
<p>13</p>
</td>
</tr>
<tr>
<td width="44">
<p>11</p>
</td>
<td width="68">
<p>144</p>
</td>
</tr>
<tr>
<td width="44">
<p>25</p>
</td>
<td width="68">
<p>121393</p>
</td>
</tr>
</tbody>
</table>
<ol start="6">
<li><strong>Prime Checker</strong></li>
</ol>
<p>Write a Boolean method <strong>Is</strong><strong>Prime(n)</strong> that check whether a given integer number <strong>n</strong> is <a href="https://en.wikipedia.org/wiki/Prime_number">prime</a>. Examples:</p>
<table>
<tbody>
<tr>
<td width="108">
<p><strong>n</strong></p>
</td>
<td width="85">
<p><strong>IsPrime</strong><strong>(n)</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>0</p>
</td>
<td width="85">
<p>false</p>
</td>
</tr>
<tr>
<td width="108">
<p>1</p>
</td>
<td width="85">
<p>false</p>
</td>
</tr>
<tr>
<td width="108">
<p>2</p>
</td>
<td width="85">
<p>true</p>
</td>
</tr>
<tr>
<td width="108">
<p>3</p>
</td>
<td width="85">
<p>true</p>
</td>
</tr>
<tr>
<td width="108">
<p>4</p>
</td>
<td width="85">
<p>false</p>
</td>
</tr>
<tr>
<td width="108">
<p>5</p>
</td>
<td width="85">
<p>true</p>
</td>
</tr>
<tr>
<td width="108">
<p>323</p>
</td>
<td width="85">
<p>false</p>
</td>
</tr>
<tr>
<td width="108">
<p>337</p>
</td>
<td width="85">
<p>true</p>
</td>
</tr>
<tr>
<td width="108">
<p>6737626471</p>
</td>
<td width="85">
<p>true</p>
</td>
</tr>
<tr>
<td width="108">
<p>117342557809</p>
</td>
<td width="85">
<p>false</p>
</td>
</tr>
</tbody>
</table>
<ol start="7">
<li><strong>* Primes in Given Range</strong></li>
</ol>
<p>Write a method that calculates <strong>all prime numbers in given range</strong> and returns them as list of integers:</p>
<table>
<tbody>
<tr>
<td width="695">
<p>static List&lt;int&gt; FindPrimesInRange(startNum, endNum)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; &hellip;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>Write a method to <strong>print a list of integers</strong>. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="154">
<p><strong>Start and End Number</strong></p>
</td>
<td width="540">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="154">
<p>0</p>
<p>10</p>
</td>
<td width="540">
<p>2, 3, 5, 7</p>
</td>
</tr>
<tr>
<td width="154">
<p>5</p>
<p>11</p>
</td>
<td width="540">
<p>5, 7, 11</p>
</td>
</tr>
<tr>
<td width="154">
<p>100</p>
<p>200</p>
</td>
<td width="540">
<p>101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199</p>
</td>
</tr>
<tr>
<td width="154">
<p>250</p>
<p>950</p>
</td>
<td width="540">
<p>251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947</p>
</td>
</tr>
<tr>
<td width="154">
<p>100</p>
<p>50</p>
</td>
<td width="540">
<p><em>(empty list)</em></p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Center Point</h2>
<p>You are given the coordinates of two points on a <a href="https://en.wikipedia.org/wiki/Cartesian_coordinate_system">Cartesian coordinate system</a> - X1, Y1, X2 and Y2. <strong>Create a method</strong> that prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y). If the points are on a same distance from the center, print only the first one.</p>
<h3>Examples</h3>
<table width="176">
<tbody>
<tr>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="52">
<p>2</p>
<p>4</p>
<p>-1</p>
<p>2</p>
</td>
<td width="124">
<p>(-1, 2)</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Longer Line</h2>
<p>You are given the coordinates of four points in the 2D plane. The first and the second pair of points form two different lines. Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem). If the lines are of equal length, print only the first one.</p>
<h3>Examples</h3>
<table width="230">
<tbody>
<tr>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="179">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="52">
<p>2</p>
<p>4</p>
<p>-1</p>
<p>2</p>
<p>-5</p>
<p>-5</p>
<p>4</p>
<p>-3</p>
</td>
<td width="179">
<p>(4, -3)(-5, -5)</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cube Properties</h2>
<p>Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area of a <strong>cube</strong> (<a href="http://www.mathopenref.com/cube.html">http://www.mathopenref.com/cube.html</a>) by a given side. On the first line you will get the side of the cube. On the second line is given the parameter (<strong>face</strong>, <strong>space</strong>, <strong>volume</strong> or <strong>area</strong>).</p>
<p>Output should be rounded to the second digit after the decimal point:</p>
<h3>Examples</h3>
<table width="176">
<tbody>
<tr>
<td width="70">
<p><strong>Input</strong></p>
</td>
<td width="106">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="70">
<p>5</p>
<p>face</p>
<p>&nbsp;</p>
</td>
<td width="106">
<p>7.07</p>
</td>
</tr>
<tr>
<td width="70">
<p>5</p>
<p>volume</p>
</td>
<td width="106">
<p>125.00</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Geometry Calculator</h2>
<p>Write a program that can <strong>calculate the area</strong> of <strong>four different geometry figures</strong> - triangle, square, rectangle and circle.</p>
<p><strong>On the first line</strong> you will get the <strong>figure type</strong>. Next you will get parameters for the chosen figure, <strong>each on a different line</strong>:</p>
<ul>
<li>Triangle - side and height</li>
<li>Square - side</li>
<li>Rectangle - width and height</li>
<li>Circle - radius</li>
</ul>
<p>The output should be rounded to the second digit after the decimal point:</p>
<h3>Examples</h3>
<table width="176">
<tbody>
<tr>
<td width="70">
<p><strong>Input</strong></p>
</td>
<td width="106">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="70">
<p>triangle</p>
<p>3</p>
<p>6</p>
</td>
<td width="106">
<p>9.00</p>
</td>
</tr>
<tr>
<td width="70">
<p>rectangle</p>
<p>4</p>
<p>5</p>
</td>
<td width="106">
<p>20.00</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Master Numbers</h2>
<p>A master number is an integer that holds the following properties:</p>
<ul>
<li>Is <strong>symmetric</strong> (palindrome), e.g. 5, 77, 282, 14341, 9553559.</li>
<li>Its <strong>sum of digits is divisible by 7</strong>, e.g. 77, 313, 464, 5225, 37173.</li>
<li>Holds at least <strong>one even digit</strong>, e.g. 232, 707, 6886, 87578.</li>
</ul>
<p>Write a program to <strong>print all master numbers</strong> in the range [1&hellip;<strong>n</strong>].</p>
<h3>Examples</h3>
<table width="262">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="35">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>600</p>
</td>
<td width="62">
<p>232</p>
<p>383</p>
<p>464</p>
<p>545</p>
</td>
<td width="35">
<p>&nbsp;</p>
</td>
<td width="51">
<p>5000</p>
</td>
<td width="62">
<p>232</p>
<p>383</p>
<p>464</p>
<p>545</p>
<p>626</p>
<p>696</p>
<p>707</p>
<p>858</p>
<p>1661</p>
<p>2552</p>
<p>3443</p>
<p>4334</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>Write 3 utility methods:</li>
</ol>
<ul>
<li>IsPalindrome(intnum)</li>
<li>SumOfDigits(intnum)</li>
<li>ContainsEvenDigit(int num)</li>
</ul>
<ol start="2">
<li>Loop through all numbers in range [1&hellip;n] and check every number with the helper methods.</li>
</ol>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Factorial</h2>
<p>Write a program that calculates and prints the n! for any n in the range [1&hellip;1000].</p>
<h3>Examples</h3>
<table width="697">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="520">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
</td>
<td width="62">
<p>120</p>
</td>
<td width="13">
<p>&nbsp;</p>
</td>
<td width="51">
<p>100</p>
</td>
<td width="520">
<p>93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use the class BigInteger from the built-in .NET library System.Numerics.dll.</p>
<ol>
<li>First add reference to Numerics.dll.</li>
<li>Import the namespace &ldquo;Numerics&rdquo;:</li>
<li>Use the type BigInteger instead of long or decimal to keep the factorial value:</li>
</ol>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Factorial Trailing Zeroes</h2>
<p>Create a program that counts the trailing zeroes of the factorial of a given number.</p>
<h3>Examples</h3>
<table width="646">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="532">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
</td>
<td width="62">
<p>1</p>
</td>
<td width="532">
<p>5! = 12<strong>0</strong> -&gt; One trailing zero</p>
</td>
</tr>
<tr>
<td width="51">
<p>100</p>
</td>
<td width="62">
<p>24</p>
</td>
<td width="532">
<p>100! = 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864<strong>000000000000000000000000</strong> -&gt; 24 trailing zeroes</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>You may use your solution from the previous problem. Add additional method that counts and returns the number of zeroes a number has.</li>
</ol>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Debugging Exercise: Substring</h2>
<p>The goal of this exercise is to practice <strong>debugging techniques </strong>in scenarios where a piece of code does not work correctly. Your task is to <strong>pinpoint the bug</strong> and <strong>fix it</strong> (without rewriting the entire code). Test your fixed solution in the judge system:</p>
<p>You can download the broken solution from <a href="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</a>.</p>
<h3>Problem Description</h3>
<p>You are given a <strong>text </strong>and a number count. Your program should search through the text for the letter '<strong>p</strong>' (ASCII code <strong>112</strong>) and print '<strong>p</strong>' along with count letters to its right.</p>
<p>For example, we are given the <strong>text</strong> "<strong>phahah put</strong>" and count = <strong>3</strong>. We find a match of '<strong>p</strong>' in the first letter so we print it and the 3 letters to its right. The result is "<strong>phah</strong>". We continue and find another match of '<strong>p</strong>', but there aren't 3 letters to its right, so we print only "<strong>put</strong>".</p>
<p>Each match should be printed on a separate line. If there are no matches of '<strong>p</strong>' in the text, we print "<strong>no</strong>".</p>
<h3>Input</h3>
<ul>
<li>The first line holds the <strong>text</strong> to be processed (string).</li>
<li>The second line holds the <strong>number </strong>count.</li>
</ul>
<h3>Output</h3>
<p>For each match, print the <strong>matched substring</strong> at separate line. Print "<strong>no</strong>" if there are no matches.</p>
<h3>Constraints</h3>
<ul>
<li>The number count will be in the range [0 ... 100].</li>
</ul>
<h3>Tests</h3>
<table>
<tbody>
<tr>
<td width="174">
<p><strong>Input</strong></p>
</td>
<td width="144">
<p><strong>Program Output</strong></p>
</td>
<td width="138">
<p><strong>Expected Output</strong></p>
</td>
</tr>
<tr>
<td width="174">
<p>phahah put</p>
<p>3</p>
</td>
<td width="144">
<p>no</p>
</td>
<td width="138">
<p>phah</p>
<p>put</p>
</td>
</tr>
<tr>
<td width="174">
<p>No match</p>
<p>5</p>
</td>
<td width="144">
<p>no</p>
<p>&nbsp;</p>
</td>
<td width="138">
<p>no</p>
</td>
</tr>
<tr>
<td width="174">
<p>preparation</p>
<p>4</p>
</td>
<td width="144">
<p>no</p>
</td>
<td width="138">
<p>prepa</p>
</td>
</tr>
<tr>
<td width="174">
<p>preposition</p>
<p>0</p>
</td>
<td width="144">
<p>no</p>
</td>
<td width="138">
<p>P</p>
<p>p</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Debugging Exercise: Instruction Set</h2>
<p>The goal of this exercise is to practice <strong>debugging techniques </strong>in scenarios where a piece of code does not work correctly. Your task is to <strong>pinpoint the bug</strong> and <strong>fix it</strong> (without rewriting the entire code).</p>
<p>You can download the broken solution from <a href="http://svn.softuni.org/admin/svn/soft-tech/Jan-2017/Programming-Fundamentals-Jan-2017/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</a>.</p>
<h3>Problem Description</h3>
<p>Write an <strong>instruction interpreter</strong> that executes an arbitrary number of <strong>instructions</strong>. The program should <strong>parse the instructions</strong>, <strong>execute</strong> them and <strong>print the result</strong>. The following instruction set should be supported:</p>
<ul>
<li>INC &lt;operand1&gt; &ndash; increments the operand by 1</li>
<li>DEC<strong>&lt;operand1&gt;</strong> &ndash; decrements the operand by 1</li>
<li>ADD&lt;operand1&gt; &lt;operand2&gt; &ndash; performs addition on the two operands</li>
<li>MLA&lt;operand1&gt; &lt;operand2&gt; &ndash; performs multiplication on the two operands</li>
<li>END &ndash; end of input</li>
</ul>
<h3>Output</h3>
<h3>The result of each instruction should be printed on a separate line on the console.</h3>
<h3>Constraints</h3>
<ul>
<li>The operands will be valid integers in the range [&minus;2 147 483 648 &hellip; 2 147 483 647].</li>
</ul>
<h3>Tests</h3>
<table>
<tbody>
<tr>
<td width="174">
<p><strong>Input</strong></p>
</td>
<td width="175">
<p><strong>Program Output</strong><strong> (Wrong)</strong></p>
</td>
<td width="182">
<p><strong>Expected Output (Correct)</strong></p>
</td>
</tr>
<tr>
<td width="174">
<p>INC 0</p>
<p>END</p>
</td>
<td width="175">
<p>0</p>
<p>0</p>
<p>&hellip; (infinite)</p>
</td>
<td width="182">
<p>1</p>
</td>
</tr>
<tr>
<td width="174">
<p>ADD 1323134 421315521</p>
<p>END</p>
</td>
<td width="175">
<p>422638655</p>
<p>422638655</p>
<p>&hellip; (infinite)</p>
</td>
<td width="182">
<p>422638655</p>
</td>
</tr>
<tr>
<td width="174">
<p>DEC 57314183</p>
<p>END</p>
</td>
<td width="175">
<p>57314183</p>
<p>57314183</p>
<p>&hellip; (infinite)</p>
</td>
<td width="182">
<p>57314182</p>
</td>
</tr>
<tr>
<td width="174">
<p>MLA 252621 324532</p>
<p>END</p>
</td>
<td width="175">
<p>379219748</p>
<p>379219748</p>
<p>&hellip; (infinite)</p>
</td>
<td width="182">
<p>81983598372</p>
</td>
</tr>
</tbody>
</table>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Debugging Exercise: Be Positive</h2>
<p>The goal of this exercise is to practice <strong>debugging techniques </strong>in scenarios where a piece of code does not work correctly. Your task is to <strong>pinpoint the bug</strong> and <strong>fix it</strong> (without rewriting the entire code). Test your fixed solution in the judge system:</p>
<p>You can download the broken solution from <a href="http://svn.softuni.org/admin/svn/soft-tech/Jan-2017/Programming-Fundamentals-Jan-2017/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</a>.</p>
<h3>Problem Description</h3>
<p>A program is designed to take some <strong>sequences of numbers</strong> from the console, to <strong>process them </strong>as described below and <strong>print</strong> each obtained sequence.</p>
<h3>Input</h3>
<ul>
<li>On the first line of input you are given a <strong>count N &ndash; the number of sequences</strong>.</li>
<li>On each of <strong>the next N lines </strong>you will receive some <strong>numbers surrounded by whitespaces</strong>.</li>
</ul>
<h3>Processing Logic</h3>
<p>You need to check each number, if it&rsquo;s <strong>positive</strong> &ndash; print it on the console; if it&rsquo;s <strong>negative</strong>, add to its value the value of the next number and only <strong>print the result if it&rsquo;s not negative</strong>. You only perform the addition once, e.g. if you have the sequence: -3, 1, 3, the algorithm is as follows:</p>
<ul>
<li>-3 is negative =&gt; add to it the next number (1) =&gt; -3 + 1 = -2 still negative =&gt; do not print anything (and don&rsquo;t keep adding numbers, you stop here).</li>
<li>The next number we consider is 3 which is positive =&gt; print it.</li>
</ul>
<p>If no numbers can be obtained in this manner for the given sequence, print <strong>&ldquo;(empty)&rdquo;</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="150">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Expected Output</strong></p>
</td>
<td width="246">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="150">
<p>3</p>
<p>&nbsp; 3 -4&nbsp;&nbsp;&nbsp; 5 2&nbsp; 123</p>
<p>-1 -1 3 4</p>
<p>-2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1</p>
</td>
<td width="124">
<p>3 1 2 123</p>
<p>3 4</p>
<p>(empty)</p>
</td>
<td width="246">
<p>(3) <strong>(-4 + 5 = 1 &gt; 0)</strong> (2) (123)</p>
<p><strong>(-1 + (-1) &lt; 0)</strong> (3) (4)</p>
<p><strong>(-2 + 1 &lt; 0)</strong></p>
</td>
</tr>
</tbody>
</table>
<h3>Output</h3>
<p>Print on the console <strong>each modified sequence on a separate line.</strong></p>
<h3>Constraints</h3>
<ul>
<li>The <strong>number N</strong> will be an integer in the range [1 &hellip; 15].</li>
<li>The <strong>numbers in the sequences</strong> will be integers in the range [-1000 &hellip; 1000].</li>
<li>The <strong>count of numbers in each sequence</strong> will be in the range [1 &hellip; 20].</li>
<li>There may be <strong>whitespaces anywhere around the numbers</strong> in a given sequence</li>
</ul>
<h3>Tests</h3>
<table>
<tbody>
<tr>
<td width="161">
<p><strong>Input</strong></p>
</td>
<td width="175">
<p><strong>Program Output (Wrong)</strong></p>
</td>
<td width="124">
<p><strong>Expected Output</strong></p>
</td>
</tr>
<tr>
<td width="161">
<p>3</p>
<p>&nbsp; 3 -4&nbsp;&nbsp;&nbsp; 5 2&nbsp; 123</p>
<p>-1 -1 3 4</p>
<p>-2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1</p>
</td>
<td width="175">
<p>Exception&hellip;</p>
</td>
<td width="124">
<p>3 1 2 123</p>
<p>3 4</p>
<p>(empty)</p>
</td>
</tr>
<tr>
<td width="161">
<p>1</p>
<p>0 -2 2 -2 3</p>
</td>
<td width="175">
<p>Exception&hellip;</p>
<p>&nbsp;</p>
</td>
<td width="124">
<p>0 0 1</p>
</td>
</tr>
</tbody>
</table>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Debugging Exercise: Sequence of Commands</h2>
<p>The goal of this exercise is to practice <strong>debugging techniques </strong>in scenarios where a piece of code does not work correctly. Your task is to <strong>pinpoint the bug</strong> and <strong>fix it</strong> (without rewriting the entire code). Test your fixed solution in the judge system:</p>
<p>You can download the broken solution from <a href="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.%20Programming-Fundamentals-Methods-and-Debugging-Exercises-Broken-Solutions.zip">here</a>.</p>
<h3>Problem Description</h3>
<p>You are given a program that reads a n<strong> numbers</strong> and a <strong>sequence of commands</strong> to be executed over these numbers.</p>
<h3>Input</h3>
<ul>
<li>The first line holds an <strong>integer</strong> n &ndash; the <strong>count</strong> of numbers.</li>
<li>The second line holds <strong>n numbers </strong>&ndash; integers separated by space.</li>
<li>Each of the next few lines hold <strong>commands</strong> in format: <strong>&ldquo;[action] [i-th element] [value]&rdquo;</strong>.</li>
<li>The commands sequence end with a command <strong>&ldquo;stop&rdquo;</strong>.</li>
</ul>
<h3>Commands</h3>
<p>Commands are given in format <strong>&ldquo;[action] [i-th element] [value]&rdquo;</strong>. Elements are indexed from <strong>1</strong> to <strong>n</strong>.</p>
<p>The <strong>action</strong> can be <strong>&ldquo;multiply&rdquo;</strong>, <strong>&ldquo;add&rdquo;</strong>,<strong> &ldquo;subtract&rdquo;</strong>,<strong> &ldquo;rshift&rdquo; </strong>or<strong> &ldquo;lshift&rdquo;</strong>.</p>
<ul>
<li>The actions <strong>&ldquo;multiply&rdquo;, &ldquo;add&rdquo; </strong>and <strong>&ldquo;subtract&rdquo; </strong>have parameters. The first parameter is the <strong>index</strong> of the element that needs to be changed (in range [<strong>1</strong>...<strong>n</strong>]). The second parameter is the <strong>value</strong> with which we manipulate the element.</li>
<li>The command <strong>&ldquo;lshift&rdquo;</strong> moves the first element last. E.g. &ldquo;<strong>lshift</strong>&rdquo; over {1, 2, 3} will produce {2, 3, 1}.</li>
<li>The command <strong>&ldquo;rshift&rdquo;</strong> moves the last element first. E.g. &ldquo;<strong>rshift</strong>&rdquo; over {1, 2, 3} will produce {3, 1, 2}.</li>
</ul>
<h3>Output</h3>
<p>Print the values of the <strong>n elements</strong> after the execution of each command (except the last &ldquo;<strong>stop</strong>&rdquo; command).</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>number </strong>n will be an integer in the range [1 &hellip; 15].</li>
<li>Each <strong>element of the array</strong> will be an integer in the range [0 &hellip; 2<sup>63</sup>-1].</li>
<li>The <strong>number </strong>i and the <strong>number of commands</strong> will be integers in the range [1 &hellip; 10].</li>
<li>The <strong>number value</strong> will be an integer in the range [-100 &hellip; 100]. If the command is &ldquo;<strong>rshift</strong>&rdquo; or &ldquo;<strong>lshift</strong>&rdquo; there are no parameters.</li>
</ul>
<h3>Tests</h3>
<table width="409">
<tbody>
<tr>
<td width="110">
<p><strong>Input</strong></p>
</td>
<td width="175">
<p><strong>Program Output (Wrong)</strong></p>
</td>
<td width="124">
<p><strong>Expected Output</strong></p>
</td>
</tr>
<tr>
<td width="110">
<p>5</p>
<p>3 0 9 333 11</p>
<p>add 2 2</p>
<p>subtract 1 1</p>
<p>multiply 3 3</p>
<p>rshift</p>
<p>stop</p>
</td>
<td width="175">
<p>3 0 9 333 11</p>
<p>3 0 9 333 11</p>
</td>
<td width="124">
<p>3 <strong>2</strong> 9 333 11</p>
<p>2 2 9 333 11</p>
<p>2 2 <strong>27</strong> 333 11</p>
<p>11 2 2 27 333</p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>