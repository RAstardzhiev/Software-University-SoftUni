<h1><strong>Calculate Sequence with Queue</strong></h1>
<p>We are given the following sequence of numbers:</p>
<ul>
<li>S<sub>1</sub> = N</li>
<li>S<sub>2</sub> = S<sub>1</sub> + 1</li>
<li>S<sub>3</sub> = 2*S<sub>1</sub> + 1</li>
<li>S<sub>4</sub> = S<sub>1</sub> + 2</li>
<li>S<sub>5</sub> = S<sub>2</sub> + 1</li>
<li>S<sub>6</sub> = 2*S<sub>2</sub> + 1</li>
<li>S<sub>7</sub> = S<sub>2</sub> + 2</li>
<li>&hellip;</li>
</ul>
<p>Using the <strong>ArrayDeque&lt;E&gt;</strong> class, write a program to print its first 50 members for given N.</p>
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
<p>2</p>
</td>
<td width="372">
<p>2 3 5 4 4 7 5 6 11 7 5 9 6 &hellip;</p>
</td>
</tr>
<tr>
<td width="305">
<p>-1</p>
</td>
<td width="372">
<p>-1 0 -1 1 1 1 2 &hellip;</p>
</td>
</tr>
<tr>
<td width="305">
<p>1000</p>
</td>
<td width="372">
<p>1000 1001 2001 1002 1002 2003 1003 &hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>