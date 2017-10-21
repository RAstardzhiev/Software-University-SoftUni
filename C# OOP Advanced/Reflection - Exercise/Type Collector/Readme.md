<h3 style="text-align: center;">Returns an Array of all types which&nbsp;inherit the given abstraction.</h3>
<p>&nbsp;</p>
<p style="text-align: left;">How to use it - Example:&nbsp;</p>
<table style="height: 142px; margin-left: auto; margin-right: auto;" width="1004">
<tbody>
<tr>
<td style="width: 976px; padding: 10px;">
<p>TypeCollector&nbsp;tc&nbsp;= new&nbsp;TypeCollector();</p>
<p>var allObjectsInheritingTheInterface = tc .GetAllInheritingTypes&lt;Interface&gt;();</p>
<p>var allObjectsInheritingTheAbstractClass =&nbsp;tc .GetAllInheritingTypes&lt;AbstractClass&gt;();</p>
</td>
</tr>
</tbody>
</table>