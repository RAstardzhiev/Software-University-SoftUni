<h1>Exercises: Arrays, Matrices, Multi-Dimensional Arrays</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/313/">https://judge.softuni.bg/Contests/313/</a>.</p>
<h2>1.&nbsp;&nbsp; Print an Array with a given Delimiter</h2>
<p>Write a JS function that prints a given array.</p>
<p>The <strong>input</strong> comes as array of strings. The last element of the array is the delimiter.</p>
<p>The <strong>output</strong> is the same array, printed on the console, each element <strong>separated</strong> from the others by the <strong>given delimiter</strong>.</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="58">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="138">
<p><strong>Input</strong></p>
</td>
<td width="276">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>One</p>
<p>Two</p>
<p>Three</p>
<p>Four</p>
<p>Five</p>
<p>-</p>
</td>
<td width="198">
<p>One-Two-Three-Four-Five</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="138">
<p>How about no?</p>
<p>I</p>
<p>will</p>
<p>not</p>
<p>do</p>
<p>it!</p>
<p>_</p>
</td>
<td width="276">
<p>How about no?_I_will_not_do_it!</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Let&rsquo;s start by extracting the delimiter from the input array:</li>
<li>Now that we have the element, we need to delete it from the array, because we don&rsquo;t need it in the output. Thankfully, the Array in JavaScript has a <strong>built-in function</strong> for <strong>removing the last element</strong>, which is <strong>pop()</strong>.</li>
<li>And last but not least, let&rsquo;s print each element of the array, separated with the next one by the delimiter:</li>
<li>The result variable holds our final string. The if check in the loop is necessary so that we don&rsquo;t <strong>attach an</strong> <strong>unneeded delimiter</strong> somewhere in the result string.</li>
</ul>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; Print every N-th Element from an Array</h2>
<p>Write a JS function that prints every element of an array, on a given step.</p>
<p>The <strong>input</strong> comes as array of strings. The last element is <strong>N - the step</strong>.</p>
<p>The <strong>output</strong> is every element on the <strong>N-th</strong> step <strong>starting from the first one</strong>. If the step is &ldquo;3&rdquo;, you need to print the <strong>1-st</strong>, the <strong>4-th</strong>, the <strong>7-th</strong> &hellip; and so on, until you reach the end of the array. The elements must be printed each on a new line.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="102">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="120">
<p><strong>Input</strong></p>
</td>
<td width="114">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>5</p>
<p>20</p>
<p>31</p>
<p>4</p>
<p>20</p>
<p>2</p>
</td>
<td width="108">
<p>5</p>
<p>31</p>
<p>20</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="102">
<p>dsa</p>
<p>asd</p>
<p>test</p>
<p>tset</p>
<p>2</p>
<p>&nbsp;</p>
</td>
<td width="102">
<p>dsa</p>
<p>test</p>
</td>
<td width="120">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p>
<p>6</p>
</td>
<td width="114">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use what you&rsquo;ve seen from the <strong>previous problem</strong> to <strong>extract the last element</strong> of the array.</li>
<li>Create a step variable to hold the <strong>given step</strong> of the array. Then <strong>print all the elements</strong> with a for loop, <strong>incrementing</strong> the <strong>loop variable </strong>with the value of the step</li>
</ul>
<h2>3.&nbsp;&nbsp; *Add and Remove Elements from Array</h2>
<p>Write a JS function that <strong>adds</strong> and <strong>removes</strong> numbers <strong>to / from</strong> an array. You will receive a command which can either be &ldquo;add&rdquo; or &ldquo;remove&rdquo;.</p>
<p>The <strong>initial number</strong> is <strong>1</strong>. Each input command should <strong>increase that number</strong>, regardless of what it is.</p>
<p><br /> Upon receiving an &ldquo;add&rdquo; command you should add the current number to your array. <br /> Upon receiving the &ldquo;remove&rdquo; command you should remove the last entered number, currently existent in the array.</p>
<p>The <strong>input</strong> comes as array of strings. Each element holds a <strong>command</strong>.</p>
<p>The <strong>output</strong> is the array itself, with each element printed on a new line. In case of an empty array, just print &ldquo;Empty&rdquo;.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="102">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="120">
<p><strong>Input</strong></p>
</td>
<td width="114">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>add</p>
<p>add</p>
<p>add</p>
<p>add</p>
<p>&nbsp;</p>
</td>
<td width="108">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="102">
<p>add</p>
<p>add</p>
<p>remove</p>
<p>add</p>
<p>add</p>
</td>
<td width="102">
<p>1</p>
<p>4</p>
<p>5</p>
</td>
<td width="120">
<p>remove</p>
<p>remove</p>
<p>remove</p>
</td>
<td width="114">
<p>Empty</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Rotate Array</h2>
<p>Write a JS function that rotates an array. The array should be rotated to the right side, meaning that the last element should become the first, upon rotation.</p>
<p>The <strong>input</strong> comes as array of strings. The <strong>last element </strong>of the array is the amount of rotation you need to perform.</p>
<p>The <strong>output</strong> is the resulted array after the rotations. The elements should be printed on one line, separated by a <strong>single space</strong>.</p>
<h3>Examples</h3>
<table width="586">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>2</p>
</td>
<td width="108">
<p>3 4 1 2</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="102">
<p>Banana</p>
<p>Orange</p>
<p>Coconut</p>
<p>Apple</p>
<p>15</p>
</td>
<td width="246">
<p>Orange Coconut Apple Banana</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Check if there is a <strong>built-in function</strong> for inserting elements <strong>at the</strong> <strong>start </strong>of the array.</li>
</ul>
<h2>5.&nbsp;&nbsp; Extract an Non-decreasing Subsequence from an Array</h2>
<p>Write a JS function that extracts only those numbers that <strong>form a</strong> <strong>non-decreasing subsequence</strong>. In other words, you start from the <strong>first element</strong> and continue to <strong>the end</strong> of the <strong>given array of numbers</strong>. Any number which is <strong>LESS THAN </strong>the <strong>current biggest one</strong> is <strong>ignored</strong>, alternatively if it&rsquo;s equal or higher than the <strong>current biggest one</strong> you set it as the <strong>current biggest one</strong> and you continue to the next number.</p>
<p>The <strong>input</strong> comes as array of numbers.</p>
<p>The <strong>output</strong> is the processed array after the filtration, which should be a non-decreasing subsequence. Each element should be printed on a new line.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="102">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="120">
<p><strong>Input</strong></p>
</td>
<td width="114">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>1</p>
<p>3</p>
<p>8</p>
<p>4</p>
<p>10</p>
<p>12</p>
<p>3</p>
<p>2</p>
<p>24</p>
</td>
<td width="108">
<p>1</p>
<p>3</p>
<p>8</p>
<p>10</p>
<p>12</p>
<p>24</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="102">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
</td>
<td width="102">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
</td>
<td width="120">
<p>20</p>
<p>3</p>
<p>2</p>
<p>15</p>
<p>6</p>
<p>1</p>
</td>
<td width="114">
<p>20</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>The <strong>filter()</strong> built-in function might help you a lot with this problem.</li>
</ul>
<h2>6.&nbsp;&nbsp; Sort an Array by 2 Criteria</h2>
<p>Write a JS function that orders a <strong>given array of strings</strong>, by <strong>length</strong> in <strong>ascending order</strong> as <strong>primary criteria</strong>, and by <strong>alphabetical value </strong>in<strong> ascending order </strong>as <strong>second criteria</strong>. The comparison should be <strong>case-insensitive</strong>.</p>
<p>The <strong>input</strong> comes as array of strings.</p>
<p>The <strong>output</strong> is the ordered array of strings.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="102">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="120">
<p><strong>Input</strong></p>
</td>
<td width="114">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>alpha</p>
<p>beta</p>
<p>gamma</p>
</td>
<td width="108">
<p>beta</p>
<p>alpha</p>
<p>gamma</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="102">
<p>Isacc</p>
<p>Theodor</p>
<p>Jack</p>
<p>Harrison</p>
<p>George</p>
<p>&nbsp;</p>
</td>
<td width="102">
<p>Jack</p>
<p>Isacc</p>
<p>George</p>
<p>Theodor</p>
<p>Harrison</p>
<p>&nbsp;</p>
</td>
<td width="120">
<p>test</p>
<p>Deny</p>
<p>omen</p>
<p>Default</p>
</td>
<td width="114">
<p>Deny</p>
<p>omen</p>
<p>test</p>
<p>Default</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>An array can be sorted by passing a comparing function to the <strong>sort()</strong> function.</li>
<li>Creating a comparing function by 2 criteria can be achieved by first comparing by the <strong>main criteria</strong>, if the 2 items are different (the result of the compare is not 0) - return the result as the result of the comparing function. If the two items are the same by the <strong>main criteria</strong> (the result of the compare is 0), we need to compare by the <strong>second criteria</strong> and the result of that comparison is the result of the comparing function.</li>
<li>You can check more about <strong>sort()</strong> here - <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/sort%20">https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/sort</a></li>
</ul>
<h1>Multidimensional Arrays</h1>
<p>We will mainly work with 2-dimensional arrays. The concept is as simple as working with a simple 1-dimensional array. It is just an array of arrays.</p>
<h2>7.&nbsp;&nbsp; Magic Matrices</h2>
<p>Write a JS function that checks if a given matrix of numbers is magical. A matrix is magical if the <strong>sums of the cells</strong> of <strong>every row</strong> and <strong>every column</strong> are <strong>equal</strong>.</p>
<p>The <strong>input</strong> comes as an array of arrays, containing numbers (number 2D matrix). The input numbers will <strong>always be positive</strong>.</p>
<p>The <strong>output</strong> is a Boolean result indicating whether the matrix is magical or not.</p>
<h3>Examples</h3>
<table width="628">
<tbody>
<tr>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="18">
<p><strong>&nbsp;</strong></p>
</td>
<td width="132">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>[[4, 5, 6],</p>
<p>&nbsp;[6, 5, 4],</p>
<p>&nbsp;[5, 5, 5]]</p>
</td>
<td width="76">
<p>true</p>
</td>
<td width="18">
<p>&nbsp;</p>
</td>
<td width="132">
<p>[[11, 32, 45],</p>
<p>&nbsp;[21, 0, 1],</p>
<p>&nbsp;[21, 1, 1]]</p>
</td>
<td width="76">
<p>false</p>
<p>&nbsp;</p>
</td>
<td width="113">
<p>[[1, 0, 0],</p>
<p>&nbsp;[0, 0, 1],</p>
<p>&nbsp;[0, 1, 0]]</p>
</td>
<td width="76">
<p>true</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; *Spiral Matrix</h2>
<p>Write a JS function that generates a <strong>Spirally-filled</strong> matrix with numbers, with given dimensions.</p>
<p>The <strong>input</strong> comes as 2 numbers that represent the <strong>dimension of the matrix</strong>.</p>
<p>The <strong>output</strong> is the matrix filled spirally starting from <strong>1</strong>. You need to print <strong>every row on a new line</strong>, with the cells <strong>separated by a space</strong>. Check the examples below.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="192">
<p><strong>Output</strong></p>
</td>
<td width="126">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="174">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>5, 5</p>
</td>
<td width="192">
<p>1 2 3 4 5</p>
<p>16 17 18 19 6</p>
<p>15 24 25 20 7</p>
<p>14 23 22 21 8</p>
<p>13 12 11 10 9</p>
</td>
<td width="126">
<p>&nbsp;</p>
</td>
<td width="102">
<p>3, 3</p>
</td>
<td width="174">
<p>1 2 3</p>
<p>8 9 4</p>
<p>7 6 5</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; *Diagonal Attack</h2>
<p>Write a JS function that reads a given matrix of numbers, and checks if both <strong>main diagonals have equal sum</strong>. If they do, set every element that is <strong>NOT</strong> part of <strong>the main diagonals</strong> to that sum, alternatively just print the matrix unchanged.</p>
<p>The <strong>input</strong> comes as array of strings. Each element represents a <strong>string of numbers</strong>, with <strong>spaces</strong> between them. Parse it into a <strong>matrix of numbers</strong>, so you can work with it.</p>
<p>The <strong>output</strong> is either the new matrix, with all cells not belonging to a main diagonal changed to the diagonal sum or the original matrix, if the two diagonals have different sums. You need to print <strong>every row on a new line</strong>, with cells <strong>separated by a space</strong>. Check the examples below.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="154">
<p><strong>Input</strong></p>
</td>
<td width="156">
<p><strong>Output</strong></p>
</td>
<td width="114">
<p><strong>&nbsp;</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="174">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="154">
<p>['5 3 12 3 1',</p>
<p>'11 4 23 2 5',</p>
<p>'101 12 3 21 10',</p>
<p>'1 4 5 2 2',</p>
<p>'5 22 33 11 1']</p>
</td>
<td width="156">
<p>5 15 15 15 1</p>
<p>15 4 15 2 15</p>
<p>15 15 3 15 15</p>
<p>15 4 15 2 15</p>
<p>5 15 15 15 1</p>
</td>
<td width="114">
<p>&nbsp;</p>
</td>
<td width="102">
<p>['1 1 1',</p>
<p>'1 1 1'</p>
<p>'1 1 0']</p>
<p>&nbsp;</p>
</td>
<td width="174">
<p>1 1 1</p>
<p>1 1 1</p>
<p>1 1 0</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; **Orbit</h2>
<p>You will be given an empty rectangular space of cells. Then you will be given the position of a star. You need to build the orbits around it.</p>
<p>You will be given a coordinate of a cell, which will <strong>always be</strong> <strong>inside the matrix</strong>, on which you will put the value &ndash; 1. Then you must set the values of the cells <strong>directly surrounding that cell</strong>, including the <strong>diagonals</strong>, <strong>to </strong>2. After which you must set the values of the next surrounding cells to 3 and so on. Check the pictures for more info.</p>
<p>For example we are given a matrix which has 5 rows and 5 columns and the star is at coordinates &ndash; 0, 0. Then the following should happen:</p>
<table>
<tbody>
<tr>
<td width="28">
<p>1</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>1</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>1</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>5</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>5</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>5</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>4</p>
</td>
<td width="28">
<p>5</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>5</p>
</td>
<td width="28">
<p>5</p>
</td>
<td width="28">
<p>5</p>
</td>
<td width="28">
<p>5</p>
</td>
<td width="28">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<p><br /> &nbsp;&nbsp;</p>
<p>If the coordinates of the star are somewhere in the middle of the matrix for example &ndash; 2, 2, then it should look like this:</p>
<table>
<tbody>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>3</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>1</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>1</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>1</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>3</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>2</p>
</td>
<td width="28">
<p>3</p>
</td>
</tr>
<tr>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>&nbsp;</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
<td width="28">
<p>3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>The <strong>input</strong> comes as an array of 4 numbers <strong>[width, height, x, y]</strong> which represents the <strong>dimensions of the matrix</strong> and the <strong>coordinates of the star.</strong></p>
<p>The <strong>output</strong> is the filled matrix, with the cells <strong>separated by a space</strong>, each <strong>row on a new line</strong>.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="106">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="116">
<p><strong>Input</strong></p>
</td>
<td width="88">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="120">
<p><strong>Input</strong></p>
</td>
<td width="114">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>[4, 4, 0, 0]</p>
</td>
<td width="106">
<p>1 2 3 4</p>
<p>2 2 3 4</p>
<p>3 3 3 4</p>
<p>4 4 4 4</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="116">
<p>[5, 5, 2, 2]</p>
<p>&nbsp;</p>
</td>
<td width="88">
<p>3 3 3 3 3</p>
<p>3 2 2 2 3</p>
<p>3 2 1 2 3</p>
<p>3 2 2 2 3</p>
<p>3 3 3 3 3</p>
</td>
<td width="120">
<p>[3, 3, 2, 2]</p>
</td>
<td width="114">
<p>3 3 3</p>
<p>3 2 2</p>
<p>3 2 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Check if there is some <strong>dependency</strong> or <strong>relation</strong> between the <strong>position of the numbers</strong> and the <strong>rows</strong> and <strong>columns </strong>of those positions.</li>
</ul>