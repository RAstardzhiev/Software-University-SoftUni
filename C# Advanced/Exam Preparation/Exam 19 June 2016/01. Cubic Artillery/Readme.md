<h1>Problem 1 &ndash; Cubic Artillery</h1>
<p>Cubic has taken charge of creating places where the, the weapons, armor and basically all the resources for the Cubic army, can be stored. He is creating massive bunkers which are capable of storing weapons. However every weapon has a different capacity, and the bunkers can only take up to a specified total capacity. That is why you have taken the task of supervising and managing the process.</p>
<p>You will be given <strong>n</strong> &ndash; an integer specifying the <strong>bunkers&rsquo; maximum capacity</strong>. Then you will be given input lines which will contain <strong>English alphabet letters</strong> and <strong>numbers</strong>, separated by a <strong>single space</strong>. The <strong>letters</strong> represent the <strong>bunkers</strong> and the <strong>numbers</strong> &ndash; the <strong>weapons</strong> and their <strong>capacity</strong>. Weapons must be <strong>stored</strong> in the bunkers. The <strong>first entered</strong> bunker is the <strong>first in which weapons are getting stored</strong>. Every weapon takes <strong>specific capacity</strong>, equal to its number.</p>
<p>When a bunker <strong>overflows</strong> (it <strong>cannot contain</strong> a given weapon due to lack of enough <strong>free capacity)</strong>, it passes the weapon to the <strong>next entered bunker</strong>. If the <strong>next bunker cannot contain</strong> the weapon, it passes it to the next-next, and so on till the <strong>last entered bunker</strong>. If there is <strong>no bunker</strong> that <strong>can hold</strong> the given weapon, <strong>ignore</strong> that weapon.</p>
<p>If there are <strong>no other bunkers</strong> besides the current one, you must check if current weapon can actually be contained (its <strong>needed capacity</strong> is <strong>less than</strong> the <strong>maximum capacity specified for the bunkers</strong>). If the weapon <strong>can be contained</strong>, you must <strong>make enough free capacity</strong> to hold that weapon, <strong>if there isn&rsquo;t already</strong>. That is done by <strong>removing weapons</strong>, starting from <strong>the first entered</strong>, till the last. If the weapon <strong>cannot be</strong> contained, <strong>ignore</strong> the weapon.</p>
<p>If a bunker overflows you must <strong>remove it</strong>, and print it on the console, along with all of the weapons it <strong>currently contains</strong>. If there are no weapons, just print &ldquo;<strong>Empty</strong>&rdquo;. After you&rsquo;ve removed that bunker, <strong>the next one</strong> becomes the <strong>first in the order</strong> &ndash; weapons will <strong>first be passed to it</strong>. If there are <strong>no other bunkers</strong>, you must <strong>NOT</strong> remove the one that overflowed.</p>
<p>The input sequence <strong>ends</strong> when you receive the command &ldquo;<strong>Bunker Revision</strong>&rdquo;.</p>
<h3>Input</h3>
<ul>
<li>The input will come in lines of letters and digits separated by a space.</li>
<li>The input ends when you receive the command &ldquo;<strong>Bunker Revision</strong>&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>For output, you must print a bunker, every time it overflows, after removing it.</li>
<li>The format is the following: <strong>{bunker}</strong> <strong>-&gt; {weapon1}, {weapossn2}&hellip;</strong></li>
<li>Where {bunker} is the letter that corresponds to that bunker, and the weapons are the numbers.</li>
<li>In case a bunker has no weapons, just print &ldquo;<strong>Empty</strong>&rdquo;.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The bunkers will only be English alphabet letters.</li>
<li>Each bunker&rsquo;s letter will always be unique.</li>
<li>The integer n will be In the range [0, 500].</li>
<li>The weapons will always be valid integers in the range [0, 500].</li>
<li>Allowed time/memory: 100ms/16MB.</li>
</ul>
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
<p><strong>60</strong></p>
<p><strong>a 20 20 b 20 1</strong></p>
<p><strong>Bunker Revision</strong></p>
</td>
<td width="294">
<p><strong>a -&gt; 20, 20, 20</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="599">
<p><strong><strong>Comment</strong></strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="599">
<p><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> is the first entered bunker. Then we receive the weapons </strong><strong><strong>20</strong></strong><strong> and </strong><strong><strong>20</strong></strong><strong> which are passed to </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong>. Then we get the bunker </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong>.</strong> <strong>Then again we receive a weapon </strong><strong><strong>20</strong></strong><strong>. </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> still has enough capacity to hold the weapon so we store it there. Then we get the weapon </strong><strong><strong>1</strong></strong><strong>. </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> has capacity </strong><strong><strong>60/60</strong></strong><strong> &ndash; it overflows, so we pass the weapon to the next bunker. We find </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong> and we pass the weapon to </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong>. </strong><strong><strong>&ldquo;a&rdquo;</strong></strong><strong> is then removed and printed on the console. </strong><strong><strong>&ldquo;b&rdquo;</strong></strong><strong> becomes the first bunker now.</strong></p>
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
<p><strong>50</strong></p>
<p><strong>b 10 15 20 30</strong></p>
<p><strong>c 100</strong></p>
<p><strong>a 65</strong></p>
<p><strong>Bunker Revision</strong></p>
</td>
<td width="294">
<p><strong>b -&gt; 20, 30</strong></p>
<p><strong>c -&gt; Empty</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>