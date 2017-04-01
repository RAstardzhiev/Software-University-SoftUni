<h2>Refactor Special Numbers</h2>
<p>You are given a <strong>working code</strong> that is a solution to <strong>Problem 5. Special Numbers</strong>. However, the variables are <strong>improperly named, declared before</strong> they are needed and some of them are used for multiple things. Without using your previous solution, <strong>modify the code</strong> so that it is <strong>easy to read and understand</strong>.</p>
<h3>Code</h3>
<table width="685">
<tbody>
<tr>
<td width="685">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="685">
<p>int kolkko = int.Parse(Console.ReadLine());</p>
<p>int obshto = 0; int takova = 0; bool toe = false;</p>
<p>for (int ch = 1; ch &lt;= kolkko; ch++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; takova = ch;</p>
<p>&nbsp;&nbsp;&nbsp; while (ch &gt; 0)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;obshto += ch % 10;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ch = ch / 10;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; toe = (obshto == 5) || (obshto == 7) || (obshto == 11);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine($"{takova} -&gt; {toe}");</p>
<p>&nbsp;&nbsp;&nbsp; obshto = 0;</p>
<p>&nbsp;&nbsp;&nbsp; ch = takova;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Reduce the span of the variables by declaring them in the moment they receive a value, not before</li>
<li>Rename your variables to represent their real purpose (example: "dul" should become length, etc.)</li>
<li>Search for variables that have multiple purpose. If you find any, introduce a new variable</li>
</ul>