<h1><strong>Balanced Parentheses</strong></h1>
<p>Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closed parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses:&nbsp;(,&nbsp;{, and&nbsp;[.</p>
<p>{[()]} - This is a balanced parenthesis.</p>
<p>{[(])} - This is not a balanced parenthesis.</p>
<p><strong>Input Format: </strong>Each input consists of a single line,&nbsp;S, the sequence of parentheses.</p>
<p><strong>Constraints:</strong>&nbsp;<br /> 1 &le; len<sub>s </sub>&le; 1000, where&nbsp;len<sub>s</sub>&nbsp;is the length of the sequence.&nbsp;<br /> Each character of the sequence will be one of&nbsp;{, },&nbsp;(,&nbsp;),&nbsp;[,&nbsp;].</p>
<p><strong>Output Format: </strong>For each test case, print on a new line "<em>YES</em>" if the parentheses are balanced. Otherwise, print "<em>NO</em>". Do not print the quotes.</p>
<p><strong>Examples</strong></p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>{[()]}</p>
</td>
<td width="372">
<p>YES</p>
</td>
</tr>
<tr>
<td width="305">
<p>{[(])}</p>
</td>
<td width="372">
<p>NO</p>
</td>
</tr>
<tr>
<td width="305">
<p>{{[[(())]]}}</p>
</td>
<td width="372">
<p>YES</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>