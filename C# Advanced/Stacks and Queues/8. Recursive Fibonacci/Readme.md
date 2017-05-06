<h1><strong>Recursive Fibonacci</strong></h1>
<p>The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34&hellip; <br /> The following sequence can be generated with an array, but that&rsquo;s easy, so your task is to implement recursively.</p>
<p>So if the function getFibonacci(n) returns the n&rsquo;th Fibonacci number we can express it using getFibonacci(n) = getFibonacci(n-1) + getFibonacci(n-2)</p>
<p>However, this will never end and in a few seconds a StackOverflow Exception is thrown. In order for the recursion to stop it has to have a &ldquo;bottom&rdquo;. The bottom of the recursion is getFibonacci(1) should return 1 and getFibonacci(0) should return 1.</p>
<p><strong>Input Format: </strong>On the only line in the input the user should enter the wanted Fibonacci number.</p>
<p><strong>Output Format: </strong>The output should be the n&rsquo;th Fibonacci number counting from 0</p>
<p><strong>Constraints: </strong></p>
<p>1 &le; N &le; 49</p>
<p><strong>Examples</strong></p>
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
<p>5</p>
</td>
<td width="372">
<p>8</p>
</td>
</tr>
<tr>
<td width="305">
<p>10</p>
</td>
<td width="372">
<p>89</p>
</td>
</tr>
<tr>
<td width="305">
<p>21</p>
</td>
<td width="372">
<p>17711</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>For the Nth Fibonacci number, we calculate the N-1th and the N-2th number, but for the calculation of N-1th number we calculate the N-1-1th(N-2th) and the N-1-2th number, so we have a lot of repeated calculations.</p>
<p>&nbsp;</p>
<p>If you want to figure out how to skip those unnecessary calculations, you can search for a technique called <a href="https://en.wikipedia.org/wiki/Memoization">memoization</a>.</p>