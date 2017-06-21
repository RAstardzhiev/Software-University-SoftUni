<h1>Problem 4 &ndash; Cubic Assault</h1>
<p>After countless of hours of preparation &ndash; artillery storage, quantum research, and planning trough encoded messages, time has finally come for a war with the Spherical Race. Cubic is on the front lines devastating the enemy forces. Someone, however, must give statistics to Cubic about the count of enemies on each front. You are best for this job.</p>
<p>You will be given as input lines containing, a region, the type of the soldiers at that region and their amount. You must <strong>store statistics</strong> about the <strong>amount of meteors</strong> Cubic needs to defeat in <strong>every region</strong>. Note that if at one region 1 000 000 Green Meteors gather, they <strong>combine</strong> into 1 Red Meteor. By the same logic, 1 000 000 Red Meteors get <strong>combined </strong>into 1 Black Meteor. Note also, that you might receive <strong>several input lines</strong> with information about <strong>1 region</strong>. In that case just <strong>update that region&rsquo;s statistics</strong>. Multiple values to one type <strong>increase</strong> that type&rsquo;s value each time.</p>
<p>The input data will come in the following format <strong>{regionName} -&gt; {meteorType} -&gt; {count}. </strong></p>
<p>When you receive the command &ldquo;<strong>Count em all</strong>&rdquo;, you must <strong>end</strong> the input sequence. You must print all the regions ordered by the <strong>amount of Black Meteors</strong> &ndash; descending, then by the <strong>length of their names</strong> &ndash; ascending, and lastly <strong>alphabetically</strong>. For every region you must print how many green, red and black meteors there. Order the printing of the types by <strong>amount of defeated units</strong> in them &ndash; descending, and if two are with the same value, order them <strong>alphabetically</strong>.</p>
<h3>Input</h3>
<ul>
<li>As input you will receive random amount of input lines containing information about Cubic&rsquo;s statistics.</li>
<li>The input ends when you receive the command &ldquo;Count em all&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. You must print each region and the statistics about the 3 types of meteors in it.</li>
<li>The format of output is :</li>
</ul>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>{regionName} </strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt; {firstType} : {firstTypeCount} </strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt; {secondType} : {secondTypeCount} </strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -&gt; {thirdType} : {thirdTypeCount}</strong></p>
<ul>
<li>The order of each type depends on its count as specified above. All data must be ordered correctly.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input numbers will be valid integers in the range [-2<sup>31</sup> + 1, 2<sup>31</sup> &ndash; 1].</li>
<li>The input will always be in the format specified above. There is no need to check it explicitly.</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="294">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="305">
<p><strong>Cubica -&gt; Black -&gt; 1</strong></p>
<p><strong>Cubica -&gt; Red -&gt; 1000</strong></p>
<p><strong>Spherica -&gt; Green -&gt; 1000000</strong></p>
<p><strong>Count em all</strong></p>
</td>
<td width="294">
<p><strong>Cubica</strong></p>
<p><strong>-&gt; Red : 1000</strong></p>
<p><strong>-&gt; Black : 1</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>Spherica</strong></p>
<p><strong>-&gt; Red : 1</strong></p>
<p><strong>-&gt; Black : 0</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
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
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="294">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="305">
<p><strong>Triangula Canyon -&gt; Black -&gt; 100</strong></p>
<p><strong>Diagonalica -&gt; Red -&gt; 999999</strong></p>
<p><strong>Ellipsetica -&gt; Red -&gt; 100000000</strong></p>
<p><strong>Diagonalica -&gt; Black -&gt; 99</strong></p>
<p><strong>Diagonalica -&gt; Green -&gt; 1000000</strong></p>
<p><strong>Count em all</strong></p>
</td>
<td width="294">
<p><strong>Diagonalica</strong></p>
<p><strong>-&gt; Black : 100</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>-&gt; Red : 0</strong></p>
<p><strong>Ellipsetica</strong></p>
<p><strong>-&gt; Black : 100</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>-&gt; Red : 0</strong></p>
<p><strong>Triangula Canyon</strong></p>
<p><strong>-&gt; Black : 100</strong></p>
<p><strong>-&gt; Green : 0</strong></p>
<p><strong>-&gt; Red : 0</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>