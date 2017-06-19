<h1>Problem 1 &ndash; Second Nature</h1>
<p>Some unknown universal power has given you the idea to create a software program, which oversees the blooming of the legendary Edel flowers. The Edel flowers blooms when their Weiss dust is completely gone. Weiss dust is reduced by watering an Edel flower.</p>
<p>You will be given a <strong>sequence of integers</strong> &ndash; each indicating the Weiss dust in <strong>each flower</strong>. After that you will be given <strong>another sequence of integers</strong>. This time, each indicating &ndash; a bucket and the water in it.</p>
<p>Watering is done by picking <strong>exactly one</strong> bucket at a time. You must start picking from <strong>the last received bucket</strong> and start watering from <strong>the first entered flower</strong>. If the current bucket has <strong>N </strong>water, you <strong>give</strong> the <strong>first entered flower</strong> <strong>N</strong> water, <strong>reducing</strong> its Weiss dust by <strong>N</strong> &ndash; therefore <strong>reducing</strong> its integer value by <strong>N</strong>.</p>
<p>When an Edel flower&rsquo;s <strong>integer value</strong> reaches <strong>0 or less</strong>, it blooms and <strong>gets removed</strong>. It is <strong>possible</strong> that the current flower&rsquo;s value is <strong>greater</strong> than the current bucket&rsquo;s value. <strong>In that case</strong> you <strong>pick buckets</strong> <strong>until</strong> you reduce its integer value to <strong>0 or less</strong>. If a bucket&rsquo;s value is <strong>greater</strong> than the flower&rsquo;s <strong>current</strong> value, you water the flower, and <strong>add the remaining water</strong> to the <strong>next bucket in order</strong>. In case there is no such, keep the remaining water in the same bucket.</p>
<p>If the <strong>current bucket</strong>&rsquo;s value is <strong>equal</strong> to the <strong>current flower</strong>&rsquo;s <strong>current value</strong>, the flower develops a <strong>second nature</strong>. <br /> By doing that, the flower becomes eternally bloomed &ndash; it cannot be affected by water. The bucket however <strong>gets removed</strong>.<br /> The watering is <strong>continued</strong> with the <strong>next flower in order</strong>.</p>
<p>If you <strong>have managed</strong> to <strong>water all the flowers</strong>, print the <strong>remaining water buckets</strong>, from the <strong>last entered</strong> <strong>&ndash; to the first</strong>. <br /> If you <strong>haven&rsquo;t managed</strong> to water <strong>all the flowers</strong> with the given water, you must print the <strong>remaining</strong> <strong>flowers</strong>, by <strong>order of entrance</strong> &ndash; from the <strong>first entered &ndash; to the last</strong>. <br /> In both cases, you must also print the <strong>second nature</strong> flowers, if there are such, by <strong>order of their appearance</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first line</strong> of input you will receive the integers, representing the <strong>flowers</strong>, and the Weiss dust in them &ndash; each with each, <strong>separated</strong> by a <strong>single space</strong>.</li>
<li>On the <strong>second line </strong>of input you will receive the integers, representing the <strong>buckets with water</strong> &ndash; each with each, <strong>separated</strong> by a <strong>single space</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first line of output you must print the remaining water buckets, or the remaining flowers, depending on the case you are in. Just <strong>keep</strong> the <strong>orders of printing</strong> exactly as <strong>specified</strong>.</li>
<li>On the second line of output you must print the second nature flowers, by the order of their appearance.<br /> If there are no second nature flowers, just print <strong>&ldquo;None&rdquo; </strong>on the second line of output.</li>
</ul>
<p>&nbsp;</p>
<h3>Constraints</h3>
<ul>
<li>All of the given numbers will be valid integers in the range [1, 500].</li>
<li>It is safe to assume that there will be <strong>NO</strong> case in which the water is <strong>exactly as much</strong> as the flowers&rsquo; values, so that at the end there are no flowers and no water.</li>
<li>Allowed time/memory: 100ms/16MB.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="679">
<tbody>
<tr>
<td width="103">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="104">
<p><strong><strong>Output</strong></strong></p>
</td>
<td width="472">
<p><strong><strong>Comment</strong></strong></p>
</td>
</tr>
<tr>
<td width="103">
<p><strong>4 2 10 5</strong></p>
<p><strong>3 5 5 11 6</strong></p>
</td>
<td width="104">
<p><strong>9</strong></p>
<p><strong>None</strong></p>
</td>
<td width="472">
<p><strong>We take the first entered flower, and the last entered bucket, as we are told by the description.</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong><strong>6 &ndash; 4 = 2 </strong></strong><strong>&ndash; we have </strong><strong><strong>2</strong></strong><strong> more so we add it to the next bucket in order and it becomes </strong><strong><strong>13</strong></strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong><strong>13 &ndash; 2 = 11</strong></strong><strong> - </strong>again more, so we add it to 5 and it becomes 16</p>
<p>&nbsp;</p>
<p><strong><strong>16 &ndash; 10 = 6 </strong></strong><strong>&ndash; we add it to the next in order </strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong><strong>11 &ndash; 5 = 6</strong></strong><strong> &ndash; adds its value to the last bucket</strong></p>
<p><strong><strong>&nbsp;</strong></strong></p>
<p><strong>We&rsquo;ve managed to water all the flowers so we print what we have, remaining, from the water and the second nature flowers we found, in our case - </strong><strong><strong>None</strong></strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="254">
<tbody>
<tr>
<td width="150">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="104">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="150">
<p><strong>1 5 28 11 4</strong></p>
<p><strong>3 8 1 9 30 4 5</strong></p>
</td>
<td width="104">
<p><strong>8 3</strong></p>
<p><strong>4</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>