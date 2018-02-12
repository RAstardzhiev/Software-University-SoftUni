<h1>Problem 1 &ndash; Bitcoin "Mining"</h1>
<p><em>So you have heard that a lot of people are using Bitcoins as alternative currency and mining them can make you rich quickly, without doing </em><em>anything. Because of this you decided to become a miner at the local mine and start digging Bitcoins out of the ground. Well, after a few days you realized that there are no burried Bitcoins in the ground... But luckily, you started digging up gold and decided to invest it in Bitcoins, because they are cool and gold sucks. So you started exchanging gold for BGN and buying Bitcoins with the money, and keeping track of the whole process. How many Bitcoins did you buy and how much money were you left with it at the end?</em></p>
<p>Write a JavaScript program that calculates the <strong>total amount</strong> of <strong>bitcoins</strong> you purchased with the gold you mined during your <strong>shift </strong>at the mine. Your shift consists of a certain number of days where you mine an amount of <strong>gold</strong> in <strong>grams</strong>. Your program will receive an <strong>array with the amount of gold </strong>you mined <strong>each day</strong>, where the <strong>first day</strong> of your <strong>shift</strong> is the <strong>first index of the array</strong>. Also, someone was stealing <strong>every third day</strong> from the start of your shift <strong>30%</strong> from the mined <strong>gold</strong> for <strong>this day</strong>. For the different exchanges use these <strong>prices</strong>:</p>
<table>
<tbody>
<tr>
<td width="116">
<p><strong>1 Bitcoin</strong></p>
</td>
<td width="95">
<p>11949.16 lv.</p>
</td>
</tr>
<tr>
<td width="116">
<p><strong>1 g of gold</strong></p>
</td>
<td width="95">
<p>67.51 lv.</p>
</td>
</tr>
</tbody>
</table>
<h3>Input</h3>
<p>You will receive an array of <strong>strings</strong> that must be parsed as <strong>numbers</strong>, representing your <strong>shift </strong>at the mine.</p>
<h3>Output</h3>
<p>Print on the <strong>console these lines in the following formats</strong>:</p>
<ul>
<li><strong>First line</strong> prints the <strong>total</strong> <strong>amount </strong>of bought <strong>bitcoins</strong>:</li>
</ul>
<p>&nbsp;"<strong>Bought Bitcoins: {count}</strong>"</p>
<ul>
<li><strong>Second line</strong> prints <strong>witch day</strong> you <strong>bought</strong> your <strong>first bitcoin</strong>:</li>
</ul>
<p>&nbsp;"<strong>Day of the first purchased bitcoin: {day}</strong>"</p>
<p>In case you <strong>did not</strong> <strong>purchased any bitcoins,</strong> do not print the second line.</p>
<ul>
<li><strong>Third line</strong> prints the <strong>amount</strong> of <strong>money</strong> that&rsquo;s left after the bitcoin purchases <strong>rounded by the second digit</strong> after the decimal point:</li>
</ul>
<p>&nbsp;"<strong>Left money: {money} lv.</strong>"</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>input</strong> array may contain up to <strong>1,000</strong> elements</li>
<li>The numbers in the array are in range <strong>[0.01..5,000.00] inclusive</strong></li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<h3>&nbsp;Examples</h3>
<table width="490">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="350">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>100, 200, 300</p>
</td>
<td width="350">
<p>Bought Bitcoins: 2</p>
<p>Day of the first purchased bitcoin: 2</p>
<p>Left money: 10531.78 lv.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Scroll down to see the explanation for the first example and more examples.</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Day 1</strong> &ndash; you dig up <strong>100 g</strong> of gold then exchange it for <strong>6751.00 lv.</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Day 2 </strong>&ndash; you dig up <strong>200 g</strong> of gold then exchange it for <strong>13,502.00 lv. </strong>and the total amount of money is <strong>20,253.00 lv. </strong>Then you buy <strong>1 Bitcoin </strong>which leaves you with <strong>8,303.84 lv. </strong>Also this purchase is the <strong>first day you bought bitcoin</strong>.</p>
<p>&nbsp;</p>
<p><strong>Day 3 </strong>&ndash; you dig up <strong>300 g </strong>of gold but then <strong>30% </strong>of it is stolen and your gold drops to <strong>210 g </strong>which you exchange for <strong>14,177.10 lv. </strong>making your total amount of money <strong>22,480.94 lv. </strong>Then you buy <strong>1 </strong><strong>Bitcoin </strong>making the final amount of money that you are <strong>left with</strong> <strong>10,531.78 lv. </strong>with <strong>2 bought Bitcoins.</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="45">
<p><strong>Input</strong></p>
</td>
<td width="208">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="38">
<p><strong>&nbsp;</strong></p>
</td>
<td width="85">
<p><strong>Input</strong></p>
</td>
<td width="319">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="45">
<p>50, 100</p>
</td>
<td width="208">
<p>Bitcoins bought: 0</p>
<p>Money left: 10126.50 lv.</p>
</td>
<td width="85">
<p>3124.15, 504.212, 2511.124</p>
</td>
<td width="319">
<p>Bitcoins bought: 30</p>
<p>Day of the first purchased bitcoin: 1</p>
<p>Money left: 5144.11 lv.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>