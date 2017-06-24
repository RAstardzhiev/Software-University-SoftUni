<h1>Problem 2 &ndash; Monopoly</h1>
<p>Monopoly is such a fun game but you&rsquo;ve always been looking for something more. Besides, you want it to be fun even in single player mode. So you came up with a really nice idea which needs to be tested.</p>
<p>The rules are quite simple &ndash; there is a rectangular game field in which the <strong>player</strong> starts with 50 <strong>money</strong> at the <strong>top</strong> <strong>left</strong> corner. He <strong>always</strong> moves in the following way:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If he is moving <strong>right</strong>, he follows the row to the <strong>last</strong> column. Then he gets to the last column&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; in the row <strong>next</strong> row and starts <strong>moving</strong> left until he reaches the <strong>first</strong> column. The pattern</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>repeats</strong> to the end of the game field.</p>
<p>He moves one step at a time. On his way down, he will encounter one of the following objects:</p>
<ul>
<li><strong>H (hotel)</strong> &ndash; the player spends <strong>all</strong> his money to buy the hotel. He then gets <strong>10 money per turn </strong>for it. A new hotel contributes to the income from the turn it is bought.</li>
<li><strong>J (Jail)</strong> &ndash; the player <strong>cannot</strong> move for <strong>two</strong> turns</li>
<li><strong>F (Free) </strong>&ndash; nothing happens here, the game just advances with one step</li>
<li><strong>S (Shop) </strong>&ndash; the player has to spend money equal to the <strong>product</strong> of the current <strong>row</strong> and <strong>column</strong> number (assume the first row/col is at position 1). If he doesn&rsquo;t have enough money, he spends all that he has.</li>
</ul>
<p>For each of the objects except <strong>F </strong>you need to print a corresponding message to the console. At the end of the output, print the <strong>total</strong> turns done in the game and the <strong>final</strong> amount of money. Consider a <strong>turn</strong> to be an <strong>iteration</strong> of the game loop. <strong>Note</strong> that <strong>contrary</strong> to logic, a player can buy a hotel for 0 money.</p>
<p>&nbsp;</p>
<h3>Input</h3>
<ul>
<li>On the first line of input you receive integers <strong>R</strong> and <strong>C</strong> &ndash; the dimensions of the field</li>
<li>On the next <strong>R </strong>lines &ndash; you are given a string with length <strong>C</strong> containing only one of the valid objects (<strong>H, J, F, S</strong>)</li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first several lines print a message that describes what happened to the player:
<ul>
<li>Buys a hotel &ndash; {<strong>Bought a hotel for &lt;money&gt;. Total hotels: &lt;hotels&gt;.</strong>}</li>
<li>Goes to jail &ndash; {<strong>Gone to jail at turn &lt;turn&gt;.</strong>}</li>
<li>Enters to shop &ndash; {<strong>Spent &lt;money&gt; at the shop.</strong>}</li>
</ul>
</li>
<li>On the last two lines after the player has reached the last cell:
<ul>
<li>{<strong>Turns &lt;turns&gt;</strong>}</li>
<li>{<strong>Money &lt;money&gt;</strong>}</li>
</ul>
</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>1 &le; R,C &le; 10</li>
<li>Time/memory allowed: 100ms/16MB</li>
</ul>
<table width="467">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>4 4</p>
<p>HHHF</p>
<p>FFFF</p>
<p>SFFF</p>
<p>FFFF</p>
</td>
<td width="360">
<p>Bought a hotel for 50. Total hotels: 1.</p>
<p>Bought a hotel for 10. Total hotels: 2.</p>
<p>Bought a hotel for 20. Total hotels: 3.</p>
<p>Spent 3 money at the shop.</p>
<p>Turns 16</p>
<p>Money 417</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="467">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>1 3</p>
<p>HJF</p>
</td>
<td width="360">
<p>Bought a hotel for 50. Total hotels: 1.</p>
<p>Gone to jail at turn 1.</p>
<p>Turns 5</p>
<p>Money 50</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="467">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>2 4</p>
<p>FFFF</p>
<p>SFFH</p>
<p>&nbsp;</p>
</td>
<td width="360">
<p>Bought a hotel for 50. Total hotels: 1.</p>
<p>Spent 2 money at the shop.</p>
<p>Turns 8</p>
<p>Money 38</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>