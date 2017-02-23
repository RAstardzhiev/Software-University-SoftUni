<p><strong>Problem 3 &ndash; Nether Realms</strong></p>
<p>Mighty battle is coming. In the stormy nether realms, demons are fighting against each other for supremacy in a duel from which only one will survive.</p>
<p>Your job, however is not so exciting. You are assigned to <strong>sign in all the participants</strong> in the nether realm's mighty battle's demon book, which of course is <strong>sorted alphabetically</strong>.</p>
<p>A demon's <strong>name contains his health and his damage</strong>.</p>
<p>The <strong>sum of the asci codes</strong> of <strong>all characters</strong> (excluding numbers (0-9), arithmetic symbols (<strong>'+', '-', '*', '/'</strong>) and delimiter dot (<strong>'.'</strong>)) gives a <strong>demon's total health</strong>.</p>
<p><strong>The sum of all numbers</strong> in his name forms his base damage. Note that you should consider the plus <strong>'+'</strong> and minus <strong>'-'</strong> signs (e.g. <strong>+10 is 10</strong> and <strong>-10 is -10</strong>). However, there are some symbols (<strong>'*'</strong> and <strong>'/'</strong>) that can further <strong>alter the base damage by multiplying or dividing it by 2</strong> (e.g. in the name "m<strong>15</strong>*/c<strong>-5.0</strong>", the base damage is <strong>15 + (-5.0) = 10</strong> and then you need to multiply it by 2 (e.g. 10 * 2 = 20) and then divide it by 2 (e.g. 20 / 2 = 10)).</p>
<p>So, <strong>multiplication and division </strong>are applied<strong> only after all numbers are included </strong>in the calculation and<strong> in the order they appear in the name</strong>.</p>
<p>You will get all demons <strong>on a single line</strong>, separated by commas and zero or more blank spaces. Sort them in <strong>alphabetical order</strong> and print their names <strong>along their health and damage</strong>.</p>
<p><strong>Input</strong></p>
<p>The input will be read from the console. The input consists of a <strong>single line </strong>containing all demon names <strong>separated by commas and zero or more spaces</strong> in the format: <strong>"{demon name}, {demon name}, &hellip; {demon name}"</strong></p>
<p><strong>Output</strong></p>
<p>Print all demons <strong>sorted by their name in ascending order</strong>, each on a separate line in the format:</p>
<ul>
<li><strong>"{demon name} - {health points} health, {damage points} damage"</strong></li>
</ul>
<p><strong>Constraints</strong></p>
<ul>
<li>A demon's name will contain <strong>at least one character</strong></li>
<li>A demon's name <strong>cannot contain</strong> blank spaces ' ' or commas ','</li>
<li>A <strong>floating point number will always have digits before and after its decimal separator</strong></li>
<li><strong>Number</strong> in a demon's name <strong>is considere</strong>d everything that is a valid integer or floating point number (with dot '.' used as separator). For example, all these are valid numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5'</li>
</ul>
<p><strong>Examples</strong></p>
<table width="637">
<tbody>
<tr>
<td width="164">
<p><strong>Input</strong></p>
</td>
<td width="180">
<p><strong>Output</strong></p>
</td>
<td colspan="2" width="293">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="164">
<p>M3ph-0.5s-0.5t0.0**</p>
</td>
<td width="180">
<p>M3ph-0.5s-0.5t0.0** - 524 health, 8.00 damage</p>
</td>
<td colspan="2" width="293">
<p>M3ph-0.5s-0.5t0.0**:</p>
<p>Health = 'M' + 'p' + 'h' + 's' + 't' = 524 health.</p>
<p>Damage = (3 + (-0.5) + (-0.5) + 0.0) * 2 * 2 = 8 damage.</p>
</td>
</tr>
<tr>
<td width="164">
<p><strong>Input</strong></p>
</td>
<td colspan="2" width="246">
<p><strong>Output</strong></p>
</td>
<td width="227">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="164">
<p>M3ph1st0**, Azazel</p>
</td>
<td colspan="2" width="246">
<p>Azazel - 615 health, 0.00 damage</p>
<p>M3ph1st0** - 524 health, 16.00 damage</p>
<p>&nbsp;</p>
</td>
<td width="227">
<p>Azazel:</p>
<p>Health - 'A' + 'z' + 'a' + 'z' + 'e' + 'l' = 615 health. Damage - no digits = 0 damage.</p>
<p>&nbsp;</p>
<p>M3ph1st0**:</p>
<p>Health - 'M' + 'p' + 'h' + 's' + 't' = 524 health.</p>
<p>Damage - (3 + 1 + 0) * 2 * 2 = 16 damage.</p>
</td>
</tr>
<tr>
<td width="164">
<p>Gos/ho</p>
</td>
<td colspan="2" width="246">
<p>Gos/ho - 512 health, 0.00 damage</p>
</td>
<td width="227">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="164">&nbsp;</td>
<td width="180">&nbsp;</td>
<td width="66">&nbsp;</td>
<td width="227">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>