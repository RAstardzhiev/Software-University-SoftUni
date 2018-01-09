<h1>Lab: Control Flow Logic</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/288/">https://judge.softuni.bg/Contests/288/</a>.</p>
<h2>1.&nbsp;&nbsp; Multiply Numbers</h2>
<p>Write a JS function that calculates the product of two numbers.</p>
<p>The <strong>input</strong> comes as two number arguments.</p>
<p>The <strong>output</strong> should be the returned as a result of your function.</p>
<h3>Examples</h3>
<table width="553">
<tbody>
<tr>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>3</p>
<p>2</p>
</td>
<td width="151">
<p>6</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="113">
<p>23632.36</p>
<p>-12.3249</p>
</td>
<td width="151">
<p>-291266.473764</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Boxes and Bottles</h2>
<p>Write a JS function to calculate how many boxes will be needed to fit <strong>n</strong> bottles if each box fits <strong>k</strong> bottles.</p>
<p>The <strong>input</strong> comes as two number arguments. The first element is the number of bottles and the second is the capacity of a single box.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
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
<p>20</p>
<p>5</p>
</td>
<td width="62">
<p>4</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>15</p>
<p>7</p>
</td>
<td width="62">
<p>3</p>
</td>
<td width="51">
<p>5</p>
<p>10</p>
</td>
<td width="62">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Leap Year</h2>
<p>Write a JS function to check whether a year is leap. Leap years are either divisible by 4 but not by 100 or are divisible by 400.</p>
<p>The <strong>input</strong> comes as a single number argument.</p>
<p>The <strong>output</strong> should be printed to the console. Print yes if the year is leap and no otherwise.</p>
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
<p>1999</p>
</td>
<td width="62">
<p>no</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>2000</p>
</td>
<td width="62">
<p>yes</p>
</td>
<td width="51">
<p>1900</p>
</td>
<td width="62">
<p>no</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Circle Area</h2>
<p>Write a JS function that calculates circle area by given radius. Print the area as it is calculated and then print it rounded to two decimal places.</p>
<p>The <strong>input</strong> comes as a single number argument.</p>
<p>The <strong>output</strong> should be printed to the console on a new line for each result.</p>
<h3>Examples</h3>
<table width="265">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>5</p>
</td>
<td width="189">
<p>78.53981633974483</p>
<p>78.54</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Triangle Area</h2>
<p>Write a JS function that calculates a triangle&rsquo;s area by its 3 sides.</p>
<p>The <strong>input</strong> comes as three number arguments, representing one side of a triangle.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="265">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>2</p>
<p>3.5</p>
<p>4</p>
</td>
<td width="189">
<p>3.4994419198</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use <a href="https://en.wikipedia.org/wiki/Heron%27s_formula">Heron&rsquo;s formula</a> to obtain the result.</p>
<h2>6.&nbsp;&nbsp; Cone</h2>
<p>Write a JS function to calculate a cone&rsquo;s volume and surface area by given height and radius at the base.</p>
<p>The <strong>input</strong> comes as two number arguments. The first element is the cone&rsquo;s <strong>radius</strong> and the second is its <strong>height</strong>.</p>
<p>The <strong>output</strong> should be printed to the console on a new line for every result.</p>
<h3>Examples</h3>
<table width="553">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>3</p>
<p>5</p>
</td>
<td width="189">
<p>volume = 47.1239</p>
<p>area = 83.2298</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="76">
<p>3.3</p>
<p>7.8</p>
</td>
<td width="189">
<p>volume = 88.9511</p>
<p>area = 122.016</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can use this online tool to check your results: <a href="http://www.calculatorsoup.com/calculators/geometry-solids/cone.php">http://www.calculatorsoup.com/calculators/geometry-solids/cone.php</a></p>
<h2>7.&nbsp;&nbsp; Odd / Even</h2>
<p>Write a JS function to check if a number is <strong>odd</strong> or <strong>even</strong> or <strong>invalid </strong>(fractions are neither odd nor even).</p>
<p>The <strong>input</strong> comes as a single number argument.</p>
<p>The <strong>output</strong> should be printed to the console. Print odd for odd numbers, even for even number and invalid for numbers that contain decimal fractions.</p>
<h3>Examples</h3>
<table width="429">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
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
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
</td>
<td width="76">
<p>odd</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>8</p>
</td>
<td width="76">
<p>even</p>
</td>
<td width="51">
<p>1.5</p>
</td>
<td width="76">
<p>invalid</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Fruit or Vegetable</h2>
<p>Write a JS function to print "<strong>fruit</strong>", "<strong>vegetable</strong>" or "<strong>unknown</strong>" depending on the input string.</p>
<ul>
<li>Fruits are: banana, apple, kiwi, cherry, lemon, grapes, peach</li>
<li>Vegetable are: tomato, cucumber, pepper, onion, garlic, parsley</li>
<li>All others are unknown</li>
</ul>
<p>The <strong>input</strong> comes as a single string argument, the name of the fruit.</p>
<p>The <strong>output</strong> should be printed to the console.</p>
<h3>Examples</h3>
<table width="672">
<tbody>
<tr>
<td width="94">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="94">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="94">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="94">
<p>banana</p>
</td>
<td width="113">
<p>fruit</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="94">
<p>cucumber</p>
</td>
<td width="113">
<p>vegetable</p>
</td>
<td width="94">
<p>pizza</p>
</td>
<td width="113">
<p>unknown</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Colorful Numbers</h2>
<p>Write a JS function to print the numbers from 1 to <strong>n</strong>. Return a string holding HTML list with the odd lines in blue and even lines in green. See the example for more information.</p>
<p>The <strong>input</strong> comes as a single number argument <strong>n</strong>.</p>
<p>The <strong>output</strong> should be returned as a result of your function in the form of a string.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="454">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>10</p>
</td>
<td width="454">
<p>&lt;ul&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:green'&gt;1&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:blue'&gt;2&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:green'&gt;3&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:blue'&gt;4&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:green'&gt;5&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:blue'&gt;6&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:green'&gt;7&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:blue'&gt;8&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:green'&gt;9&lt;/span&gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&lt;span style='color:blue'&gt;10&lt;/span&gt;&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Chess Board</h2>
<p>Write a JS function to print a chessboard of size <strong>n X n</strong>. See the example for more information.</p>
<p>The <strong>input</strong> comes as a single number argument <strong>n</strong>.</p>
<p>The <strong>output</strong> should be returned as a result of your function in the form of a string.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="454">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>3</p>
</td>
<td width="454">
<p>&lt;div class="chessboard"&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="black"&gt;&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="white"&gt;&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="black"&gt;&lt;/span&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="white"&gt;&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="black"&gt;&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="white"&gt;&lt;/span&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="black"&gt;&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="white"&gt;&lt;/span&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;span class="black"&gt;&lt;/span&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/div&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Binary Logarithm</h2>
<p>Write a JS function that prints the <strong>binary logarithm</strong>&nbsp;(<strong><em>log<sub>2</sub> x</em></strong>) for each number in the input.</p>
<p>The <strong>input</strong> comes as an array of number elements.</p>
<p>The <strong>output</strong> should be printed to the console, on a new line for each number.</p>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prime Number Checker</h2>
<p>Write a JS function to check if a number is prime (only wholly divisible by itself and one).</p>
<p>The <strong>input</strong> comes as a single number argument.</p>
<p>The <strong>output</strong> should be the return value of your function. Return true for prime number and false otherwise.</p>
<h3>Examples</h3>
<table width="429">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
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
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>7</p>
</td>
<td width="76">
<p>true</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="51">
<p>8</p>
</td>
<td width="76">
<p>false</p>
</td>
<td width="51">
<p>81</p>
</td>
<td width="76">
<p>false</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>