<h2>Fast Prime Checker - Refactor</h2>
<p>You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} is prime -&gt; {True or False}". The code however, is not very well written. Your job is to modify it in a way that is <strong>easy to read and understand.</strong></p>
<h3>Code</h3>
<table width="673">
<tbody>
<tr>
<td width="673">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="673">
<p>int ___Do___ = int.Parse(Console.ReadLine());</p>
<p>for (int DAVIDIM = 0; DAVIDIM &lt;= ___Do___; DAVIDIM++)</p>
<p>{&nbsp;&nbsp;&nbsp; bool TowaLIE = true;</p>
<p>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;for (int delio = 2; delio &lt;= Math.Sqrt(DAVIDIM); delio++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;if &nbsp;(DAVIDIM % delio == 0)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;TowaLIE = false;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; break;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine($"{DAVIDIM} is prime -&gt; {TowaLIE}");</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="247">
<tbody>
<tr>
<td width="96">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="96">
<p>5</p>
</td>
<td width="151">
<p>2 -&gt; True</p>
<p>3 -&gt; True</p>
<p>4 -&gt; False</p>
<p>5 -&gt; True</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Search how to check if a number is prime</li>
<li>Rename all variables such as to be clear what is their role in the algorithm</li>
</ul>