<h1>Problem 4 &ndash; Ashes of Roses</h1>
<p>The time has come for the great Rosen Flame Festival. Million Roses must be prepared for the reincarnation of the Icarus, The Great Phoenix God. Different regions that participate in the Festival will grow roses for Icarus to burn, upon resurrecting. You are asked to create a software program which oversees that process.</p>
<p>Regions can <strong>grow</strong> a <strong>specific amount</strong> of <strong>specifically colored</strong> roses.</p>
<p>The <strong>valid input</strong> will come in the following format:</p>
<ul>
<li><strong>Grow &lt;{regionName}&gt; &lt;{colorName}&gt; {roseAmount}</strong> &ndash; grows the given amount of the given color roses in the given region.</li>
</ul>
<p>The <strong>region names</strong> must always <strong>start</strong> with a <strong>capital</strong> <strong>English alphabet letter</strong>, and <strong>consist </strong>only of <strong>lowercase</strong> letters. The <strong>color&rsquo;s name</strong> must consist only of <strong>English alphabet letters</strong> and <strong>digits</strong>. The <strong>rose amount</strong> must be an <strong>integer</strong>. <br /> Any input that <strong>does NOT</strong> <strong>follow </strong>the, specified above, rules is to be treated as <strong>invalid</strong>, and must be <strong>ignored</strong>.</p>
<p>If you receive an input with <strong>existent</strong> region, you should <strong>add</strong> the new color and roses to it. If even <strong>the</strong> <strong>color exists, increase</strong> their <strong>current value</strong> with the<strong> given one</strong>.</p>
<p>The input ends when you receive the command <strong>&ldquo;Icarus, Ignite!&rdquo;</strong>. That means that the Festival is ready to begin, and the roses are all ready and set. You must <strong>print all the regions</strong> and their roses, but in a <strong>specific order</strong>.</p>
<p>Regions must be <strong>ordered by amount</strong> of roses they have, in <strong>descending order</strong>, as prime criteria and in <strong>alphabetical order</strong>, as secondary criteria. Their colors must be <strong>ordered by amount of roses</strong>, in <strong>ascending order</strong>, as prime criteria and in <strong>alphabetical order</strong>, as secondary criteria.</p>
<h3>Input</h3>
<ul>
<li>The input will consist only of the commands specified above.</li>
<li>The input ends when you receive the command <strong>&ldquo;Icarus, Ignite!&rdquo;</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print information about each region and its roses in the specified order.</li>
<li>The format of output is:
<ul>
<li><strong>&ldquo;{region1Name}</strong></li>
<li><strong>*--{color1Name} | {roseCount}</strong></li>
<li><strong>*--{color2Name} | {roseCount}</strong></li>
<li><strong>&hellip;&rdquo;</strong></li>
</ul>
</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input lines can consist of any ASCII character. You must find only the valid ones.</li>
<li>The input count of roses will be a valid integer in range [0, 2<sup>31 </sup>&ndash; 1].</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="670">
<tbody>
<tr>
<td width="339">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="331">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="339">
<p><strong>Grow &lt;Dorne&gt; &lt;Indigo&gt; 2000</strong></p>
<p><strong>Grow &lt;Dorne&gt; &lt;Purple&gt; 5000</strong></p>
<p><strong>Grow &lt;Dorne&gt; &lt;Purple&gt; 1000</strong></p>
<p><strong>Grow &lt;Ironislands&gt; &lt;Blue&gt; 20000</strong></p>
<p><strong>Grow &lt;North&gt; &lt;Scarlet&gt; 1000000</strong></p>
<p><strong>Icarus, Ignite!</strong></p>
</td>
<td width="331">
<p><strong>North</strong></p>
<p><strong>*--Scarlet | 1000000</strong></p>
<p><strong>Ironislands</strong></p>
<p><strong>*--Blue | 20000</strong></p>
<p><strong>Dorne</strong></p>
<p><strong>*--Indigo | 2000</strong></p>
<p><strong>*--Purple | 6000</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="670">
<tbody>
<tr>
<td width="339">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="331">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="339">
<p><strong>Grow &lt;Valeofarryn&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;Stormlands&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;TheGift&gt; &lt;White&gt; 1</strong></p>
<p><strong>Grow&nbsp;&nbsp;&nbsp;&nbsp; &lt;Yiti&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;White&gt; 1</strong></p>
<p><strong>Grow &lt;Valeofarryn&gt; &lt;Blue&gt; 1</strong></p>
<p><strong>Grow &lt;Stormlands&gt; &lt;Green&gt; 1</strong></p>
<p><strong>Icarus, Ignite!</strong></p>
</td>
<td width="331">
<p><strong>Stormlands</strong></p>
<p><strong>*--Green | 1</strong></p>
<p><strong>*--White | 1</strong></p>
<p><strong>Valeofarryn</strong></p>
<p><strong>*--Blue | 1</strong></p>
<p><strong>*--White | 1</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>