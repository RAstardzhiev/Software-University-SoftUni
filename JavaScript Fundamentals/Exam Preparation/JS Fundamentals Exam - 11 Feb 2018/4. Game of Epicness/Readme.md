<h1>Problem 4 &ndash; Game of Epicness</h1>
<p><em>Welcome to the Game of Epicness where different kingdoms are fighting for the grant price of a bucket of Bitcoins&hellip; EPIC! In this amazing game there are many kingdoms with many generals and every general have their own army. To decide who is the winner for this totally amazing price they fight battles between them. But they are not so awesome at math, so they need you to help them record their battle results. </em></p>
<p>Write a JavaScript program that <strong>determines</strong> the <strong>winner</strong> from <strong>all battles</strong>. You will receive <strong>two</strong> arguments:</p>
<p>The <strong>first </strong>argument is an <strong>array of kingdoms </strong><strong>with</strong><strong> generals </strong><strong>and their</strong><strong> army</strong> in the form of an <strong>object</strong> with format:</p>
<p>{ kingdom: String, general: String, army: Number }</p>
<p>Every <strong>general</strong> has his own <strong>army</strong> that fights for a certain <strong>kingdom</strong>. Note that, every <strong>kingdom&rsquo;s name </strong>is <strong>unique, </strong>and every general&rsquo;s <strong>name </strong>is <strong>unique </strong>in <strong>this kingdom</strong>. If the <strong>general</strong> already <strong>exists</strong> <strong>in</strong> this <strong>kingdom</strong> <strong>add</strong> the <strong>army</strong> to his current one. After you go through all the kingdoms with their generals with armies and store the information about them, it&rsquo;s time to start the battles.</p>
<p>The <strong>second </strong>argument is <strong>matrix of strings </strong>showing which <strong>kingdom&rsquo;s generals</strong> are <strong>fighting</strong> in this format:</p>
<p><strong>[</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [ "{AttackingKingdom} ", "{AttackingGeneral}", "{DefendingKingdom} ", "{DefendingGeneral}" ],</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &hellip;</strong></p>
<p><strong>]</strong></p>
<p>The <strong>first two elements </strong>are the <strong>names </strong>of the <strong>attacking general from </strong>certain <strong>kingdom</strong> and the <strong>second two</strong> are the <strong>names</strong> of the <strong>defending general from </strong>certain <strong>kingdom</strong>. <strong>Compare</strong> the two general&rsquo;s <strong>armies to determine</strong> who <strong>wins</strong> and who <strong>losses </strong>based on who have the <strong>larger army wins. </strong>The <strong>winner&rsquo;s army increases </strong>with <strong>10% </strong>and the <strong>loser&rsquo;s army decreases </strong>with <strong>10%. </strong>Keep in mind to <strong>round</strong> them <strong>down</strong> if there is any excess <strong>army</strong> <strong>after the battle. </strong>If there is a <strong>draw</strong>, <strong>do not do anything</strong>.<strong> Keep track</strong> of the <strong>wins </strong>and <strong>losses</strong> for every general&rsquo;s battle.</p>
<p>Note that, <strong>generals</strong> from the <strong>same kingdom</strong> <strong>cannot</strong> <strong>attack</strong> <strong>each other</strong>.</p>
<p>After you finish with all battles you need to <strong>find</strong> which <strong>kingdom</strong> <strong>wins</strong> the game. To decide that, <strong>first</strong> <strong>order them </strong>by all their <strong>general&rsquo;s wins (descending)</strong> then by their <strong>losses (ascending), </strong>and finally by the <strong>kingdom&rsquo;s name </strong>in <strong>ascending alphabetical</strong> order.</p>
<h3>Input</h3>
<p>You will receive <strong>two arguments &ndash; </strong>an <strong>array of objects</strong> with properties and a <strong>matrix of strings</strong> as shown above.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> the winning kingdom and <strong>sort </strong>the generals by their <strong>armies in</strong> <strong>descending </strong>order,<strong> formatted </strong>as seen in the examples.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>number</strong> of <strong>elements</strong> in the <strong>first input argument</strong> will be in range <strong>[1..100] inclusive</strong></li>
<li>The <strong>number</strong> of <strong>elements</strong> in the <strong>second input argument</strong> will be in range <strong>[0..100] inclusive</strong></li>
<li>General&rsquo;s <strong>army </strong>will be always an <strong>integer </strong>in range <strong>[0..1,000,000] inclusive</strong></li>
<li>There <strong>will</strong> be <strong>no invalid</strong> <strong>input</strong></li>
<li>There <strong>will </strong>be <strong>no matching number </strong>of <strong>armies </strong>in the <strong>output</strong></li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[ { kingdom: "Maiden Way", general: "Merek", army: 5000 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Ulric", army: 4900 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Doran", army: 70000 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 0 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 2000 },</p>
<p>&nbsp; { kingdom: "Maiden Way", general: "Berinon", army: 100000 } ],</p>
<p>[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],</p>
<p>&nbsp; ["Stonegate", "Ulric", "Stonegate", "Doran"],</p>
<p>&nbsp; ["Stonegate", "Doran", "Maiden Way", "Merek"],</p>
<p>&nbsp; ["Stonegate", "Ulric", "Maiden Way", "Merek"],</p>
<p>&nbsp; ["Maiden Way", "Berinon", "Stonegate", "Ulric"] ]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Winner: Stonegate</p>
<p>/\general: Doran</p>
<p>---army: 77000</p>
<p>---wins: 1</p>
<p>---losses: 0</p>
<p>/\general: Ulric</p>
<p>---army: 5336</p>
<p>---wins: 2</p>
<p>---losses: 1</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>After you successfully store the kingdoms information, the first battle&rsquo;s result is victory for the defender Ulric and a loss for the attacker Quinn. Second battle is ignored because the generals are from the same kingdom. Third battle is a victory for Doran and a loss for Merek. Fourth battle is a win for Ulric and a loss for Merek. Fifth battle is a victory for Berinon and a defeat for Ulric. All winners increase their armies with 10% for each win and all losers decrease their armies with 10% for each loss.</p>
<p>The result from the battles are &ndash; Stonegate: 3 wins and 1 loss; Maiden Way: 1 win and 2 losses; YorkenShire: 0 wins and 1 loss. Making Stonegate the winner of the games because they have the most wins from kingdoms.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[ { kingdom: "Stonegate", general: "Ulric", army: 5000 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 5000 },</p>
<p>&nbsp; { kingdom: "Maiden Way", general: "Berinon", army: 1000 } ],</p>
<p>[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],</p>
<p>&nbsp; ["Maiden Way", "Berinon", "YorkenShire", "Quinn"] ]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Winner: YorkenShire</p>
<p>/\general: Quinn</p>
<p>---army: 5500</p>
<p>---wins: 1</p>
<p>---losses: 0</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>The first battle between Quinn and Ulric is a draw because they have even armies because of that it is not recorded and their armies size does not change. The second battle is a win for Quinn and a loss for Berinon making YorkenShire the winner of the game with 1 win and 0 losses.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[ { kingdom: "Maiden Way", general: "Merek", army: 5000 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Ulric", army: 4900 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Doran", army: 70000 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 0 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 2000 } ],</p>
<p>[ ["YorkenShire", "Quinn", "Stonegate", "Doran"],</p>
<p>&nbsp; ["Stonegate", "Ulric", "Maiden Way", "Merek"] ]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Winner: Maiden Way</p>
<p>/\general: Merek</p>
<p>---army: 5500</p>
<p>---wins: 1</p>
<p>---losses: 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>