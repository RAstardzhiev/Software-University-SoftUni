<h1>Problem 4 &ndash; Champion&rsquo;s League</h1>
<p>The Champion&rsquo;s League is well under way and their team needs a person who can aggregate some data for them. Actually, that person is you. The data you receive will be in format:</p>
<p><strong>&lt;team1&gt; | &lt;team2&gt; | &lt;team1 goals&gt;:&lt;team2 goals&gt; | &lt;team2 goals&gt;:&lt;team1 goals&gt;</strong></p>
<p>For example: <strong>Barcelona | Real Madrid | 2:1 | 3:2</strong>. In that case, <strong>Barcelona</strong> have scored 4 goals total, <strong>Real</strong> <strong>Madrid</strong> have also scored 4 goals, but <strong>Barcelona</strong> is the overall winner because they have more goals on away soil. For each team, you need to keep the names of all teams they have played against. You also have to count the total wins.</p>
<p>There will be <strong>no</strong> matches with a score such as <strong>2:2 | 2:2 </strong>where the winner must be decided by a penalty shootout. All pairs will be <strong>unique</strong>.</p>
<h3>Input</h3>
<ul>
<li>You will receive several lines in the above described format. There is no redundant whitespace.</li>
<li>The input ends with the command &lsquo;<strong>stop</strong>&rsquo;</li>
<li>There is no invalid input.</li>
</ul>
<h3>Output</h3>
<ul>
<li>For each team print information in format:</li>
</ul>
<p><strong>&lt;team name&gt;</strong></p>
<p><strong>- Wins: &lt;total wins&gt;</strong></p>
<p><strong>- Opponents: &lt;opponent_1, opponent_2, &hellip; opponent_N&gt;</strong></p>
<ul>
<li>The teams must be ordered by total wins in descending order. If two teams have the same number of wins, keep in alphabetical order by team name.</li>
<li>The opponents must be printed in alphabetical order.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>There are no more than 50 lines of input.</li>
<li>The team names will consist of several words containing only English alphabet letters.</li>
<li>The goals are integers in range [0 &hellip; 10].</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<table width="599">
<tbody>
<tr>
<td width="329">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="329">
<p>Real Madrid | Barcelona | 0:0 | 1:1</p>
<p>Barcelona | Arsenal | 2:0 | 0:2</p>
<p>Liverpool | Manchester United | 2:0 | 0:0</p>
<p>Bayern Munich | Juventus | 2:1 | 3:2</p>
<p>stop</p>
</td>
<td width="270">
<p>Barcelona</p>
<p>- Wins: 1</p>
<p>- Opponents: Arsenal, Real Madrid</p>
<p>Bayern Munich</p>
<p>- Wins: 1</p>
<p>- Opponents: Juventus</p>
<p>Liverpool</p>
<p>- Wins: 1</p>
<p>- Opponents: Manchester United</p>
<p>Real Madrid</p>
<p>- Wins: 1</p>
<p>- Opponents: Barcelona</p>
<p>Arsenal</p>
<p>- Wins: 0</p>
<p>- Opponents: Barcelona</p>
<p>Juventus</p>
<p>- Wins: 0</p>
<p>- Opponents: Bayern Munich</p>
<p>Manchester United</p>
<p>- Wins: 0</p>
<p>- Opponents: Liverpool</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>