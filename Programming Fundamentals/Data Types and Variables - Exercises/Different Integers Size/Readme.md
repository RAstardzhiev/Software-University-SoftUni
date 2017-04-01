<h2>* Different Integers Size</h2>
<p>Given an input integer, you must <strong>determine which primitive data types</strong> are capable of properly storing that input.</p>
<h3>Input</h3>
<ul>
<li>You receive <strong>N</strong> &ndash; integer which can be arbitrarily large or small</li>
</ul>
<h3>Output</h3>
<p>You must determine if the given primitives are capable of storing it. If yes, then print:</p>
<table width="576">
<tbody>
<tr>
<td width="576">
<p>{N} can fit in:</p>
<p>* dataType</p>
</td>
</tr>
</tbody>
</table>
<p>If there is more than one appropriate data type, print each one on its own line and order them by size<br /> (sbyte<strong> &lt; </strong>byte<strong> &lt; </strong>short<strong> &lt; </strong>ushort<strong> &lt; </strong>int<strong> &lt; </strong>uint<strong> &lt; </strong>long).</p>
<p>If the number cannot be stored in one of the four aforementioned primitives, print the line:</p>
<table width="576">
<tbody>
<tr>
<td width="576">
<p>{N} can't fit in any type</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="646">
<tbody>
<tr>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="235">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="28">
<p><strong>&nbsp;</strong></p>
</td>
<td width="66">
<p><strong>Input</strong></p>
</td>
<td width="265">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="52">
<p>-150</p>
</td>
<td width="235">
<p>-150 can fit in:</p>
<p>* short</p>
<p>* int</p>
<p>* long</p>
</td>
<td width="66">
<p>150000</p>
</td>
<td width="265">
<p>150000 can fit in:</p>
<p>* int</p>
<p>* uint</p>
<p>* long</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="287">
<tbody>
<tr>
<td width="92">
<p><strong>Input</strong></p>
</td>
<td width="195">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1500000000</p>
</td>
<td width="195">
<p>1500000000 can fit in:</p>
<p>* int</p>
<p>* uint</p>
<p>* long</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="646">
<tbody>
<tr>
<td width="315">
<p><strong>Input</strong></p>
</td>
<td width="331">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="315">
<p>213333333333333333333333333333333333</p>
</td>
<td width="331">
<p>213333333333333333333333333333333333 can't fit in any type</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use the <strong>try &hellip; catch</strong></li>
</ul>