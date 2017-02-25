<h1>Problem 1 &ndash; Sweet Dessert</h1>
<p>Ivancho and his girlfriend are <strong>throwing a party</strong>. She plans <strong>to cook her favorite dessert</strong>. She asks Ivancho to <strong>buy</strong> the <strong>needed products</strong>. The <strong>number of desserts</strong> depends on <strong>how many people will be coming</strong>. She can prepare the dessert <strong>in portions of 6</strong>. If there are <strong>5 guests</strong> coming, she will still <strong>cook 6 portions,</strong> <strong>10 guests &ndash; cook 12</strong>. The products for the dessert are <strong>bananas, eggs and berries</strong>. For <strong>a set of 6</strong> she needs <strong>2 bananas, 4 eggs and 0.2 kilos berries</strong>.</p>
<p>You will be given <strong>the amount of money Ivancho has</strong>, the <strong>number of guests </strong>and the <strong>prices of the products</strong>. You have to help Ivancho <strong>calculate</strong> if the <strong>cash</strong> he has is <strong>enough to buy all of the products</strong>, or how much more money he needs.</p>
<h3>Input</h3>
<p>The input data should be read from the console. It will consist of <strong>exactly 5 lines</strong>:</p>
<ul>
<li>The <strong>amount of cash</strong> Ivancho has &ndash; <strong>floating-point number</strong> in <strong>range [0.0</strong><strong>0&hellip;1,000,000,000.00]</strong></li>
<li>The <strong>number of guests &ndash; integer in range [0&hellip;1,000,000,000]</strong></li>
<li>The <strong>price of bananas</strong> for a <strong>single unit &ndash; floating-point number</strong> in <strong>range [0.</strong><strong>00&hellip;1,000.00]</strong></li>
<li>The <strong>price of eggs</strong> for a <strong>single unit &ndash; floating-point number</strong> in <strong>range [0.</strong><strong>00&hellip;1,000.00]</strong></li>
<li>The <strong>price of berries</strong> for a <strong>kilo &ndash; floating-point number</strong> in <strong>range [0.0</strong><strong>0&hellip;1,000.00]</strong></li>
</ul>
<p>The <strong>input data will always be valid</strong> and in the format described. <strong>There is no need to check it explicitly</strong>.</p>
<h3>Output</h3>
<p>The output should be printed on the console.</p>
<ul>
<li><strong>If the calculated price of the products is less or equal to the money Ivancho has:</strong>
<ul>
<li>&ldquo;Ivancho has enough money - it would cost {the cost of the products}lv.&rdquo;</li>
</ul>
</li>
<li><strong>If the calculated price of the products is more than the money Ivancho has:</strong>
<ul>
<li>&ldquo;Ivancho will have to withdraw money - he will need {neededMoney}lv more.&rdquo;</li>
</ul>
</li>
<li><strong>All prices</strong> must be <strong>rounded to two digits after the decimal point.</strong></li>
</ul>
<h3>Examples</h3>
<table width="702">
<tbody>
<tr>
<td width="50">
<p><strong>Input</strong></p>
</td>
<td width="304">
<p><strong>Output</strong></p>
</td>
<td width="348">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>10</p>
<p>12</p>
<p>0.35</p>
<p>0.20</p>
<p>4.50</p>
</td>
<td width="304">
<p>Ivancho has enough money - it would cost 4.80lv.</p>
</td>
<td width="348">
<p>For 12 guests &ndash; 2 sets of 6 portions</p>
<p>Needed product:</p>
<p>2*(2 bananas), 2*(4 eggs), 2*(0.2 kilos berries)</p>
<p>2*(2*0.35) + 2*(4*0.20) + 2*(0.2*4.50) = 4.80</p>
<p>4.80 &lt;= 10 &ndash; the money will be enough.</p>
</td>
</tr>
<tr>
<td width="50">
<p><strong>Input</strong></p>
</td>
<td width="304">
<p><strong>Output</strong></p>
</td>
<td width="348">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>20</p>
<p>33</p>
<p>0.60</p>
<p>0.50</p>
<p>10</p>
</td>
<td width="304">
<p>Ivancho will have to withdraw money - he will need 11.20lv more.</p>
</td>
<td width="348">
<p>For 33 guests &ndash; 6 sets of 6 portions</p>
<p>Needed product:</p>
<p>6*(2 bananas), 6*(4 eggs), 6*(0.2 kilos berries)</p>
<p>6*(2*0.60) + 6*(4*0.50) + 6*(0.2*10.00) = 31.20</p>
<p>31.20 &gt; 20 &ndash; need 11.20 lv. more.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>