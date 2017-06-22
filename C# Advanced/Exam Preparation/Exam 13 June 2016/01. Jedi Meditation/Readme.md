<p>Problem 1 &ndash; Jedi Meditation</p>
<p>A long time ago, in a galaxy far, far away...</p>
<p>All Jedi must meditate. Yet, when the Jedi are at their temple, they cannot mediate at the same time, because the temple will overload itself with too much force and an implosion will occur. There is a <strong>strict</strong> <strong>order</strong> for meditations: Jedi Masters mediate <strong>first</strong>, <strong>then</strong> Jedi Knights, and <strong>lastly &ndash;</strong> the Padawans.</p>
<p>Given the sequence of Jedi:</p>
<p>{Jedi Type}{Jedi Level}</p>
<p>p1 k1 m2 m1 k2 p2</p>
<p>they will meditate in the following order:</p>
<p>m2 m1 k1 k2 p1 p2</p>
<p><strong>m</strong>&nbsp;means a Jedi Master,&nbsp;<strong>k</strong>&nbsp;is a Jedi Knight, and&nbsp;<strong>p</strong>&nbsp;is a Padawan.</p>
<p>Toshko and Slav are padawans. They want to have as much time with the Force as they can. So they always try to mediate <strong>before</strong> Jedi Masters, <strong>until</strong> Jedi Master Yoda shows up and moves them <strong>after</strong> Jedi Knights and <strong>before</strong> Jedi Padawans. Given that &nbsp;they do not want to wait meaninglessly for meditation, you need to help them solve in which order all Jedi will mediate. There can be multiple yodas, but the number identifiers (such as m<strong>2 </strong>are unique<strong>).</strong></p>
<h3>Input</h3>
<ul>
<li>On the first line, you will find the number N &ndash; the count of the input lines.</li>
<li>On the next N lines you will receive sequences with Jedis, separated by a <strong>single space</strong>, waiting for meditation
<ul>
<li><strong>m</strong>means Jedi master</li>
<li><strong>k</strong>means Jedi knight</li>
<li><strong>p</strong>means Jedi padawan</li>
<li><strong>t </strong>means Toshko the padawan</li>
<li><strong>s </strong>means Slav the padawan</li>
<li><strong>y </strong>means Master Yoda</li>
</ul>
</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output consists of a single line.</li>
<li>You must print the sequence of jedis, ready for meditation in the correct order, and in the following format:</li>
<ul>
<li>Print each jedis type and level</li>
<li>Different jedis are separated by a <strong>single</strong> <strong>space</strong></li>
<li>Master Yoda must <strong>NOT</strong> be printed.</li>
</ul>
</ul>
<h3>Constraints</h3>
<ul>
<li>0 &lt; N &lt; 100 000</li>
<li>All inputs will be <strong>lowercase</strong> characters</li>
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
<p>2</p>
<p>m1 k1 p1 t1 s1</p>
<p>m2 p2</p>
</td>
<td width="306">
<p>t1 s1 m1 m2 k1 p1 p2</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="611">
<tbody>
<tr>
<td width="387">
<p><strong>Input</strong></p>
</td>
<td width="225">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="387">
<p>1</p>
<p>p4 p2 p3 m1 k2 p1 k1 s1 t1 y1</p>
</td>
<td width="225">
<p>m1 k2 k1 s1 t1 p4 p2 p3 p1</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>