<h1><strong>**Poisonous Plants</strong></h1>
<p>You are given&nbsp;<strong>N</strong>&nbsp;plants in a garden. Each of these plants has been added with some amount of pesticide. After each day, if any plant has <strong>more pesticide</strong> than the plant at <strong>its left</strong>, being weaker(more GMO) than the left one, <strong>it dies</strong>. You are given the initial values of the pesticide and position of each plant. Print the number of days <strong>after</strong> which no plant dies, i.e. the time after which there are no plants with more pesticide content than the plant to their left.</p>
<p><strong>Input Format: </strong>The input consists of an integer&nbsp;<strong>N</strong> representing the number of plants. The next <strong>single line</strong> consists of&nbsp;<strong>N</strong>&nbsp;integers where every integer represents the position and amount of pesticides of each plant.</p>
<p><strong>Constraints</strong>: 1 &le; N &le; 100000<br /> Pesticides amount on a plant is between 0 and 1000000000</p>
<p><strong>Output Format: </strong>Output a single value equal to the number of days after which no plants die</p>
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
<p>7</p>
<p>6 5 8 4 7 10 9</p>
</td>
<td width="372">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Explanation</strong></p>
<p>Initially all plants are alive.&nbsp;<br /> Plants = {(6,1), (5,2), (8,3), (4,4), (7,5), (10,6), (9,7)}&nbsp;<br /> Plants[k] = (i,j) =&gt; j<sup>th</sup>&nbsp;plant has pesticide amount = i.&nbsp;<br /> After the 1<sup>st</sup>&nbsp;day, 4 plants remain as plants 3, 5, and 6 die.&nbsp;<br /> Plants = {(6,1), (5,2), (4,4), (9,7)}&nbsp;<br /> After the 2<sup>nd</sup>&nbsp;day, 3 plants survive as plant 7 dies. Plants = {(6,1), (5,2), (4,4)}&nbsp;<br /> After the 3<sup>rd</sup>&nbsp;day, 3 plants survive and no more plants die.&nbsp;<br /> Plants = {(6,1), (5,2), (4,4)}&nbsp;<br /> After the 2<sup>nd</sup>&nbsp;day the plants stop dying.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>