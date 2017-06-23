<h1>Problem 1 &ndash; Arrange Integers</h1>
<p>You are given an array of integer numbers which you need to rearrange by their <strong>name</strong> in the English language. For example, the integers <strong>0, 1, 2, 3, 4, 5, 6, 7, 8, 9 </strong>must be ordered as <strong>8, 5, 4, 9, 1, 7, 6, 3, 2, 0. </strong>(eight, five, four, nine, one, seven, six, three, two, zero, i.e. sorted alphabetically)</p>
<p>Integers larger than ten are represented in a simplified way, for example <strong>88</strong> is &lsquo;<strong>eight-eight</strong>&rsquo; and <strong>1234 </strong>is &lsquo;<strong>one-two-three-four&rsquo;. </strong>That means that <strong>88</strong> comes before <strong>85. </strong>If the name of one integer starts with the name of another integer, such as in <strong>11</strong> (<strong>one-one</strong>) and <strong>111</strong> (<strong>one-one-one</strong>), the smaller integer comes first.</p>
<p>There are no negative integers in the input.</p>
<h3>Input</h3>
<ul>
<li>The input is on a single line &ndash; the integers to be rearranged, separated by a comma and space.</li>
</ul>
<h3>Output</h3>
<ul>
<li>On the only output line, print the rearranged integers, in format {<strong>n1, n2, n3 &hellip; n</strong>}</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input numbers are positive signed integers</li>
<li>There are no more than 50 integers in the input</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>0, 1, 2, 3, 4, 5, 6, 7, 8, 9</p>
</td>
<td width="294">
<p>8, 5, 4, 9, 1, 7, 6, 3, 2, 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>1111, 1, 111, 11</p>
</td>
<td width="294">
<p>1, 11, 111, 1111</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>17, 32, 45, 88, 44</p>
</td>
<td width="294">
<p>88, 45, 44, 17, 32</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>