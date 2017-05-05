<h1><strong>* Truck Tour</strong></h1>
<p>Suppose there is a circle. There are&nbsp;<strong>N</strong>&nbsp;petrol pumps on that circle. Petrol pumps are numbered&nbsp;0&nbsp;to&nbsp;(N&minus;1)&nbsp;(both inclusive). You have <strong>two pieces of information</strong> corresponding to each of the petrol pump: (1) the <strong>amount of petrol</strong> that particular petrol pump will give, and (2) the <strong>distance from that petrol pump</strong> to the next petrol pump.</p>
<p>Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at <strong>any</strong> of the petrol pumps. Calculate the <strong>first point</strong> from where the truck will be able to complete the circle. Consider that the truck will stop at <strong>each of the petrol pumps</strong>. The truck will move one kilometer for each liter of the petrol.</p>
<p><strong>Input Format: </strong>The first line will contain the value of&nbsp;<strong>N</strong>.<br /> The next&nbsp;<strong>N</strong>&nbsp;lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump.</p>
<p><strong>Output Format: </strong>An integer which will be the smallest index of the petrol pump from which we can start the tour.</p>
<p><strong>Constraints: </strong><br /> 1 &le; N &le; 1000001<br /> 1 &le; Amount of petrol, Distance &le; 1000000000</p>
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
<p>3</p>
<p>1 5</p>
<p>10 3</p>
<p>3 4</p>
</td>
<td width="372">
<p>1</p>
</td>
</tr>
</tbody>
</table>