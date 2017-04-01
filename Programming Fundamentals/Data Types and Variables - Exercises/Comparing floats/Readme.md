<h2>* Comparing Floats</h2>
<p>Write a program that <strong>safely compares floating-point numbers</strong> (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant <strong>eps</strong>. Examples:</p>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>Number a</strong></p>
</td>
<td width="85">
<p><strong>Number b</strong></p>
</td>
<td width="236">
<p><strong>Equal (with precision eps=0.000001)</strong></p>
</td>
<td width="285">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>5.3</p>
</td>
<td width="85">
<p>6.01</p>
</td>
<td width="236">
<p>False</p>
</td>
<td width="285">
<p>The difference of 0.71 is too big (&gt; eps)</p>
</td>
</tr>
<tr>
<td width="84">
<p>5.00000001</p>
</td>
<td width="85">
<p>5.00000003</p>
</td>
<td width="236">
<p>True</p>
</td>
<td width="285">
<p>The difference 0.00000002 &lt; eps</p>
</td>
</tr>
<tr>
<td width="84">
<p>5.00000005</p>
</td>
<td width="85">
<p>5.00000001</p>
</td>
<td width="236">
<p>True</p>
</td>
<td width="285">
<p>The difference 0.00000004 &lt; eps</p>
</td>
</tr>
<tr>
<td width="84">
<p>-0.0000007</p>
</td>
<td width="85">
<p>0.00000007</p>
</td>
<td width="236">
<p>True</p>
</td>
<td width="285">
<p>The difference 0.00000077 &lt; eps</p>
</td>
</tr>
<tr>
<td width="84">
<p>-4.999999</p>
</td>
<td width="85">
<p>-4.999998</p>
</td>
<td width="236">
<p>False</p>
</td>
<td width="285">
<p>Border case. The difference 0.000001 == eps. We consider the numbers are different.</p>
</td>
</tr>
<tr>
<td width="84">
<p>4.999999</p>
</td>
<td width="85">
<p>4.999998</p>
</td>
<td width="236">
<p>False</p>
</td>
<td width="285">
<p>Border case. The difference 0.000001 == eps. We consider the numbers are different.</p>
</td>
</tr>
</tbody>
</table>