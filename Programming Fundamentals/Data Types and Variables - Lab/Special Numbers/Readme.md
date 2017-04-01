<h2>Special Numbers</h2>
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