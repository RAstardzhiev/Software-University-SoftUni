<h1>Problem 2 &ndash; Array Manipulator</h1>
<p>Trifon has finally become a junior developer and has received his first task. It&rsquo;s about manipulating an array of integers. He is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of money, though, and he is willing to give somebody half of it if to help him do his job. You, on the other hand, love arrays (and money) so you decide to try your luck.</p>
<p>The array may be manipulated by one of the following commands</p>
<ul>
<li><strong>exchange {index}</strong> &ndash; splits the array <strong>after</strong> the given index, and exchanges the places of the two resulting sub-arrays. E.g. [1, 2, 3, 4, 5] -&gt; exchange 2 -&gt; result: [4, 5, 1, 2, 3]
<ul>
<li>If the index is outside the boundaries of the array, print &ldquo;<strong>Invalid index</strong>&rdquo;</li>
</ul>
</li>
<li><strong>max</strong> <strong>even/odd</strong>&ndash; returns the <strong>INDEX</strong> of the max even/odd element -&gt; [1, 4, 8, 2, 3] -&gt; <strong>max odd</strong> -&gt; print <strong>4</strong></li>
<li><strong>min</strong> <strong>even/odd </strong>&ndash; returns the <strong>INDEX</strong> of the min even/odd element -&gt; [1, 4, 8, 2, 3] -&gt; <strong>min even</strong> &gt; print <strong>3</strong>
<ul>
<li>If there are two or more equal <strong>min/max</strong> elements, return the index of the <strong>rightmost</strong> one</li>
<li>If a <strong>min/max even/odd </strong>element <strong>cannot</strong> be found, print <strong>&ldquo;No matches&rdquo;</strong></li>
</ul>
</li>
<li><strong>first {count}</strong> <strong>even/odd</strong>&ndash; returns the first {count} elements -&gt; [1, 8, 2, 3] -&gt; <strong>first 2 even</strong> -&gt; print [<strong>8, 2]</strong></li>
<li><strong>last {count}</strong> <strong>even/odd </strong>&ndash; returns the last {count} elements -&gt; [1, 8, 2, 3] -&gt; <strong>last 2 odd</strong> -&gt; print [<strong>1, 3]</strong>
<ul>
<li>If the count is greater than the array length, print &ldquo;<strong>Invalid count</strong>&rdquo;</li>
<li>If there are <strong>not</strong> <strong>enough</strong> elements to satisfy the count, print as many as you can. If there are <strong>zero</strong> <strong>even/odd</strong> elements, print an empty array &ldquo;[]&rdquo;</li>
</ul>
</li>
<li><strong>end </strong>&ndash; stop taking input and print the final state of the array</li>
</ul>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>On the first line, the initial array is received as a line of integers, separated by a single space</li>
<li>On the next lines, until the command &ldquo;<strong>end</strong>&rdquo; is received, you will receive the array manipulation commands</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>On a separate line, print the output of the corresponding command</li>
<li>On the last line, print the final array in <strong>square brackets</strong> with its elements separated by a comma and a space</li>
<li>See the examples below to get a better understanding of your task</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The <strong>number of input lines</strong> will be in the range [2 &hellip; 50].</li>
<li>The <strong>array elements</strong> will be integers in the range [0 &hellip; 1000].</li>
<li>The <strong>number of elements</strong> will be in the range [1 .. 50]</li>
<li>The <strong>split index </strong>will be an integer in the range [-2<sup>31 </sup>&hellip; 2<sup>31</sup> &ndash; 1]</li>
<li><strong>first/last count </strong>will be an integer in the range [1 &hellip; 2<sup>31</sup> &ndash; 1]</li>
</ul>
<ul>
<li>There will <strong>not</strong> be redundant whitespace anywhere in the input</li>
</ul>
<ul>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>1 3 5 7 9</p>
<p>exchange 1</p>
<p>max odd</p>
<p>min even</p>
<p>first 2 odd</p>
<p>last 2 even</p>
<p>exchange 3</p>
<p>end</p>
</td>
<td width="372">
<p>2</p>
<p>No matches</p>
<p>[5, 7]</p>
<p>[]</p>
<p>[3, 5, 7, 9, 1]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>1 10 100 1000</p>
<p>max even</p>
<p>first 5 even</p>
<p>exchange 10</p>
<p>min odd</p>
<p>exchange 0</p>
<p>max even</p>
<p>min even</p>
<p>end</p>
</td>
<td width="372">
<p>3</p>
<p>Invalid count</p>
<p>Invalid index</p>
<p>0</p>
<p>2</p>
<p>0</p>
<p>[10, 100, 1000, 1]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>1 10 100 1000</p>
<p>exchange 3</p>
<p>first 2 odd</p>
<p>last 4 odd</p>
<p>end</p>
</td>
<td width="372">
<p>[1]</p>
<p>[1]</p>
<p>[1, 10, 100, 1000]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>