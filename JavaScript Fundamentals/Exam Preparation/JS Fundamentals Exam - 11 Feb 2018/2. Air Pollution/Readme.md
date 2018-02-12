<h1>Problem 2 &ndash; Air Pollution</h1>
<p><em>Because of recent events you have become very conscious of the air quality in Sofia. That&rsquo;s why you decided to keep track of the air pollution levels by making a map. Each block of the map displays a number that represents the current particle pollution in the air at this moment. There are different forces which affect the air quality in various ways. So how clean is the air in Sofia now?</em></p>
<p>Write a JavaScript program that tracks the<strong> pollution</strong> <strong>in the air</strong> above Sofia. You will receive <strong>two arguments</strong> &ndash; the <strong>first</strong> is the <strong>map of Sofia</strong> represented by a <strong>matrix of numbers</strong> and the second is an <strong>array of strings</strong> representing the <strong>forces</strong> <strong>affecting</strong> the <strong>air quality</strong>. The <strong>map</strong> will <strong>always</strong> be with <strong>5 rows</strong> and <strong>5 columns</strong> in <strong>total</strong> <strong>of</strong> <strong>25 elements - blocks</strong>. Each block&rsquo;s particle pollution (PM) is <strong>affected</strong> by <strong>3 forces </strong>received in the following formats<strong>:</strong></p>
<ul>
<li><strong>"</strong><strong>breeze {index}"</strong><strong> &ndash;</strong> index is <strong>the row </strong>where <strong>all column&rsquo;s value drops </strong>by <strong>15 </strong>PM</li>
<li><strong>"</strong><strong>gale {index}"</strong><strong> &ndash; </strong>index is <strong>the column in all rows </strong>where <strong>value drops </strong>by <strong>20 </strong>PM</li>
<li><strong>"</strong><strong>smog {value}"</strong><strong> &ndash; all</strong> <strong>blocks </strong>in the map <strong>increase</strong> equally by <strong>the given value&rsquo;s </strong>PM</li>
</ul>
<p>The threshold in each block is <strong>50 </strong>PM. If it is <strong>below</strong> <strong>that number</strong>, the block&rsquo;s air is considered <strong>normal</strong> but if it <strong>reaches or goes over it,</strong> that block&rsquo;s air is considered <strong>polluted</strong>. Also note, that the <strong>polluted particles</strong> in a block <strong>cannot go below</strong> <strong>zero</strong>.</p>
<p>Finally, your program needs to <strong>find</strong> if there are <strong>any polluted blocks</strong> and <strong>print them </strong>in the format given below.</p>
<h3>Input</h3>
<p>You will receive <strong>two</strong> <strong>arguments</strong>:</p>
<ul>
<li>The<strong> first</strong> argument is an <strong>array with five strings</strong> &ndash; <strong>rows</strong> of the matrix with <strong>columns separated by space </strong>that must be parsed as <strong>numbers</strong>, representing the <strong>map of Sofia</strong>.</li>
<li>The <strong>second</strong> argument is an <strong>array of strings</strong> &ndash; each <strong>string</strong> consists of one of the <strong>words (breeze/gale/smog)</strong> and a <strong>number</strong> <strong>separated by space</strong>, representing the <strong>different forces</strong>.</li>
</ul>
<h3>Output</h3>
<p>Print on the <strong>console</strong><strong> a </strong><strong>single line</strong>:</p>
<ul>
<li>If there are <strong>polluted blocks</strong> in the map, <strong>use</strong> their <strong>coordinates</strong> in the following format:</li>
<li><strong>"[{rowIndex}-{columnIndex}]"</strong></li>
</ul>
<p>Note that you must <strong>start</strong> from the <strong>top left corner</strong> of the map moving to the <strong>bottom right corner</strong> <strong>horizontally</strong>. Then <strong>separate</strong> each <strong>formatted block&rsquo;s coordinates</strong> with <strong>comma and space</strong> and print them in a single line in the following format:</p>
<ul>
<li><strong>"Polluted areas: {block1}, {block2}, {block3}, &hellip;"</strong></li>
<li>If there are <strong>no polluted blocks</strong> in the map print:</li>
<li><strong>"No polluted areas"</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The <strong>number</strong> of <strong>rows</strong> and <strong>columns</strong> for the <strong>matrix </strong>will<strong> always </strong>be <strong>5</strong></li>
<li>The <strong>number</strong> in each block will be an <strong>integer</strong> in range <strong>[0..1000] inclusive</strong></li>
<li>The <strong>number</strong> of <strong>elements</strong> in the <strong>second input argument</strong> will be in range <strong>[0..100] inclusive</strong></li>
<li>Given <strong>smog&rsquo;s</strong> <strong>value </strong>will be an <strong>integer </strong>in range <strong>[0..100] inclusive</strong></li>
<li>Given <strong>indexes</strong> will <strong>always</strong> be <strong>valid</strong></li>
</ul>
<h3>Examples</h3>
<table width="697">
<tbody>
<tr>
<td width="282">
<p><strong>Input</strong></p>
</td>
<td width="416">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="282">
<p>[</p>
<p>&nbsp; "5 7 72 14 4",</p>
<p>&nbsp; "41 35 37 27 33",</p>
<p>&nbsp; "23 16 27 42 12",</p>
<p>&nbsp; "2 20 28 39 14",</p>
<p>&nbsp; "16 34 31 10 24",</p>
<p>],</p>
<p>["breeze 1", "gale 2", "smog 25"]</p>
</td>
<td width="416">
<p>Polluted areas: [0-2], [1-0], [2-3], [3-3], [4-1]</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h3>Explanation</h3>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>input</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>breeze 1 (-15)</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>gale 2 (-20)</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>smog 25 (+25)</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>polluted areas</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Graphic diagram explaining the <strong>first example&rsquo;s </strong>program flow:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;</p>
<table width="697">
<tbody>
<tr>
<td width="282">
<p><strong>Input</strong></p>
</td>
<td width="416">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="282">
<p>[</p>
<p>&nbsp; "5 7 3 28 32",</p>
<p>&nbsp; "41 12 49 30 33",</p>
<p>&nbsp; "3 16 20 42 12",</p>
<p>&nbsp; "2 20 10 39 14",</p>
<p>&nbsp; "7 34 4 27 24",</p>
<p>],</p>
<p>[</p>
<p>&nbsp; "smog 11", "gale 3",</p>
<p>&nbsp; "breeze 1", "smog 2"</p>
<p>]</p>
</td>
<td width="416">
<p>No polluted areas</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="697">
<tbody>
<tr>
<td width="282">
<p><strong>Input</strong></p>
</td>
<td width="416">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="282">
<p>[</p>
<p>&nbsp; "5 7 2 14 4",</p>
<p>&nbsp; "21 14 2 5 3",</p>
<p>&nbsp; "3 16 7 42 12",</p>
<p>&nbsp; "2 20 8 39 14",</p>
<p>&nbsp; "7 34 1 10 24",</p>
<p>],</p>
<p>["breeze 1", "gale 2", "smog 35"]</p>
</td>
<td width="416">
<p>Polluted areas: [2-1], [2-3], [3-1], [3-3], [4-1], [4-4]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>