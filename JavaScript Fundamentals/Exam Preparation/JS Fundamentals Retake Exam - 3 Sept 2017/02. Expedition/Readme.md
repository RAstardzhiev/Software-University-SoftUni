<h1>Problem 2 &ndash; Expedition</h1>
<p><em>You are on an expedition in the mountains but the signs are pointing the wrong way and no one knows how to find you &ndash; so you're lost. It is getting dark already and you remember that you have an old map of the surrounding terrain in your backpack. To read it, first you've got to decode it. If you manage to figure out the way back to the rest house, you'll get there safely. Otherwise, you'll have to spend the night in the mountains and, as you know, the night is dark and full of terrors(bears).</em></p>
<p>You have an <strong>encrypted</strong> map represented by a <strong>rectangular</strong> matrix (<strong>primary</strong>) with dimensions <strong>N x M</strong> and <strong>random</strong> values of <strong>0</strong> and <strong>1</strong>. An element of the matrix with <strong>value 0</strong> corresponds to a <strong>path</strong> and an element with <strong>value 1</strong> &ndash; to an <strong>obstacle </strong>that <strong>cannot be crossed</strong>. In addition to the primary matrix, there is another one &ndash; <strong>secondary </strong>rectangular matrix, with dimensions <strong>P x Q</strong>. Its elements are also of <strong>random</strong> values (<strong>0</strong> and <strong>1</strong>). To be able to decode the map, you've got to overlay the secondary matrix on the primary matrix <strong>n-times</strong>. The coordinates of the element from the <strong>primary</strong> matrix, corresponding to the <strong>upper-left</strong> (<strong>0, 0</strong>) element of the <strong>secondary</strong> matrix, are received from the input. For example, if the received input is [1, 1] you have to place the upper-left (0,0) corner of the secondary matrix at 1, 1 of the primary matrix. Use the following modification criteria for <strong>altering</strong> <strong>the</strong> <strong>primary</strong> matrix:</p>
<ul>
<li>Element with <strong>value</strong> <strong>1 </strong>from the <strong>secondary</strong> matrix <strong>inverts</strong> the value of the corresponding element in the <strong>primary</strong> matrix;</li>
<li>Element with <strong>value</strong> <strong>0 </strong>from the <strong>secondary</strong> matrix <strong>doesn't</strong> <strong>change</strong> the value of the corresponding element in the <strong>primary</strong> matrix;</li>
</ul>
<p>When you're done with <strong>all of the alterations</strong> of the primary matrix you will get the <strong>final</strong> matrix. It represents the <strong>deciphered</strong> map of the terrain and you can use it to find your way back to the rest house. Your current location (<strong>start</strong>) is <strong>always</strong> going to be <strong>on one of the four sides</strong> of the matrix (<strong>excluding the corners</strong>) and the end will not be with the same coordinates as the start. You can only move <strong>up</strong>, <strong>down</strong>, <strong>left</strong> or <strong>right</strong>. At every moment, there will be <strong>only one possible direction </strong>to take, <strong>if any</strong>. In case you've come to a <strong>dead end</strong>, there is no way back and you've got to spend the night in the mountains.</p>
<h3>Input</h3>
<p>You will receive four arguments &ndash; <strong>primary</strong> matrix, <strong>secondary</strong> matrix, <strong>overlay</strong> coordinates and <strong>starting coordinates</strong>. The overlay coordinates are an array of arrays, holding (x, y) coordinate pairs. The starting coordinates are also an (x, y) coordinate pair.</p>
<h3>Output</h3>
<p>The first line of the output contains the number of steps made from the beginning to the end of the path. The starting point is the first step. Each cell of the matrix, holding value 0, corresponds to a single step. In case you find a way out, on the second line you must print "<strong>Top</strong>"/"<strong>Bottom</strong>"/"<strong>Right</strong>"/"<strong>Left</strong>", depending on that on which side of the matrix lies the exit (there won't be an exit in the corners of the matrix). If you've come to a dead end, you must print "<strong>Dead end</strong>", followed by a <strong>quadrant number</strong>, in which the end of the path is. See the examples below to understand how it works.</p>
<h3>Constraints</h3>
<ul>
<li>The number of rows and columns of the primary matrix will always be an even number.</li>
</ul>
<p>Scroll down for examples.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="653">
<tbody>
<tr>
<td width="333">
<p><strong>Input</strong></p>
</td>
<td width="320">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="333">
<p>[[1, 1, 0, 1, 1, 1, 1, 0],</p>
<p>&nbsp;[0, 1, 1, 1, 0, 0, 0, 1],</p>
<p>&nbsp;[1, 0, 0, 1, 0, 0, 0, 1],</p>
<p>&nbsp;[0, 0, 0, 1, 1, 0, 0, 1],</p>
<p>&nbsp;[1, 0, 0, 1, 1, 1, 1, 1],</p>
<p>&nbsp;[1, 0, 1, 1, 0, 1, 0, 0]],</p>
<p>[[0, 1, 1],</p>
<p>&nbsp;[0, 1, 0],</p>
<p>&nbsp;[1, 1, 0]],</p>
<p>[[1, 1],</p>
<p>&nbsp;[2, 3],</p>
<p>&nbsp;[5, 3]],</p>
<p>[0, 2]</p>
</td>
<td width="320">
<p>15</p>
<p>Bottom</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="2" width="653">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="653">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="653">
<tbody>
<tr>
<td width="333">
<p><strong>Input</strong></p>
</td>
<td width="321">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="333">
<p>[[1, 1, 0, 1],</p>
<p>&nbsp;[0, 1, 1, 0],</p>
<p>&nbsp;[0, 0, 1, 0],</p>
<p>&nbsp;[1, 0, 1, 0]],</p>
<p>[[0, 0, 1, 0, 1],</p>
<p>&nbsp;[1, 0, 0, 1, 1],</p>
<p>&nbsp;[1, 0, 1, 1, 1],</p>
<p>&nbsp;[1, 0, 1, 0, 1]],</p>
<p>[[0, 0],</p>
<p>&nbsp;[2, 1],</p>
<p>&nbsp;[1, 0]],</p>
<p>[2, 0]</p>
</td>
<td width="321">
<p>4</p>
<p>Dead end 1</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="2" width="653">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="653">
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>