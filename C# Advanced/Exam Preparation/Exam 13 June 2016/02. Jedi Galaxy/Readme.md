<h1>Problem 2 &ndash; Jedi Galaxy</h1>
<p>Ivo is the illegal son of Darth Vader. But he doesn&rsquo;t know much about being a powerful Jedi warrior. Meanwhile, Princess Lea just broke up with Han Solo, because he cheated on her. Ivo decided to grab her heart, but he needs your help. He must be powerful enough to impress her and so he starts gathering stars to grow stronger.</p>
<p>His galaxy is represented as a two dimensional array. Every cell in the matrix is a star that has a value. Ivo starts at the given <strong>col</strong> and <strong>row</strong>. He can move only on the diagonal <strong>from the lowest left to the upper right</strong>, and <strong>adds</strong> to his score all the stars (values) from the cells he <strong>passes through</strong>. Unfortunately, there is always an Evil power that tries to prevent his success.</p>
<p>Evil power starts at the given <strong>row</strong> and <strong>col</strong> and instantly destroys all stars on the opposite diagonal &ndash; <strong>From lowest right to the upper left. </strong></p>
<p>Ivo <strong>adds</strong> the values only of the stars that are <strong>not</strong> <strong>destroyed</strong> by the evil power.&nbsp; &nbsp;</p>
<p>You will receive <strong>two</strong> integers, separated by space, which represent the two dimensional array - the first being the rows and the second being the columns. Then, you must fill the two dimensional array with increasing integers starting from 0, and continuing on every row, like this: <br /> first row: 0, 1, 2&hellip; m<br /> second row: n+1, n+2, n+3&hellip; n + n. <br /> <strong>Example:</strong></p>
<p>Ivo starts with coordinates row = 5, col = -1. He must collect all stars with value [20, 16, 12, 8, 4]. Evil starts with coordinates row = 5, col = 5. The Evil destroys all stars in range [24, 18, 12, 6, 0]. The star with value <strong>12 </strong>is the cross point for Ivo and The Evil, so Ivo skips the stars and collects only these who are not in the evil range.</p>
<p>You will also receive multiple pairs of commands in the form of 2 integers separated by a single space. The first two integers will represent Ivo&rsquo;s start coordinates. The second one will represent the Evil Power&rsquo;s start coordinates.</p>
<p>The input ends when you receive the command &ldquo;<strong>Let the Force be with you</strong>&rdquo;. When that happens, you must print the value of all stars that Ivo has collected successfully.</p>
<h3>Input</h3>
<ul>
<li>On the first line, you will receive the number N, M -&gt; the dimensions of the matrix. You must then fill the matrix according to these dimensions.</li>
<li>On the next several lines you will begin receiving 2 integers separated by a single <strong>space</strong>, which represent Ivo&rsquo;s row and col. On the next line you will receive the Evil Power&rsquo;s coordinates.</li>
<li>There will always be <strong>at least 2 lines</strong> of input to represent at least 1 path of Ivo and the Evil force.</li>
<li>When you receive the command, &ldquo;<strong>Let the Force be with you</strong>&rdquo; the input ends.</li>
</ul>
<p>&nbsp;</p>
<h3>Output</h3>
<ul>
<li>The output is simple. Print the sum of the values from all stars that Ivo has collected.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the matrix will be integers in the range [5, 2000].</li>
<li>The given rows will be valid integers in the range [0, 2000].</li>
<li>The given columns will be valid integers in the range [-2<sup>31 </sup>+ 1, 2<sup>31</sup> - 1].</li>
</ul>
<table width="611">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="306">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>5 5</p>
<p>5 -1</p>
<p>5 5</p>
<p>Let the Force be with you</p>
</td>
<td width="306">
<p>48</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="611">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="306">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>5 5</p>
<p>4 -1</p>
<p>4 5</p>
<p>Let the Force be with you</p>
</td>
<td width="306">
<p>29</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>