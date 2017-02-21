<p><strong>Problem 4 &ndash; Winning Ticket</strong></p>
<p>Lottery is exciting. What is not, is checking a million tickets for winnings only by hand. So, you are given the task to create a program which automatically checks if a ticket is a winner.</p>
<p>You are given a <strong>collection of tickets separated by commas and spaces</strong>. You need to check every one of them if it has a winning combination of symbols.</p>
<p><strong>A valid ticket should have exactly 20 characters</strong>. The winning symbols are '<strong>@</strong>', '<strong>#</strong>', '<strong>$</strong>' and '<strong>^</strong>'. But in order for a ticket to be a winner the symbol should uninterruptedly repeat for at least <strong>6 times</strong> in both the <strong>tickets left half</strong> and the <strong>tickets right half</strong>.</p>
<p>For example, a valid winning ticket should be something like this:</p>
<p>"<strong>Cash$$$$$$Ca$$$$$$sh</strong>"</p>
<p>The left half "<strong>Cash$$$$$$</strong>" contains "<strong>$$$$$$</strong>", which is also contained in the tickets right half "<strong>Ca$$$$$$sh</strong>". A winning ticket should contain symbols repeating up to 10 times in both halves, which is considered a Jackpot (for example: "<strong>$$$$$$$$$$$$$$$$$$$$</strong>").</p>
<p><strong>Input</strong></p>
<p>The input will be read from the console. The input consists of a <strong>single line </strong>containing all tickets <strong>separated by commas and one or more white spaces</strong> in the format:</p>
<ul>
<li><strong>"{ticket}, {ticket}, &hellip; {ticket}"</strong></li>
</ul>
<p><strong>Output</strong></p>
<p>Print the result for every ticket in the order of their appearance, each on a separate line in the format:</p>
<ul>
<li><strong>Invalid ticket - "invalid ticket"</strong></li>
<li><strong>No match - "ticket "{ticket}" - no match"</strong></li>
<li><strong>Match with length 6 to 9 - "ticket "{ticket}" - {match length}{match symbol}"</strong></li>
<li><strong>Match with length 10 - "ticket "{ticket}" - {match length}{match symbol} Jackpot!"</strong></li>
</ul>
<p><strong>Constrains</strong></p>
<ul>
<li>Number of tickets will be in range [0 &hellip; 100]</li>
</ul>
<p><strong>Examples</strong></p>
<table width="680">
<tbody>
<tr>
<td width="284">
<p><strong>Input</strong></p>
</td>
<td width="397">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="284">
<p>Cash$$$$$$Ca$$$$$$sh</p>
</td>
<td width="397">
<p>ticket "Cash$$$$$$Ca$$$$$$sh" - 6$</p>
</td>
</tr>
<tr>
<td width="284">
<p>$$$$$$$$$$$$$$$$$$$$&nbsp;&nbsp; ,&nbsp;&nbsp; aabb&nbsp; ,&nbsp;&nbsp;&nbsp; &nbsp;th@@@@@@eemo@@@@@@ey</p>
</td>
<td width="397">
<p>ticket "$$$$$$$$$$$$$$$$$$$$" - 10$ Jackpot!</p>
<p>invalid ticket</p>
<p>ticket "th@@@@@@eemo@@@@@@ey" - 6@</p>
</td>
</tr>
<tr>
<td width="284">
<p>validticketnomatch:(</p>
</td>
<td width="397">
<p>ticket "validticketnomatch:(" - no match</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>