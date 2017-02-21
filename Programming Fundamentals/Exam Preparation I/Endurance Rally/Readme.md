<p><strong>Problem 3 &ndash; Endurance Rally</strong></p>
<p>The goal of the Endurance Rally is, simply, to finish the race.</p>
<p>You are given <strong>the names of the participants</strong>, <strong>the track layout</strong> and <strong>the</strong> <strong>checkpoint </strong>indexes.</p>
<p>The starting fuel of each participant is <strong>equal to the ASCII code</strong> of the <strong>first character</strong> of his name.</p>
<p>Track layout consists of zones represented by numbers, given on a single line separated by a single space. Every number <strong>represents</strong> the <strong>fuel given</strong> or the <strong>fuel taken</strong> by the current zone of the track:</p>
<ul>
<li>If the current zone <strong>is a checkpoint</strong>, the value of the zone is <strong>added</strong> to the driver's <strong>fuel</strong>.</li>
<li>If the current zone <strong>is not a checkpoint</strong>, the value of the zone is <strong>subtracted </strong>from the driver's fuel.</li>
</ul>
<p>Zones are <strong>indexed</strong>. Indexes are sequential and always<strong> start from zero </strong>(like an array).</p>
<p>The <strong>checkpoints</strong> are numbers, representing indexes that show if <strong>a zone of the track</strong> <strong>is a checkpoint</strong>. For example, you are given checkpoints 0, 3 and 5, that means that zones at index 0, 3 and 5 of the track are checkpoints and therefore provide fuel for the driver.</p>
<p>Given this information, you need to <strong>check if a driver can finish</strong> and <strong>print the fuel that he is left with</strong>. If a driver <strong>can't finish</strong> you need to <strong>print the zone he managed to reach</strong>.</p>
<p><strong>Input</strong></p>
<p>The input will be read from the console. The input consists of <strong>exactly three lines</strong>:</p>
<ul>
<li>The first line holds the drivers' names separated by a space:<strong> "{driver 1} {driver 2} &hellip; {driver N}"</strong></li>
<li>On the second line is the track layout (zones) in the form of numbers separated by a space: <strong>"{zone 0} {zone 1} &hellip; {zone N}"</strong></li>
<li>On the third line are the checkpoint indexes also separated by a space:<strong> "{index 0} {index 1} &hellip; {index N}"</strong></li>
</ul>
<p><strong>Output</strong></p>
<p>Print all drivers <strong>in the order of their appearance</strong>, each on a separate line:</p>
<ul>
<li>If the driver finished, print his name and fuel left to the second digit after the decimal point in the format:<strong> "{driver name} - fuel left {fuel points}"</strong></li>
<li>If the driver could not finish, print:<strong> "{driver name} - reached {zone index}"</strong></li>
</ul>
<p><strong>Constrains</strong></p>
<ul>
<li>Drivers count will be in the range [0 &hellip; 200]</li>
<li>Zone fuel will be a floating-point number</li>
<li>Checkpoints will be integers in the range [-2<sup>31</sup> &hellip; 2<sup>31 </sup>- 1]</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p><strong>Examples</strong></p>
<table width="637">
<tbody>
<tr>
<td width="193">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
<td width="246">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="193">
<p>Garry Clark</p>
<p>69 <strong>1</strong> <strong>15</strong> 5</p>
<p>1 2</p>
</td>
<td width="198">
<p>Garry - fuel left 13.00</p>
<p>Clark - reached 0</p>
</td>
<td width="246">
<p>Zones 1 and 2 -&gt; checkpoints.</p>
<p>&nbsp;</p>
<p>Garry ('G' = 71)</p>
<p>-&gt; 71 - 69 + 1 + 15 - 5 = 13.00</p>
<p>Garry finished with 13 fuel</p>
<p>&nbsp;</p>
<p>Clark ('C' = 67)</p>
<p>-&gt; 67 - 69 = -2</p>
<p>Clark reached 0</p>
</td>
</tr>
<tr>
<td width="193">
<p>Garry Clark Larry</p>
<p><strong>4</strong> 5 12 <strong>0</strong> 8 <strong>7</strong> 13 22 <strong>5.5</strong> 26</p>
<p>0 3 5 8</p>
</td>
<td width="198">
<p>Garry - fuel left 1.50</p>
<p>Clark - reached 9</p>
<p>Larry - fuel left 6.50</p>
</td>
<td width="246">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="193">
<p>Garry</p>
<p>-29 <strong>-5.0</strong> <strong>-5.0</strong></p>
<p>1 2</p>
</td>
<td width="198">
<p>Garry - fuel left 90.00</p>
</td>
<td width="246">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>