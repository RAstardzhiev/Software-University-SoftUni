<h1>Exercises: Data Types, Expressions, Statements</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni Judge system at <a href="https://judge.softuni.bg/Contests/308">https://judge.softuni.bg/Contests/308</a>.</p>
<h2>1.&nbsp;&nbsp; Hello, JavaScript!</h2>
<p>Write a JS function that can receive a name as input and print a greeting to the console.</p>
<p>The <strong>input</strong> comes as a single string that is the name of the person.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>Pesho</p>
</td>
<td width="340">
<p>Hello, Pesho, I am JavaScript!</p>
</td>
</tr>
<tr>
<td width="189">
<p>Bill Gates</p>
</td>
<td width="340">
<p>Hello, Bill Gates, I am JavaScript!</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>We would get the name from a single string variable that would be passed to our method.</p>
<p>We need to concatenate three strings &ndash; the two static parts of our greeting and the name of the person in the middle. We can do this by simply adding the three strings with the addition operator. Since this is an operation which returns the concatenated string, we can directly perform this expression in a call to console.log(). Note the space at the end of the first string:</p>
<p>You should be ready to submit your solution to the <strong>judge system</strong>. Open the judge contest for this homework and submit your code:<a href="https://judge.softuni.bg/Contests/308"> https://judge.softuni.bg/Contests/308</a>. It should look like this:</p>
<p>The judge system should <strong>accept your solution</strong> as correct:</p>
<p>If you get an error, you can see what went wrong in the detailed report, using the highlighted button:<br /> &nbsp;</p>
<p>Here you can see what the system expected and what your program&rsquo;s result was. You can also see what the input for the test was:</p>
<p>Note you can only view detailed information for zero tests &ndash; they do not give you points, but are handy for finding typos and debugging some errors. Chances are, if you manage to get all zero tests to pass, you&rsquo;ll also have some competitive tests passing too.</p>
<h2>2.&nbsp;&nbsp; Area and Perimeter</h2>
<p>Write a JS function that calculates the area and perimeter of a rectangle by given two sides.</p>
<p>The <strong>input</strong> comes as 2 numbers that are the lengths of the 2 sides of the rectangle (sideA and sideB)</p>
<p>The <strong>output</strong> should be printed to the console on two lines.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>2 2</p>
</td>
<td width="340">
<p>4</p>
<p>8</p>
</td>
</tr>
<tr>
<td width="189">
<p>1 3</p>
</td>
<td width="340">
<p>3</p>
<p>8</p>
</td>
</tr>
<tr>
<td width="189">
<p>2.5 3.14</p>
</td>
<td width="340">
<p>7.85</p>
<p>11.28</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>The multiplication operator will automatically coerce the input variables to numbers, so we can directly find the area of the rectangle by multiplying the two input elements.</p>
<p>The remaining operations are straightforward arithmetic and finally printing the two results (area and perimeter) to the console.</p>
<h2>3.&nbsp;&nbsp; Distance over Time</h2>
<p>Two objects start from point <strong><em>A</em></strong> and travel in the same direction at constant speeds <strong><em>V<sub>1</sub></em></strong> and <strong><em>V<sub>2</sub></em></strong> for a period <strong><em>T</em></strong>. Write a JS function that calculates the distance between the two object at the end of the period.</p>
<p>The <strong>input</strong> comes as array of numbers. The first two elements are the speeds to the two objects in km/h and the third element is the time in seconds.</p>
<p>The <strong>output</strong> should be printed to the console. Calculate the distance in meters.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[0, 60, 3600]</p>
</td>
<td width="340">
<p>60000</p>
</td>
</tr>
<tr>
<td width="189">
<p>[11, 10, 120]</p>
</td>
<td width="340">
<p>33.33333333333337</p>
</td>
</tr>
<tr>
<td width="189">
<p>[5, -5, 40]</p>
</td>
<td width="340">
<p>111.11111111111111</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Speed, time and distance are related to each other with the following formula:</p>
<p>However, the incoming units need to be equalized first and after the calculation, a final conversion needs to be done to match the required output units. There are 3600 seconds in an hour and 1000 meters in a kilometer. We don&rsquo;t know which object covered a greater distance, so simply subtracting them from one another may result in a <strong>negative number</strong>. Distance however is absolute (always positive), so we need to get the absolute value of the operation, using the built-in Math.abs(number) functions:</p>
<h2>4.&nbsp;&nbsp; Distance in 3D</h2>
<p>Write a JS function that calculates the distance between the two points in 3D by given coordinates.</p>
<p>The <strong>input</strong> comes as an array of numbers. The first three elements are the x, y and z coordinates for the first point and the second set of arguments are the coordinates of the other point.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[1, 1, 0, 5, 4, 0]</p>
</td>
<td width="340">
<p>5</p>
</td>
</tr>
<tr>
<td width="189">
<p>[3.5, 0, 1, 0, 2, -1]</p>
</td>
<td width="340">
<p>4.5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can find the horizontal and vertical offset between two points by calculating the difference between their respective coordinates. Use Pythagoras&rsquo; theorem to find the distance.</p>
<h2>5.&nbsp;&nbsp; Grads to Degrees</h2>
<p>Land surveyors use grads (also known as gon, 400 grads in a full turn) in their documents. Grads are rather unwieldy though, so you need to write a JS function that converts from grads to degrees. In addition, your program needs to constrain the results within the range , so if you arrive at a value like -15&deg;, it needs to be converted to 345&deg; and 420&deg; becomes 60&deg;.</p>
<p>The <strong>input</strong> comes as single number.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>100</p>
</td>
<td width="76">
<p>90</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="76">
<p>400</p>
</td>
<td width="76">
<p>0</p>
</td>
<td width="76">
<p>850</p>
</td>
<td width="76">
<p>45</p>
</td>
<td width="76">
<p>-50</p>
</td>
<td width="76">
<p>315</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can use the remainder (modulo) operator to get a value that is cyclic &ndash; it returns the same result for all input values with offset equal to the second parameter. For instance, n % 10 will return 3 with values for <strong>n</strong> 3, 13, 23, 243, 1003 and so on.</p>
<h2>6.&nbsp;&nbsp; Compound Interest</h2>
<p>Write a JS function that calculates the total accumulated value for a monetary deposit by given principal sum, interest rate, compounding frequency and overall length.</p>
<p>The <strong>input</strong> comes as an array of numbers. The first value is the principal sum, the second is the interest rate in percent, the third is the compounding period in months and the final value is the total timespan, given in years.</p>
<p>The <strong>output</strong> should be printed to the console, with two decimal places.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>[1500, 4.3, 3, 6]</p>
</td>
<td width="113">
<p>1938.84</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>[100000, 5, 12, 25]</p>
</td>
<td width="113">
<p>338635.49</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>The formula for calculating compound interest is as follows:</p>
<p>where:</p>
<ul>
<li><strong><em>P</em></strong> is the principal sum</li>
<li><strong><em>i</em></strong> is the nominal interest rate</li>
<li><strong><em>n</em></strong> is the compounding frequency</li>
<li><strong><em>t</em></strong> is the overall length of time the interest is applied</li>
</ul>
<p>Note that at the beginning of the task you are given the compounding period, which is inversely related to the frequency. You need to express the frequency as how many times in a year the interest is compounded. For instance, a 3-month period means the interest will be updated 4 times in a year. Any percentages need to be expressed as a fraction.</p>
<h2>7.&nbsp;&nbsp; *Rounding</h2>
<p>Write a JS function that rounds numbers to specific precision.</p>
<p>The <strong>input</strong> comes as an array of two numbers. The first value is the number to be rounded and the second is the precision (significant decimal places). If a precision is passed, that is more than <strong>15</strong> it should automatically be reduced to <strong>15</strong>.</p>
<p>The <strong>output</strong> should be printed to the console. Do not print insignificant decimals.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>[3.1415926535897932384626433832795, 2]</p>
</td>
<td width="113">
<p>3.14</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>[10.5, 3]</p>
</td>
<td width="113">
<p>10.5</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Imperial Units</h2>
<p>Imperial units are confusing, but still in use in some backwards countries (Myanmar, Liberia and the United States are the only countries still using them). They are so confusing in fact, that native users struggle to convert between them. Write a JS function that converts from inches to feet and inches. There are 12 inches in a foot. See the example for formatting details.</p>
<p>The <strong>input</strong> comes as a single number.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="615">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>36</p>
</td>
<td width="113">
<p>3'-0"</p>
</td>
<td width="76">
<p>55</p>
</td>
<td width="113">
<p>4'-7"</p>
</td>
<td width="76">
<p>11</p>
</td>
<td width="113">
<p>0'-11"</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Now Playing</h2>
<p>Write a JS function that displays information about the currently playing musical track.</p>
<p>The <strong>input</strong> comes as an array of string elements. The first element is the name of the track, the second is the name of the artist performing and the third is the duration in minutes and seconds.</p>
<p>The <strong>output</strong> should be printed to the console in the following format:</p>
<p>Now Playing: {artist name} - {track name} [{duration}]</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="302">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="302">
<p>['Number One', 'Nelly', '4:09']</p>
</td>
<td width="378">
<p>Now Playing: Nelly &ndash; Number One [4:09]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Compose Tag</h2>
<p>Write a JS function that composes an HTML image tag.</p>
<p>The <strong>input</strong> comes as an array of string elements. The first element is the location of the file and the second is the alternate text.</p>
<p>The <strong>output</strong> should be printed to the console in the following format:</p>
<p>&lt;img src="{file location}" alt="{alternate text}"&gt;</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="302">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="302">
<p>['smiley.gif', 'Smiley Face']</p>
</td>
<td width="378">
<p>&lt;img src="smiley.gif" alt="Smiley Face"&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Binary to Decimal</h2>
<p>Write a JS function that reads an 8-bit binary number and converts it to a decimal.</p>
<p>The <strong>input</strong> comes as one string element, representing a binary number.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>00001001</p>
</td>
<td width="113">
<p>9</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>11110000</p>
</td>
<td width="113">
<p>240</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assign Properties</h2>
<p>Write a JS function that composes an object by given properties. There will be 3 sets of property-value pairs (a total of 6 elements). Assign each value to its respective property of an object and return the object as a result of the function.</p>
<p>The <strong>input</strong> comes as an array of string elements.</p>
<p>The <strong>output</strong> should be returned as a value.</p>
<h3>Examples</h3>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>['name', 'Pesho', 'age', '23', 'gender', 'male']</p>
</td>
</tr>
<tr>
<td width="567">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>{</p>
<p>&nbsp; name: 'Pesho',</p>
<p>&nbsp; age: '23',</p>
<p>&nbsp; gender: 'male'</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>['ssid', '90127461', 'status', 'admin', 'expires', '600']</p>
</td>
</tr>
<tr>
<td width="567">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>{</p>
<p>&nbsp; ssid: '90127461',</p>
<p>&nbsp; status: 'admin',</p>
<p>&nbsp; expires: '600'</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Last Month</h2>
<p>Write a JS function that receives a date as array of strings containing <strong>day, month</strong> and<strong> year</strong> in that order. Your task is to print the last day of previous month (the month <strong>BEFORE </strong>the given date). Check the examples to better understand the problem.</p>
<p>The <strong>input</strong> comes as an array of numbers.</p>
<p>The <strong>output</strong> should be a single number representing the <strong>last day</strong> of the previous month.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>[17, 3, 2002]</p>
</td>
<td width="113">
<p>28</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>[13, 12, 2004]</p>
</td>
<td width="113">
<p>30</p>
</td>
</tr>
</tbody>
</table>
<h1>Conditional Statements and Loops</h1>
<p>In this homework, you are supposed to <strong>write program logic</strong> using expressions, conditions and loops in JavaScript. You will practice working with arithmetic operators, <strong>expressions</strong> and calculations, using <strong>conditional statements</strong> (if, if-else, multiple if-else-if-else-&hellip; and switch-case) and working with <strong>loop statements</strong> (like for, while, do-while and for-of) and <strong>nested loops</strong>, combined with conditional statements and calculations.</p>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Biggest of 3 Numbers</h2>
<p>Write a JS function that finds the <strong>biggest of 3 numbers</strong>.</p>
<p>The <strong>input</strong> comes as array of 3 numbers.</p>
<p>The <strong>output</strong> is the biggest from the input numbers.</p>
<h3>Examples</h3>
<table width="664">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
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
<p>5</p>
<p>-2</p>
<p>7</p>
</td>
<td width="62">
<p>7</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>130</p>
<p>5</p>
<p>99</p>
</td>
<td width="62">
<p>130</p>
</td>
<td width="51">
<p>43</p>
<p>43.2</p>
<p>43.1</p>
</td>
<td width="62">
<p>43.2</p>
</td>
<td width="51">
<p>5</p>
<p>5</p>
<p>5</p>
</td>
<td width="62">
<p>5</p>
</td>
<td width="51">
<p>-10</p>
<p>-20</p>
<p>-30</p>
</td>
<td width="62">
<p>-10</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Read the input and assign each number to a variable:</p>
<p>You may use Math.max(num1, num2, num3) to find the biggest number. It will automatically convert strings to numbers, so parsing the input elements to number might not be obligatory. Your code might look like this:</p>
<p><strong>Test </strong>the above code<strong> locally</strong> by invoking the biggestNumber() function like this:</p>
<p><strong>Test </strong>the above code<strong> locally</strong> in your Web browser:</p>
<p>Finally, submit your code in the judge system: <a href="https://judge.softuni.bg/Contests/Practice/Index/300">https://judge.softuni.bg/Contests/Practice/Index/300</a>.</p>
<p>Note: the above code might be shortened like this:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>The above code takes the input as array of 3 string variables num1, num2 and num3. Then the function Math.max(&hellip;) converts its string arguments to numbers and returns the biggest of them.</p>
<p>You may shorten further your solution by making it an <strong>arrow function</strong> like the shown below:</p>
<p>The <strong>judge</strong> system will <strong>accept</strong> the above solution as correct.</p>
<p>In the judge you can also <strong>return the expected result</strong> instead of printing it at the console, so the following solution will also be accepted by the judge, as well:</p>
<p>The above code could be even further shortened like this:</p>
<p>The judge system will accept the above arrow function as correct solution, passing all the tests.</p>
<p>Enjoy!</p>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Point in Rectangle</h2>
<p>Write a JS function that takes as input 6 numbers x, y, xMin, xMax, yMin, yMax and prints whether the point {x, y} is <strong>inside</strong> the rectangle or <strong>outside</strong> of it. If the point is at the rectangle <strong>border</strong>, it is considered <strong>inside</strong>.</p>
<p>The <strong>input</strong> comes as array of numbers. Its holds the representations of x, y, xMin, xMax, yMin, yMax. All numbers will in the range [-1&nbsp;000 000 &hellip; 1 000&nbsp;000]. It is guaranteed that xMin &lt; xMax and yMin &lt; yMax.</p>
<p>The <strong>output</strong> is a single line holding &ldquo;<strong>inside</strong>&rdquo; or &ldquo;<strong>outside</strong>&rdquo;.</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="214">
<p><strong>Figure</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="72">
<p><strong>Output</strong></p>
</td>
<td width="217">
<p><strong>Figure</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>8</p>
<p>-1</p>
<p>2</p>
<p>12</p>
<p>-3</p>
<p>3</p>
</td>
<td width="64">
<p>inside</p>
</td>
<td width="214">&nbsp;</td>
<td width="52">
<p>12.5</p>
<p>-1</p>
<p>2</p>
<p>12</p>
<p>-3</p>
<p>3</p>
</td>
<td width="72">
<p>outside</p>
</td>
<td width="217">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>First write a JS function to <strong>read the input numbers</strong> x, y, xMin, xMax, yMin and yMax from the array of 6 numbers, passed as input parameter input. The numbers should be taken from the array elements input[0], input[1], &hellip; as follows:</p>
<p>The above code could be significantly shortened by using a JS language feature called &ldquo;<strong>destructuring assignment</strong>&rdquo; like this:</p>
<p>Next, write if-else statement to check whether the point {x, y} is inside the rectangle. A <strong>point is inside a rectangle</strong> if and only if both of the following conditions are fulfilled:</p>
<ul>
<li>its x coordinate is between xMin and xMax</li>
<li>its y coordinate is between yMin and yMax</li>
</ul>
<p>The code may look like this:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>Now <strong>test the function locally</strong> on your computer. Invoke the above function like this:</p>
<p>Note that the function takes its input as <strong>6 numbers</strong>. You may test your code in your IDE, in the console (with Node.js) or in your Web browser&rsquo;s JS console.</p>
<p>The screenshot below shows the above function, invoked in <strong>Chrome JavaScript Console</strong>:</p>
<p>The screenshot below shows the above code in the <strong>Node.js REPL console</strong>:</p>
<p>Now you are ready to submit your solution in the <strong>judge system</strong>. Open the judge contest for this homework and submit your code: <a href="https://judge.softuni.bg/Contests/Practice/Index/300">https://judge.softuni.bg/Contests/Practice/Index/300</a>. It should look like this:</p>
<p>The judge system should <strong>accept your solution</strong> as correct:</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Odd Numbers 1 to N</h2>
<p>Write a JS function that reads an integer <strong>n</strong> and prints all <strong>odd numbers</strong> from <strong>1</strong> to <strong>n</strong>.</p>
<p>The <strong>input</strong> comes as a single number <strong>n</strong>. The number <strong>n</strong> will be an integer in the range [1 &hellip; 100&nbsp;000].</p>
<p>The <strong>output</strong> should hold the expected odd numbers, each at a separate line.</p>
<h3>Examples</h3>
<table width="389">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
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
<p>5</p>
</td>
<td width="62">
<p>1</p>
<p>3</p>
<p>5</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>4</p>
</td>
<td width="62">
<p>1</p>
<p>3</p>
</td>
<td width="51">
<p>7</p>
</td>
<td width="62">
<p>1</p>
<p>3</p>
<p>5</p>
<p>7</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>First write a JS function to read the input number <strong>n</strong>.</p>
<p>Next, write a for-loop from 1 to n with <strong>step</strong> 2:</p>
<p>Finally, print the number i at each iteration of the for-loop. The entire function should look like this:</p>
<p>Now <strong>test the function locally</strong> on your computer. Invoke the above function like this:</p>
<p>You may test your code in the console (with Node.js) or in your Web browser&rsquo;s JS console.</p>
<p>The screenshot below shows the above function, invoked in <strong>Chrome JavaScript Console</strong>:</p>
<p>The screenshot below shows the above code in the <strong>Node.js REPL console</strong>:</p>
<p>Now you are ready to submit the problem in the <strong>judge system</strong>. Open the judge contest for this homework and submit your code: <a href="https://judge.softuni.bg/Contests/Practice/Index/300">https://judge.softuni.bg/Contests/Practice/Index/300</a>. It should look like this:</p>
<p>The judge system should <strong>accept your solution</strong> as correct:</p>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Triangle of Dollars</h2>
<p>Write a JS function that prints a triangle of n lines of &ldquo;$&rdquo; characters like shown in the examples.</p>
<p>The <strong>input</strong> comes as a single number n (0 &lt; n &lt; 100).</p>
<p>The <strong>output</strong> consists of n text lines like shown below.</p>
<h3>Examples</h3>
<table width="389">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
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
<p>3</p>
</td>
<td width="62">
<p>$</p>
<p>$$</p>
<p>$$$</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>2</p>
</td>
<td width="62">
<p>$</p>
<p>$$</p>
</td>
<td width="51">
<p>4</p>
</td>
<td width="62">
<p>$</p>
<p>$$</p>
<p>$$$</p>
<p>$$$$</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Variant 1: use <strong>nested loops</strong> and for each row collect the &lsquo;$&rsquo; characters in a string and then print it:</p>
<p>Variant 2: use a simple loop row = 1 &hellip; n and print row dollars this way:</p>
<p>Variant 3: you can print row dollars by <strong>repeating</strong> the '$' string row times:</p>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Movie Prices</h2>
<p>Movie ticket <strong>prices</strong> in a big retro-cinema depend on the <strong>movie title</strong> and on the <strong>day of week</strong> as shown below:</p>
<table width="636">
<tbody>
<tr>
<td width="122">
<p><strong><em>Movie Title</em></strong></p>
</td>
<td width="69">
<p><strong><em>Monday</em></strong></p>
</td>
<td width="69">
<p><strong><em>Tuesday</em></strong></p>
</td>
<td width="90">
<p><strong><em>Wednesday</em></strong></p>
</td>
<td width="75">
<p><strong><em>Thursday</em></strong></p>
</td>
<td width="73">
<p><strong><em>Friday</em></strong></p>
</td>
<td width="73">
<p><strong><em>Saturday</em></strong></p>
</td>
<td width="63">
<p><strong><em>Sunday</em></strong></p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>The Godfather</strong></p>
</td>
<td width="69">
<p>12</p>
</td>
<td width="69">
<p>10</p>
</td>
<td width="90">
<p>15</p>
</td>
<td width="75">
<p>12.50</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="73">
<p>25</p>
</td>
<td width="63">
<p>30</p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>Schindler's List</strong></p>
</td>
<td width="69">
<p>8.50</p>
</td>
<td width="69">
<p>8.50</p>
</td>
<td width="90">
<p>8.50</p>
</td>
<td width="75">
<p>8.50</p>
</td>
<td width="73">
<p>8.50</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="63">
<p>15</p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>Casablanca</strong></p>
</td>
<td width="69">
<p>8</p>
</td>
<td width="69">
<p>8</p>
</td>
<td width="90">
<p>8</p>
</td>
<td width="75">
<p>8</p>
</td>
<td width="73">
<p>8</p>
</td>
<td width="73">
<p>10</p>
</td>
<td width="63">
<p>10</p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>The Wizard of Oz</strong></p>
</td>
<td width="69">
<p>10</p>
</td>
<td width="69">
<p>10</p>
</td>
<td width="90">
<p>10</p>
</td>
<td width="75">
<p>10</p>
</td>
<td width="73">
<p>10</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="63">
<p>15</p>
</td>
</tr>
</tbody>
</table>
<p>Write a JS function that <strong>calculate the ticket price</strong> by movie title and day of week.</p>
<p>The <strong>input</strong> comes as array of 2 strings. The first string holds the <strong>movie title</strong>. The second string holds the <strong>day of week</strong>.</p>
<p>The <strong>output</strong> should hold the <strong>ticket price</strong> or &ldquo;<strong>error</strong>&rdquo; if the title or day of week is invalid.</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="107">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="87">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="107">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="62">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>The Godfather</p>
<p>Friday</p>
</td>
<td width="62">
<p>15</p>
</td>
<td width="87">
<p>casablanca</p>
<p>sunday</p>
</td>
<td width="62">
<p>10</p>
</td>
<td width="107">
<p>Schindler's LIST</p>
<p>monday</p>
</td>
<td width="62">
<p>8.50</p>
</td>
<td width="62">
<p>SoftUni</p>
<p>Nineday</p>
</td>
<td width="66">
<p>error</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Turn all input values to <strong>lowercase</strong> to avoid character casing mistakes.</li>
<li><strong>Check the movie title</strong> in if-else-if</li>
<li>For each movie title check the price in a switch-case.</li>
<li>Beware of <strong>invalid</strong> movie titles and invalid days of week. Show &ldquo;<strong>error</strong>&rdquo; in such cases.</li>
</ul>
<p>You may follow the <strong>code example</strong> below:</p>
<p>You may <strong>test your code</strong> locally like this:</p>
<h2>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quadratic Equation</h2>
<p>Write a JS function to <strong>solve a quadratic equation</strong> by given in standard form as its coefficients: <strong>a</strong>, <strong>b</strong>, <strong>c</strong>. You may learn more about quadratic equations here: <a href="https://www.mathsisfun.com/algebra/quadratic-equation.html">https://www.mathsisfun.com/algebra/quadratic-equation.html</a>.</p>
<p>The <strong>input</strong> comes as 3 numbers <strong>a</strong>, <strong>b</strong> and <strong>c</strong>. The value of a will be non-zero.</p>
<p>The <strong>output</strong> depends on the equation:</p>
<ul>
<li>It holds two numbers x<sub>1</sub> and x<sub>2</sub> if the equation has two different solutions (roots): x<sub>1</sub> and x<sub>2</sub>.
<ul>
<li>First print the smaller root, then the greater.</li>
</ul>
</li>
<li>It holds a single number x if the equation has only one solution (root): x.</li>
<li>It holds the text &ldquo;No&rdquo; if the equation has no solutions (no real roots).</li>
</ul>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="68">
<p><strong>Output</strong></p>
</td>
<td width="568">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>6</p>
<p>11</p>
<p>-35</p>
</td>
<td width="68">
<p>-3.5</p>
<p>1.66667</p>
<p>&nbsp;</p>
</td>
<td width="568">
<p>The equation is: 6<em>x</em><sup>2</sup>&nbsp;+&nbsp;11<em>x</em>&nbsp;- 35 = 0 &agrave; <em>a</em> = 6; <em>b</em> = 11; <em>c</em> = -35</p>
<p>The discriminant is: <em>d</em> = <em>b</em><sup>2</sup> - 4*<em>a</em>*<em>c</em> = 11*11 - 4*6*(-35) = 121 + 840 = 961</p>
<p>We have positive discriminant (<em>d</em> &gt; 0), so the equation has two real roots:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x<sub>1</sub> = (-<em>b</em> + &radic;<em>d</em>) / (2*<em>a</em>) = (-11 + 31) / 12 = 20/12 = 5/3 &asymp; 1.66667</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x<sub>2</sub> = (-<em>b</em> - &radic;<em>d</em>) / (2*<em>a</em>) = (-11 - 31) / 12 = -42/12 = -7/2 = -3.5</p>
<p>The output consists of two lines:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -3.5 (the smaller root at the first line)</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1.66667 (the bigger root at the second line)</p>
</td>
</tr>
<tr>
<td width="51">
<p>1</p>
<p>-12</p>
<p>36</p>
</td>
<td width="68">
<p>6</p>
</td>
<td width="568">
<p>The equation is: <em>x</em><sup>2</sup>&nbsp;-&nbsp;12<em>x</em>&nbsp;+ 36 = 0 &agrave; <em>a</em> = 1; <em>b</em> = -12; <em>c</em> = 36</p>
<p>The discriminant is: <em>d</em> = <em>b</em><sup>2</sup> - 4*<em>a</em>*<em>c</em> = -12*-12 - 4*1*36 = 144 - 144 = 0</p>
<p>We have zero discriminant (<em>d</em> = 0), so the equation has only one real root:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x = -<em>b</em> / (2*<em>a</em>) = 12 / 2 = 6</p>
<p>The output is only one line, holding the number 6.</p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
<p>2</p>
<p>1</p>
</td>
<td width="68">
<p>No</p>
</td>
<td width="568">
<p>The equation is: 5<em>x</em><sup>2</sup>&nbsp;-&nbsp;2<em>x</em>&nbsp;+ 1 = 0 &agrave; <em>a</em> = 5; <em>b</em> = -2; <em>c</em> = 1</p>
<p>The discriminant is: <em>d</em> = <em>b</em><sup>2</sup> - 4*<em>a</em>*<em>c</em> = -2*-2 - 4*5*1 = 4 - 20 = -16</p>
<p>We have negative discriminant (<em>d</em> &lt; 0), so the equation has no real roots.</p>
<p>The output is only one line, holding the text &ldquo;No&rdquo;.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Search for &ldquo;<strong><em>solving quadratic equation</em></strong>&rdquo; in Internet.</li>
<li>Use if-conditions and expressions to calculate the <strong>discriminant</strong> and the equation <strong>roots</strong> (if any).</li>
</ul>
<h2>20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Multiplication Table</h2>
<p>Write a JS function to print a <strong>math multiplication table</strong> of size n, formatted as <strong>HTML table</strong>.</p>
<p>The <strong>input</strong> comes as a single number n (0 &lt; n &lt; 100).</p>
<p>The <strong>output</strong> consists of n+3 text lines like shown below.</p>
<h3>Examples</h3>
<table width="594">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="529">
<p>5</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="529">
<p>&lt;table border="1"&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>x</strong>&lt;/th&gt;&lt;th&gt;<strong>1</strong>&lt;/th&gt;&lt;th&gt;<strong>2</strong>&lt;/th&gt;&lt;th&gt;<strong>3</strong>&lt;/th&gt;&lt;th&gt;<strong>4</strong>&lt;/th&gt;&lt;th&gt;<strong>5</strong>&lt;/th&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>1</strong>&lt;/th&gt;&lt;td&gt;<strong>1</strong>&lt;/td&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>2</strong>&lt;/th&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>3</strong>&lt;/th&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>9</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>4</strong>&lt;/th&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>16</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>5</strong>&lt;/th&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;td&gt;<strong>25</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Preview</strong></p>
</td>
<td width="529">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create a function multiplicationTable(n) { &hellip; }. It will return a table of size n.</li>
<li>First, print the &ldquo;&lt;table border='1'&gt;&rdquo; opening tag.</li>
<li>Using a simple loop, print the <strong>heading row</strong>.
<ul>
<li>It should hold &lt;tr&gt; + &ldquo;x&rdquo; + the numbers 1&hellip;n (all surrounded in &lt;td&gt;&lt;/td&gt;) + &lt;/tr&gt;.</li>
</ul>
</li>
<li>Print the <strong>next</strong> n <strong>lines</strong> using nested loops.
<ul>
<li>For each line start with &lt;tr&gt;, then append its elements in a loop (all surrounded in &lt;td&gt;&lt;/td&gt;) and finally append &lt;/tr&gt;.</li>
</ul>
</li>
<li>After the loops, at the end, print the &ldquo;&lt;/table&gt;&rdquo; closing tag.</li>
<li>You may visualize your code&rsquo;s output in the browser like this:</li>
</ul>
<h2>21.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Figure of 4 Squares</h2>
<p>Write a JS function to print a <strong>figure of 4 squares</strong> of size n like shown in the examples below.</p>
<p>The <strong>input</strong> is an integer number n in the range [2 &hellip; 200].</p>
<p>The <strong>output</strong> consists of n lines for <strong>odd </strong>n and n-1 lines for even n. Each line holds 2*n-1 characters (+ or | or <strong><em>space</em></strong>) as shown in the examples. The figure is fully symmetric (horizontally and vertically).</p>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>4</p>
</td>
<td width="76">
<p>+--+--+</p>
<p>+--+--+</p>
<p>+--+--+</p>
</td>
<td width="51">
<p>5</p>
</td>
<td width="92">
<p>+---+---+</p>
<p>|&nbsp;&nbsp; |&nbsp;&nbsp; |</p>
<p>+---+---+</p>
<p>|&nbsp;&nbsp; |&nbsp;&nbsp; |</p>
<p>+---+---+</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>6</p>
</td>
<td width="108">
<p>+----+----+</p>
<p>|&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp; |</p>
<p>+----+----+</p>
<p>|&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp; |</p>
<p>+----+----+</p>
</td>
<td width="51">
<p>7</p>
</td>
<td width="124">
<p>+-----+-----+</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>+-----+-----+</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>+-----+-----+</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use <strong>nested loops</strong> and if-statements. Try to figure out the <strong>logic of construction</strong> of the above figures.</li>
</ul>
<h2>22.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Monthly Calendar</h2>
<p>Note: this problem is for champions only!</p>
<p>Write a JS function calendar([day, month, year]) that returns a <strong>monthly calendar as HTML</strong> <strong>table</strong> (like in the examples below) by given <strong>day</strong>, <strong>month</strong> and <strong>year</strong>. Weeks start by &ldquo;<strong>Sun</strong>&rdquo; (Sunday) and end by &ldquo;<strong>Sat</strong>&rdquo; (Saturday).</p>
<p>The <strong>input</strong> comes as array of 3 numbers:</p>
<ul>
<li>day (1 &le; day &le; 31)</li>
<li>month (1 &le; month &le; 12)</li>
<li>year (1900 &le; year &le; 2100)</li>
</ul>
<p>The <strong>output</strong> should be an <strong>HTML table</strong>, holding the calendar rows and columns, like in the examples below. Display the <strong>weeks</strong> as table rows: &lt;tr&gt;&hellip;&lt;/tr&gt;. Display the <strong>days</strong> as table cells: &lt;td&gt;&hellip;&lt;/td&gt;. Display the days of the previous month with CSS class &ldquo;<strong>prev-month</strong>&rdquo;, the days of the next month with CSS class &ldquo;<strong>next-month</strong>&rdquo; and the current day with CSS class &ldquo;today&rdquo;. See the examples below.</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="630">
<p>24</p>
<p>12</p>
<p>2012</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="630">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;th&gt;<strong>Sun</strong>&lt;/th&gt;&lt;th&gt;<strong>Mon</strong>&lt;/th&gt;&lt;th&gt;<strong>Tue</strong>&lt;/th&gt;&lt;th&gt;<strong>Wed</strong>&lt;/th&gt;&lt;th&gt;<strong>Thu</strong>&lt;/th&gt;&lt;th&gt;<strong>Fri</strong>&lt;/th&gt;&lt;th&gt;<strong>Sat</strong>&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>25</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>26</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>27</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>28</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>29</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>30</strong>&lt;/td&gt;&lt;td&gt;<strong>1</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>7</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>9</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;td&gt;<strong>11</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>13</strong>&lt;/td&gt;&lt;td&gt;<strong>14</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>16</strong>&lt;/td&gt;&lt;td&gt;<strong>17</strong>&lt;/td&gt;&lt;td&gt;<strong>18</strong>&lt;/td&gt;&lt;td&gt;<strong>19</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;td&gt;<strong>21</strong>&lt;/td&gt;&lt;td&gt;<strong>22</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>23</strong>&lt;/td&gt;&lt;td class="<strong>today</strong>"&gt;<strong>24</strong>&lt;/td&gt;&lt;td&gt;<strong>25</strong>&lt;/td&gt;&lt;td&gt;<strong>26</strong>&lt;/td&gt;&lt;td&gt;<strong>27</strong>&lt;/td&gt;&lt;td&gt;<strong>28</strong>&lt;/td&gt;&lt;td&gt;<strong>29</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>30</strong>&lt;/td&gt;&lt;td&gt;<strong>31</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;1&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>2</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>3</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>4</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>5</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Preview</strong></p>
</td>
<td width="630">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="694">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="630">
<p>4</p>
<p>9</p>
<p>2016</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="630">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;th&gt;<strong>Sun</strong>&lt;/th&gt;&lt;th&gt;<strong>Mon</strong>&lt;/th&gt;&lt;th&gt;<strong>Tue</strong>&lt;/th&gt;&lt;th&gt;<strong>Wed</strong>&lt;/th&gt;&lt;th&gt;<strong>Thu</strong>&lt;/th&gt;&lt;th&gt;<strong>Fri</strong>&lt;/th&gt;&lt;th&gt;<strong>Sat</strong>&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>28</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>29</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>30</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>31</strong>&lt;/td&gt;&lt;td&gt;<strong>1</strong>&lt;/td&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td class="<strong>today</strong>"&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>7</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;td&gt;<strong>9</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>11</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>13</strong>&lt;/td&gt;&lt;td&gt;<strong>14</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;td&gt;<strong>16</strong>&lt;/td&gt;&lt;td&gt;<strong>17</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>18</strong>&lt;/td&gt;&lt;td&gt;<strong>19</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;td&gt;<strong>21</strong>&lt;/td&gt;&lt;td&gt;<strong>22</strong>&lt;/td&gt;&lt;td&gt;<strong>23</strong>&lt;/td&gt;&lt;td&gt;<strong>24</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>25</strong>&lt;/td&gt;&lt;td&gt;<strong>26</strong>&lt;/td&gt;&lt;td&gt;<strong>27</strong>&lt;/td&gt;&lt;td&gt;<strong>28</strong>&lt;/td&gt;&lt;td&gt;<strong>29</strong>&lt;/td&gt;&lt;td&gt;<strong>30</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>1</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Preview</strong></p>
</td>
<td width="630">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>HTML Skeleton</h3>
<p>To simplify your work, use the below HTML code and write the missing code in the calendar() function:</p>
<table width="664">
<tbody>
<tr>
<td width="51">
<p><strong>calendar.html</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>&lt;!DOCTYPE html&gt;<br /> &lt;<strong>html</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Monthly Calendar&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>prev-month</strong>, .<strong>next-month </strong>{ color: <strong>#CCC </strong>}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>today </strong>{ font-weight: <strong>bold</strong>; background: <strong>#DDD</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>title </strong>{ background: <strong>#AAAAFF</strong>; margin: 10<strong>px 0</strong>; padding:5<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>table </strong>{ border: 1<strong>px solid </strong><strong>#CCC</strong>;}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>td </strong>{ text-align: <strong>center</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#calendarCode </strong>{ width: 100%; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>function </strong><em>calendar</em>([day, month, year])<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<em>// </em><strong><em>TODO: return the HTML text holding the calendar table</em></strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> <br /> &lt;<strong>body</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; Day: &lt;<strong>input </strong>id=<strong>"day" </strong>type=<strong>"number" </strong>value=<strong>"4" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; Month: &lt;<strong>input </strong>id=<strong>"month" </strong>type=<strong>"number" </strong>value=<strong>"9" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; Year: &lt;<strong>input </strong>id=<strong>"year" </strong>type=<strong>"number" </strong>value=<strong>"2016" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong>type=<strong>"button" </strong>value=<strong>"Show"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>onclick=<strong>"</strong><strong>let </strong><strong><em>calendarHTML </em></strong>=<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>calendar</em>([<strong>document</strong>.getElementById(<strong>'day'</strong>).<strong>value</strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'month'</strong>).<strong>value</strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'year'</strong>).<strong>value</strong>]);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'calendar'</strong>).<strong>innerHTML </strong>= <strong><em>calendarHTML</em></strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'calendarCode'</strong>).<strong>innerText </strong>= <strong><em>calendarHTML</em></strong><strong>" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong>class=<strong>"title"</strong>&gt;Calendar:&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong>id=<strong>"calendar"</strong>&gt;Calendar will be shown here&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong>class=<strong>"title"</strong>&gt;HTML:&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>textarea </strong>rows=<strong>"12" </strong>id=<strong>"calendarCode"</strong>&gt;&lt;/<strong>textarea</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> <br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Submit in the <strong>judge system</strong> the JS code of your calendar() function only, without the above HTML code that visualizes the calendar in the Web browser.</p>
<h3>Screenshot</h3>
<p>This is how your calendar should look in Web browser, when the calendar() function is implemented correctly:</p>
<h3>Hints</h3>
<ul>
<li>Printing a calendar in JS without using an external library is not as simple as the
<h1>Exercises: Data Types, Expressions, Statements</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni Judge system at <a href="https://judge.softuni.bg/Contests/308">https://judge.softuni.bg/Contests/308</a>.</p>
<h2>1.&nbsp;&nbsp; Hello, JavaScript!</h2>
<p>Write a JS function that can receive a name as input and print a greeting to the console.</p>
<p>The <strong>input</strong> comes as a single string that is the name of the person.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>Pesho</p>
</td>
<td width="340">
<p>Hello, Pesho, I am JavaScript!</p>
</td>
</tr>
<tr>
<td width="189">
<p>Bill Gates</p>
</td>
<td width="340">
<p>Hello, Bill Gates, I am JavaScript!</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>We would get the name from a single string variable that would be passed to our method.</p>
<p>We need to concatenate three strings &ndash; the two static parts of our greeting and the name of the person in the middle. We can do this by simply adding the three strings with the addition operator. Since this is an operation which returns the concatenated string, we can directly perform this expression in a call to console.log(). Note the space at the end of the first string:</p>
<p>You should be ready to submit your solution to the <strong>judge system</strong>. Open the judge contest for this homework and submit your code:<a href="https://judge.softuni.bg/Contests/308"> https://judge.softuni.bg/Contests/308</a>. It should look like this:</p>
<p>The judge system should <strong>accept your solution</strong> as correct:</p>
<p>If you get an error, you can see what went wrong in the detailed report, using the highlighted button:<br /> &nbsp;</p>
<p>Here you can see what the system expected and what your program&rsquo;s result was. You can also see what the input for the test was:</p>
<p>Note you can only view detailed information for zero tests &ndash; they do not give you points, but are handy for finding typos and debugging some errors. Chances are, if you manage to get all zero tests to pass, you&rsquo;ll also have some competitive tests passing too.</p>
<h2>2.&nbsp;&nbsp; Area and Perimeter</h2>
<p>Write a JS function that calculates the area and perimeter of a rectangle by given two sides.</p>
<p>The <strong>input</strong> comes as 2 numbers that are the lengths of the 2 sides of the rectangle (sideA and sideB)</p>
<p>The <strong>output</strong> should be printed to the console on two lines.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>2 2</p>
</td>
<td width="340">
<p>4</p>
<p>8</p>
</td>
</tr>
<tr>
<td width="189">
<p>1 3</p>
</td>
<td width="340">
<p>3</p>
<p>8</p>
</td>
</tr>
<tr>
<td width="189">
<p>2.5 3.14</p>
</td>
<td width="340">
<p>7.85</p>
<p>11.28</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>The multiplication operator will automatically coerce the input variables to numbers, so we can directly find the area of the rectangle by multiplying the two input elements.</p>
<p>The remaining operations are straightforward arithmetic and finally printing the two results (area and perimeter) to the console.</p>
<h2>3.&nbsp;&nbsp; Distance over Time</h2>
<p>Two objects start from point <strong><em>A</em></strong> and travel in the same direction at constant speeds <strong><em>V<sub>1</sub></em></strong> and <strong><em>V<sub>2</sub></em></strong> for a period <strong><em>T</em></strong>. Write a JS function that calculates the distance between the two object at the end of the period.</p>
<p>The <strong>input</strong> comes as array of numbers. The first two elements are the speeds to the two objects in km/h and the third element is the time in seconds.</p>
<p>The <strong>output</strong> should be printed to the console. Calculate the distance in meters.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[0, 60, 3600]</p>
</td>
<td width="340">
<p>60000</p>
</td>
</tr>
<tr>
<td width="189">
<p>[11, 10, 120]</p>
</td>
<td width="340">
<p>33.33333333333337</p>
</td>
</tr>
<tr>
<td width="189">
<p>[5, -5, 40]</p>
</td>
<td width="340">
<p>111.11111111111111</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Speed, time and distance are related to each other with the following formula:</p>
<p>However, the incoming units need to be equalized first and after the calculation, a final conversion needs to be done to match the required output units. There are 3600 seconds in an hour and 1000 meters in a kilometer. We don&rsquo;t know which object covered a greater distance, so simply subtracting them from one another may result in a <strong>negative number</strong>. Distance however is absolute (always positive), so we need to get the absolute value of the operation, using the built-in Math.abs(number) functions:</p>
<h2>4.&nbsp;&nbsp; Distance in 3D</h2>
<p>Write a JS function that calculates the distance between the two points in 3D by given coordinates.</p>
<p>The <strong>input</strong> comes as an array of numbers. The first three elements are the x, y and z coordinates for the first point and the second set of arguments are the coordinates of the other point.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[1, 1, 0, 5, 4, 0]</p>
</td>
<td width="340">
<p>5</p>
</td>
</tr>
<tr>
<td width="189">
<p>[3.5, 0, 1, 0, 2, -1]</p>
</td>
<td width="340">
<p>4.5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can find the horizontal and vertical offset between two points by calculating the difference between their respective coordinates. Use Pythagoras&rsquo; theorem to find the distance.</p>
<h2>5.&nbsp;&nbsp; Grads to Degrees</h2>
<p>Land surveyors use grads (also known as gon, 400 grads in a full turn) in their documents. Grads are rather unwieldy though, so you need to write a JS function that converts from grads to degrees. In addition, your program needs to constrain the results within the range , so if you arrive at a value like -15&deg;, it needs to be converted to 345&deg; and 420&deg; becomes 60&deg;.</p>
<p>The <strong>input</strong> comes as single number.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>100</p>
</td>
<td width="76">
<p>90</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="76">
<p>400</p>
</td>
<td width="76">
<p>0</p>
</td>
<td width="76">
<p>850</p>
</td>
<td width="76">
<p>45</p>
</td>
<td width="76">
<p>-50</p>
</td>
<td width="76">
<p>315</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can use the remainder (modulo) operator to get a value that is cyclic &ndash; it returns the same result for all input values with offset equal to the second parameter. For instance, n % 10 will return 3 with values for <strong>n</strong> 3, 13, 23, 243, 1003 and so on.</p>
<h2>6.&nbsp;&nbsp; Compound Interest</h2>
<p>Write a JS function that calculates the total accumulated value for a monetary deposit by given principal sum, interest rate, compounding frequency and overall length.</p>
<p>The <strong>input</strong> comes as an array of numbers. The first value is the principal sum, the second is the interest rate in percent, the third is the compounding period in months and the final value is the total timespan, given in years.</p>
<p>The <strong>output</strong> should be printed to the console, with two decimal places.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>[1500, 4.3, 3, 6]</p>
</td>
<td width="113">
<p>1938.84</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>[100000, 5, 12, 25]</p>
</td>
<td width="113">
<p>338635.49</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>The formula for calculating compound interest is as follows:</p>
<p>where:</p>
<ul>
<li><strong><em>P</em></strong> is the principal sum</li>
<li><strong><em>i</em></strong> is the nominal interest rate</li>
<li><strong><em>n</em></strong> is the compounding frequency</li>
<li><strong><em>t</em></strong> is the overall length of time the interest is applied</li>
</ul>
<p>Note that at the beginning of the task you are given the compounding period, which is inversely related to the frequency. You need to express the frequency as how many times in a year the interest is compounded. For instance, a 3-month period means the interest will be updated 4 times in a year. Any percentages need to be expressed as a fraction.</p>
<h2>7.&nbsp;&nbsp; *Rounding</h2>
<p>Write a JS function that rounds numbers to specific precision.</p>
<p>The <strong>input</strong> comes as an array of two numbers. The first value is the number to be rounded and the second is the precision (significant decimal places). If a precision is passed, that is more than <strong>15</strong> it should automatically be reduced to <strong>15</strong>.</p>
<p>The <strong>output</strong> should be printed to the console. Do not print insignificant decimals.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>[3.1415926535897932384626433832795, 2]</p>
</td>
<td width="113">
<p>3.14</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>[10.5, 3]</p>
</td>
<td width="113">
<p>10.5</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Imperial Units</h2>
<p>Imperial units are confusing, but still in use in some backwards countries (Myanmar, Liberia and the United States are the only countries still using them). They are so confusing in fact, that native users struggle to convert between them. Write a JS function that converts from inches to feet and inches. There are 12 inches in a foot. See the example for formatting details.</p>
<p>The <strong>input</strong> comes as a single number.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="615">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>36</p>
</td>
<td width="113">
<p>3'-0"</p>
</td>
<td width="76">
<p>55</p>
</td>
<td width="113">
<p>4'-7"</p>
</td>
<td width="76">
<p>11</p>
</td>
<td width="113">
<p>0'-11"</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Now Playing</h2>
<p>Write a JS function that displays information about the currently playing musical track.</p>
<p>The <strong>input</strong> comes as an array of string elements. The first element is the name of the track, the second is the name of the artist performing and the third is the duration in minutes and seconds.</p>
<p>The <strong>output</strong> should be printed to the console in the following format:</p>
<p>Now Playing: {artist name} - {track name} [{duration}]</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="302">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="302">
<p>['Number One', 'Nelly', '4:09']</p>
</td>
<td width="378">
<p>Now Playing: Nelly &ndash; Number One [4:09]</p>
</td>
</tr>
</tbody>
</table>
<br />
<p>&nbsp;</p>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Compose Tag</h2>
<p>Write a JS function that composes an HTML image tag.</p>
<p>The <strong>input</strong> comes as an array of string elements. The first element is the location of the file and the second is the alternate text.</p>
<p>The <strong>output</strong> should be printed to the console in the following format:</p>
<p>&lt;img src="{file location}" alt="{alternate text}"&gt;</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="302">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="302">
<p>['smiley.gif', 'Smiley Face']</p>
</td>
<td width="378">
<p>&lt;img src="smiley.gif" alt="Smiley Face"&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Binary to Decimal</h2>
<p>Write a JS function that reads an 8-bit binary number and converts it to a decimal.</p>
<p>The <strong>input</strong> comes as one string element, representing a binary number.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>00001001</p>
</td>
<td width="113">
<p>9</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>11110000</p>
</td>
<td width="113">
<p>240</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assign Properties</h2>
<p>Write a JS function that composes an object by given properties. There will be 3 sets of property-value pairs (a total of 6 elements). Assign each value to its respective property of an object and return the object as a result of the function.</p>
<p>The <strong>input</strong> comes as an array of string elements.</p>
<p>The <strong>output</strong> should be returned as a value.</p>
<h3>Examples</h3>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>['name', 'Pesho', 'age', '23', 'gender', 'male']</p>
</td>
</tr>
<tr>
<td width="567">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>{</p>
<p>&nbsp; name: 'Pesho',</p>
<p>&nbsp; age: '23',</p>
<p>&nbsp; gender: 'male'</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<br />
<p>&nbsp;</p>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>['ssid', '90127461', 'status', 'admin', 'expires', '600']</p>
</td>
</tr>
<tr>
<td width="567">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>{</p>
<p>&nbsp; ssid: '90127461',</p>
<p>&nbsp; status: 'admin',</p>
<p>&nbsp; expires: '600'</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Last Month</h2>
<p>Write a JS function that receives a date as array of strings containing <strong>day, month</strong> and<strong> year</strong> in that order. Your task is to print the last day of previous month (the month <strong>BEFORE </strong>the given date). Check the examples to better understand the problem.</p>
<p>The <strong>input</strong> comes as an array of numbers.</p>
<p>The <strong>output</strong> should be a single number representing the <strong>last day</strong> of the previous month.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
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
<p>[17, 3, 2002]</p>
</td>
<td width="113">
<p>28</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="189">
<p>[13, 12, 2004]</p>
</td>
<td width="113">
<p>30</p>
</td>
</tr>
</tbody>
</table>
<h1>Conditional Statements and Loops</h1>
<p>In this homework, you are supposed to <strong>write program logic</strong> using expressions, conditions and loops in JavaScript. You will practice working with arithmetic operators, <strong>expressions</strong> and calculations, using <strong>conditional statements</strong> (if, if-else, multiple if-else-if-else-&hellip; and switch-case) and working with <strong>loop statements</strong> (like for, while, do-while and for-of) and <strong>nested loops</strong>, combined with conditional statements and calculations.</p>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Biggest of 3 Numbers</h2>
<p>Write a JS function that finds the <strong>biggest of 3 numbers</strong>.</p>
<p>The <strong>input</strong> comes as array of 3 numbers.</p>
<p>The <strong>output</strong> is the biggest from the input numbers.</p>
<h3>Examples</h3>
<table width="664">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
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
<p>5</p>
<p>-2</p>
<p>7</p>
</td>
<td width="62">
<p>7</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>130</p>
<p>5</p>
<p>99</p>
</td>
<td width="62">
<p>130</p>
</td>
<td width="51">
<p>43</p>
<p>43.2</p>
<p>43.1</p>
</td>
<td width="62">
<p>43.2</p>
</td>
<td width="51">
<p>5</p>
<p>5</p>
<p>5</p>
</td>
<td width="62">
<p>5</p>
</td>
<td width="51">
<p>-10</p>
<p>-20</p>
<p>-30</p>
</td>
<td width="62">
<p>-10</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Read the input and assign each number to a variable:</p>
<p>You may use Math.max(num1, num2, num3) to find the biggest number. It will automatically convert strings to numbers, so parsing the input elements to number might not be obligatory. Your code might look like this:</p>
<p><strong>Test </strong>the above code<strong> locally</strong> by invoking the biggestNumber() function like this:</p>
<p><strong>Test </strong>the above code<strong> locally</strong> in your Web browser:</p>
<p>Finally, submit your code in the judge system: <a href="https://judge.softuni.bg/Contests/Practice/Index/300">https://judge.softuni.bg/Contests/Practice/Index/300</a>.</p>
<p>Note: the above code might be shortened like this:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>The above code takes the input as array of 3 string variables num1, num2 and num3. Then the function Math.max(&hellip;) converts its string arguments to numbers and returns the biggest of them.</p>
<p>You may shorten further your solution by making it an <strong>arrow function</strong> like the shown below:</p>
<p>The <strong>judge</strong> system will <strong>accept</strong> the above solution as correct.</p>
<p>In the judge you can also <strong>return the expected result</strong> instead of printing it at the console, so the following solution will also be accepted by the judge, as well:</p>
<p>The above code could be even further shortened like this:</p>
<p>The judge system will accept the above arrow function as correct solution, passing all the tests.</p>
<p>Enjoy!</p>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Point in Rectangle</h2>
<p>Write a JS function that takes as input 6 numbers x, y, xMin, xMax, yMin, yMax and prints whether the point {x, y} is <strong>inside</strong> the rectangle or <strong>outside</strong> of it. If the point is at the rectangle <strong>border</strong>, it is considered <strong>inside</strong>.</p>
<p>The <strong>input</strong> comes as array of numbers. Its holds the representations of x, y, xMin, xMax, yMin, yMax. All numbers will in the range [-1&nbsp;000 000 &hellip; 1 000&nbsp;000]. It is guaranteed that xMin &lt; xMax and yMin &lt; yMax.</p>
<p>The <strong>output</strong> is a single line holding &ldquo;<strong>inside</strong>&rdquo; or &ldquo;<strong>outside</strong>&rdquo;.</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="214">
<p><strong>Figure</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="72">
<p><strong>Output</strong></p>
</td>
<td width="217">
<p><strong>Figure</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>8</p>
<p>-1</p>
<p>2</p>
<p>12</p>
<p>-3</p>
<p>3</p>
</td>
<td width="64">
<p>inside</p>
</td>
<td width="214">&nbsp;</td>
<td width="52">
<p>12.5</p>
<p>-1</p>
<p>2</p>
<p>12</p>
<p>-3</p>
<p>3</p>
</td>
<td width="72">
<p>outside</p>
</td>
<td width="217">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>First write a JS function to <strong>read the input numbers</strong> x, y, xMin, xMax, yMin and yMax from the array of 6 numbers, passed as input parameter input. The numbers should be taken from the array elements input[0], input[1], &hellip; as follows:</p>
<p>The above code could be significantly shortened by using a JS language feature called &ldquo;<strong>destructuring assignment</strong>&rdquo; like this:</p>
<p>Next, write if-else statement to check whether the point {x, y} is inside the rectangle. A <strong>point is inside a rectangle</strong> if and only if both of the following conditions are fulfilled:</p>
<ul>
<li>its x coordinate is between xMin and xMax</li>
<li>its y coordinate is between yMin and yMax</li>
</ul>
<p>The code may look like this:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>Now <strong>test the function locally</strong> on your computer. Invoke the above function like this:</p>
<p>Note that the function takes its input as <strong>6 numbers</strong>. You may test your code in your IDE, in the console (with Node.js) or in your Web browser&rsquo;s JS console.</p>
<p>The screenshot below shows the above function, invoked in <strong>Chrome JavaScript Console</strong>:</p>
<p>The screenshot below shows the above code in the <strong>Node.js REPL console</strong>:</p>
<p>Now you are ready to submit your solution in the <strong>judge system</strong>. Open the judge contest for this homework and submit your code: <a href="https://judge.softuni.bg/Contests/Practice/Index/300">https://judge.softuni.bg/Contests/Practice/Index/300</a>. It should look like this:</p>
<p>The judge system should <strong>accept your solution</strong> as correct:</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Odd Numbers 1 to N</h2>
<p>Write a JS function that reads an integer <strong>n</strong> and prints all <strong>odd numbers</strong> from <strong>1</strong> to <strong>n</strong>.</p>
<p>The <strong>input</strong> comes as a single number <strong>n</strong>. The number <strong>n</strong> will be an integer in the range [1 &hellip; 100&nbsp;000].</p>
<p>The <strong>output</strong> should hold the expected odd numbers, each at a separate line.</p>
<h3>Examples</h3>
<table width="389">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
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
<p>5</p>
</td>
<td width="62">
<p>1</p>
<p>3</p>
<p>5</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>4</p>
</td>
<td width="62">
<p>1</p>
<p>3</p>
</td>
<td width="51">
<p>7</p>
</td>
<td width="62">
<p>1</p>
<p>3</p>
<p>5</p>
<p>7</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>First write a JS function to read the input number <strong>n</strong>.</p>
<p>Next, write a for-loop from 1 to n with <strong>step</strong> 2:</p>
<p>Finally, print the number i at each iteration of the for-loop. The entire function should look like this:</p>
<p>Now <strong>test the function locally</strong> on your computer. Invoke the above function like this:</p>
<p>You may test your code in the console (with Node.js) or in your Web browser&rsquo;s JS console.</p>
<p>The screenshot below shows the above function, invoked in <strong>Chrome JavaScript Console</strong>:</p>
<p>The screenshot below shows the above code in the <strong>Node.js REPL console</strong>:</p>
<p>Now you are ready to submit the problem in the <strong>judge system</strong>. Open the judge contest for this homework and submit your code: <a href="https://judge.softuni.bg/Contests/Practice/Index/300">https://judge.softuni.bg/Contests/Practice/Index/300</a>. It should look like this:</p>
<p>The judge system should <strong>accept your solution</strong> as correct:</p>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Triangle of Dollars</h2>
<p>Write a JS function that prints a triangle of n lines of &ldquo;$&rdquo; characters like shown in the examples.</p>
<p>The <strong>input</strong> comes as a single number n (0 &lt; n &lt; 100).</p>
<p>The <strong>output</strong> consists of n text lines like shown below.</p>
<h3>Examples</h3>
<table width="389">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
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
<p>3</p>
</td>
<td width="62">
<p>$</p>
<p>$$</p>
<p>$$$</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>2</p>
</td>
<td width="62">
<p>$</p>
<p>$$</p>
</td>
<td width="51">
<p>4</p>
</td>
<td width="62">
<p>$</p>
<p>$$</p>
<p>$$$</p>
<p>$$$$</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Variant 1: use <strong>nested loops</strong> and for each row collect the &lsquo;$&rsquo; characters in a string and then print it:</p>
<p>Variant 2: use a simple loop row = 1 &hellip; n and print row dollars this way:</p>
<p>Variant 3: you can print row dollars by <strong>repeating</strong> the '$' string row times:</p>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Movie Prices</h2>
<p>Movie ticket <strong>prices</strong> in a big retro-cinema depend on the <strong>movie title</strong> and on the <strong>day of week</strong> as shown below:</p>
<table width="636">
<tbody>
<tr>
<td width="122">
<p><strong><em>Movie Title</em></strong></p>
</td>
<td width="69">
<p><strong><em>Monday</em></strong></p>
</td>
<td width="69">
<p><strong><em>Tuesday</em></strong></p>
</td>
<td width="90">
<p><strong><em>Wednesday</em></strong></p>
</td>
<td width="75">
<p><strong><em>Thursday</em></strong></p>
</td>
<td width="73">
<p><strong><em>Friday</em></strong></p>
</td>
<td width="73">
<p><strong><em>Saturday</em></strong></p>
</td>
<td width="63">
<p><strong><em>Sunday</em></strong></p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>The Godfather</strong></p>
</td>
<td width="69">
<p>12</p>
</td>
<td width="69">
<p>10</p>
</td>
<td width="90">
<p>15</p>
</td>
<td width="75">
<p>12.50</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="73">
<p>25</p>
</td>
<td width="63">
<p>30</p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>Schindler's List</strong></p>
</td>
<td width="69">
<p>8.50</p>
</td>
<td width="69">
<p>8.50</p>
</td>
<td width="90">
<p>8.50</p>
</td>
<td width="75">
<p>8.50</p>
</td>
<td width="73">
<p>8.50</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="63">
<p>15</p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>Casablanca</strong></p>
</td>
<td width="69">
<p>8</p>
</td>
<td width="69">
<p>8</p>
</td>
<td width="90">
<p>8</p>
</td>
<td width="75">
<p>8</p>
</td>
<td width="73">
<p>8</p>
</td>
<td width="73">
<p>10</p>
</td>
<td width="63">
<p>10</p>
</td>
</tr>
<tr>
<td width="122">
<p><strong>The Wizard of Oz</strong></p>
</td>
<td width="69">
<p>10</p>
</td>
<td width="69">
<p>10</p>
</td>
<td width="90">
<p>10</p>
</td>
<td width="75">
<p>10</p>
</td>
<td width="73">
<p>10</p>
</td>
<td width="73">
<p>15</p>
</td>
<td width="63">
<p>15</p>
</td>
</tr>
</tbody>
</table>
<p>Write a JS function that <strong>calculate the ticket price</strong> by movie title and day of week.</p>
<p>The <strong>input</strong> comes as array of 2 strings. The first string holds the <strong>movie title</strong>. The second string holds the <strong>day of week</strong>.</p>
<p>The <strong>output</strong> should hold the <strong>ticket price</strong> or &ldquo;<strong>error</strong>&rdquo; if the title or day of week is invalid.</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="107">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="87">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="107">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="62">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>The Godfather</p>
<p>Friday</p>
</td>
<td width="62">
<p>15</p>
</td>
<td width="87">
<p>casablanca</p>
<p>sunday</p>
</td>
<td width="62">
<p>10</p>
</td>
<td width="107">
<p>Schindler's LIST</p>
<p>monday</p>
</td>
<td width="62">
<p>8.50</p>
</td>
<td width="62">
<p>SoftUni</p>
<p>Nineday</p>
</td>
<td width="66">
<p>error</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Turn all input values to <strong>lowercase</strong> to avoid character casing mistakes.</li>
<li><strong>Check the movie title</strong> in if-else-if</li>
<li>For each movie title check the price in a switch-case.</li>
<li>Beware of <strong>invalid</strong> movie titles and invalid days of week. Show &ldquo;<strong>error</strong>&rdquo; in such cases.</li>
</ul>
<p>You may follow the <strong>code example</strong> below:</p>
<p>You may <strong>test your code</strong> locally like this:</p>
<h2>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quadratic Equation</h2>
<p>Write a JS function to <strong>solve a quadratic equation</strong> by given in standard form as its coefficients: <strong>a</strong>, <strong>b</strong>, <strong>c</strong>. You may learn more about quadratic equations here: <a href="https://www.mathsisfun.com/algebra/quadratic-equation.html">https://www.mathsisfun.com/algebra/quadratic-equation.html</a>.</p>
<p>The <strong>input</strong> comes as 3 numbers <strong>a</strong>, <strong>b</strong> and <strong>c</strong>. The value of a will be non-zero.</p>
<p>The <strong>output</strong> depends on the equation:</p>
<ul>
<li>It holds two numbers x<sub>1</sub> and x<sub>2</sub> if the equation has two different solutions (roots): x<sub>1</sub> and x<sub>2</sub>.
<ul>
<li>First print the smaller root, then the greater.</li>
</ul>
</li>
<li>It holds a single number x if the equation has only one solution (root): x.</li>
<li>It holds the text &ldquo;No&rdquo; if the equation has no solutions (no real roots).</li>
</ul>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="68">
<p><strong>Output</strong></p>
</td>
<td width="568">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>6</p>
<p>11</p>
<p>-35</p>
</td>
<td width="68">
<p>-3.5</p>
<p>1.66667</p>
<p>&nbsp;</p>
</td>
<td width="568">
<p>The equation is: 6<em>x</em><sup>2</sup>&nbsp;+&nbsp;11<em>x</em>&nbsp;- 35 = 0 &agrave; <em>a</em> = 6; <em>b</em> = 11; <em>c</em> = -35</p>
<p>The discriminant is: <em>d</em> = <em>b</em><sup>2</sup> - 4*<em>a</em>*<em>c</em> = 11*11 - 4*6*(-35) = 121 + 840 = 961</p>
<p>We have positive discriminant (<em>d</em> &gt; 0), so the equation has two real roots:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x<sub>1</sub> = (-<em>b</em> + &radic;<em>d</em>) / (2*<em>a</em>) = (-11 + 31) / 12 = 20/12 = 5/3 &asymp; 1.66667</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x<sub>2</sub> = (-<em>b</em> - &radic;<em>d</em>) / (2*<em>a</em>) = (-11 - 31) / 12 = -42/12 = -7/2 = -3.5</p>
<p>The output consists of two lines:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -3.5 (the smaller root at the first line)</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1.66667 (the bigger root at the second line)</p>
</td>
</tr>
<tr>
<td width="51">
<p>1</p>
<p>-12</p>
<p>36</p>
</td>
<td width="68">
<p>6</p>
</td>
<td width="568">
<p>The equation is: <em>x</em><sup>2</sup>&nbsp;-&nbsp;12<em>x</em>&nbsp;+ 36 = 0 &agrave; <em>a</em> = 1; <em>b</em> = -12; <em>c</em> = 36</p>
<p>The discriminant is: <em>d</em> = <em>b</em><sup>2</sup> - 4*<em>a</em>*<em>c</em> = -12*-12 - 4*1*36 = 144 - 144 = 0</p>
<p>We have zero discriminant (<em>d</em> = 0), so the equation has only one real root:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x = -<em>b</em> / (2*<em>a</em>) = 12 / 2 = 6</p>
<p>The output is only one line, holding the number 6.</p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
<p>2</p>
<p>1</p>
</td>
<td width="68">
<p>No</p>
</td>
<td width="568">
<p>The equation is: 5<em>x</em><sup>2</sup>&nbsp;-&nbsp;2<em>x</em>&nbsp;+ 1 = 0 &agrave; <em>a</em> = 5; <em>b</em> = -2; <em>c</em> = 1</p>
<p>The discriminant is: <em>d</em> = <em>b</em><sup>2</sup> - 4*<em>a</em>*<em>c</em> = -2*-2 - 4*5*1 = 4 - 20 = -16</p>
<p>We have negative discriminant (<em>d</em> &lt; 0), so the equation has no real roots.</p>
<p>The output is only one line, holding the text &ldquo;No&rdquo;.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Search for &ldquo;<strong><em>solving quadratic equation</em></strong>&rdquo; in Internet.</li>
<li>Use if-conditions and expressions to calculate the <strong>discriminant</strong> and the equation <strong>roots</strong> (if any).</li>
</ul>
<h2>20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Multiplication Table</h2>
<p>Write a JS function to print a <strong>math multiplication table</strong> of size n, formatted as <strong>HTML table</strong>.</p>
<p>The <strong>input</strong> comes as a single number n (0 &lt; n &lt; 100).</p>
<p>The <strong>output</strong> consists of n+3 text lines like shown below.</p>
<h3>Examples</h3>
<table width="594">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="529">
<p>5</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="529">
<p>&lt;table border="1"&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>x</strong>&lt;/th&gt;&lt;th&gt;<strong>1</strong>&lt;/th&gt;&lt;th&gt;<strong>2</strong>&lt;/th&gt;&lt;th&gt;<strong>3</strong>&lt;/th&gt;&lt;th&gt;<strong>4</strong>&lt;/th&gt;&lt;th&gt;<strong>5</strong>&lt;/th&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>1</strong>&lt;/th&gt;&lt;td&gt;<strong>1</strong>&lt;/td&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>2</strong>&lt;/th&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>3</strong>&lt;/th&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>9</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>4</strong>&lt;/th&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>16</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&nbsp; &lt;<strong>tr</strong>&gt;&lt;th&gt;<strong>5</strong>&lt;/th&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;td&gt;<strong>25</strong>&lt;/td&gt;&lt;/<strong>tr</strong>&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Preview</strong></p>
</td>
<td width="529">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create a function multiplicationTable(n) { &hellip; }. It will return a table of size n.</li>
<li>First, print the &ldquo;&lt;table border='1'&gt;&rdquo; opening tag.</li>
<li>Using a simple loop, print the <strong>heading row</strong>.
<ul>
<li>It should hold &lt;tr&gt; + &ldquo;x&rdquo; + the numbers 1&hellip;n (all surrounded in &lt;td&gt;&lt;/td&gt;) + &lt;/tr&gt;.</li>
</ul>
</li>
<li>Print the <strong>next</strong> n <strong>lines</strong> using nested loops.
<ul>
<li>For each line start with &lt;tr&gt;, then append its elements in a loop (all surrounded in &lt;td&gt;&lt;/td&gt;) and finally append &lt;/tr&gt;.</li>
</ul>
</li>
<li>After the loops, at the end, print the &ldquo;&lt;/table&gt;&rdquo; closing tag.</li>
<li>You may visualize your code&rsquo;s output in the browser like this:</li>
</ul>
<h2>21.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Figure of 4 Squares</h2>
<p>Write a JS function to print a <strong>figure of 4 squares</strong> of size n like shown in the examples below.</p>
<p>The <strong>input</strong> is an integer number n in the range [2 &hellip; 200].</p>
<p>The <strong>output</strong> consists of n lines for <strong>odd </strong>n and n-1 lines for even n. Each line holds 2*n-1 characters (+ or | or <strong><em>space</em></strong>) as shown in the examples. The figure is fully symmetric (horizontally and vertically).</p>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>4</p>
</td>
<td width="76">
<p>+--+--+</p>
<p>+--+--+</p>
<p>+--+--+</p>
</td>
<td width="51">
<p>5</p>
</td>
<td width="92">
<p>+---+---+</p>
<p>|&nbsp;&nbsp; |&nbsp;&nbsp; |</p>
<p>+---+---+</p>
<p>|&nbsp;&nbsp; |&nbsp;&nbsp; |</p>
<p>+---+---+</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>6</p>
</td>
<td width="108">
<p>+----+----+</p>
<p>|&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp; |</p>
<p>+----+----+</p>
<p>|&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp; |</p>
<p>+----+----+</p>
</td>
<td width="51">
<p>7</p>
</td>
<td width="124">
<p>+-----+-----+</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>+-----+-----+</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>|&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp;&nbsp;&nbsp; |</p>
<p>+-----+-----+</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use <strong>nested loops</strong> and if-statements. Try to figure out the <strong>logic of construction</strong> of the above figures.</li>
</ul>
<h2>22.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Monthly Calendar</h2>
<p>Note: this problem is for champions only!</p>
<p>Write a JS function calendar([day, month, year]) that returns a <strong>monthly calendar as HTML</strong> <strong>table</strong> (like in the examples below) by given <strong>day</strong>, <strong>month</strong> and <strong>year</strong>. Weeks start by &ldquo;<strong>Sun</strong>&rdquo; (Sunday) and end by &ldquo;<strong>Sat</strong>&rdquo; (Saturday).</p>
<p>The <strong>input</strong> comes as array of 3 numbers:</p>
<ul>
<li>day (1 &le; day &le; 31)</li>
<li>month (1 &le; month &le; 12)</li>
<li>year (1900 &le; year &le; 2100)</li>
</ul>
<p>The <strong>output</strong> should be an <strong>HTML table</strong>, holding the calendar rows and columns, like in the examples below. Display the <strong>weeks</strong> as table rows: &lt;tr&gt;&hellip;&lt;/tr&gt;. Display the <strong>days</strong> as table cells: &lt;td&gt;&hellip;&lt;/td&gt;. Display the days of the previous month with CSS class &ldquo;<strong>prev-month</strong>&rdquo;, the days of the next month with CSS class &ldquo;<strong>next-month</strong>&rdquo; and the current day with CSS class &ldquo;today&rdquo;. See the examples below.</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="630">
<p>24</p>
<p>12</p>
<p>2012</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="630">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;th&gt;<strong>Sun</strong>&lt;/th&gt;&lt;th&gt;<strong>Mon</strong>&lt;/th&gt;&lt;th&gt;<strong>Tue</strong>&lt;/th&gt;&lt;th&gt;<strong>Wed</strong>&lt;/th&gt;&lt;th&gt;<strong>Thu</strong>&lt;/th&gt;&lt;th&gt;<strong>Fri</strong>&lt;/th&gt;&lt;th&gt;<strong>Sat</strong>&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>25</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>26</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>27</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>28</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>29</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>30</strong>&lt;/td&gt;&lt;td&gt;<strong>1</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;td&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>7</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>9</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;td&gt;<strong>11</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>13</strong>&lt;/td&gt;&lt;td&gt;<strong>14</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>16</strong>&lt;/td&gt;&lt;td&gt;<strong>17</strong>&lt;/td&gt;&lt;td&gt;<strong>18</strong>&lt;/td&gt;&lt;td&gt;<strong>19</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;td&gt;<strong>21</strong>&lt;/td&gt;&lt;td&gt;<strong>22</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>23</strong>&lt;/td&gt;&lt;td class="<strong>today</strong>"&gt;<strong>24</strong>&lt;/td&gt;&lt;td&gt;<strong>25</strong>&lt;/td&gt;&lt;td&gt;<strong>26</strong>&lt;/td&gt;&lt;td&gt;<strong>27</strong>&lt;/td&gt;&lt;td&gt;<strong>28</strong>&lt;/td&gt;&lt;td&gt;<strong>29</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>30</strong>&lt;/td&gt;&lt;td&gt;<strong>31</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;1&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>2</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>3</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>4</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>5</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Preview</strong></p>
</td>
<td width="630">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="694">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="630">
<p>4</p>
<p>9</p>
<p>2016</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Output</strong></p>
</td>
<td width="630">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;th&gt;<strong>Sun</strong>&lt;/th&gt;&lt;th&gt;<strong>Mon</strong>&lt;/th&gt;&lt;th&gt;<strong>Tue</strong>&lt;/th&gt;&lt;th&gt;<strong>Wed</strong>&lt;/th&gt;&lt;th&gt;<strong>Thu</strong>&lt;/th&gt;&lt;th&gt;<strong>Fri</strong>&lt;/th&gt;&lt;th&gt;<strong>Sat</strong>&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>28</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>29</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>30</strong>&lt;/td&gt;&lt;td class="<strong>prev-month</strong>"&gt;<strong>31</strong>&lt;/td&gt;&lt;td&gt;<strong>1</strong>&lt;/td&gt;&lt;td&gt;<strong>2</strong>&lt;/td&gt;&lt;td&gt;<strong>3</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td class="<strong>today</strong>"&gt;<strong>4</strong>&lt;/td&gt;&lt;td&gt;<strong>5</strong>&lt;/td&gt;&lt;td&gt;<strong>6</strong>&lt;/td&gt;&lt;td&gt;<strong>7</strong>&lt;/td&gt;&lt;td&gt;<strong>8</strong>&lt;/td&gt;&lt;td&gt;<strong>9</strong>&lt;/td&gt;&lt;td&gt;<strong>10</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>11</strong>&lt;/td&gt;&lt;td&gt;<strong>12</strong>&lt;/td&gt;&lt;td&gt;<strong>13</strong>&lt;/td&gt;&lt;td&gt;<strong>14</strong>&lt;/td&gt;&lt;td&gt;<strong>15</strong>&lt;/td&gt;&lt;td&gt;<strong>16</strong>&lt;/td&gt;&lt;td&gt;<strong>17</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>18</strong>&lt;/td&gt;&lt;td&gt;<strong>19</strong>&lt;/td&gt;&lt;td&gt;<strong>20</strong>&lt;/td&gt;&lt;td&gt;<strong>21</strong>&lt;/td&gt;&lt;td&gt;<strong>22</strong>&lt;/td&gt;&lt;td&gt;<strong>23</strong>&lt;/td&gt;&lt;td&gt;<strong>24</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;<strong>25</strong>&lt;/td&gt;&lt;td&gt;<strong>26</strong>&lt;/td&gt;&lt;td&gt;<strong>27</strong>&lt;/td&gt;&lt;td&gt;<strong>28</strong>&lt;/td&gt;&lt;td&gt;<strong>29</strong>&lt;/td&gt;&lt;td&gt;<strong>30</strong>&lt;/td&gt;&lt;td class="<strong>next-month</strong>"&gt;<strong>1</strong>&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>Preview</strong></p>
</td>
<td width="630">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>HTML Skeleton</h3>
<p>To simplify your work, use the below HTML code and write the missing code in the calendar() function:</p>
<table width="664">
<tbody>
<tr>
<td width="51">
<p><strong>calendar.html</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>&lt;!DOCTYPE html&gt;<br /> &lt;<strong>html</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Monthly Calendar&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>prev-month</strong>, .<strong>next-month </strong>{ color: <strong>#CCC </strong>}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>today </strong>{ font-weight: <strong>bold</strong>; background: <strong>#DDD</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>title </strong>{ background: <strong>#AAAAFF</strong>; margin: 10<strong>px 0</strong>; padding:5<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>table </strong>{ border: 1<strong>px solid </strong><strong>#CCC</strong>;}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>td </strong>{ text-align: <strong>center</strong>; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#calendarCode </strong>{ width: 100%; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>function </strong><em>calendar</em>([day, month, year])<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<em>// </em><strong><em>TODO: return the HTML text holding the calendar table</em></strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> <br /> &lt;<strong>body</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; Day: &lt;<strong>input </strong>id=<strong>"day" </strong>type=<strong>"number" </strong>value=<strong>"4" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; Month: &lt;<strong>input </strong>id=<strong>"month" </strong>type=<strong>"number" </strong>value=<strong>"9" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; Year: &lt;<strong>input </strong>id=<strong>"year" </strong>type=<strong>"number" </strong>value=<strong>"2016" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong>type=<strong>"button" </strong>value=<strong>"Show"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>onclick=<strong>"</strong><strong>let </strong><strong><em>calendarHTML </em></strong>=<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>calendar</em>([<strong>document</strong>.getElementById(<strong>'day'</strong>).<strong>value</strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'month'</strong>).<strong>value</strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'year'</strong>).<strong>value</strong>]);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'calendar'</strong>).<strong>innerHTML </strong>= <strong><em>calendarHTML</em></strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>document</strong>.getElementById(<strong>'calendarCode'</strong>).<strong>innerText </strong>= <strong><em>calendarHTML</em></strong><strong>" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong>class=<strong>"title"</strong>&gt;Calendar:&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong>id=<strong>"calendar"</strong>&gt;Calendar will be shown here&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong>class=<strong>"title"</strong>&gt;HTML:&lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>textarea </strong>rows=<strong>"12" </strong>id=<strong>"calendarCode"</strong>&gt;&lt;/<strong>textarea</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> <br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Submit in the <strong>judge system</strong> the JS code of your calendar() function only, without the above HTML code that visualizes the calendar in the Web browser.</p>
<h3>Screenshot</h3>
<p>This is how your calendar should look in Web browser, when the calendar() function is implemented correctly:</p>
<h3>Hints</h3>
<ul>
<li>Printing a calendar in JS without using an external library is not as simple as the previous problems in this exercise! It may take a few hours or even more to implement it correctly.</li>
<li>Play with the class <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date"><strong>Date</strong></a> in JavaScript and make some calculations.</li>
<li>You may also search in Google, e.g. try &ldquo;JavaScript calendar code example&rdquo;.</li>
<li>Print the calendar table <strong>headings</strong> + days.</li>
<li>Print the days from the <strong>previous month</strong> (if any).
<ul>
<li>Find the day of week for the first day of the input date.</li>
<li>If it is not Sunday, days from the previous month exist.</li>
<li>Go back a few days in the previous month to find the closest Sunday (first week day).</li>
<li>Start from it and print the days until the end of the previous month.</li>
</ul>
</li>
<li>Print the days from the <strong>current month</strong>.
<ul>
<li>Print the days, one after another.</li>
<li>Create a new table row after the last week day (Saturday).</li>
</ul>
</li>
<li>Print the days from the <strong>next month</strong> (if any).
<ul>
<li>Stop when you reach Saturday (the last week day).</li>
</ul>
</li>
<li>You may start from this code template:</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
previous problems in this exercise! It may take a few hours or even more to implement it correctly.</li>
<li>Play with the class <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date"><strong>Date</strong></a> in JavaScript and make some calculations.</li>
<li>You may also search in Google, e.g. try &ldquo;JavaScript calendar code example&rdquo;.</li>
<li>Print the calendar table <strong>headings</strong> + days.</li>
<li>Print the days from the <strong>previous month</strong> (if any).
<ul>
<li>Find the day of week for the first day of the input date.</li>
<li>If it is not Sunday, days from the previous month exist.</li>
<li>Go back a few days in the previous month to find the closest Sunday (first week day).</li>
<li>Start from it and print the days until the end of the previous month.</li>
</ul>
</li>
<li>Print the days from the <strong>current month</strong>.
<ul>
<li>Print the days, one after another.</li>
<li>Create a new table row after the last week day (Saturday).</li>
</ul>
</li>
<li>Print the days from the <strong>next month</strong> (if any).
<ul>
<li>Stop when you reach Saturday (the last week day).</li>
</ul>
</li>
<li>You may start from this code template:</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>