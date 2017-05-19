<h1>Lab: Methods and Debugging</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/304/Methods-and-Debugging-Lab">https://judge.softuni.bg/Contests/304/Methods-and-Debugging-Lab</a>.</p>
<h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Declaring and Invoking Methods</h1>
<h2>1.&nbsp;&nbsp; Blank Receipt</h2>
<p>Create a method that prints a blank cash receipt. The method should invoke three other methods: one for printing the header, one for the body and one for the footer of the receipt.</p>
<table width="680">
<tbody>
<tr>
<td width="340">
<p>The header should contain the following text:</p>
</td>
<td width="340">
<p>CASH RECEIPT</p>
<p>------------------------------</p>
</td>
</tr>
<tr>
<td width="340">
<p>The body should contain the following text:</p>
</td>
<td width="340">
<p>Charged to____________________</p>
<p>Received by___________________</p>
</td>
</tr>
<tr>
<td width="340">
<p>And the text for the footer:</p>
</td>
<td width="340">
<p>------------------------------</p>
<p>&copy; SoftUni</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="334">
<tbody>
<tr>
<td width="334">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="334">
<p>CASH RECEIPT</p>
<p>------------------------------</p>
<p>Charged to____________________</p>
<p>Received by___________________</p>
<p>------------------------------</p>
<p>&copy; SoftUni</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>First create a method with no parameters for printing the header starting with <strong>static void</strong>. Give it a <strong>meaningful name</strong> like "PrintReceiptHeader" and write the code that it will execute:</li>
<li>Do the same for printing the receipt body and footer.</li>
<li>Create a <strong>method that will call all three methods</strong> in the necessary order. Again, give it a <strong>meaningful and descriptive name</strong> like "PrintReceipt" and write the code:</li>
<li>For printing <strong>"&copy;" </strong>use Unicode <strong>"\u00A9"</strong></li>
<li><strong>Call </strong>(invoke) the PrintReceipt method from the main.</li>
</ol>
<h2>2.&nbsp;&nbsp; Sign of Integer Number</h2>
<p>Create a method that prints the sign of an integer number n.</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>2</p>
</td>
<td width="340">
<p>The number 2 is positive.</p>
</td>
</tr>
<tr>
<td width="140">
<p>-5</p>
</td>
<td width="340">
<p>The number -5 is negative.</p>
</td>
</tr>
<tr>
<td width="140">
<p>0</p>
</td>
<td width="340">
<p>The number 0 is zero.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>Create a method with a <strong>descriptive name</strong> like "PrintSign" which should receive <strong>one parameter</strong> of type <strong>int</strong>.</li>
</ol>
<p>&nbsp;</p>
<ol start="2">
<li>Implement the body of the method by handling different cases:
<ol>
<li>If the number is greater than zero</li>
<li>If the number is less than zero</li>
<li>And if the number is equal to zero</li>
</ol>
</li>
<li>Call (invoke) the newly created method from the main.</li>
</ol>
<h2>3.&nbsp;&nbsp; Printing Triangle</h2>
<p>Create a method for printing triangles as shown below:</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>3</p>
</td>
<td width="340">
<p>1</p>
<p>1 2</p>
<p>1 2 3</p>
<p>1 2</p>
<p>1</p>
</td>
</tr>
<tr>
<td width="140">
<p>4</p>
</td>
<td width="340">
<p>1</p>
<p>1 2</p>
<p>1 2 3</p>
<p>1 2 3 4</p>
<p>1 2 3</p>
<p>1 2</p>
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>After you read the input</li>
<li>Start by creating a method <strong>for printing a single line</strong> from a <strong>given start</strong> to a <strong>given end</strong>. Choose a <strong>meaningful name</strong> for it, describing its purpose:</li>
<li>Think how you can use it to solve the problem</li>
<li>After you spent some time thinking, you should have come to the conclusion that you will need two loops</li>
<li>In the first loop you can print the first half of the triangle without the middle line:</li>
<li>Next, print the middle line:</li>
<li>Lastly, print the rest of the triangle:</li>
</ol>
<h2>4.&nbsp;&nbsp; Draw a Filled Square</h2>
<p>Draw at the console a filled square of size n like in the example:</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>4</p>
</td>
<td width="340">
<p>--------</p>
<p>-\/\/\/-</p>
<p>-\/\/\/-</p>
<p>--------</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>Read the input</li>
<li>Create a method which will print the top and the bottom rows (they are the same). Don&rsquo;t forget to give it a descriptive name and to give it as a parameter some length
<ol>
<li>Instead of loop you can use the "new string" command which creates a new string consisting of a character repeated some given times:</li>
</ol>
</li>
<li>Create the method which will print the middle rows. Well, of course, you should probably name it "PrintMiddleRow"</li>
<li>Use the methods that you've just created to draw a square</li>
</ol>
<h1>&nbsp;&nbsp; II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Returning Values and Overloading</h1>
<h2>5.&nbsp;&nbsp; Calculate Triangle Area</h2>
<p>Create a method that calculates and <strong>returns</strong> the <a href="http://www.mathopenref.com/trianglearea.html">area</a> of a triangle by given base and height:</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>3</p>
<p>4</p>
</td>
<td width="340">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>After reading the input</li>
<li>Create a method, but this time <strong>instead</strong> of typing <strong>"static void"</strong> before its name, type <strong>"static double"</strong> as this will make it to <strong>return a value of type double</strong>:</li>
<li><strong>Invoke</strong> the method in the main and <strong>save the return value in a new variable</strong>:</li>
</ol>
<h2>6.&nbsp;&nbsp; Math Power</h2>
<p>Create a method that calculates and returns the value of a number raised to a given power:</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>2</p>
<p>8</p>
</td>
<td width="340">
<p>256</p>
</td>
</tr>
<tr>
<td width="140">
<p>3</p>
<p>4</p>
</td>
<td width="340">
<p>81</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>As usual, read the input</li>
<li>Create a method which will have two parameters - the number and the power, and will return a result of type double:</li>
<li>Print the result</li>
</ol>
<h2>7.&nbsp;&nbsp; Greater of Two Values</h2>
<p>You are given two values of the same type as input. The values can be of type int, char of string. Create a method GetMax() that returns the greater of the two values:</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>int</p>
<p>2</p>
<p>16</p>
</td>
<td width="340">
<p>16</p>
</td>
</tr>
<tr>
<td width="140">
<p>char</p>
<p>a</p>
<p>z</p>
</td>
<td width="340">
<p>z</p>
</td>
</tr>
<tr>
<td width="140">
<p>string</p>
<p>Ivan</p>
<p>Todor</p>
</td>
<td width="340">
<p>Todor</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>For this method you need to create three methods with the same name and different signatures</li>
<li>Create a method which will compare integers:</li>
<li>Create a second method with the same name which will compare characters. Follow the logic of the previous method:</li>
<li>Lastly you need to create a method to compare strings. This is a bit different as strings don't allow to be compared with the operators &gt; and &lt;</li>
</ol>
<p>You need to use the method "CompareTo()", which returns an integer value (greater than zero if the compared object is greater, less than zero if the compared object is lesser and zero if the two objects are equal.</p>
<ol start="5">
<li>The last step is to read the input, use appropriate variables and call the GetMax() from your Main():</li>
</ol>
<p>&nbsp;</p>
<h1>III.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Debugging and Program Flow</h1>
<h2>8.&nbsp;&nbsp; Multiply Evens by Odds</h2>
<p>Create a program that reads an <strong>integer number</strong> and <strong>multiplies the sum of all its even digits</strong> by <strong>the sum of all its odd digits</strong>:</p>
<h3>Examples</h3>
<table width="622">
<tbody>
<tr>
<td width="124">
<p><strong>Input</strong></p>
</td>
<td width="158">
<p><strong>Output</strong></p>
</td>
<td width="340">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="124">
<p>12345</p>
</td>
<td width="158">
<p>54</p>
</td>
<td width="340">
<p>12345 has <strong>2 even digits</strong> - 2 and 4. Even digits has <strong>sum of 6</strong>.</p>
<p>Also it has <strong>3 odd digits</strong> - 1, 3 and 5. Odd digits has <strong>sum of 9</strong>.</p>
<p><strong>Multiply 6 by 9</strong> and you get <strong>54</strong>.</p>
</td>
</tr>
<tr>
<td width="124">
<p>-12345</p>
</td>
<td width="158">
<p>54</p>
</td>
<td width="340">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>Create a method with a <strong>name describing its purpose</strong> (like GetMultipleOfEvensAndOdds). The method should have a <strong>single integer parameter</strong> and an<strong> integer return value</strong>. Also the method will call two other methods:</li>
<li>Create two other methods each of which will sum either even or odd digits</li>
<li>Implement the logic for summing odd digits:</li>
</ol>
<p>&nbsp;</p>
<ol start="4">
<li>Do the same for the method that will sum even digits</li>
<li>As you test your solution you may notice that it doesn't work for negative numbers. Following the program execution line by line, find and fix the bug (<strong>hint: you can use Math.Abs()</strong>)</li>
</ol>
<h2>9.&nbsp;&nbsp; Debug the Code: Holidays Between Two Dates</h2>
<p>You are assigned to <strong>find and fix the bugs</strong> in an existing piece of code, using the Visual Studio <strong>debugger</strong>. You should trace the program execution to find the lines of code that produce incorrect or unexpected results.</p>
<p>You are given a program (existing <strong>source code</strong>) that aims to <strong>count the non-working days between two dates</strong> given in format day.month.year (e.g. between <strong>1.05.2015</strong> and <strong>15.05.2015</strong> there are <strong>5</strong> non-working days &ndash; Saturday and Sunday).</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="542">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>1.05.2016</p>
<p>15.05.2016</p>
</td>
<td width="62">
<p>5</p>
</td>
<td width="542">
<p>There are 5 non-working days (Saturday / Sunday) in this period:<br /> 1-May-2016, 7-May-2016, 8-May-2016, 14-May-2016, 15-May-2016</p>
</td>
</tr>
<tr>
<td width="84">
<p>1.5.2016</p>
<p>2.5.2016</p>
</td>
<td width="62">
<p>1</p>
</td>
<td width="542">
<p>Only 1 non-working day in the specified period: 1.05.2016 (Sunday)</p>
</td>
</tr>
<tr>
<td width="84">
<p>15.5.2020</p>
<p>10.5.2020</p>
</td>
<td width="62">
<p>0</p>
</td>
<td width="542">
<p>The second date is before the first. No dates in the range.</p>
</td>
</tr>
<tr>
<td width="84">
<p>22.2.2020</p>
<p>1.3.2020</p>
</td>
<td width="62">
<p>4</p>
</td>
<td width="542">
<p>Two Saturdays and Sundays:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 22.02.2020 and 23.02.2020</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 29.02.2020 and 1.03.2020</p>
</td>
</tr>
</tbody>
</table>
<p>You can <strong>find the broken code</strong> in the judge system: <a href="http://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.Programming-Fundamentals-Methods-and-Debugging-Lab-Broken-Solutions.zip">Broken Code for Refactoring</a>. It looks as follows:</p>
<table width="693">
<tbody>
<tr>
<td width="693">
<p>HolidaysBetweenTwoDates.cs</p>
</td>
</tr>
<tr>
<td width="693">
<p>using System;</p>
<p>using System.Globalization;</p>
<p>&nbsp;</p>
<p>class HolidaysBetweenTwoDates</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; static void Main()</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var startDate = DateTime.ParseExact(Console.ReadLine(),</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "dd.m.yyyy", CultureInfo.InvariantCulture);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var endDate = DateTime.ParseExact(Console.ReadLine(),</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "dd.m.yyyy", CultureInfo.InvariantCulture);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var holidaysCount = 0;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for (var date = startDate; date &lt;= endDate; date.AddDays(1))</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; if (date.DayOfWeek == DayOfWeek.Saturday &amp;&amp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(holidaysCount);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>There are <strong>4</strong> <strong>mistakes</strong> in the code. You&rsquo;ve got to <strong>use the debugger</strong> to find them and fix them. After you do that, submit your <strong>fixed code in the judge contest</strong>: <a href="https://judge.softuni.bg/Contests/Practice/Index/304#8">https://judge.softuni.bg/Contests/Practice/Index/304#8</a>.</p>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Price Change Alert</h2>
<p>You are assigned to <strong>rework a given piece of code</strong> which is working <strong>without bugs</strong> but is <strong>not properly formatted</strong>.</p>
<p>The given program <strong>tracks stock prices </strong>and <strong>gives updates</strong> about the <strong>significance in each price change</strong>. Based on the significance, there are <strong>four kind of changes</strong>: no change at all (price is equal to the previous), minor (difference is below the significance threshold), price up and price down.</p>
<p>You can <strong>find the broken code</strong> here: <a href="http://softuni.bg/downloads/svn/soft-tech/Sep-2016/Programming-Fundamentals-Sep-2016/03.%20Programming-Fundamentals-Methods-Debugging-and-Troubleshooting-Code/03.Programming-Fundamentals-Methods-and-Debugging-Lab-Broken-Solutions.zip">Broken Code for Refactoring</a>.</p>
<h3>Input</h3>
<ul>
<li>On the first line you are given <strong>N</strong> - the number of prices</li>
<li>On the second line you are given the significance threshold</li>
<li>On the next N lines, you are given prices</li>
</ul>
<h3>Output</h3>
<ul>
<li>Don&rsquo;t print anything for the first price</li>
<li>If there is <strong>no difference</strong> from the previous price the output message is: "NO CHANGE: {current price}"</li>
<li>In case of <strong>minor change</strong>: "MINOR CHANGE: {last price} to {current price} ({difference}%)"</li>
<li>In case of <strong>major change</strong>: "PRICE UP: {last price} to {current price} ({difference}%)" or "PRICE DOWN: {last price} to {current price} ({difference}%)"</li>
</ul>
<p>The percentage should be rounded to the second digit after the decimal point.</p>
<h3>Examples</h3>
<table width="480">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>3</p>
<p>0.1</p>
<p>10</p>
<p>11</p>
<p>12</p>
</td>
<td width="340">
<p>PRICE UP: 10 to 11 (10.00%)</p>
<p>MINOR CHANGE: 11 to 12 (9.09%)</p>
</td>
</tr>
<tr>
<td width="140">
<p>3</p>
<p>0.1</p>
<p>10</p>
<p>10</p>
<p>12</p>
</td>
<td width="340">
<p>NO CHANGE: 10</p>
<p>PRICE UP: 10 to 12 (20.00%)</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>Download the source code and get familiar with it</li>
<li>Deal with poor code formatting - Remove unnecessary blank lines, indent the code properly</li>
<li>Fix method parameters naming</li>
<li>Give methods a proper name</li>
</ol>
<p>&nbsp;</p>