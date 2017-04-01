<h2>Refactor Volume of Pyramid</h2>
<p>You are given a <strong>working code</strong> that finds the <strong>volume of a pyramid</strong>. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that <strong>have multiple purpose</strong>.</p>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<h3>Code</h3>
<table width="437">
<tbody>
<tr>
<td width="437">
<p><strong>Sample Code</strong></p>
</td>
</tr>
<tr>
<td width="437">
<p>double dul, sh, V = 0;</p>
<p>Console.Write("Length: ");</p>
<p>dul = double.Parse(Console.ReadLine());</p>
<p>Console.Write("Width: ");</p>
<p>sh = double.Parse(Console.ReadLine());</p>
<p>Console.Write("Heigth: ");</p>
<p>V = double.Parse(Console.ReadLine());</p>
<p>V = (dul + sh + V) / 3;</p>
<p>Console.WriteLine("Pyramid Volume: {0:F2}", V);</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Reduce the span</strong> of the variables by declaring them in the moment they receive a value, not before</li>
<li>Rename your variables to <strong>represent their </strong>real <strong>purpose</strong> (example: "dul" should become length, etc.)</li>
<li>Search for variables that have multiple purpose. If you find any,<strong> introduce a new variable</strong>.</li>
</ul>