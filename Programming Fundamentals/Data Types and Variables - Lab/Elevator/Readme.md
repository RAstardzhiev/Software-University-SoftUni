<h2>Elevator</h2>
<p>Calculate how many courses will be needed to <strong>elevate n persons</strong> by using an elevator of <strong>capacity of p persons</strong>. The input holds two lines: the <strong>number of people n</strong> and the <strong>capacity p</strong> of the elevator.</p>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="576">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>17</p>
<p>3</p>
</td>
<td width="62">
<p>6</p>
</td>
<td width="576">
<p>5 courses * 3 people<br /> + 1 course * 2 persons</p>
</td>
</tr>
<tr>
<td width="51">
<p>4</p>
<p>5</p>
</td>
<td width="62">
<p>1</p>
</td>
<td width="576">
<p>All the persons fit inside in the elevator.</p>
<p>Only one course is needed.</p>
</td>
</tr>
<tr>
<td width="51">
<p>10</p>
<p>5</p>
</td>
<td width="62">
<p>2</p>
</td>
<td width="576">
<p>2 courses * 5 people</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>You should <strong>divide </strong>n<strong> by </strong>p. This gives you the number of full courses (e.g. 17 / 3 = 5).</li>
<li>If n does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).</li>
<li>Another approach is to round up n / p to the nearest integer (ceiling), e.g. 17/3 = 67 &agrave; rounds up to 6.</li>
</ul>