<h1>Problem 2 &ndash;Nature&rsquo;s Prophet</h1>
<p>Furion loves nature and that is why he has a beautiful square garden. He wants to plant it with magical flowers, so it can be even more beautiful. No one knows why, but he actually needs a software program to do that, that is why you&rsquo;ll write one for him.</p>
<p>You will be given <strong>N</strong> and <strong>M</strong> &ndash; <strong>integers</strong>, indicating the <strong>dimensions </strong>of the <strong>square garden</strong>. The garden is <strong>empty at the beginning</strong> &ndash; it has no flowers. Furion wants every place for a flower to be presented with a <strong>zero (0)</strong> when it is <strong>empty</strong>. After you&rsquo;ve finished creating the garden, you will start receiving two integers &ndash; <strong>Row</strong> and <strong>Column</strong>, <strong>separated</strong> by a <strong>single space</strong> &ndash; which represent the <strong>position</strong> at which Furion <strong>currently plants a flower</strong>. This happens until you receive the command <strong>&ldquo;Bloom Bloom Plow&rdquo;</strong>. When you receive that input, <strong>all planted flowers</strong> should <strong>bloom</strong>.</p>
<p>The flowers are <strong>magical</strong>. When a flower <strong>blooms</strong> it instantly <strong>blooms flowers</strong> to <strong>all places</strong> to its <strong>left</strong>, <strong>right</strong>, <strong>up</strong>, and <strong>down</strong>, <strong>increasing</strong> their <strong>value</strong> with <strong>1</strong>. Flowers can bloom <strong>multiple times</strong>, and <strong>each time</strong> the flower blooms &ndash; it becomes more and more beautiful, which means its <strong>value increases</strong>. The blooming of flowers is done from the <strong>top-left</strong> corner of the garden to the <strong>bottom-right</strong> one.</p>
<p><strong>Note</strong>: If one flower blooms and affects several places, and then another flower blooms and affects one of the <strong>first flower&rsquo;s affected places</strong>, it does <strong>NOT</strong> override their values with 1 again. Instead it blooms them one more time &ndash; <strong>increasing</strong> their value with <strong>1</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first line of input you will receive two integers, separated by a single space &ndash; indicating the dimensions of the garden.</li>
<li>On the next several lines you will be receiving two integers separated by a single space &ndash; indicating the position at which Furion currently plants a flower.</li>
<li>When you receive the input line <strong>&ldquo;Bloom Bloom Plow&rdquo; </strong>the input sequence should end.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. Print the whole garden &ndash; each row of it on a new line, and each column &ndash; separated by a <strong>single space</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the matrix (<strong>N</strong> and <strong>M</strong>) will be integers in the range [3, 500].</li>
<li>The integers received as position of planting a flower will <strong>always</strong> be inside the matrix.</li>
<li>The amount of input commands will be in the range [0, <strong>N * M</strong>].</li>
<li>Flowers will <strong>always</strong> be planted on <strong>empty</strong></li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="689">
<tbody>
<tr>
<td width="150">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="123">
<p><strong><strong>Output</strong></strong></p>
</td>
<td width="416">
<p><strong><strong>Comment</strong></strong></p>
</td>
</tr>
<tr>
<td width="150">
<p><strong>5 5</strong></p>
<p><strong>1 1</strong></p>
<p><strong>3 3</strong></p>
<p><strong>Bloom Bloom Plow</strong></p>
</td>
<td width="123">
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 1 1 2 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 2 1 1 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
</td>
<td width="416">
<p><strong>The garden has 5 rows and 5 columns.</strong></p>
<p><strong>They are all </strong><strong><strong>0</strong></strong><strong> at the beginning.</strong></p>
<p><strong>The planted flowers are at [1, 1] and [3, 3].</strong></p>
<p><strong>The affected places are:</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>0 0 0 0 0</strong></p>
<p><strong>We receive the blooming command and we bloom the flowers from top-left to bottom-right corner of the garden.</strong></p>
<p><strong>First we reach the first flower, and we bloom it, increasing all affected fields&rsquo; value with 1.</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>1 1 1 1 1</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>0 1 0 0 0</strong></p>
<p><strong>Then we bloom the second flower, and we increase all affected fields&rsquo; (even those from the first flower) value with 1.</strong></p>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 1 1 </strong><strong>2</strong><strong> 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
<p><strong>1 2 1 1 1</strong></p>
<p><strong>0 1 0 1 0</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="273">
<tbody>
<tr>
<td width="150">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="123">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="150">
<p><strong>4 4</strong></p>
<p><strong>0 0</strong></p>
<p><strong>3 3</strong></p>
<p><strong>1 1</strong></p>
<p><strong>2 2</strong></p>
<p><strong>Bloom Bloom Plow</strong></p>
</td>
<td width="123">
<p><strong>1 </strong><strong>2 </strong><strong>2 </strong><strong>2</strong></p>
<p><strong>2 1 2 2</strong></p>
<p><strong>2 2 1 2</strong></p>
<p><strong>2 2 2 1</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>