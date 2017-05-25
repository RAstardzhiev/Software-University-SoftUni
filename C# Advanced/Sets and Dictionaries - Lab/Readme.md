<h1>Lab: Sets And Dictionaries</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1633/csharp-advanced-may-2017">"C# Advanced" course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Practice/Index/572#5">https://judge.softuni.bg/Contests/Practice/Index/572#5</a>.</p>
<h2>I.&nbsp;&nbsp;&nbsp;&nbsp; Sets</h2>
<h3>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parking Lot</h3>
<p>Write program that:</p>
<ul>
<li>Record <strong>car number</strong> for every car that enter in <strong>parking lot</strong></li>
<li>Remove <strong>car number</strong> when the car go out</li>
<li>Input will be string in format <strong>[direction, carNumber]</strong></li>
<li>input end with string <strong>"</strong><strong>END"</strong></li>
</ul>
<p>Print the output with all car numbers which are in parking lot</p>
<h4>Examples</h4>
<table width="659">
<tbody>
<tr>
<td width="192">
<p><strong>Input</strong></p>
</td>
<td width="467">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="192">
<p>IN, CA2844AA</p>
<p>IN, CA1234TA</p>
<p>OUT, CA2844AA</p>
<p>IN, CA9999TT</p>
<p>IN, CA2866HI</p>
<p>OUT, CA1234TA</p>
<p>IN, CA2844AA</p>
<p>OUT, CA2866HI</p>
<p>IN, CA9876HH</p>
<p>IN, CA2822UU</p>
<p>END</p>
</td>
<td width="467">
<p>CA2822UU</p>
<p>CA2844AA</p>
<p>CA9876HH</p>
<p>CA9999TT</p>
</td>
</tr>
<tr>
<td width="192">
<p>IN, CA2844AA</p>
<p>IN, CA1234TA</p>
<p>OUT, CA2844AA</p>
<p>OUT, CA1234TA</p>
<p>END</p>
</td>
<td width="467">
<p>Parking Lot is Empty</p>
</td>
</tr>
</tbody>
</table>
<h4>Hints</h4>
<ul>
<li>Car numbers are <strong>unique</strong></li>
<li>For print, first ask if set is empty</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h4>Solution</h4>
<p>You might help yourself with the code below:</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;SoftUni Party</h3>
<p>There is a party in SoftUni. Many guests are invited and they are two type VIP and regular. When guest come check if he/she exist in any of two reservation lists</p>
<p>All reservation numbers will be with 8 chars</p>
<p>All VIP numbers start with digit</p>
<p>There will be 2 command lines. First is "PARTY" - party is on and guests start coming. Second is "END" &ndash; then party is over and no more guest will come</p>
<p>Output have to all guest, who didn't come to the party (VIP must be first)</p>
<h4>Examples</h4>
<table width="392">
<tbody>
<tr>
<td width="85">
<p><strong>Input</strong></p>
</td>
<td width="102">
<p><strong>Output</strong></p>
</td>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="102">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>7IK9Yo0h</p>
<p>9NoBUajQ</p>
<p>Ce8vwPmE</p>
<p>SVQXQCbc</p>
<p>tSzE5t0p</p>
<p>PARTY</p>
<p>9NoBUajQ</p>
<p>Ce8vwPmE</p>
<p>SVQXQCbc</p>
<p>END</p>
</td>
<td width="102">
<p>2</p>
<p>7IK9Yo0h</p>
<p>tSzE5t0p</p>
</td>
<td width="102">
<p>m8rfQBvl</p>
<p>fc1oZCE0</p>
<p>UgffRkOn</p>
<p>7ugX7bm0</p>
<p>9CQBGUeJ</p>
<p>2FQZT3uC</p>
<p>dziNz78I</p>
<p>mdSGyQCJ</p>
<p>LjcVpmDL</p>
<p>fPXNHpm1</p>
<p>HTTbwRmM</p>
<p>B5yTkMQi</p>
<p>8N0FThqG</p>
<p>xys2FYzn</p>
<p>MDzcM9ZK</p>
<p>PARTY</p>
<p>2FQZT3uC</p>
<p>dziNz78I</p>
<p>mdSGyQCJ</p>
<p>LjcVpmDL</p>
<p>fPXNHpm1</p>
<p>HTTbwRmM</p>
<p>B5yTkMQi</p>
<p>8N0FThqG</p>
<p>m8rfQBvl</p>
<p>fc1oZCE0</p>
<p>UgffRkOn</p>
<p>7ugX7bm0</p>
<p>9CQBGUeJ</p>
<p>END</p>
</td>
<td width="102">
<p>2</p>
<p>MDzcM9ZK</p>
<p>xys2FYzn</p>
</td>
</tr>
</tbody>
</table>
<h4>Hints</h4>
<ul>
<li>All string starts with digit are alphabetical before string starts with letter</li>
</ul>
<p>&nbsp;</p>
<h2>&nbsp;II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Dictionaries</h2>
<h3>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Count Same Values in Array</h3>
<p>Write a program that counts in a given array of double values the number of occurrences of each value.</p>
<h4>Examples</h4>
<table width="659">
<tbody>
<tr>
<td width="495">
<p><strong>Input</strong></p>
</td>
<td width="164">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="495">
<p>-2,5 4 3 -2,5 -5,5 4 3 3 -2,5 3</p>
</td>
<td width="164">
<p>-5,5 &ndash; 1 times</p>
<p>-2,5 &ndash; 3 times</p>
<p>3 &ndash; 4 times</p>
<p>4 &ndash; 2 times</p>
</td>
</tr>
<tr>
<td width="495">
<p>2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3</p>
<p>&nbsp;</p>
</td>
<td width="164">
<p>2 - 3 times</p>
<p>3 - 7 times</p>
<p>4 - 6 times</p>
<p>5 - 4 times</p>
</td>
</tr>
</tbody>
</table>
<h4>Hints</h4>
<ul>
<li>Use SortedDictionary() for correct result, because you can't be sure what kind of hash algorithm is used in Judge.</li>
</ul>
<p>&nbsp;</p>
<h3>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Academy Graduation</h3>
<p>Write a program that:</p>
<ul>
<li>Read from console <strong>number</strong> of student for a track</li>
<li>Read on <strong>pair of rows</strong>:
<ul>
<li>First line is <strong>name</strong> of student</li>
<li>Second line is his <strong>score</strong> for different number of courses</li>
</ul>
</li>
<li>Print on console &ldquo;<strong>{name} </strong>is graduated with <strong>{average scores)</strong>&rdquo;</li>
</ul>
<h4>Examples</h4>
<table width="659">
<tbody>
<tr>
<td width="344">
<p><strong>Input</strong></p>
</td>
<td width="316">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="344">
<p>3</p>
<p>Gosho</p>
<p>3.75 5</p>
<p>Mara</p>
<p>4.25 6</p>
<p>Pesho</p>
<p>6 4.5</p>
</td>
<td width="316">
<p>Gosho is graduated with 4.375</p>
<p>Mara is graduated with 5.125</p>
<p>Pesho is graduated with 5.25</p>
</td>
</tr>
<tr>
<td width="344">
<p>5</p>
<p>Gruio</p>
<p>4.36 5.50 3.30 5.63 2.57 5.75 2.81 4.89</p>
<p>Trendafilka</p>
<p>3.10 5.35 3.30 3.35 5.64 4.99 2.75 4.68</p>
<p>Mite</p>
<p>3.45 3.23 3.03 5.42 5.46 4.15 2.26 5.95</p>
<p>Roza</p>
<p>2.08 3.48 3.36 2.73 2.96 4.54 3.70 3.85</p>
<p>Ganio</p>
<p>4.75 4.92 3.78 4.79 4.82 4.75 2.81 2.13</p>
</td>
<td width="316">
<p>Ganio is graduated with 4.09375</p>
<p>Gruio is graduated with 4.35125</p>
<p>Mite is graduated with 4.11875</p>
<p>Roza is graduated with 3.3375</p>
<p>Trendafilka is graduated with 4.145</p>
</td>
</tr>
</tbody>
</table>
<h4>Hints</h4>
<ul>
<li>Think about <strong>proper type</strong> of dictionary</li>
<li><strong>Value</strong> can be <strong>array</strong></li>
</ul>