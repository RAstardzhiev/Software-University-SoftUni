<h1>Problem 3. Football Standings</h1>
<p><strong>You will be given</strong> information about <strong>results of football matches</strong>. <strong>Create a standings table by points. </strong>For <strong>win the team gets 3</strong> <strong>points</strong>, <strong>for loss &ndash; 0</strong> and <strong>for draw &ndash; 1</strong>. Also<strong> find the top 3 teams with most scored goals in descending order</strong>. If <strong>two or more teams</strong> are with <strong>same goals scored</strong> or <strong>same points</strong> <strong>order them by name</strong> in <strong>ascending order</strong>.</p>
<p>The name of each team is <strong>encrypted</strong>. You must <strong>decrypt it before</strong> <strong>proceeding with calculating</strong> statistics. You will be given some <strong>string key</strong> and the <strong>team name will be placed between that key in reversed order.</strong></p>
<p><strong>For example:</strong> the <strong>key</strong>: &ldquo;???&rdquo;;</p>
<p><strong>String to decrypt</strong>: &ldquo;kfle???airagluB???gertIt%%&rdquo; -&gt; &ldquo;airagluB&rdquo; -&gt; &ldquo;Bulgaria&rdquo;</p>
<p>Also you should <strong>ignore the letter casing</strong> in the team names. <strong>For example:</strong></p>
<p>buLgariA = BulGAria = bulGARIA = BULGARIA</p>
<h2>Input / Constrains</h2>
<ul>
<li>On the <strong>first line</strong> of input you will get the <strong>key</strong> that will be used for decryption</li>
<li>On the next lines until you receive &ldquo;<strong>final</strong>&rdquo; you will get lines in format:</li>
</ul>
<p><strong>{encrypted teamA} {encrypted teamB} {teamA score}:{teamB score}</strong></p>
<ul>
<li><strong>Team scores</strong> will be <strong>integer numbers</strong> in the <strong>range [0...2<sup>31</sup>]</strong></li>
</ul>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>League standings:</strong></p>
<p><strong>{place}. {TEAM NAME} {points}</strong></p>
<p><strong>...</strong></p>
</td>
</tr>
</tbody>
</table>
<h2><br /> Output</h2>
<ul>
<li><strong>Print the standings table</strong> <strong>ordered descending by points</strong> in format:</li>
</ul>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>Top 3 scored goals:</strong></p>
<p><strong>- {team name} -&gt; {goals}</strong></p>
<p><strong>- {team name} -&gt; {goals}</strong></p>
<p><strong>- {team name} -&gt; {goals}</strong></p>
</td>
</tr>
</tbody>
</table>
<p><br /> Where <strong>place</strong> is a number in range <strong>[1&hellip; number of teams].</strong></p>
<ul>
<li>Then you should print the top 3 team <strong>ordered by goals in descending order</strong> in format:</li>
<li><strong>All team&rsquo;s names </strong>should be</li>
<li><strong>For more clarification, see the examples on the next page.<br /> </strong></li>
</ul>
<h2>Examples</h2>
<table width="448">
<tbody>
<tr>
<td width="278">
<p><strong>Input</strong></p>
</td>
<td width="170">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="278">
<p>??</p>
<p>??ecnarF?? ??kramneD?? 0:0</p>
<p>..??airagluB??32 ??dnalgnE??gf 3:2</p>
<p>Fg??NIAPS?? fgdrt%#$??YNAMREG??gtr 3:4</p>
<p>??eCnArF?? &gt;&gt;??yLATi??&lt;&lt; 2:2</p>
<p>final</p>
</td>
<td width="170">
<p>League standings:</p>
<p>1. BULGARIA 3</p>
<p>2. GERMANY 3</p>
<p>3. FRANCE 2</p>
<p>4. DENMARK 1</p>
<p>5. ITALY 1</p>
<p>6. ENGLAND 0</p>
<p>7. SPAIN 0</p>
<p>Top 3 scored goals:</p>
<p>- GERMANY -&gt; 4</p>
<p>- BULGARIA -&gt; 3</p>
<p>- SPAIN -&gt; 3</p>
</td>
</tr>
<tr>
<td width="278">
<p><strong>Input</strong></p>
</td>
<td width="170">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="278">
<p>KZL</p>
<p>fdKZLairagluBKZL KZLkramneDKZLll 2:0</p>
<p>kzljjjKZLAiRaGluBKZL KZLylATIKZLkk 1:1</p>
<p>KZLkRamnedKZL KZLYlatiKZL 4:4</p>
<p>final</p>
</td>
<td width="170">
<p>League standings:</p>
<p>1. BULGARIA 4</p>
<p>2. ITALY 2</p>
<p>3. DENMARK 1</p>
<p>Top 3 scored goals:</p>
<p>- ITALY -&gt; 5</p>
<p>- DENMARK -&gt; 4</p>
<p>- BULGARIA -&gt; 3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>