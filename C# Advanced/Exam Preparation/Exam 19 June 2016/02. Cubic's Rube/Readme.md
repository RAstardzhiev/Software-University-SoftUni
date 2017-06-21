<h1>Problem 2 &ndash; Cubic&rsquo;s Rube</h1>
<p>Several years ago, while Cubic was researching a new quantum technology, to design a weapon he can use against the Spherical Race, he discovered a magical sub-dimension which stands in the cross-road of all other dimensions. The dimension was completely empty but it had a perfect cubic form and Cubic liked that a lot, so he named it after himself &ndash; The Cubic&rsquo;s Rube.</p>
<p>Cubic noticed that the Rube gets frequently bombarded with particles which fill it, so he decided to research its volume to see how it reacts with particles. He asked for help from The Great Cubical Army, and, guess what? They sent you.</p>
<p>You will be given <strong>n</strong> &ndash; an integer specifying the 3 dimensions of The Rube. Only 1 integer is used for all 3 dimensions because The Rube is a perfect cube. After that you will start receiving lines containing 4 integers separated by a single space. The <strong>first three integers</strong> will represent a <strong>point </strong>in the 3D space, and <strong>the last integer</strong> will represent the particles. You must bombard that cell at that point, <strong>if there is such cell</strong>, with the <strong>given particles</strong>, adding to it &ndash; the value corresponding to the given 4<sup>th</sup> integer. Note that the properties specified above apply <strong>only</strong> for cells <strong>INSIDE </strong>The Rube. Also, there will be <strong>NO</strong> cell that is <strong>hit</strong> more than <strong>1 times</strong> by particles.</p>
<p>The input ends when you receive the command &ldquo;<strong>Analyze</strong>&rdquo;. Then you must print the sum of all the cells in The Rube, along with the number of cells which&rsquo;s value has not been changed. See the output section for more info.</p>
<h3>Input</h3>
<ul>
<li>The first line of input will hold an integer <strong>n</strong>.</li>
<li>After that you will begin receiving lines of input containing 4 integers separated by a space.</li>
<li>The input ends when you receive the command &ldquo;<strong>Analyze</strong>&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output consists of two lines.</li>
<li>On the first line print the sum of all the cells in the Rube.</li>
<li>On the second line print the amount of cells which&rsquo;s value has not been changed.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the matrix &ndash; n will be in the range [0, 25].</li>
<li>The integers from the input lines will be in the range [-2<sup>31 </sup>+ 1, 2<sup>31</sup> &ndash; 1].</li>
<li>Allowed time/memory: 100ms/16MB.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Example</h3>
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
<p><strong>4</strong></p>
<p><strong>2 2 2 2</strong></p>
<p><strong>Analyze</strong></p>
</td>
<td width="294">
<p><strong>2</strong></p>
<p><strong>63</strong></p>
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
<p><strong>5</strong></p>
<p><strong>3 2 3 10</strong></p>
<p><strong>-1 -1 -1 0</strong></p>
<p><strong>1 4 0 20</strong></p>
<p><strong>2 2 2 5</strong></p>
<p><strong>Analyze</strong></p>
</td>
<td width="294">
<p><strong>35</strong></p>
<p><strong>122</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>